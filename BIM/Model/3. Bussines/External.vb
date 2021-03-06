Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports Excel = Microsoft.Office.Interop.Excel

Public Module External
    <DllImport("kernel32")> Private Function GetPrivateProfileString(lpAppName As String, lpKeyName As String, lpDefault As String, lpReturnedString As System.Text.StringBuilder, nSize As Integer, lpFileName As String) As Integer
    End Function

    Public Function fn_text_settings(name As String, item As String, path As String) As String
        Dim sb As New System.Text.StringBuilder(5000)
        Dim profile_code As Integer
        Dim result_text As String

        profile_code = GetPrivateProfileString(name, item, String.Empty, sb, sb.MaxCapacity, path)
        result_text = sb.ToString

        Return result_text
    End Function

    Public Function fn_excel_import(filename As String) As DataTable

        If ((String.IsNullOrEmpty(filename))) Then Throw New ArgumentNullException(message_text("No ha seleccionado ningun archivo.", MessageBoxButtons.OK))

        Try
            Dim extension As String = IO.Path.GetExtension(filename)
            Dim dataSource As String = filename
            Dim connString As String = Nothing

            If (extension = ".xls") Then
                connString &= "Provider=Microsoft.Jet.OLEDB.4.0;" &
               "Extended Properties='Excel 8.0;HDR=YES;IMEX=1';" & "Data Source=" & dataSource

            ElseIf (extension = ".xlsx") Then
                connString &= "Provider=Microsoft.ACE.OLEDB.12.0;" &
               "Extended Properties='Excel 12.0;HDR=YES;IMEX=1';" & "Data Source=" & dataSource

            Else
                Throw New ArgumentException(message_text("La extensión " & extension & " del archivo no está permitida.", MessageBoxButtons.OK))
            End If

            '--create conection of oledb'
            Dim cnn As OleDb.OleDbConnection
            Dim worksheet As String = String.Empty
            Dim dt As New DataTable()

            'Crea una nueva conexion
            cnn = New OleDb.OleDbConnection(connString)

            'Variables para el control del archivo de excel
            Dim xlApp As Excel.Application = Nothing
            Dim xlWorkBooks As Excel.Workbooks = Nothing
            Dim xlWorkBook As Excel.Workbook = Nothing
            Dim xlWorkSheet As Excel.Worksheet = Nothing

            xlApp = New Excel.Application
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(filename)
            xlApp.Visible = False
            xlWorkSheet = xlWorkBook.ActiveSheet

            If xlWorkBook IsNot Nothing Then worksheet = xlWorkSheet.Name.ToString

            'Libera el archivo cargado y los recursos utilizados
            xlWorkBook.Close()
            xlApp.UserControl = True
            xlApp.Quit()
            objects_released(xlWorkSheet)
            objects_released(xlWorkBook)
            objects_released(xlWorkBooks)
            objects_released(xlApp)

            'Crea el select para leer la pagina
            Dim sql As String = "SELECT * FROM [" & worksheet & "$]"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            da.Fill(dt)
            da.Dispose()

            Return dt

        Catch ex As Exception
            Throw New ArgumentException(message_text("Error: " & ex.ToString, MessageBoxButtons.OK))
        Finally
        End Try
    End Function

    Public Sub fn_excel_format(fields_name As String)
        Try
            Dim fields_array As String() = fn_split_words(fields_name)

            If fields_array.Count > 0 Then
                'Variables para el control del archivo de excel
                Dim xlApp As Excel.Application = Nothing
                Dim xlWorkBooks As Excel.Workbooks = Nothing
                Dim xlWorkBook As Excel.Workbook = Nothing
                Dim xlWorkSheet As Excel.Worksheet = Nothing
                Dim column As Integer = 1

                xlApp = New Excel.Application
                xlWorkBooks = xlApp.Workbooks
                xlWorkBook = xlWorkBooks.Add()
                xlWorkSheet = xlWorkBook.ActiveSheet
                xlApp.Visible = False

                With xlWorkSheet
                    For Each field As String In fields_array
                        xlWorkSheet.Cells(1, column).Value = field.ToString
                        column += 1
                    Next
                End With

                'save excel file generate
                xlWorkBook.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\excel_format.xlsx")

                'Libera el archivo cargado y los recursos utilizados
                xlWorkBook.Close()
                xlApp.UserControl = True
                xlApp.Quit()
                objects_released(xlWorkSheet)
                objects_released(xlWorkBook)
                objects_released(xlWorkBooks)
                objects_released(xlApp)
            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub

    Public Function fn_split_words(split_text As String) As String()
        Return Regex.Split(split_text, "\W+")
    End Function

    Public Sub objects_released(ByVal o As Object)
        Try
            While (Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub
End Module
