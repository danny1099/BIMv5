Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class model_object_export
    Private parameter As Parameters = Parameters.Instance
    Private export_setting As New XlsxExportOptionsEx
    Private object_view As GridView

#Region "constructors"

    Public Sub New(gridview As GridView)
        InitializeComponent()
        PerformAutoScale()

        'define el valor del parametro en la variable
        object_view = gridview
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_object_export.Datasources(fn_format_export, "format")
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Function fn_format_export() As DataTable
        Dim table As New DataTable

        With table
            .Columns.Add("Id")
            .Columns.Add("format")
            .Columns.Add("method")

            'agrega las filas con los procedimientos de exportación
            .Rows.Add("xlsx", "Export to Excel", "ExportToXlsx")
            .Rows.Add("xls", "Export to Excel 97 - 2003", "ExportToXls")
            .Rows.Add("csv", "Export to CSV", "ExportToCsv")
            .Rows.Add("txt", "Export to Text", "ExportToText")
            .Rows.Add("pdf", "Export to PDF", "ExportToPdf")
        End With

        Return table
    End Function

    Private Sub check_column(visible As Boolean)
        If object_view.DataRowCount > 0 Then
            If object_view.Columns("Opciones") IsNot Nothing Then
                object_view.Columns("Opciones").Visible = visible
            End If
        End If
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click
        If xvp_validate.Validate = True Then
            Try
                If xfs_path.ShowDialog = DialogResult.OK Then
                    'oculta la columna de opciones del listado
                    check_column(False)

                    'Cuenta si la vista tiene nodos adjuntos para cambiar el metodo de exportacion
                    If object_view.GridControl.LevelTree.Nodes.Count = 1 Then
                        If message_text("La consulta tiene un nodo de relación, Desea exportar el reporte con este nodo?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Cambia el metodo de exportacion y exporta en xlsx con el nodo de detalles
                            export_setting.ExportType = DevExpress.Export.ExportType.WYSIWYG
                            object_view.ExportToXlsx(xfs_path.FileName & ".xlsx", export_setting)
                        Else
                            GoTo Normal
                        End If
                Else
Normal:
                        'ejecuta el procedimiento del gridview para exportar la informacion
                        CallByName(object_view, cmb_object_export.GetColumnValue("method"), CallType.Method, xfs_path.FileName & "." & cmb_object_export.EditValue)
                    End If

                    'close form export when finalize metod
                    If message_text("Los datos fueron exportados exitosamente...", MessageBoxButtons.OK) = DialogResult.OK Then
                        check_column(True)
                        Close()
                    End If
                End If
            Catch ex As Exception
            Finally
            End Try
        End If
    End Sub
#End Region

End Class