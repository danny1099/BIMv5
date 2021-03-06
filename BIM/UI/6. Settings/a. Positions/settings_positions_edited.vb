Public Class settings_positions_edited
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
            object_listed_query.Datasources(positions_query(), "query_level")
            object_listed_hierarchy.Datasources(.fn_procedure_search(dop.spEntitiesBussinesPositions_Search, "p.row_visible=1"), "position_name")
        End With

        'Consulta el registro seleccionado 
        search_datarow()
    End Sub

    Private Function positions_query() As DataTable
        Dim source_table As New DataTable

        With source_table.Columns
            .Add("Id")
            .Add("query_level")
        End With

        With source_table.Rows
            .Add("A", "Administrador del sistema")
            .Add("G", "Consulta  general de registros vigentes")
            .Add("P", "Busqueda de registros por permisos de agencia")
            .Add("O", "Busqueda de registros propios del usuario")
        End With

        Return source_table
    End Function

    Private Sub search_datarow()
        Dim source_table As DataTable = object_search.fn_procedure_search(dop.spEntitiesBussinesPositions_Search, "p.Id=" & row_affected)

        With source_table
            object_text_name.EditValue = .Rows(0).Item("position_name").ToString
            object_listed_query.EditValue = .Rows(0).Item("query_level").ToString
            object_text_date.EditValue = CDate(.Rows(0).Item("event_date"))
            object_listed_hierarchy.EditValue = object_listed_hierarchy.Properties.GetKeyValueByDisplayText(.Rows(0).Item("hierarchy_name").ToString)
            object_check_visible.Checked = CBool(.Rows(0).Item("row_visible"))

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
                .CommandText = dop.spEntitiesBussinesPositions_Edited.ToString

                .Parameters.Clear()
                .Parameters.Add("@row_affected", SqlDbType.TinyInt).Value = row_affected
                .Parameters.Add("@position_name", SqlDbType.VarChar, 50).Value = object_text_name.EditValue
                .Parameters.Add("@query_level", SqlDbType.Char, 1).Value = object_listed_query.EditValue
                .Parameters.Add("@position_hierarchy", SqlDbType.TinyInt).Value = If(object_listed_hierarchy.EditValue IsNot Nothing, object_listed_hierarchy.EditValue, DBNull.Value)
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
