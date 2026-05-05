<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutocorrectForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me._tlpOuter = New System.Windows.Forms.TableLayoutPanel()
        Me._grpTyping = New System.Windows.Forms.GroupBox()
        Me._txtInput = New System.Windows.Forms.RichTextBox()
        Me._lblLastCorrection = New System.Windows.Forms.Label()
        Me._tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me._grpRules = New System.Windows.Forms.GroupBox()
        Me._tlpRules = New System.Windows.Forms.TableLayoutPanel()
        Me._lvRules = New System.Windows.Forms.ListView()
        Me._colFrom = New System.Windows.Forms.ColumnHeader()
        Me._colTo = New System.Windows.Forms.ColumnHeader()
        Me._tlpRuleInput = New System.Windows.Forms.TableLayoutPanel()
        Me._lblFrom = New System.Windows.Forms.Label()
        Me._txtFrom = New System.Windows.Forms.TextBox()
        Me._lblTo = New System.Windows.Forms.Label()
        Me._txtTo = New System.Windows.Forms.TextBox()
        Me._flpRuleButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me._btnAddRule = New System.Windows.Forms.Button()
        Me._btnRemoveRule = New System.Windows.Forms.Button()
        Me._btnClearAll = New System.Windows.Forms.Button()
        Me._grpOptions = New System.Windows.Forms.GroupBox()
        Me._tlpOptions = New System.Windows.Forms.TableLayoutPanel()
        Me._chkEnabled = New System.Windows.Forms.CheckBox()
        Me._chkWholeWord = New System.Windows.Forms.CheckBox()
        Me._chkCapSentence = New System.Windows.Forms.CheckBox()
        Me._toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me._tlpOuter.SuspendLayout()
        Me._grpTyping.SuspendLayout()
        Me._tlpBottom.SuspendLayout()
        Me._grpRules.SuspendLayout()
        Me._tlpRules.SuspendLayout()
        Me._tlpRuleInput.SuspendLayout()
        Me._flpRuleButtons.SuspendLayout()
        Me._grpOptions.SuspendLayout()
        Me._tlpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        '_tlpOuter
        '
        Me._tlpOuter.ColumnCount = 1
        Me._tlpOuter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpOuter.Controls.Add(Me._grpTyping, 0, 0)
        Me._tlpOuter.Controls.Add(Me._lblLastCorrection, 0, 1)
        Me._tlpOuter.Controls.Add(Me._tlpBottom, 0, 2)
        Me._tlpOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpOuter.Location = New System.Drawing.Point(0, 0)
        Me._tlpOuter.Name = "_tlpOuter"
        Me._tlpOuter.Padding = New System.Windows.Forms.Padding(8)
        Me._tlpOuter.RowCount = 3
        Me._tlpOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me._tlpOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me._tlpOuter.TabIndex = 0
        '
        '_grpTyping
        '
        Me._grpTyping.AutoSize = False
        Me._grpTyping.Controls.Add(Me._txtInput)
        Me._grpTyping.Dock = System.Windows.Forms.DockStyle.Fill
        Me._grpTyping.Location = New System.Drawing.Point(11, 11)
        Me._grpTyping.Margin = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me._grpTyping.Name = "_grpTyping"
        Me._grpTyping.Padding = New System.Windows.Forms.Padding(8, 6, 8, 8)
        Me._grpTyping.TabIndex = 0
        Me._grpTyping.TabStop = False
        Me._grpTyping.Text = "Type here — autocorrect is active"
        '
        '_txtInput
        '
        Me._txtInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me._txtInput.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtInput.Location = New System.Drawing.Point(8, 19)
        Me._txtInput.Margin = New System.Windows.Forms.Padding(3)
        Me._txtInput.Name = "_txtInput"
        Me._txtInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me._txtInput.Size = New System.Drawing.Size(580, 120)
        Me._txtInput.TabIndex = 0
        Me._txtInput.Text = ""
        '
        '_lblLastCorrection
        '
        Me._lblLastCorrection.AutoSize = True
        Me._lblLastCorrection.Dock = System.Windows.Forms.DockStyle.Fill
        Me._lblLastCorrection.ForeColor = System.Drawing.SystemColors.GrayText
        Me._lblLastCorrection.Location = New System.Drawing.Point(11, 160)
        Me._lblLastCorrection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._lblLastCorrection.Name = "_lblLastCorrection"
        Me._lblLastCorrection.Size = New System.Drawing.Size(576, 13)
        Me._lblLastCorrection.TabIndex = 1
        Me._lblLastCorrection.Text = "No corrections yet."
        '
        '_tlpBottom
        '
        Me._tlpBottom.ColumnCount = 2
        Me._tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me._tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me._tlpBottom.Controls.Add(Me._grpRules, 0, 0)
        Me._tlpBottom.Controls.Add(Me._grpOptions, 1, 0)
        Me._tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpBottom.Location = New System.Drawing.Point(11, 181)
        Me._tlpBottom.Margin = New System.Windows.Forms.Padding(3)
        Me._tlpBottom.Name = "_tlpBottom"
        Me._tlpBottom.RowCount = 1
        Me._tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpBottom.TabIndex = 2
        '
        '_grpRules
        '
        Me._grpRules.AutoSize = False
        Me._grpRules.Controls.Add(Me._tlpRules)
        Me._grpRules.Dock = System.Windows.Forms.DockStyle.Fill
        Me._grpRules.Location = New System.Drawing.Point(3, 3)
        Me._grpRules.Name = "_grpRules"
        Me._grpRules.Padding = New System.Windows.Forms.Padding(8, 6, 8, 8)
        Me._grpRules.TabIndex = 0
        Me._grpRules.TabStop = False
        Me._grpRules.Text = "Autocorrect Rules"
        '
        '_tlpRules
        '
        Me._tlpRules.ColumnCount = 1
        Me._tlpRules.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpRules.Controls.Add(Me._lvRules, 0, 0)
        Me._tlpRules.Controls.Add(Me._tlpRuleInput, 0, 1)
        Me._tlpRules.Controls.Add(Me._flpRuleButtons, 0, 2)
        Me._tlpRules.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpRules.Location = New System.Drawing.Point(8, 19)
        Me._tlpRules.Name = "_tlpRules"
        Me._tlpRules.RowCount = 3
        Me._tlpRules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpRules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpRules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpRules.TabIndex = 0
        '
        '_lvRules
        '
        Me._lvRules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._colFrom, Me._colTo})
        Me._lvRules.Dock = System.Windows.Forms.DockStyle.Fill
        Me._lvRules.FullRowSelect = True
        Me._lvRules.GridLines = True
        Me._lvRules.HideSelection = False
        Me._lvRules.Location = New System.Drawing.Point(3, 3)
        Me._lvRules.MultiSelect = False
        Me._lvRules.Name = "_lvRules"
        Me._lvRules.Size = New System.Drawing.Size(350, 160)
        Me._lvRules.TabIndex = 0
        Me._lvRules.UseCompatibleStateImageBehavior = False
        Me._lvRules.View = System.Windows.Forms.View.Details
        '
        '_colFrom
        '
        Me._colFrom.Text = "Replace"
        Me._colFrom.Width = 160
        '
        '_colTo
        '
        Me._colTo.Text = "With"
        Me._colTo.Width = 160
        '
        '_tlpRuleInput
        '
        Me._tlpRuleInput.AutoSize = True
        Me._tlpRuleInput.ColumnCount = 4
        Me._tlpRuleInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpRuleInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me._tlpRuleInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpRuleInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me._tlpRuleInput.Controls.Add(Me._lblFrom, 0, 0)
        Me._tlpRuleInput.Controls.Add(Me._txtFrom, 1, 0)
        Me._tlpRuleInput.Controls.Add(Me._lblTo, 2, 0)
        Me._tlpRuleInput.Controls.Add(Me._txtTo, 3, 0)
        Me._tlpRuleInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpRuleInput.Location = New System.Drawing.Point(0, 168)
        Me._tlpRuleInput.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me._tlpRuleInput.Name = "_tlpRuleInput"
        Me._tlpRuleInput.RowCount = 1
        Me._tlpRuleInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpRuleInput.TabIndex = 1
        '
        '_lblFrom
        '
        Me._lblFrom.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me._lblFrom.AutoSize = True
        Me._lblFrom.Location = New System.Drawing.Point(3, 4)
        Me._lblFrom.Margin = New System.Windows.Forms.Padding(3)
        Me._lblFrom.Name = "_lblFrom"
        Me._lblFrom.Size = New System.Drawing.Size(47, 13)
        Me._lblFrom.Text = "&Replace:"
        '
        '_txtFrom
        '
        Me._txtFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me._txtFrom.Location = New System.Drawing.Point(56, 3)
        Me._txtFrom.Margin = New System.Windows.Forms.Padding(3)
        Me._txtFrom.Name = "_txtFrom"
        Me._txtFrom.Size = New System.Drawing.Size(120, 20)
        Me._txtFrom.TabIndex = 0
        '
        '_lblTo
        '
        Me._lblTo.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me._lblTo.AutoSize = True
        Me._lblTo.Location = New System.Drawing.Point(182, 4)
        Me._lblTo.Margin = New System.Windows.Forms.Padding(3)
        Me._lblTo.Name = "_lblTo"
        Me._lblTo.Size = New System.Drawing.Size(22, 13)
        Me._lblTo.Text = "&With:"
        '
        '_txtTo
        '
        Me._txtTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me._txtTo.Location = New System.Drawing.Point(210, 3)
        Me._txtTo.Margin = New System.Windows.Forms.Padding(3)
        Me._txtTo.Name = "_txtTo"
        Me._txtTo.Size = New System.Drawing.Size(120, 20)
        Me._txtTo.TabIndex = 1
        '
        '_flpRuleButtons
        '
        Me._flpRuleButtons.AutoSize = True
        Me._flpRuleButtons.Controls.Add(Me._btnAddRule)
        Me._flpRuleButtons.Controls.Add(Me._btnRemoveRule)
        Me._flpRuleButtons.Controls.Add(Me._btnClearAll)
        Me._flpRuleButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flpRuleButtons.Location = New System.Drawing.Point(0, 197)
        Me._flpRuleButtons.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me._flpRuleButtons.Name = "_flpRuleButtons"
        Me._flpRuleButtons.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me._flpRuleButtons.TabIndex = 2
        '
        '_btnAddRule
        '
        Me._btnAddRule.Location = New System.Drawing.Point(3, 6)
        Me._btnAddRule.Margin = New System.Windows.Forms.Padding(3)
        Me._btnAddRule.Name = "_btnAddRule"
        Me._btnAddRule.Size = New System.Drawing.Size(80, 26)
        Me._btnAddRule.TabIndex = 0
        Me._btnAddRule.Text = "&Add Rule"
        Me._btnAddRule.UseVisualStyleBackColor = True
        '
        '_btnRemoveRule
        '
        Me._btnRemoveRule.Location = New System.Drawing.Point(89, 6)
        Me._btnRemoveRule.Margin = New System.Windows.Forms.Padding(3)
        Me._btnRemoveRule.Name = "_btnRemoveRule"
        Me._btnRemoveRule.Size = New System.Drawing.Size(90, 26)
        Me._btnRemoveRule.TabIndex = 1
        Me._btnRemoveRule.Text = "&Remove Rule"
        Me._btnRemoveRule.UseVisualStyleBackColor = True
        '
        '_btnClearAll
        '
        Me._btnClearAll.Location = New System.Drawing.Point(185, 6)
        Me._btnClearAll.Margin = New System.Windows.Forms.Padding(3)
        Me._btnClearAll.Name = "_btnClearAll"
        Me._btnClearAll.Size = New System.Drawing.Size(70, 26)
        Me._btnClearAll.TabIndex = 2
        Me._btnClearAll.Text = "Clear &All"
        Me._btnClearAll.UseVisualStyleBackColor = True
        '
        '_grpOptions
        '
        Me._grpOptions.AutoSize = False
        Me._grpOptions.Controls.Add(Me._tlpOptions)
        Me._grpOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me._grpOptions.Location = New System.Drawing.Point(393, 3)
        Me._grpOptions.Name = "_grpOptions"
        Me._grpOptions.Padding = New System.Windows.Forms.Padding(8, 6, 8, 8)
        Me._grpOptions.TabIndex = 1
        Me._grpOptions.TabStop = False
        Me._grpOptions.Text = "Options"
        '
        '_tlpOptions
        '
        Me._tlpOptions.AutoSize = True
        Me._tlpOptions.ColumnCount = 1
        Me._tlpOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpOptions.Controls.Add(Me._chkEnabled, 0, 0)
        Me._tlpOptions.Controls.Add(Me._chkWholeWord, 0, 1)
        Me._tlpOptions.Controls.Add(Me._chkCapSentence, 0, 2)
        Me._tlpOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me._tlpOptions.Location = New System.Drawing.Point(8, 19)
        Me._tlpOptions.Name = "_tlpOptions"
        Me._tlpOptions.RowCount = 3
        Me._tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpOptions.TabIndex = 0
        '
        '_chkEnabled
        '
        Me._chkEnabled.AutoSize = True
        Me._chkEnabled.Checked = True
        Me._chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkEnabled.Location = New System.Drawing.Point(3, 3)
        Me._chkEnabled.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me._chkEnabled.Name = "_chkEnabled"
        Me._chkEnabled.Size = New System.Drawing.Size(120, 17)
        Me._chkEnabled.TabIndex = 0
        Me._chkEnabled.Text = "&Enable autocorrect"
        Me._chkEnabled.UseVisualStyleBackColor = True
        '
        '_chkWholeWord
        '
        Me._chkWholeWord.AutoSize = True
        Me._chkWholeWord.Checked = True
        Me._chkWholeWord.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkWholeWord.Location = New System.Drawing.Point(3, 29)
        Me._chkWholeWord.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me._chkWholeWord.Name = "_chkWholeWord"
        Me._chkWholeWord.Size = New System.Drawing.Size(130, 17)
        Me._chkWholeWord.TabIndex = 1
        Me._chkWholeWord.Text = "&Whole-word matching"
        Me._chkWholeWord.UseVisualStyleBackColor = True
        '
        '_chkCapSentence
        '
        Me._chkCapSentence.AutoSize = True
        Me._chkCapSentence.Checked = True
        Me._chkCapSentence.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCapSentence.Location = New System.Drawing.Point(3, 55)
        Me._chkCapSentence.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me._chkCapSentence.Name = "_chkCapSentence"
        Me._chkCapSentence.Size = New System.Drawing.Size(145, 17)
        Me._chkCapSentence.TabIndex = 2
        Me._chkCapSentence.Text = "&Capitalize after period"
        Me._chkCapSentence.UseVisualStyleBackColor = True
        '
        'AutocorrectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 500)
        Me.Controls.Add(Me._tlpOuter)
        Me.MinimumSize = New System.Drawing.Size(500, 460)
        Me.Name = "AutocorrectForm"
        Me.Text = "Autocorrect Demo"
        Me._tlpOuter.ResumeLayout(False)
        Me._tlpOuter.PerformLayout()
        Me._grpTyping.ResumeLayout(False)
        Me._tlpBottom.ResumeLayout(False)
        Me._grpRules.ResumeLayout(False)
        Me._tlpRules.ResumeLayout(False)
        Me._tlpRules.PerformLayout()
        Me._tlpRuleInput.ResumeLayout(False)
        Me._tlpRuleInput.PerformLayout()
        Me._flpRuleButtons.ResumeLayout(False)
        Me._grpOptions.ResumeLayout(False)
        Me._grpOptions.PerformLayout()
        Me._tlpOptions.ResumeLayout(False)
        Me._tlpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _txtInput As System.Windows.Forms.RichTextBox
    Private _lblLastCorrection As System.Windows.Forms.Label
    Private _tlpOuter As System.Windows.Forms.TableLayoutPanel
    Private _grpTyping As System.Windows.Forms.GroupBox
    Private _tlpBottom As System.Windows.Forms.TableLayoutPanel
    Private _grpRules As System.Windows.Forms.GroupBox
    Private _tlpRules As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents _lvRules As System.Windows.Forms.ListView
    Private _colFrom As System.Windows.Forms.ColumnHeader
    Private _colTo As System.Windows.Forms.ColumnHeader
    Private _tlpRuleInput As System.Windows.Forms.TableLayoutPanel
    Private _lblFrom As System.Windows.Forms.Label
    Friend WithEvents _txtFrom As System.Windows.Forms.TextBox
    Private _lblTo As System.Windows.Forms.Label
    Friend WithEvents _txtTo As System.Windows.Forms.TextBox
    Private _flpRuleButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents _btnAddRule As System.Windows.Forms.Button
    Friend WithEvents _btnRemoveRule As System.Windows.Forms.Button
    Friend WithEvents _btnClearAll As System.Windows.Forms.Button
    Private _grpOptions As System.Windows.Forms.GroupBox
    Private _tlpOptions As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents _chkEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents _chkWholeWord As System.Windows.Forms.CheckBox
    Friend WithEvents _chkCapSentence As System.Windows.Forms.CheckBox
    Private _toolTip As System.Windows.Forms.ToolTip
End Class
