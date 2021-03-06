Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class settings_dealers_showed
    Private object_search As object_data_search = object_data_search.Instance
    Private criteria_search As String = "d.row_visible=1"

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        reports_show(criteria_search)
    End Sub
#End Region

#Region "behaviors"
    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source_table As DataTable = object_search.fn_procedure_search(dop.spEntitiesBussinesDealer_Viewer, criteria_search)

        'Limpia los origenes de datos anteriores
        object_datagrid_master.DataSource = Nothing
        object_datagrid_view.Columns.Clear()
        object_label_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source_table.Rows.Count > 0 Then
            'Define el origen de datos al grid control
            object_datagrid_master.DataSource = source_table

            'parametriza las columnas de la vista
            With object_datagrid_view
                .BestFitColumns(True)
                .SelectRow(0)

                'Define el total de filas en la etiqueta de totales
                object_label_count.Text = .RowCount.ToString
            End With

            'Define la columna de opciones
            option_column()
            custom_layout()
        End If
    End Sub

    Private Sub options_show(sender As Object, e As RowClickEventArgs) Handles object_datagrid_view.RowClick
        If object_datagrid_view.IsRowSelected(e.RowHandle) = True Then
            Dim hi As GridHitInfo = object_datagrid_view.CalcHitInfo(e.Location)
            If hi.InRowCell Then
                If hi.Column.FieldName = "Opciones" Then
                    'Cambia la configuracion de botones segun el clic realizado
                    change_options(e.Button)

                    'Muestra el selector de opciones
                    With object_panel_flyout
                        .Options.Location = If(hi.HitPoint.Y >= 270, New Point(hi.HitPoint.X, 150), hi.HitPoint)
                        .ShowPopup(True)
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub count_rows(sender As Object, e As EventArgs) Handles object_datagrid_view.ColumnFilterChanged
        object_label_count.Text = object_datagrid_view.RowCount.ToString
    End Sub

    Private Sub customization_viewer(sender As Object, e As EventArgs) Handles object_datagrid_view.HideCustomizationForm
        If message_text("Desea guardar la configuración de campos seleccionada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then object_datagrid_view.SaveLayoutToXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Private Sub selected_copy(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles object_datagrid_view.KeyDown
        Dim view As GridView = CType(sender, GridView)
        If e.Control AndAlso e.KeyCode = Keys.C Then
            If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
                Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub flyout_hidden(sender As Object, e As DevExpress.Utils.FlyoutPanelEventArgs) Handles object_panel_flyout.Hidden
        With object_panel_flyout
            .Size = .MaximumSize

            'Restablece el tamaño del flyout de opciones
            For Each b As Button In object_panel_actions.Controls
                b.Size = b.MaximumSize
            Next
        End With
    End Sub

    Private Sub change_options(select_button As MouseButtons)
        For Each b As Button In object_panel_actions.Controls
            With object_panel_flyout
                b.Size = If(b.Tag = "S", If(select_button = MouseButtons.Right, b.MinimumSize, b.MaximumSize), If(select_button = MouseButtons.Left, b.MinimumSize, b.MaximumSize))
                .Height = If(b.Size = b.MinimumSize, (.Height - 40), .Height)
            End With
        Next
    End Sub

    Private Sub custom_layout()
        If My.Computer.FileSystem.FileExists("C:\APDA\BIM\bin\" & Me.Name & ".xml") Then object_datagrid_view.RestoreLayoutFromXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Private Sub option_column()
        If object_datagrid_view.RowCount > 0 Then
            Dim column_option As GridColumn = object_datagrid_view.Columns.AddVisible("column_option")

            With column_option
                .UnboundType = DevExpress.Data.UnboundColumnType.Object
                .ColumnEdit = object_datagrid_column
                .ImageOptions.Image = My.Resources.options_settings
                .ImageOptions.Alignment = StringAlignment.Center
                .FieldName = "Opciones"
                .AppearanceHeader.ForeColor = Color.DarkGray
                .Width = 40
                .MaxWidth = 40
                .MinWidth = 40
                .VisibleIndex = 0
            End With
        End If
    End Sub
#End Region

#Region "options"
    Private Sub created_option(sender As Object, e As EventArgs) Handles object_button_create.Click
        show_option(New settings_dealers_created)
    End Sub

    Private Sub edited_option(sender As Object, e As EventArgs) Handles object_button_edited.Click
        With object_datagrid_view
            If .SelectedRowsCount.ToString = 1 Then
                If .IsRowSelected(.FocusedRowHandle) = True Then
                    If message_text("Está seguro que desea modificar el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        show_option(New settings_dealers_edited(Integer.Parse(.GetRowCellValue(.FocusedRowHandle, "IDR")).ToString))
                    End If
                End If
            Else
                message_text("La acción no se puede realizar con selección multiple", MessageBoxButtons.OK)
            End If
        End With
    End Sub

    Private Sub erased_option(sender As Object, e As EventArgs) Handles object_button_erased.Click
        With object_datagrid_view
            If .RowCount > 0 Then
                If message_text("Está seguro que desea eliminar los registros seleccionados?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    For i As Integer = 0 To .DataRowCount - 1
                        If .IsRowSelected(i) = True Then
                            If object_search.fn_procedure_execute(dop.spEntitiesBussinesDealer_Erased, Integer.Parse(.GetRowCellValue(i, "IDR")), False) = True Then
                            End If
                        End If
                    Next

                    'Retorna el mensaje de finalizado el proceso
                    If message_text("Los registros seleccionados fueron anulados exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then reports_show(criteria_search)
                End If
            End If
        End With
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles object_button_update.Click
        reports_show(criteria_search)
    End Sub

    Private Sub filtering_option(sender As Object, e As EventArgs) Handles object_button_filtering.Click
        reports_show("d.row_visible=0")
    End Sub

    Private Sub export_option(sender As Object, e As EventArgs) Handles object_button_export.Click
        If object_datagrid_view.RowCount > 0 Then
            If object_component_saved.ShowDialog = DialogResult.OK Then
                'Exporta el resultado de la consulta a la ubicacion definida
                object_datagrid_view.ExportToXlsx(object_component_saved.FileName & ".xlsx")

                'Genera el mensaje de confirmación del proceso de exportacion
                message_text("Los datos fueron exportados exitosamente...", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub fields_selector(sender As Object, e As EventArgs) Handles object_button_fields.Click
        If object_datagrid_view.RowCount > 0 Then object_datagrid_view.ShowCustomization()
    End Sub

    Private Sub group_option(sender As Object, e As EventArgs) Handles object_button_panel.Click
        With object_datagrid_view.OptionsView
            .ShowGroupPanel = If(.ShowGroupPanel = False, True, False)
        End With
    End Sub
#End Region
End Class
