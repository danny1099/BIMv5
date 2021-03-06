Public Class settings_dealers_created
    Private object_search As object_data_search = object_data_search.Instance

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
    Private Sub object_listed()
        With object_search
            object_listed_agency.Datasources(.fn_procedure_search(dop.spEntitiesBussinesAgency_Search, "a.row_visible=1"), "agency_name")
            object_listed_operator.Datasources(.fn_procedure_search(dop.spSettingsGeneralSearch_Operator, "o.row_visible=1"), "operator_name")
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
                .CommandText = dop.spEntitiesBussinesDealer_Create.ToString

                .Parameters.Clear()
                .Parameters.Add("@dealer_name", SqlDbType.VarChar, 50).Value = object_text_name.EditValue
                .Parameters.Add("@operator_code", SqlDbType.TinyInt).Value = object_listed_operator.EditValue
                .Parameters.Add("@agency_array", SqlDbType.VarChar, 100).Value = object_listed_agency.EditValue
                .Parameters.Add("@external_code", SqlDbType.VarChar, 10).Value = object_text_external.EditValue
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_container)
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@row_affected", SqlDbType.Int).Direction = ParameterDirection.Output
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If object_search.execute_create <> 0 Then
                If object_check_form.Checked = True Then
                    defaults_objects(object_panel_container)
                Else
                    closed_module()
                End If
            End If
        End If
    End Sub
#End Region
End Class
