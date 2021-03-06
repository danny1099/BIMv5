Public Class comercial_customer_addressed
    Property address_name As String


#Region "contructors"
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
        object_listed_address.Datasources(component_address(), "address_name")
    End Sub

    Public Function component_address() As DataTable
        Dim table_source As New DataTable

        With table_source
            .Columns.Add("Id")
            .Columns.Add("address_name")

            .Rows.Add(1, "Calle")
            .Rows.Add(2, "Carrera")
            .Rows.Add(3, "Avenida")
            .Rows.Add(4, "Transversal")
            .Rows.Add(5, "Autopista")
            .Rows.Add(6, "Manzana")
            .Rows.Add(7, "Kilometro")
            .Rows.Add(8, "Urbanización")
            .Rows.Add(9, "Vereda")
            .Rows.Add(10, "Parcelación")
            .Rows.Add(11, "Diagonal")
            .Rows.Add(12, "Lote")
        End With

        Return table_source
    End Function

    Private Sub search_container()
        Dim object_parent As Object = Me.GetContainerControl()
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_component_validate.Validate = True Then
            address_name = object_listed_address.Text & " " & object_text_address.EditValue & " # " & If(IsNumeric(Replace(object_text_number.EditValue, "-", "")) = True, object_text_number.EditValue & "-" & object_text_house.EditValue, object_text_number.EditValue & " " & object_text_house.EditValue)

            If address_name <> "" Then
                TryCast(Me.Parent, model_object_flyout).Close()
            End If
        End If
    End Sub
#End Region
End Class
