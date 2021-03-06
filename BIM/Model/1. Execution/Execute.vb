Imports System.Data.SqlClient

Public Class Execute
    Implements IProcedure, ITables, IFunction, IDataset, IDisposable

#Region "objects"
    Property sql_connection As Connections = Connections.Instance
    Property sql_adapter As SqlDataAdapter
    Property sql_command As SqlCommand
#End Region

#Region "methods"
    Public Sub New()
        sql_command = New SqlCommand
    End Sub

    Public Function execute_create(Optional show_message As Boolean = True) As Object Implements IProcedure.execute_create
        Dim process_executed As New Object

        Try
            With sql_connection
                If fn_connection_state(.cnn_cloud) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_cloud
                    sql_adapter = New SqlDataAdapter(sql_command)
                    sql_adapter.SelectCommand.ExecuteNonQuery()

                    'Comprueba si el proceso a ejecutar tiene el parametro de retorno (Id) que sea diferente a cero (0)
                    process_executed = If(sql_command.Parameters("@row_affected").Value IsNot Nothing, sql_command.Parameters("@row_affected").Value.ToString, 0)

                    'Comprueba que el parametro de mensaje retorno no sea nulo o vacío 
                    If show_message = True Then
                        message_text(sql_command.Parameters("@text_message").Value.ToString, MessageBoxButtons.OK)
                    End If
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
        Finally
            If Not sql_adapter Is Nothing Then sql_adapter.Dispose()
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return process_executed
    End Function

    Public Function execute_edited(Optional show_message As Boolean = True) As Object Implements IProcedure.execute_edited
        Dim process_executed As New Object

        Try
            With sql_connection
                If fn_connection_state(.cnn_cloud) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_cloud
                    sql_adapter = New SqlDataAdapter(sql_command)
                    sql_adapter.SelectCommand.ExecuteNonQuery()

                    'Comprueba si el proceso a ejecutar tiene el parametro de retorno (Id) que sea diferente a cero (0)
                    process_executed = If(sql_command.Parameters("@text_message").Value.ToString.Contains("exitosamente"), True, False)

                    'Comprueba que el parametro de mensaje retorno no sea nulo o vacío 
                    If show_message = True Then
                        message_text(sql_command.Parameters("@text_message").Value.ToString, MessageBoxButtons.OK)
                    End If
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
        Finally
            If Not sql_adapter Is Nothing Then sql_adapter.Dispose()
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return process_executed
    End Function

    Public Function execute_table(Optional table_name_ As String = "table_source", Optional show_message As Boolean = False) As DataTable Implements ITables.execute_table
        Dim process_executed As New DataTable With {.TableName = table_name_}

        Try
            With sql_connection
                If fn_connection_state(.cnn_cloud) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_cloud
                    sql_adapter = New SqlDataAdapter(sql_command)
                    sql_adapter.Fill(process_executed)

                    'Comprueba que el procedimiento tiene parametro de mensaje retorno
                    If sql_command.Parameters.Contains("@text_message") Then
                        If show_message = True Then If sql_command.Parameters("@text_message").Value.ToString <> "" Then message_text(sql_command.Parameters("@text_message").Value.ToString, MessageBoxButtons.OK)
                    End If
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
        Finally
            If Not sql_adapter Is Nothing Then sql_adapter.Dispose()
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return process_executed
    End Function

    Public Function execute_dataset(Optional table_name As String = "table_result") As DataSet Implements IDataset.execute_dataset
        Dim process_executed As New DataSet

        Try
            With sql_connection
                If fn_connection_state(.cnn_cloud) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_cloud
                    sql_adapter = New SqlDataAdapter(sql_command)
                    sql_adapter.Fill(process_executed, table_name)

                    'Comprueba que el procedimiento tiene parametro de mensaje retorno
                    If sql_command.Parameters.Contains("@text_message") Then message_text(sql_command.Parameters("@text_message").Value.ToString, MessageBoxButtons.OK)
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
        Finally
            If Not sql_adapter Is Nothing Then sql_adapter.Dispose()
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return process_executed
    End Function

    Public Function execute_function() As Object Implements IFunction.execute_function
        Dim process_executed As New Object

        Try
            With sql_connection
                If fn_connection_state(.cnn_cloud) = ConnectionState.Open Then
                    sql_command.Connection = .cnn_cloud
                    process_executed = sql_command.ExecuteScalar
                Else
                    message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
                End If
            End With

        Catch ex As Exception
            message_text("No se pudo establecer conexión al servidor", MessageBoxButtons.OK)
        Finally
            If Not sql_command Is Nothing Then sql_command.Dispose()
        End Try

        Return process_executed
    End Function

    Private Function fn_connection_state(cnn_ As SqlConnection) As ConnectionState
        If cnn_ IsNot Nothing Then
            If cnn_.State = ConnectionState.Closed Then cnn_.Open()
        Else
            If sql_connection IsNot Nothing Then cnn_ = sql_connection.fn_connection_cloud
        End If

        Return cnn_.State
    End Function

    Private Sub Dispose() Implements IDisposable.Dispose
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
