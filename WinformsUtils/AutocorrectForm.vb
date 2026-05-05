Imports System.Text.RegularExpressions

Public Class AutocorrectForm

    ' Ordered list so rules display predictably; Dictionary for fast lookup
    Private ReadOnly _ruleKeys As New List(Of String)()
    Private ReadOnly _rules As New Dictionary(Of String, String)(StringComparer.Ordinal)

    ' Suppress re-entrant TextChanged while we are editing the RichTextBox
    Private _isApplying As Boolean = False

    ' -------------------------------------------------------------------------
    ' Built-in rules
    ' -------------------------------------------------------------------------
    Private Sub LoadDefaultRules()
        AddRule(" i ", " I ")
        AddRule("i ", "I ", onlyAtStart:=True)
        AddRule("havent", "haven't")
        AddRule("dont", "don't")
        AddRule("doesnt", "doesn't")
        AddRule("cant", "can't")
        AddRule("wont", "won't")
        AddRule("wouldnt", "wouldn't")
        AddRule("shouldnt", "shouldn't")
        AddRule("couldnt", "couldn't")
        AddRule("im ", "I'm ")
        AddRule("ive ", "I've ")
        AddRule("id ", "I'd ")
        AddRule("ill ", "I'll ")
        AddRule("thx", "thanks")
        AddRule("u ", "you ")
        AddRule("ur ", "your ")
        AddRule("teh", "the")
        AddRule("recieve", "receive")
        AddRule("occured", "occurred")
        AddRule("seperate", "separate")
    End Sub

    ' -------------------------------------------------------------------------
    ' Rule management
    ' -------------------------------------------------------------------------
    Private Sub AddRule(from As String, [to] As String, Optional onlyAtStart As Boolean = False)
        Dim key As String = If(onlyAtStart, "^" & from, from)
        If Not _rules.ContainsKey(key) Then
            _ruleKeys.Add(key)
            _rules(key) = [to]
        End If
    End Sub

    Private Sub RefreshRuleList()
        _lvRules.BeginUpdate()
        _lvRules.Items.Clear()
        For Each key As String In _ruleKeys
            Dim display As String = If(key.StartsWith("^"), key.Substring(1) & "  (start only)", key)
            Dim item As New ListViewItem(display)
            item.SubItems.Add(_rules(key))
            item.Tag = key
            _lvRules.Items.Add(item)
        Next
        _lvRules.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent)
        _lvRules.EndUpdate()
    End Sub

    ' -------------------------------------------------------------------------
    ' Form Load
    ' -------------------------------------------------------------------------
    Private Sub AutocorrectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDefaultRules()
        RefreshRuleList()

        _toolTip.SetToolTip(_chkWholeWord, "When enabled, rules only fire on whole words (surrounded by spaces or start/end of text).")
        _toolTip.SetToolTip(_chkCapSentence, "Automatically capitalizes the first letter after a period and space.")
        _toolTip.SetToolTip(_btnAddRule, "Add a new autocorrect rule.")
        _toolTip.SetToolTip(_btnRemoveRule, "Remove the selected rule from the list.")
    End Sub

    ' -------------------------------------------------------------------------
    ' Core autocorrect
    ' -------------------------------------------------------------------------
    Private Sub _txtInput_TextChanged(sender As Object, e As EventArgs) Handles _txtInput.TextChanged
        If _isApplying OrElse Not _chkEnabled.Checked Then Return

        Dim text As String = _txtInput.Text
        Dim caretPos As Integer = _txtInput.SelectionStart

        For Each key As String In _ruleKeys
            Dim replacement As String = _rules(key)
            Dim isStartOnly As Boolean = key.StartsWith("^")
            Dim pattern As String = If(isStartOnly, key.Substring(1), key)

            Dim corrected As String = TryApplyRule(text, pattern, replacement, isStartOnly, _chkWholeWord.Checked, caretPos)
            If corrected IsNot Nothing Then
                _isApplying = True
                Try
                    Dim delta As Integer = corrected.Length - text.Length
                    _txtInput.Text = corrected
                    _txtInput.SelectionStart = Math.Max(0, Math.Min(caretPos + delta, corrected.Length))
                    _lblLastCorrection.Text = $"Corrected: ""{pattern.Trim()}"" → ""{replacement.Trim()}"" at {DateTime.Now:HH:mm:ss}"
                    text = corrected
                    caretPos = _txtInput.SelectionStart
                Finally
                    _isApplying = False
                End Try
            End If
        Next

        If _chkCapSentence.Checked Then
            ApplyCapitalizeAfterPeriod(text, caretPos)
        End If
    End Sub

    ''' <summary>
    ''' Returns the corrected string if the rule matches somewhere in <paramref name="text"/>
    ''' just before the caret, otherwise Nothing.
    ''' </summary>
    Private Function TryApplyRule(text As String, pattern As String, replacement As String,
                                  isStartOnly As Boolean, wholeWord As Boolean,
                                  caretPos As Integer) As String
        ' Build a region to scan: up to caretPos
        Dim region As String = If(caretPos <= text.Length, text.Substring(0, caretPos), text)

        Dim regexPattern As String
        If isStartOnly Then
            regexPattern = "^" & Regex.Escape(pattern)
        ElseIf wholeWord Then
            regexPattern = "(?<!\S)" & Regex.Escape(pattern.Trim()) & "(?=\s|$)"
            ' Re-add surrounding spaces that were stripped for matching
            If pattern.StartsWith(" ") Then regexPattern = "\s" & regexPattern.TrimStart("(?<!\S)".ToCharArray())
        Else
            regexPattern = Regex.Escape(pattern)
        End If

        Try
            Dim m As Match = Regex.Match(region, regexPattern, RegexOptions.IgnoreCase)
            If m.Success Then
                ' Only trigger on the match that ends at or just before the caret
                If m.Index + m.Length = region.Length Then
                    Return text.Substring(0, m.Index) & replacement & text.Substring(m.Index + m.Length)
                End If
            End If
        Catch
            ' Malformed pattern from user input — ignore
        End Try

        Return Nothing
    End Function

    Private Sub ApplyCapitalizeAfterPeriod(text As String, caretPos As Integer)
        ' Look for ". x" where x is a lowercase letter just typed
        If caretPos < 3 Then Return
        Dim region As String = text.Substring(0, caretPos)
        Dim m As Match = Regex.Match(region, "\.\s([a-z])$")
        If m.Success Then
            Dim idx As Integer = m.Index + m.Length - 1
            Dim upper As String = text.Substring(0, idx) & Char.ToUpper(text(idx)) & text.Substring(idx + 1)
            _isApplying = True
            Try
                _txtInput.Text = upper
                _txtInput.SelectionStart = caretPos
                _lblLastCorrection.Text = $"Capitalized after period at {DateTime.Now:HH:mm:ss}"
            Finally
                _isApplying = False
            End Try
        End If
    End Sub

    ' -------------------------------------------------------------------------
    ' Rule ListView selection → populate edit fields
    ' -------------------------------------------------------------------------
    Private Sub _lvRules_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _lvRules.SelectedIndexChanged
        If _lvRules.SelectedItems.Count = 0 Then Return
        Dim item As ListViewItem = _lvRules.SelectedItems(0)
        Dim key As String = DirectCast(item.Tag, String)
        Dim rawPattern As String = If(key.StartsWith("^"), key.Substring(1), key)
        _txtFrom.Text = rawPattern
        _txtTo.Text = _rules(key)
    End Sub

    ' -------------------------------------------------------------------------
    ' Add / Remove / Clear
    ' -------------------------------------------------------------------------
    Private Sub _btnAddRule_Click(sender As Object, e As EventArgs) Handles _btnAddRule.Click
        Dim from As String = _txtFrom.Text
        Dim [to] As String = _txtTo.Text

        If String.IsNullOrEmpty(from) OrElse String.IsNullOrEmpty([to]) Then
            MessageBox.Show("Please enter both a 'Replace' value and a 'With' value.", "Add Rule",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If _rules.ContainsKey(from) Then
            _rules(from) = [to]
        Else
            _ruleKeys.Add(from)
            _rules(from) = [to]
        End If

        RefreshRuleList()
        _txtFrom.Clear()
        _txtTo.Clear()
        _txtFrom.Focus()
    End Sub

    Private Sub _btnRemoveRule_Click(sender As Object, e As EventArgs) Handles _btnRemoveRule.Click
        If _lvRules.SelectedItems.Count = 0 Then Return
        Dim key As String = DirectCast(_lvRules.SelectedItems(0).Tag, String)
        _ruleKeys.Remove(key)
        _rules.Remove(key)
        RefreshRuleList()
    End Sub

    Private Sub _btnClearAll_Click(sender As Object, e As EventArgs) Handles _btnClearAll.Click
        Dim result As DialogResult = MessageBox.Show(
            "Remove all autocorrect rules?", "Clear All",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            _ruleKeys.Clear()
            _rules.Clear()
            RefreshRuleList()
        End If
    End Sub

End Class
