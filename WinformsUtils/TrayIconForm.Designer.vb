<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrayIconForm
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeparatorToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me._grpBalloon = New System.Windows.Forms.GroupBox()
        Me._tlpBalloon = New System.Windows.Forms.TableLayoutPanel()
        Me._lblTitle = New System.Windows.Forms.Label()
        Me._txtTitle = New System.Windows.Forms.TextBox()
        Me._lblMessage = New System.Windows.Forms.Label()
        Me._txtMessage = New System.Windows.Forms.TextBox()
        Me._lblIcon = New System.Windows.Forms.Label()
        Me._cmbIcon = New System.Windows.Forms.ComboBox()
        Me._lblTimeout = New System.Windows.Forms.Label()
        Me._nudTimeout = New System.Windows.Forms.NumericUpDown()
        Me._grpActions = New System.Windows.Forms.GroupBox()
        Me._flpButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me._btnShowBalloon = New System.Windows.Forms.Button()
        Me._btnHide = New System.Windows.Forms.Button()
        Me._btnExit = New System.Windows.Forms.Button()
        Me._lblStatus = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me._tlpMain.SuspendLayout()
        Me._grpBalloon.SuspendLayout()
        Me._tlpBalloon.SuspendLayout()
        CType(Me._nudTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._grpActions.SuspendLayout()
        Me._flpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "The application is running in the system tray."
        Me.NotifyIcon1.BalloonTipTitle = "TrayIconForm"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Text = "TrayIconForm"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.HideToolStripMenuItem, Me.SeparatorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 76)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ShowToolStripMenuItem.Text = "&Show"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HideToolStripMenuItem.Text = "&Hide"
        '
        'SeparatorToolStripMenuItem
        '
        Me.SeparatorToolStripMenuItem.Name = "SeparatorToolStripMenuItem"
        Me.SeparatorToolStripMenuItem.Size = New System.Drawing.Size(104, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        '_tlpMain
        '
        Me._tlpMain.ColumnCount = 1
        Me._tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpMain.Controls.Add(Me._grpBalloon, 0, 0)
        Me._tlpMain.Controls.Add(Me._grpActions, 0, 1)
        Me._tlpMain.Controls.Add(Me._lblStatus, 0, 2)
        Me._tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpMain.Location = New System.Drawing.Point(0, 0)
        Me._tlpMain.Name = "_tlpMain"
        Me._tlpMain.Padding = New System.Windows.Forms.Padding(6)
        Me._tlpMain.RowCount = 3
        Me._tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpMain.TabIndex = 0
        '
        '_grpBalloon
        '
        Me._grpBalloon.AutoSize = True
        Me._grpBalloon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me._grpBalloon.Controls.Add(Me._tlpBalloon)
        Me._grpBalloon.Dock = System.Windows.Forms.DockStyle.Fill
        Me._grpBalloon.Location = New System.Drawing.Point(9, 9)
        Me._grpBalloon.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me._grpBalloon.Name = "_grpBalloon"
        Me._grpBalloon.Padding = New System.Windows.Forms.Padding(8, 6, 8, 8)
        Me._grpBalloon.TabIndex = 0
        Me._grpBalloon.TabStop = False
        Me._grpBalloon.Text = "Balloon Tip Settings"
        '
        '_tlpBalloon
        '
        Me._tlpBalloon.AutoSize = True
        Me._tlpBalloon.ColumnCount = 2
        Me._tlpBalloon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpBalloon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._tlpBalloon.Controls.Add(Me._lblTitle, 0, 0)
        Me._tlpBalloon.Controls.Add(Me._txtTitle, 1, 0)
        Me._tlpBalloon.Controls.Add(Me._lblMessage, 0, 1)
        Me._tlpBalloon.Controls.Add(Me._txtMessage, 1, 1)
        Me._tlpBalloon.Controls.Add(Me._lblIcon, 0, 2)
        Me._tlpBalloon.Controls.Add(Me._cmbIcon, 1, 2)
        Me._tlpBalloon.Controls.Add(Me._lblTimeout, 0, 3)
        Me._tlpBalloon.Controls.Add(Me._nudTimeout, 1, 3)
        Me._tlpBalloon.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tlpBalloon.Location = New System.Drawing.Point(8, 19)
        Me._tlpBalloon.Name = "_tlpBalloon"
        Me._tlpBalloon.RowCount = 4
        Me._tlpBalloon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpBalloon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpBalloon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpBalloon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
        Me._tlpBalloon.TabIndex = 0
        '
        '_lblTitle
        '
        Me._lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me._lblTitle.AutoSize = True
        Me._lblTitle.Location = New System.Drawing.Point(3, 6)
        Me._lblTitle.Margin = New System.Windows.Forms.Padding(3)
        Me._lblTitle.Name = "_lblTitle"
        Me._lblTitle.Size = New System.Drawing.Size(30, 13)
        Me._lblTitle.Text = "&Title:"
        '
        '_txtTitle
        '
        Me._txtTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me._txtTitle.Location = New System.Drawing.Point(42, 3)
        Me._txtTitle.Margin = New System.Windows.Forms.Padding(3)
        Me._txtTitle.Name = "_txtTitle"
        Me._txtTitle.Size = New System.Drawing.Size(300, 20)
        Me._txtTitle.TabIndex = 0
        Me._txtTitle.Text = "TrayIconForm"
        '
        '_lblMessage
        '
        Me._lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Top
        Me._lblMessage.AutoSize = True
        Me._lblMessage.Location = New System.Drawing.Point(3, 32)
        Me._lblMessage.Margin = New System.Windows.Forms.Padding(3)
        Me._lblMessage.Name = "_lblMessage"
        Me._lblMessage.Size = New System.Drawing.Size(53, 13)
        Me._lblMessage.Text = "&Message:"
        '
        '_txtMessage
        '
        Me._txtMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me._txtMessage.Location = New System.Drawing.Point(42, 29)
        Me._txtMessage.Margin = New System.Windows.Forms.Padding(3)
        Me._txtMessage.Multiline = True
        Me._txtMessage.Name = "_txtMessage"
        Me._txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me._txtMessage.Size = New System.Drawing.Size(300, 60)
        Me._txtMessage.TabIndex = 1
        Me._txtMessage.Text = "The application is running in the system tray."
        '
        '_lblIcon
        '
        Me._lblIcon.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me._lblIcon.AutoSize = True
        Me._lblIcon.Location = New System.Drawing.Point(3, 98)
        Me._lblIcon.Margin = New System.Windows.Forms.Padding(3)
        Me._lblIcon.Name = "_lblIcon"
        Me._lblIcon.Size = New System.Drawing.Size(33, 13)
        Me._lblIcon.Text = "&Icon:"
        '
        '_cmbIcon
        '
        Me._cmbIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me._cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbIcon.Location = New System.Drawing.Point(42, 95)
        Me._cmbIcon.Margin = New System.Windows.Forms.Padding(3)
        Me._cmbIcon.Name = "_cmbIcon"
        Me._cmbIcon.Size = New System.Drawing.Size(300, 21)
        Me._cmbIcon.TabIndex = 2
        '
        '_lblTimeout
        '
        Me._lblTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me._lblTimeout.AutoSize = True
        Me._lblTimeout.Location = New System.Drawing.Point(3, 124)
        Me._lblTimeout.Margin = New System.Windows.Forms.Padding(3)
        Me._lblTimeout.Name = "_lblTimeout"
        Me._lblTimeout.Size = New System.Drawing.Size(33, 13)
        Me._lblTimeout.Text = "T&imeout (ms):"
        '
        '_nudTimeout
        '
        Me._nudTimeout.Location = New System.Drawing.Point(42, 121)
        Me._nudTimeout.Margin = New System.Windows.Forms.Padding(3)
        Me._nudTimeout.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me._nudTimeout.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me._nudTimeout.Name = "_nudTimeout"
        Me._nudTimeout.Size = New System.Drawing.Size(80, 20)
        Me._nudTimeout.TabIndex = 3
        Me._nudTimeout.Value = New Decimal(New Integer() {3000, 0, 0, 0})
        '
        '_grpActions
        '
        Me._grpActions.AutoSize = True
        Me._grpActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me._grpActions.Controls.Add(Me._flpButtons)
        Me._grpActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me._grpActions.Location = New System.Drawing.Point(9, 168)
        Me._grpActions.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me._grpActions.Name = "_grpActions"
        Me._grpActions.Padding = New System.Windows.Forms.Padding(8, 6, 8, 8)
        Me._grpActions.TabIndex = 1
        Me._grpActions.TabStop = False
        Me._grpActions.Text = "Actions"
        '
        '_flpButtons
        '
        Me._flpButtons.AutoSize = True
        Me._flpButtons.Controls.Add(Me._btnShowBalloon)
        Me._flpButtons.Controls.Add(Me._btnHide)
        Me._flpButtons.Controls.Add(Me._btnExit)
        Me._flpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flpButtons.Location = New System.Drawing.Point(8, 19)
        Me._flpButtons.Name = "_flpButtons"
        Me._flpButtons.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me._flpButtons.Size = New System.Drawing.Size(350, 40)
        Me._flpButtons.TabIndex = 0
        '
        '_btnShowBalloon
        '
        Me._btnShowBalloon.Location = New System.Drawing.Point(3, 6)
        Me._btnShowBalloon.Margin = New System.Windows.Forms.Padding(3)
        Me._btnShowBalloon.Name = "_btnShowBalloon"
        Me._btnShowBalloon.Size = New System.Drawing.Size(120, 26)
        Me._btnShowBalloon.TabIndex = 0
        Me._btnShowBalloon.Text = "Show &Balloon Tip"
        Me._btnShowBalloon.UseVisualStyleBackColor = True
        '
        '_btnHide
        '
        Me._btnHide.Location = New System.Drawing.Point(129, 6)
        Me._btnHide.Margin = New System.Windows.Forms.Padding(3)
        Me._btnHide.Name = "_btnHide"
        Me._btnHide.Size = New System.Drawing.Size(90, 26)
        Me._btnHide.TabIndex = 1
        Me._btnHide.Text = "&Hide to Tray"
        Me._btnHide.UseVisualStyleBackColor = True
        '
        '_btnExit
        '
        Me._btnExit.Location = New System.Drawing.Point(225, 6)
        Me._btnExit.Margin = New System.Windows.Forms.Padding(3)
        Me._btnExit.Name = "_btnExit"
        Me._btnExit.Size = New System.Drawing.Size(75, 26)
        Me._btnExit.TabIndex = 2
        Me._btnExit.Text = "E&xit"
        Me._btnExit.UseVisualStyleBackColor = True
        '
        '_lblStatus
        '
        Me._lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me._lblStatus.AutoSize = True
        Me._lblStatus.ForeColor = System.Drawing.SystemColors.GrayText
        Me._lblStatus.Location = New System.Drawing.Point(9, 280)
        Me._lblStatus.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me._lblStatus.Name = "_lblStatus"
        Me._lblStatus.Size = New System.Drawing.Size(200, 13)
        Me._lblStatus.Text = "Double-click the tray icon to restore the window."
        '
        'TrayIconForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 310)
        Me.Controls.Add(Me._tlpMain)
        Me.MinimumSize = New System.Drawing.Size(380, 300)
        Me.Name = "TrayIconForm"
        Me.Text = "Tray Icon Demo"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me._tlpMain.ResumeLayout(False)
        Me._tlpMain.PerformLayout()
        Me._grpBalloon.ResumeLayout(False)
        Me._grpBalloon.PerformLayout()
        Me._tlpBalloon.ResumeLayout(False)
        Me._tlpBalloon.PerformLayout()
        CType(Me._nudTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me._grpActions.ResumeLayout(False)
        Me._grpActions.PerformLayout()
        Me._flpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeparatorToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private _tlpMain As System.Windows.Forms.TableLayoutPanel
    Private _grpBalloon As System.Windows.Forms.GroupBox
    Private _tlpBalloon As System.Windows.Forms.TableLayoutPanel
    Private _lblTitle As System.Windows.Forms.Label
    Friend WithEvents _txtTitle As System.Windows.Forms.TextBox
    Private _lblMessage As System.Windows.Forms.Label
    Friend WithEvents _txtMessage As System.Windows.Forms.TextBox
    Private _lblIcon As System.Windows.Forms.Label
    Friend WithEvents _cmbIcon As System.Windows.Forms.ComboBox
    Private _lblTimeout As System.Windows.Forms.Label
    Friend WithEvents _nudTimeout As System.Windows.Forms.NumericUpDown
    Private _grpActions As System.Windows.Forms.GroupBox
    Private _flpButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents _btnShowBalloon As System.Windows.Forms.Button
    Friend WithEvents _btnHide As System.Windows.Forms.Button
    Friend WithEvents _btnExit As System.Windows.Forms.Button
    Private _lblStatus As System.Windows.Forms.Label
End Class
