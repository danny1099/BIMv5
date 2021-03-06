Public Class settings_channels_created
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
            object_listed_type.Datasources(channel_type(), "channel_type")
            object_listed_hierarchy.Datasources(.fn_procedure_search(dop.spEntitiesBussinesChannel_Search, "c.row_visible=1"), "channel_name")
            object_text_date.EditValue = Now
        End With
    End Sub

    Private Function channel_type() As DataTable
        Dim source_table As New DataTable

        With source_table.Columns
            .Add("Id")
            .Add("channel_type")
        End With

        With source_table.Rows
            .Add("C", "Canal de ventas (Primario)")
            .Add("S", "Canal Derivado (Subcanal)")
        End With

        Return source_table
    End Function

    Private Sub type_changed(sender As Object, e As EventArgs) Handles object_listed_type.EditValueChanged
        With object_listed_hierarchy
            .EditValue = Nothing
            .ReadOnly = If(object_listed_type.EditValue = "S", False, True)
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
                .CommandText = dop.spEntitiesBussinesChannel_Create.ToString

                .Parameters.Clear()
                .Parameters.Add("@channel_name", SqlDbType.VarChar, 50).Value = object_text_name.EditValue
                .Parameters.Add("@dependant_code", SqlDbType.TinyInt).Value = If(object_listed_hierarchy.EditValue IsNot Nothing, object_listed_hierarchy.EditValue, DBNull.Value)
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
