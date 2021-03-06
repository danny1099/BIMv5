Imports System.Data.SqlClient
Public NotInheritable Class Connections
    Implements IDisposable

#Region "Objects"
    Private Shared _instance As Connections = Nothing
    Private Shared ReadOnly _sync As New Object
    Public cnn_cloud As SqlConnection
#End Region

#Region "methods"
    Public Shared ReadOnly Property Instance() As Connections
        Get
            If _instance Is Nothing Then
                SyncLock _sync
                    If _instance Is Nothing Then
                        _instance = New Connections()
                    End If
                End SyncLock
            End If

            Return _instance
        End Get
    End Property

    Public Function fn_connection_cloud() As SqlConnection
        Try
            If cnn_cloud Is Nothing Then
                cnn_cloud = New SqlConnection("Data Source=" & fn_text_settings("L0DB", "DSO", "C:\APDA\BIM\settings.ini") & ";Initial Catalog=" & fn_text_settings("L0DB", "DBO", "C:\APDA\BIM\settings.ini") & ";User ID=SA;Password=" & fn_text_settings("L0DB", "IDT", "C:\APDA\BIM\settings.ini"))
                cnn_cloud.Open()
            End If
        Catch ex As Exception
            cnn_cloud = Nothing
        End Try

        Return cnn_cloud
    End Function

    Private Sub Dispose() Implements IDisposable.Dispose
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
