Public Class object_data_search
    Inherits Execute

    Private Shared current_instance As object_data_search = Nothing
    Private Shared ReadOnly sync As New Object

#Region "constructors"
    Public Shared ReadOnly Property Instance() As object_data_search
        Get
            If current_instance Is Nothing Then
                SyncLock sync
                    If current_instance Is Nothing Then
                        current_instance = New object_data_search()
                    End If
                End SyncLock
            End If

            Return current_instance
        End Get
    End Property
#End Region

#Region "methods"
    Public Function fn_procedure_search(dop_name As dop, criteria_search As String) As DataTable
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = dop_name.ToString

            .Parameters.Clear()
            .Parameters.Add("@criteria_search", SqlDbType.VarChar).Value = criteria_search
        End With

        Return execute_table("search_results")
    End Function

    Public Function fn_procedure_execute(dop_name As dop, row_affected As Integer, Optional show_message As Boolean = True) As Integer
        With sql_command
            .CommandType = CommandType.StoredProcedure
            .CommandText = dop_name.ToString

            .Parameters.Clear()
            .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
            .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_edited("Estado", "Activo", "Anulado")
            .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
            .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
        End With

        Return Convert.ToInt32(execute_procedure(show_message))
    End Function
#End Region
End Class
