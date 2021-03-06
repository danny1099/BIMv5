Public Class comercial_customer_transfered
    Private data_search As object_data_search = object_data_search.Instance
    Private row_selected As List(Of Integer)


#Region "contructors"
    Public Sub New(row_selected_ As List(Of Integer))
        InitializeComponent()
        PerformAutoScale()

        'Define el valor de la variable privada con el parametro del contructor
        row_selected = row_selected_
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region
End Class
