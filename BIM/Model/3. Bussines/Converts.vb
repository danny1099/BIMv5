Imports System.IO

Public Module Converts
    Public Function fn_transform_bytes(imagen As Image) As Byte()
        Dim arreglo As Byte() = Nothing
        Try
            If Not imagen Is Nothing Then
                Dim Bin As New MemoryStream
                imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                arreglo = Bin.ToArray()
            Else
                Return Nothing
            End If
        Catch ex As Exception
        End Try
        Return arreglo
    End Function

    Public Function fn_transform_bytes(document_object As String) As Byte()
        Try
            If document_object IsNot Nothing Then
                Dim file_selected As New FileStream(document_object, FileMode.Open, FileAccess.Read)
                Dim file_bytes() As Byte
                ReDim file_bytes(file_selected.Length)
                file_selected.Read(file_bytes, 0, file_selected.Length)

                Return file_bytes
            End If
        Catch ex As Exception
        End Try

        Return Nothing
    End Function

    Public Sub fn_transform_object(file_object As Byte(), file_name As String, file_extension As String)
        Try
            If file_object IsNot Nothing Then
                File.WriteAllBytes(Replace(file_name, " ", "_") & file_extension, file_object)

                'Crea el proceso para mostrar el archivo
                Dim object_process As New Process
                object_process.StartInfo.FileName = Replace(file_name, " ", "_") & file_extension
                object_process.StartInfo.UseShellExecute = True
                object_process.StartInfo.CreateNoWindow = True
                object_process.Start()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function fn_transform_image(imagen As Byte()) As Image
        Try
            If Not imagen Is Nothing Then
                Dim Bin As New MemoryStream(imagen)
                Dim Resultado As Image = Image.FromStream(Bin)
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function fn_transform_serialize(value_serialize As Object) As String
        Return Newtonsoft.Json.JsonConvert.SerializeObject(value_serialize)
    End Function

    Public Function fn_transform_deserialize(value_deserialize As String) As DataTable
        Try
            Return TryCast(Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(value_deserialize), DataTable)
        Catch ex As Exception
        Finally
        End Try

        Return Nothing
    End Function
End Module
