Imports APDA.Object.Controls
Imports DevExpress.XtraEditors

Public Module Tracing

#Region "methods"
    Public Function trace_to_create(container As Control) As String
        Try
            Dim tracing_data As New DataTable

            With tracing_data
                'Ejecuta el proceso para crear las columnas requeridas
                create_columns(tracing_data)

                'Recorre todos los campos del contenedor enviado como parametro
                For Each item As Object In container.Controls
                    If Not TypeOf item Is LabelControl And Not TypeOf item Is PictureEdit And Not TypeOf item Is Button And Not TypeOf item Is ListBoxControl And Not TypeOf item Is PanelControl And Not TypeOf item Is XtraScrollableControl And Not TypeOf item Is SimpleButton And item.Tag <> "" Then
                        If TypeOf item Is CheckEdit Then
                            .Rows.Add(item.Tag, If(item.Checked = True, "Si", "No"))
                        ElseIf TypeOf item Is FilterControl Then
                            .Rows.Add("Condición", item.FilterCriteria.ToString)
                        Else
                            .Rows.Add(item.Tag, If(item.Text = "", "Undefined", item.Text))
                        End If
                    End If
                Next
            End With

            Return fn_transform_serialize(tracing_data)
        Catch ex As Exception
            message_text("Error en el proceso 'trace_to_create' al intentar ejecutarse: " & ex.Message.ToString, MessageBoxButtons.OK)
        End Try
    End Function

    Public Function trace_to_create(field As String, new_value As String) As String
        Dim tracing_data As New DataTable

        With tracing_data
            'Ejecuta el proceso para crear las columnas requeridas
            create_columns(tracing_data)

            'Agrega una fila con los valores de los parametros
            .Rows.Add(field, new_value)
        End With

        Return fn_transform_serialize(tracing_data)
    End Function

    Public Function trace_to_edited(field_name As String, current_value As String, update_value As String) As String
        Dim tracing_data As New DataTable

        With tracing_data
            'Ejecuta el proceso para crear las columnas requeridas
            create_columns(tracing_data, True)

            'Agrega una fila con los datos de actualizacion de los parametros
            .Rows.Add(field_name, current_value, update_value)
        End With

        Return fn_transform_serialize(tracing_data)
    End Function

    Public Function trace_to_edited(container As Control, current_data As DataTable) As String
        Try
            Dim tracing_data As New DataTable

            With tracing_data
                'Ejecuta el proceso para crear las columnas requeridas
                create_columns(tracing_data, True)

                'Recorre todos los campos del contenedor enviado como parametro y lo compara con los datos actuales en la tabla current
                For Each item As Object In container.Controls
                    If Not TypeOf item Is LabelControl And Not TypeOf item Is PictureEdit And Not TypeOf item Is Button And Not TypeOf item Is ListBoxControl And Not TypeOf item Is PanelControl And Not TypeOf item Is XtraScrollableControl And Not TypeOf item Is SimpleButton And item.Tag <> "" Then
                        For Each r As DataRow In current_data.Rows
                            If item.Tag = r.Item(0).ToString Then
                                'Valida el tipo de objeto para determinar el metodo de validacion de texto
                                If TypeOf item Is CheckEdit Then
                                    If (If(item.Checked = True, "Si", "No")) <> r.Item(1) Then
                                        .Rows.Add(item.Text, r.Item(1), If(item.Checked = True, "Si", "No"))
                                    End If
                                ElseIf TypeOf item Is FilterControl Then
                                    If item.FilterCriteria.ToString <> r.Item(1) Then
                                        .Rows.Add(item.Tag, r.Item(1), item.FilterCriteria.ToString)
                                    End If
                                Else
                                    If (If(item.Text, "Undefined")) <> r.Item(1) Then
                                        .Rows.Add(item.Tag, r.Item(1), item.Text)
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next
            End With

            Return fn_transform_serialize(tracing_data)

        Catch ex As Exception
            message_text("Error en el proceso 'trace_to_edited' al intentar ejecutarse: " & ex.Message.ToString, MessageBoxButtons.OK)
        End Try
    End Function

    Public Function trace_to_current(container As Control) As DataTable
        Try
            Dim tracing_data As New DataTable

            With tracing_data
                'Ejecuta el proceso para crear las columnas requeridas
                create_columns(tracing_data, True)

                'run all objects in container control and added in table
                For Each item As Object In container.Controls
                    If Not TypeOf item Is LabelControl And Not TypeOf item Is PictureEdit And Not TypeOf item Is Button And Not TypeOf item Is ListBoxControl And Not TypeOf item Is PanelControl And Not TypeOf item Is XtraScrollableControl And Not TypeOf item Is SimpleButton And item.Tag <> "" Then
                        If item.Tag <> "" Then
                            If TypeOf item Is TextboxCheck Then
                                .Rows.Add(item.Tag, If(item.Checked = True, "Si", "No"))
                            ElseIf TypeOf item Is DevExpress.XtraEditors.FilterControl Then
                                .Rows.Add("Condición", item.FilterCriteria.ToString)
                            Else
                                .Rows.Add(item.Tag, If(item.Text = "", "Undefined", item.Text))
                            End If
                        End If
                    End If
                Next
            End With

            Return tracing_data
        Catch ex As Exception
            message_text("Error en el proceso 'trace_to_current' al intentar ejecutarse: " & ex.Message.ToString, MessageBoxButtons.OK)
        End Try
    End Function
#End Region

#Region "Privates"
    Private Sub create_columns(tracing_data As DataTable, Optional edited_process As Boolean = False)
        'Agrega las columnas para registrar los campos recorridos
        If Not tracing_data.Columns.Contains("Campo") Then tracing_data.Columns.Add("Campo", GetType(String))
        If Not tracing_data.Columns.Contains("Dato Actual") Then tracing_data.Columns.Add("Dato Actual", GetType(String))

        If edited_process = True Then If Not tracing_data.Columns.Contains("Dato Nuevo") Then tracing_data.Columns.Add("Dato Nuevo", GetType(String))
    End Sub
#End Region
End Module
