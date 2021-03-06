Public Class model_object_tracing
    Private field_affected As String

#Region "constructor"
    Public Sub New(field_affected_ As String)
        InitializeComponent()
        PerformAutoScale()

        'set in private variable parameter
        field_affected = field_affected_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If field_affected <> "" Then reports_show()
    End Sub

    Private Sub module_border(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Public Sub reports_show()
        Dim source As DataTable = fn_transform_deserialize(field_affected)

        'limpia los origenes de datos anteriores
        dgv_object_grid.DataSource = Nothing
        dgv_object_view.Columns.Clear()
        lbl_object_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source IsNot Nothing Then
            If source.Rows.Count > 0 Then
                'define el origen de datos al grid control
                dgv_object_grid.DataSource = source

                'parametriza las columnas de la vista
                With dgv_object_view
                    .BestFitColumns(True)
                    .SelectRow(0)

                    'comprueba el total de columnas para realizar el ajuste
                    .OptionsView.ColumnAutoWidth = If(.Columns.Count < 10, True, False)

                    'comprueba que la columna Id este incluida
                    If .Columns("Id") IsNot Nothing Then .Columns("Id").Visible = False

                    'define el total de filas en la etiqueta de totales
                    lbl_object_count.Text = .RowCount.ToString
                End With
            End If
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles dgv_object_view.ColumnFilterChanged
        lbl_object_count.Text = dgv_object_view.RowCount.ToString
    End Sub
#End Region

#Region "options"
    Private Sub create_option(sender As Object, e As EventArgs) Handles btn_object_accept.Click, btn_object_cancel.Click
        Close()
    End Sub

    Private Sub exported_option(sender As Object, e As EventArgs) Handles btn_object_export.Click
        If dgv_object_view.RowCount > 0 Then
            Using export As New model_object_export(dgv_object_view)
                export.ShowDialog(start_home)
            End Using
        End If
    End Sub

    Private Sub ajusted_option(sender As Object, e As EventArgs) Handles btn_object_columns.Click
        With dgv_object_view.OptionsView
            .ColumnAutoWidth = If(.ColumnAutoWidth = False, True, False)
        End With
    End Sub

    Private Sub printer_option(sender As Object, e As EventArgs) Handles btn_object_print.Click
        If dgv_object_view.RowCount > 0 Then dgv_object_view.ShowPrintPreview()
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles btn_object_panel.Click
        With dgv_object_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub
#End Region
End Class