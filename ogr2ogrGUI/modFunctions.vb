Module modFunctions

    Public Function GetFilePath(ByVal filetype As String, ByVal multiselection As Boolean) As String

        'GetFilePath("Text files (*.txt)|*.txt", False)
        Dim open As OpenFileDialog

        'Configure dialog
        open = New OpenFileDialog
        open.Filter = filetype
        open.Multiselect = multiselection

        open.ShowDialog()

        'Validate if a file was selected
        If open.FileName = "" Then
            Return Nothing
        Else
            Return open.FileName
        End If
    End Function

    Public Function CreateParametersString(ByVal server As String, ByVal dbname As String, ByVal shp As String, ByVal user As String, ByVal pw As String, ByVal integrated_sec As Boolean) As String
        Dim arguments As String = Nothing

        If integrated_sec = True Then
            arguments = " -overwrite -f MSSQLSpatial " & Chr(34) & "MSSQL:server=" & server &
                        ";database=" & dbname & ";Driver={SQL Server Native Client 11.0};trusted_connection=yes" &
                        Chr(34) & " " & Chr(34) & shp & Chr(34)

        Else
            arguments = " -overwrite -f MSSQLSpatial " & Chr(34) & "MSSQL:server=" &
                    server & ";database=" & dbname & ";Uid=" & user & ";Pwd=" & pw &
                        ";Driver={SQL Server Native Client 11.0}" &
                        Chr(34) & " " & Chr(34) & shp & Chr(34)
        End If

        Return arguments
    End Function

End Module
