Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports APDA.Object.Controls
Imports DevExpress.XtraEditors

Public Class comercial_customer_showed
    Private object_search As object_data_search = object_data_search.Instance
    Private criteria_search As String = String.Empty

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub search_permits()
        If sessions.position_rol <> 1 Then
            Dim table As DataTable = sessions.search_permission

            If table.Rows.Count > 0 Then
                With table
                    For Each options As Control In object_panel_actions.Controls
                        If TypeOf options Is Button Then
                            If .Select("action_object='" & options.Name & "' and option_showed='" & Me.Name & "'").Count = 0 Then
                                options.Visible = False
                                object_panel_flyout.Height = object_panel_flyout.Height - 40
                            End If
                        End If
                    Next
                End With
            End If
        End If
    End Sub

    Public Sub reports_show(Optional criteria_search As String = "")
        Dim source As DataTable ' = object_search.fn_procedure_search(dop.relationship_customer_person_showed, criteria_search)

        'Limpia los origenes de datos anteriores
        object_datagrid_master.DataSource = Nothing
        object_datagrid_view.Columns.Clear()
        object_panel_layout.Height = 0
        object_label_count.Text = 0

        'comprueba si la consulta tiene filas para mostrar
        If source.Rows.Count > 0 Then
            'Define el origen de datos al grid control
            object_datagrid_master.DataSource = source

            'parametriza las columnas de la vista
            With object_datagrid_view
                .BestFitColumns(True)
                .SelectRow(0)

                'Define el total de filas en la etiqueta de totales
                object_label_count.Text = .RowCount.ToString
                object_search_type.SelectedIndex = 0
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
                Dim column As GridColumn = hi.Column
                If column.FieldName = "Opciones" Then
                    object_panel_flyout.HidePopup()
                    object_panel_flyout.Options.Location = hi.HitPoint
                    object_panel_flyout.ShowPopup(True)
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

    Private Sub search_criteria(sender As Object, e As KeyEventArgs) Handles object_search_text.KeyDown
        If e.KeyData = Keys.Enter Then
            If object_search_type.SelectedIndex = 1 Then
                criteria_search = "c.number_document='" & object_search_text.Text & "' or c.person_name like '%" & object_search_text.Text & "%'"

                'Busca la informacion tecleada
                reports_show(criteria_search)
            End If
        End If
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

    Private Sub custom_layout()
        If My.Computer.FileSystem.FileExists("C:\APDA\BIM\bin\" & Me.Name & ".xml") Then object_datagrid_view.RestoreLayoutFromXml("C:\APDA\BIM\bin\" & Me.Name & ".xml")
    End Sub

    Private Sub object_listed()
        With object_search
            'object_search_agency.Datasources(.fn_procedure_search(dop.entities_bussines_agency_search, "row_visible=1"), "agency_name")
            object_search_depto.Datasources(.fn_procedure_search(dop.spSettingsGeneralSearch_Deparment, "d.row_visible=1"), "department_name")
            object_search_genre.Datasources(.fn_procedure_search(dop.spSettingsGeneralSearch_Genre, "g.row_visible=1"), "genre_name")
            object_search_city.Datasources(.fn_procedure_search(dop.spSettingsGeneralSearch_Cities, "c.row_visible=1"), "city_name")
            ' object_search_person.Datasources(.fn_procedure_search(dop.entities_workforce_persons_listed, "p.row_visible=1"), "Nombre de funcionario")
            'object_search_source.Datasources(.fn_procedure_search(dop.relationship_customer_person_sources, "row_visible=1"), "source_name")
            'object_search_knowledge.Datasources(.fn_procedure_search(dop.relationship_customer_knowledge_search, "row_visible=1"), "knowledge_name")
        End With
    End Sub
#End Region

#Region "options"
    Private Sub created_option(sender As Object, e As EventArgs) Handles object_button_create.Click
        show_option(New comercial_customer_created(Me))
    End Sub

    Private Sub edited_option(sender As Object, e As EventArgs) Handles object_button_edited.Click

    End Sub

    Private Sub search_option(sender As Object, e As EventArgs) Handles object_button_search.Click
        Dim condition_search As String = String.Empty

        For Each item As Object In object_panel_layout.Controls
            If TypeOf item IsNot Button And TypeOf item IsNot LabelControl Then
                If TypeOf item Is CustomChecked Then
                    If item.EditValue.ToString <> "" Then
                        If condition_search <> "" Then condition_search += " and " & item.Tag.ToString & item.EditValue & ")" Else condition_search = item.Tag.ToString & item.EditValue & ")"
                    End If
                ElseIf TypeOf item Is custombutton Then
                    If item.EditValue IsNot Nothing Then
                        If condition_search <> "" Then condition_search += " and " & item.Tag.ToString & item.EditValue & ")" Else condition_search = item.Tag.ToString & item.EditValue & ")"
                    End If
                End If
            End If
        Next

        'Lanza la consulta al servidor para mostrar en la grilla
        If condition_search <> "" Then
            reports_show(condition_search)
            defaults_objects(object_panel_layout)
        End If
    End Sub

    Private Sub advance_option(sender As Object, e As EventArgs) Handles object_label_advance.Click
        Dim filtering_advance As New model_object_filtering(process_filtering.customers_objects)

        If filtering_advance IsNot Nothing Then
            show_flyout(filtering_advance)

            'Aplica el filtro seleccionado a la busqueda de clientes
            If filtering_advance.criteria_search <> "" Then reports_show(filtering_advance.criteria_search)
        End If
    End Sub

    Private Sub transfered_option(sender As Object, e As EventArgs) Handles object_button_transfer.Click
        If object_datagrid_view.RowCount > 0 Then
            If message_text("Está seguro que desea transferir el registro seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim rows_selected As New List(Of Integer)

                For i As Integer = 0 To object_datagrid_view.DataRowCount - 1
                    If object_datagrid_view.IsRowSelected(i) = True Then
                        rows_selected.Add(CInt(object_datagrid_view.GetRowCellValue(i, "Id")))
                    End If
                Next

                If rows_selected.Count > 0 Then
                    show_flyout(New comercial_customer_transfer(rows_selected))
                Else
                    message_text("No se detectó filas seleccionadas", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub synchronize_option(sender As Object, e As EventArgs) Handles object_button_update.Click
        reports_show(criteria_search)
    End Sub

    Private Sub filtering_option(sender As Object, e As EventArgs) Handles object_button_filtering.Click
        With object_panel_layout
            .Height = If(.Height = 0, 300, 0)
        End With
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
