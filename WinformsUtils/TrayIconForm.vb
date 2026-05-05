Public Class TrayIconForm

    Private _isExiting As Boolean = False

    Private Sub TrayIconForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Icon = Me.Icon

        _cmbIcon.Items.AddRange(New Object() {
            ToolTipIcon.None,
            ToolTipIcon.Info,
            ToolTipIcon.Warning,
            ToolTipIcon.Error
        })
        _cmbIcon.SelectedIndex = 1
    End Sub

    Private Sub TrayIconForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Minimized Then
            HideToTray()
        End If
    End Sub

    Private Sub TrayIconForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _isExiting AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            HideToTray()
        End If
    End Sub

    Private Sub HideToTray()
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(2000, "Still Running", "Application minimized to tray. Double-click to restore.", ToolTipIcon.Info)
    End Sub

    ' --- NotifyIcon events ---

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        RestoreWindow()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        RestoreWindow()
    End Sub

    Private Sub RestoreWindow()
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
    End Sub

    ' --- Context menu ---

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        RestoreWindow()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        HideToTray()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ExitApplication()
    End Sub

    ' --- Buttons ---

    Private Sub _btnShowBalloon_Click(sender As Object, e As EventArgs) Handles _btnShowBalloon.Click
        Dim title As String = _txtTitle.Text.Trim()
        Dim message As String = _txtMessage.Text.Trim()
        Dim icon As ToolTipIcon = ToolTipIcon.None

        If _cmbIcon.SelectedItem IsNot Nothing Then
            icon = DirectCast(_cmbIcon.SelectedItem, ToolTipIcon)
        End If

        Dim timeout As Integer = CInt(_nudTimeout.Value)

        If String.IsNullOrEmpty(message) Then
            message = "(no message)"
        End If

        NotifyIcon1.ShowBalloonTip(timeout, title, message, icon)
        _lblStatus.Text = $"Balloon tip shown at {DateTime.Now:HH:mm:ss}."
    End Sub

    Private Sub _btnHide_Click(sender As Object, e As EventArgs) Handles _btnHide.Click
        HideToTray()
    End Sub

    Private Sub _btnExit_Click(sender As Object, e As EventArgs) Handles _btnExit.Click
        ExitApplication()
    End Sub

    Private Sub ExitApplication()
        _isExiting = True
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub

End Class
