Public Class settings_dealers_edited
    Private object_search As object_data_search = object_data_search.Instance
    Private source_current As DataTable
    Private row_affected As Integer

#Region "constructor"
    Public Sub New(row_selected As Integer)
        InitializeComponent()
        PerformAutoScale()

        'Define el valor del parametro en la variable interna
        row_affected = row_selected
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        With object_search
            object_listed_agency.Datasources(.fn_procedure_search(dop.spEntitiesBussinesAgency_Search, "a.row_visible=1"), "agency_name")
            object_listed_operator.Datasources(.fn_procedure_search(dop.spSettingsGeneralSearch_Operator, "o.row_visible=1"), "operator_name")
        End With

        'Consulta el registro seleccionado 
        search_datarow()
    End Sub

    Private Sub search_datarow()
        Dim source_table As DataTable = object_search.fn_procedure_search(dop.spEntitiesBussinesDealer_Search, "d.Id=" & row_affected)

        With source_table.Rows(0)
            object_text_name.EditValue = .Item("dealer_name").ToString
            object_text_external.EditValue = .Item("siesa_code").ToString
            object_listed_operator.EditValue = object_listed_operator.Properties.GetKeyValueByDisplayText(.Item("operator_name").ToString)
            object_listed_agency.SetEditValue(.Item("agency_array"))
            object_check_visible.Checked = CBool(.Item("row_visible"))

            'Guarda los datos actuales del registro antes de la modificación
            source_current = trace_to_current(object_panel_container)
        End With
    End Sub

    Private Sub closed_module()
        start_home.removed_tabbed()
    End Sub
#End Region

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_component_validate.Validate = True Then
            With object_search.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = dop.spEntitiesBussinesDealer_Edited.ToString

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = row_affected
                .Parameters.Add("@dealer_name", SqlDbType.VarChar, 50).Value = object_text_name.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = object_listed_operator.EditValue
                .Parameters.Add("@agency_array", SqlDbType.VarChar, 100).Value = object_listed_agency.EditValue
                .Parameters.Add("@external_code", SqlDbType.VarChar, 10).Value = object_text_external.EditValue
                .Parameters.Add("@row_visible", SqlDbType.Bit).Value = object_check_visible.Checked
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited(object_panel_container, source_current)
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If object_search.execute_edited = True Then
                closed_module()
            End If
        End If
    End Sub
#End Region
End Class
