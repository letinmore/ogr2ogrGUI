<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGUI))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInstance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExePath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtShpPath = New System.Windows.Forms.TextBox()
        Me.grpSSOptions = New System.Windows.Forms.GroupBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkIntegrated = New System.Windows.Forms.CheckBox()
        Me.grpExeOptions = New System.Windows.Forms.GroupBox()
        Me.btnFindShp = New System.Windows.Forms.Button()
        Me.btnFindExe = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpSSOptions.SuspendLayout()
        Me.grpExeOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Instance name"
        '
        'txtInstance
        '
        Me.txtInstance.Location = New System.Drawing.Point(158, 101)
        Me.txtInstance.Name = "txtInstance"
        Me.txtInstance.Size = New System.Drawing.Size(218, 26)
        Me.txtInstance.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ogr2ogr.exe path"
        '
        'txtExePath
        '
        Me.txtExePath.Location = New System.Drawing.Point(145, 36)
        Me.txtExePath.Name = "txtExePath"
        Me.txtExePath.Size = New System.Drawing.Size(218, 26)
        Me.txtExePath.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Database name"
        '
        'txtDb
        '
        Me.txtDb.Location = New System.Drawing.Point(158, 36)
        Me.txtDb.Name = "txtDb"
        Me.txtDb.Size = New System.Drawing.Size(218, 26)
        Me.txtDb.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SHP file path"
        '
        'txtShpPath
        '
        Me.txtShpPath.Location = New System.Drawing.Point(145, 98)
        Me.txtShpPath.Name = "txtShpPath"
        Me.txtShpPath.Size = New System.Drawing.Size(218, 26)
        Me.txtShpPath.TabIndex = 8
        '
        'grpSSOptions
        '
        Me.grpSSOptions.Controls.Add(Me.txtPwd)
        Me.grpSSOptions.Controls.Add(Me.Label8)
        Me.grpSSOptions.Controls.Add(Me.txtUser)
        Me.grpSSOptions.Controls.Add(Me.Label7)
        Me.grpSSOptions.Controls.Add(Me.chkIntegrated)
        Me.grpSSOptions.Controls.Add(Me.Label4)
        Me.grpSSOptions.Controls.Add(Me.txtDb)
        Me.grpSSOptions.Controls.Add(Me.Label1)
        Me.grpSSOptions.Controls.Add(Me.txtInstance)
        Me.grpSSOptions.Location = New System.Drawing.Point(479, 30)
        Me.grpSSOptions.Name = "grpSSOptions"
        Me.grpSSOptions.Size = New System.Drawing.Size(424, 318)
        Me.grpSSOptions.TabIndex = 9
        Me.grpSSOptions.TabStop = False
        Me.grpSSOptions.Text = "Options for SQL Server"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(158, 263)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(218, 26)
        Me.txtPwd.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(158, 207)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(218, 26)
        Me.txtUser.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Username"
        '
        'chkIntegrated
        '
        Me.chkIntegrated.AutoSize = True
        Me.chkIntegrated.Location = New System.Drawing.Point(23, 160)
        Me.chkIntegrated.Name = "chkIntegrated"
        Me.chkIntegrated.Size = New System.Drawing.Size(198, 24)
        Me.chkIntegrated.TabIndex = 7
        Me.chkIntegrated.Text = "Use integrated security"
        Me.chkIntegrated.UseVisualStyleBackColor = True
        '
        'grpExeOptions
        '
        Me.grpExeOptions.Controls.Add(Me.btnFindShp)
        Me.grpExeOptions.Controls.Add(Me.btnFindExe)
        Me.grpExeOptions.Controls.Add(Me.txtExePath)
        Me.grpExeOptions.Controls.Add(Me.Label3)
        Me.grpExeOptions.Controls.Add(Me.Label5)
        Me.grpExeOptions.Controls.Add(Me.txtShpPath)
        Me.grpExeOptions.Location = New System.Drawing.Point(35, 30)
        Me.grpExeOptions.Name = "grpExeOptions"
        Me.grpExeOptions.Size = New System.Drawing.Size(424, 318)
        Me.grpExeOptions.TabIndex = 10
        Me.grpExeOptions.TabStop = False
        Me.grpExeOptions.Text = "Options for ogr2ogr"
        '
        'btnFindShp
        '
        Me.btnFindShp.Location = New System.Drawing.Point(369, 94)
        Me.btnFindShp.Name = "btnFindShp"
        Me.btnFindShp.Size = New System.Drawing.Size(40, 35)
        Me.btnFindShp.TabIndex = 10
        Me.btnFindShp.Text = "..."
        Me.btnFindShp.UseVisualStyleBackColor = True
        '
        'btnFindExe
        '
        Me.btnFindExe.Location = New System.Drawing.Point(369, 31)
        Me.btnFindExe.Name = "btnFindExe"
        Me.btnFindExe.Size = New System.Drawing.Size(40, 37)
        Me.btnFindExe.TabIndex = 9
        Me.btnFindExe.Text = "..."
        Me.btnFindExe.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(285, 599)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(140, 34)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "Run"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(474, 599)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 33)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(754, 599)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 33)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Process log"
        '
        'txtCommand
        '
        Me.txtCommand.Location = New System.Drawing.Point(35, 410)
        Me.txtCommand.Multiline = True
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCommand.Size = New System.Drawing.Size(854, 152)
        Me.txtCommand.TabIndex = 15
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(31, 600)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(105, 20)
        Me.lblVersion.TabIndex = 16
        Me.lblVersion.Text = "GUI Version: "
        '
        'frmGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 652)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtCommand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpExeOptions)
        Me.Controls.Add(Me.grpSSOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGUI"
        Me.Text = "ogr2ogr GUI"
        Me.grpSSOptions.ResumeLayout(False)
        Me.grpSSOptions.PerformLayout()
        Me.grpExeOptions.ResumeLayout(False)
        Me.grpExeOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInstance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtExePath As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtShpPath As TextBox
    Friend WithEvents grpSSOptions As GroupBox
    Friend WithEvents grpExeOptions As GroupBox
    Friend WithEvents btnFindShp As Button
    Friend WithEvents btnFindExe As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkIntegrated As CheckBox
    Friend WithEvents lblVersion As Label
End Class
