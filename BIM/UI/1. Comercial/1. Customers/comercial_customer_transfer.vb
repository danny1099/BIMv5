Public Class comercial_customer_transfer
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

#Region "behaviors"
    Private Sub object_listed()
        '   object_listed_agency.Datasources(data_search.fn_procedure_search(dop.entities_bussines_agency_search, "row_visible=1"), "agency_name")
        object_text_dates.EditValue = Now
        object_text_amount.EditValue = row_selected.Count.ToString
    End Sub

    Private Sub agency_changed(sender As Object, e As EventArgs) Handles object_listed_agency.EditValueChanged
        If object_listed_agency.EditValue IsNot Nothing Then
            ' object_listed_person.Datasources(data_search.fn_procedure_search(dop.entities_workforce_persons_listed, "p.row_visible=1 and p.agency_code in (" & object_listed_agency.EditValue & ")"), "Nombre del funcionario")
        End If
    End Sub
#End Region

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_component_validate.Validate = True Then
            For Each row_affected As Integer In row_selected
                With data_search.sql_command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "relationship_customer_person_transfer"

                    .Parameters.Clear()
                    .Parameters.Add("@row_affected", SqlDbType.Int).Value = row_affected
                    .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = object_listed_person.EditValue
                    .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                    .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_container)
                    .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                    .Parameters.Add("@user_code", SqlDbType.Int).Value = sessions.person_code
                    .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
                End With

                If data_search.execute_edited(False) = True Then
                    data_search.fn_procedure_execute(row_affected, "Relationship.Customers.Persons", If(object_text_comment.EditValue IsNot Nothing, object_text_comment.EditValue, "El usuario " & sessions.person_name & " transfirio el cliente al funcionario " & object_listed_person.Text))
                End If
            Next

            'Mensaje de confirmacion de proceso finalizado
            If message_text("Los clientes fueron transferidos exitosamente", MessageBoxButtons.OK) = DialogResult.OK Then
                TryCast(Me.Parent, model_object_flyout).Close()
            End If
        End If
    End Sub
#End Region
End Class
