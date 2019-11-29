Public Class frmGUI
    Private Sub btnFindExe_Click(sender As Object, e As EventArgs) Handles btnFindExe.Click
        Dim exepath As String

        exepath = modFunctions.GetFilePath("ogr2ogr (ogr2ogr.exe)|ogr2ogr.exe", False)

        If Me.txtExePath.ReadOnly = True Then
            Me.txtExePath.ReadOnly = False
        End If

        If exepath Is Nothing Then
            MessageBox.Show("Please select a valid path to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.txtExePath.Text = exepath
        End If

        Me.txtExePath.ReadOnly = True
    End Sub

    Private Sub btnFindShp_Click(sender As Object, e As EventArgs) Handles btnFindShp.Click
        Dim shppath As String

        shppath = modFunctions.GetFilePath("SHAPE files (*.shp)|*.shp", False)

        If Me.txtShpPath.ReadOnly = True Then
            Me.txtShpPath.ReadOnly = False
        End If

        If shppath Is Nothing Then
            MessageBox.Show("Please select a valid path to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.txtShpPath.Text = shppath
        End If

        Me.txtShpPath.ReadOnly = True
    End Sub

    Private Sub ChangeFieldStatus(ByVal state As Boolean)
        Me.txtUser.Enabled = state
        Me.txtPwd.Enabled = state
    End Sub

    Private Function ValidFields() As Boolean
        Dim result As Boolean = False

        If Me.chkIntegrated.Checked = True Then
            If Me.txtExePath.Text <> "" And Me.txtShpPath.Text <> "" And
                Me.txtInstance.Text <> "" And Me.txtDb.Text <> "" Then
                result = True
            End If
        Else
            If Me.txtExePath.Text <> "" And Me.txtShpPath.Text <> "" And
                Me.txtInstance.Text <> "" And Me.txtDb.Text <> "" And
                Me.txtUser.Text <> "" And Me.txtPwd.Text <> "" Then
                result = True
            End If
        End If
        Return result
    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim arguments As String, initInfo As String

        If ValidFields() = True Then
            arguments = modFunctions.CreateParametersString(Me.txtInstance.Text, Me.txtDb.Text, Me.txtShpPath.Text, Me.txtUser.Text, Me.txtPwd.Text, Me.chkIntegrated.Checked)
            If arguments <> Nothing Then
                initInfo = "INFO: The process may take several minutes, " &
                    "and the application window may freeze while ogr2ogr is running."

                Me.txtCommand.Text = initInfo & Environment.NewLine & Environment.NewLine &
                                Me.txtExePath.Text & arguments
                ExecuteCommand(arguments)
            Else
                MessageBox.Show("The arguments for ogr2ogr could not be created. " &
                                "Close the application and open it again",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("One or more required fields are empty.",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub frmGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.chkIntegrated.Checked = True
        ChangeFieldStatus(False)
        lblVersion.Text = "GUI Version: " & Application.ProductVersion
    End Sub

    Private Sub chkIntegrated_CheckedChanged(sender As Object, e As EventArgs) Handles chkIntegrated.CheckedChanged
        If Me.chkIntegrated.Checked = True Then
            ChangeFieldStatus(False)
        Else
            MessageBox.Show("The username and password are used in plain text.",
                            "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            ChangeFieldStatus(True)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        Me.txtDb.Text = ""
        Me.txtExePath.Text = ""
        Me.txtInstance.Text = ""
        Me.txtPwd.Text = ""
        Me.txtShpPath.Text = ""
        Me.txtUser.Text = ""
        Me.txtCommand.Text = ""
    End Sub

    Private Sub ExecuteCommand(ByVal commandArguments As String)
        Dim startInfo As ProcessStartInfo = Nothing
        Dim shellProcess As Process = Nothing
        Dim Output As String = ""
        Dim OutputErrors As String = ""
        Dim suggestion As String

        suggestion = "SUGGESTION: Check if the database and server name " &
            "are correct, and that the SQL Server services are up and running."

        Try
            startInfo = New ProcessStartInfo

            startInfo.Arguments = commandArguments
            startInfo.FileName = Me.txtExePath.Text
            startInfo.UseShellExecute = False
            startInfo.CreateNoWindow = True
            startInfo.RedirectStandardOutput = True
            startInfo.RedirectStandardError = True

            shellProcess = Process.Start(startInfo)


            While shellProcess.HasExited() = False
                Output = shellProcess.StandardOutput.ReadLine
                OutputErrors = shellProcess.StandardError.ReadToEnd
                Debug.Print(Output)
                If OutputErrors <> "" Then
                    Throw New System.Exception(OutputErrors)
                End If
            End While

            Me.txtCommand.Text = Me.txtCommand.Text & Environment.NewLine &
                                    Environment.NewLine & "Shape file inserted successfully." &
                                    Environment.NewLine & Output

            shellProcess.Close()
            shellProcess.Dispose()

            Output = Nothing
            OutputErrors = Nothing

            MessageBox.Show("Shape file inserted successfully.",
                            "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As Exception
            Me.txtCommand.Text = Me.txtCommand.Text & Environment.NewLine &
                                Environment.NewLine & "ERROR: The Shape file could not be inserted. " &
                                "See the details below." & Environment.NewLine &
                                Environment.NewLine & ex.Message & Environment.NewLine &
                                Environment.NewLine & suggestion

            MessageBox.Show("The Shape file could not be inserted. " &
                            "Check the process log for more information.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If shellProcess IsNot Nothing Then
                If shellProcess.HasExited = False Then
                    shellProcess.Kill()
                    shellProcess.Close()
                End If
            End If

            shellProcess.Dispose()
            shellProcess = Nothing

        End Try
    End Sub
End Class
