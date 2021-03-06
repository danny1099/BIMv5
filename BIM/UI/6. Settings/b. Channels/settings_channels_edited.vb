Public Class settings_channels_edited
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
            object_listed_type.Datasources(channel_type(), "channel_type")
            object_listed_hierarchy.Datasources(.fn_procedure_search(dop.spEntitiesBussinesChannel_Search, "c.row_visible=1"), "channel_name")
            object_text_date.EditValue = Now
        End With

        'Carga los datos a consultar
        search_datarow()
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

    Private Sub search_datarow()
        Dim source_table As DataTable = object_search.fn_procedure_search(dop.spEntitiesBussinesChannel_Search, "c.Id=" & row_affected)

        With source_table
            object_text_name.EditValue = .Rows(0).Item("channel_name").ToString
            object_text_date.EditValue = CDate(.Rows(0).Item("event_date"))
            object_check_visible.Checked = CBool(.Rows(0).Item("row_visible"))
            object_listed_type.EditValue = If(.Rows(0).Item("dependant_name").ToString <> "", "S", "C")
            object_listed_hierarchy.EditValue = object_listed_hierarchy.Properties.GetKeyValueByDisplayText(.Rows(0).Item("dependant_name").ToString)

            'Guarda los datos actuales del registro antes de la modificación
            source_current = trace_to_current(object_panel_container)
        End With
    End Sub

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
                .CommandText = dop.spEntitiesBussinesChannel_Edited.ToString

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = row_affected
                .Parameters.Add("@channel_name", SqlDbType.VarChar, 50).Value = object_text_name.EditValue
                .Parameters.Add("@dependant_code", SqlDbType.TinyInt).Value = If(object_listed_hierarchy.EditValue IsNot Nothing, object_listed_hierarchy.EditValue, DBNull.Value)
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
