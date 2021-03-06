Imports System.Data.SqlClient

Public Class Execute
    Implements IProcedure, ITables, IDataset, IDisposable

#Region "objects"
    Public connection As Connections = Connections.Instance
    Private Property sql_adapter As SqlDataAdapter
    Public Property sql_command As SqlCommand
#End Region

#Region "methods"
    Public Sub New()
        sql_command = New SqlCommand
    End Sub

    Public Function execute_procedure(Optional show_message As Boolean = True) As Boolean Implements IProcedure.execute_procedure
        Dim process_result As Boolean

        Try
            With connection
                If fn_connection_state(.cnn_nube) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_nube
                    sql_adapter = New SqlDataAdapter(sql_command)
                    sql_adapter.SelectCommand.ExecuteNonQuery()

                    'check if sql_command have parameters output
                    If sql_command.Parameters("@text_message").Value.ToString.Contains("exitosamente") Then process_result = True

                    'check is parameter show message  is true an value is not null
                    If show_message = True Then
                        If sql_command.Parameters("@text_message").Value.ToString <> "" Then message_text(sql_command.Parameters("@text_message").Value.ToString, MessageBoxButtons.OK)
                    End If
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("Error: " & ex.Message.ToString, MessageBoxButtons.OK)
        Finally
            If Not sql_adapter Is Nothing Then sql_adapter.Dispose()
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return process_result
    End Function

    Public Function execute_table(Optional table_name_ As String = "table_source") As DataTable Implements ITables.execute_table
        Dim dt As New DataTable With {.TableName = table_name_}

        Try
            With connection
                If fn_connection_state(.cnn_nube) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_nube
                    sql_adapter = New SqlDataAdapter(sql_command)
                    sql_adapter.Fill(dt)

                    'check if sql_command have parameters output
                    If sql_command.Parameters.Contains("@text_message") Then
                        If sql_command.Parameters("@text_message").Value.ToString <> "" Then message_text(sql_command.Parameters("@text_message").Value.ToString, MessageBoxButtons.OK)
                    End If
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("Error: " & ex.Message.ToString, MessageBoxButtons.OK)
        Finally
            If Not sql_adapter Is Nothing Then sql_adapter.Dispose()
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return dt
    End Function

    Public Function execute_dataset(Optional table_name As String = "results") As DataSet Implements IDataset.execute_dataset
        Dim ds As New DataSet

        Try
            With connection
                If fn_connection_state(.cnn_nube) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_nube
                    sql_adapter = New SqlDataAdapter(sql_command)
                    sql_adapter.Fill(ds, table_name)

                    'check if sql_command have parameters output
                    If sql_command.Parameters.Contains("@text_message") Then
                        If sql_command.Parameters("@text_message").Value.ToString <> "" Then message_text(sql_command.Parameters("@text_message").Value.ToString, MessageBoxButtons.OK)
                    End If
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("Error: " & ex.Message.ToString, MessageBoxButtons.OK)
        Finally
            If Not sql_adapter Is Nothing Then sql_adapter.Dispose()
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return ds
    End Function

    Public Function execute_function(Optional show_message As Boolean = True) As Object
        Dim process_result As New Object

        Try
            With connection
                If fn_connection_state(.cnn_nube) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_nube
                    process_result = sql_command.ExecuteScalar
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("Error: " & ex.Message.ToString, MessageBoxButtons.OK)
        Finally
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return process_result
    End Function

    Private Sub Dispose() Implements IDisposable.Dispose
        'check if sql_command is not nothig to dispose
        If Not (sql_command Is Nothing) Then sql_command.Dispose()

        'suppress current class instance
        GC.SuppressFinalize(Me)
    End Sub

    Private Function fn_connection_state(cnn_ As SqlConnection, Optional cnn_local As Boolean = False) As ConnectionState
        If cnn_ IsNot Nothing Then
            If cnn_.State = ConnectionState.Closed Then cnn_.Open()
        Else
            If connection IsNot Nothing Then cnn_ = connection.fn_connection_cloud
        End If

        Return cnn_.State
    End Function
#End Region
End Class
