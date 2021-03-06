Public Class comercial_customer_created
    Private object_search As object_data_search = object_data_search.Instance
    Private lasted_control As Control


#Region "constructor"
    Public Sub New(current_control As Control)
        InitializeComponent()
        PerformAutoScale()

        'Define el control llamante para regresar
        lasted_control = current_control
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
        object_listed()
    End Sub
#End Region

#Region "behaviors"
    Private Sub object_listed()
        With object_search
            object_listed_document.Datasources(.fn_procedure_search(dop.settings_general_search_docs, "row_visible=1"), "alias_document")
            object_listed_genre.Datasources(.fn_procedure_search(dop.settings_general_search_genre, "row_visible=1"), "genre_name")
            object_listed_deptos.Datasources(.fn_procedure_search(dop.settings_general_search_deptos, "row_visible=1"), "department_name")
            object_listed_source.Datasources(.fn_procedure_search(dop.relationship_customer_person_sources, "row_visible=1"), "source_name")
            object_listed_knowledge.Datasources(.fn_procedure_search(dop.relationship_customer_knowledge_search, "row_visible=1"), "knowledge_name")
            object_listed_refered.Datasources(.fn_procedure_search(dop.relationship_customer_person_listed, "c.row_visible=1"), "Nombre del cliente")
            object_listed_person.Datasources(.fn_procedure_search(dop.entities_workforce_persons_listed, "p.agency_code in (" & sessions.agency_permit & ") and p.row_visible=1"), "Nombre del funcionario")
            object_text_lookup.EditValue = fn_trace_number("D8")
        End With
    End Sub

    Private Sub search_person()
        Dim table As DataTable = object_search.fn_procedure_search(dop.relationship_customer_person_search, "c.number_document='" & object_text_document.Text & "'")

        If table.Rows.Count >= 1 Then
            With table.Rows(0)
                object_text_name.EditValue = .Item("person_name").ToString
                object_text_birthdate.EditValue = CDate(.Item("birth_date"))
                object_listed_document.EditValue = object_listed_document.Properties.GetKeyValueByDisplayText(.Item("alias_document").ToString)
                object_listed_genre.EditValue = object_listed_genre.Properties.GetKeyValueByDisplayText(.Item("genre_name").ToString)
                If .Item("number_phone").ToString <> "" Then object_text_phone.EditValue = .Item("number_phone").ToString
                If .Item("number_cellphone").ToString <> "" Then object_text_cellphone.EditValue = .Item("number_cellphone").ToString
                If .Item("place_address").ToString <> "" Then object_text_address.EditValue = .Item("place_address").ToString
                If .Item("neighborhood").ToString <> "" Then object_text_neighborhood.EditValue = .Item("neighborhood").ToString
                object_listed_deptos.EditValue = object_listed_deptos.Properties.GetKeyValueByDisplayText(.Item("department_name").ToString)
                If .Item("email").ToString <> "" Then object_text_email.EditValue = .Item("email").ToString
                object_listed_cities.EditValue = object_listed_cities.Properties.GetKeyValueByDisplayText(.Item("city_name").ToString)
                If .Item("refered_code").ToString <> "" Then object_listed_refered.EditValue = CInt(.Item("refered_code").ToString)
                object_listed_source.EditValue = object_listed_source.Properties.GetKeyValueByDisplayText(.Item("source_name").ToString)
                object_listed_knowledge.EditValue = object_listed_knowledge.Properties.GetKeyValueByDisplayText(.Item("knowledge_name").ToString)
                object_listed_person.EditValue = CInt(.Item("person_code"))
                object_text_lookup.EditValue = .Item("code_search").ToString
                If .Item("photo_avatar").ToString <> "" Then object_image_photo.Image = fn_transform_image(.Item("photo_avatar"))
                object_check_optin.Checked = CBool(.Item("opt_in"))

                'Pregunta si desea ir al modulo de actualizacion del cliente existente
                If message_text("Desea actualizar la información del cliente seleccionado?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    show_option(New comercial_customer_edited(.Item("Id"), Me))
                End If
            End With
        End If
    End Sub

    Private Sub search_document(sender As Object, e As EventArgs) Handles object_text_document.Leave
        If object_text_document.Text <> "" Then search_person()
    End Sub

    Private Sub validate_options(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles object_text_document.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Search And object_text_document.Text <> "" Then search_person()
    End Sub

    Private Sub deptos_changed(sender As Object, e As EventArgs) Handles object_listed_deptos.EditValueChanged
        If object_listed_deptos.EditValue IsNot Nothing Then
            object_listed_cities.Datasources(object_search.fn_procedure_search(dop.settings_general_search_cities, "depto_code=" & object_listed_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub habeas_changed(sender As Object, e As EventArgs) Handles object_check_optin.CheckedChanged
        object_check_optin.CheckState = If(CheckState.Checked, "Aceptación politica de tratamiento de datos", "Rechazo de la politica de tratamiento de datos")
    End Sub

    Private Sub place_address(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles object_text_address.ButtonClick
        Dim place_addressed As New comercial_customer_addressed

        'Muestra el formulario de direccion con el fondo negro
        show_flyout(place_addressed)

        'Valida que la dirección se haya creado en el formulario
        If place_addressed.address_name <> "" Then object_text_address.EditValue = place_addressed.address_name.ToString
    End Sub

    Private Sub camera_taked(sender As Object, e As EventArgs) Handles object_image_photo.DoubleClick
        object_image_photo.ShowTakePictureDialog()
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_component_validate.Validate = True Then
            With object_search.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = dop.relationship_customer_person_created.ToString

                .Parameters.Clear()
                .Parameters.Add("@document_code", SqlDbType.TinyInt).Value = object_listed_document.EditValue
                .Parameters.Add("@number_document", SqlDbType.VarChar, 50).Value = Trim(object_text_document.EditValue)
                .Parameters.Add("@person_name", SqlDbType.VarChar, 100).Value = StrConv(object_text_name.EditValue, VbStrConv.Uppercase)
                .Parameters.Add("@birth_date", SqlDbType.Date).Value = object_text_birthdate.EditValue
                .Parameters.Add("@genre_code", SqlDbType.TinyInt).Value = object_listed_genre.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(object_text_phone.EditValue, DBNull.Value)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 18).Value = If(object_text_cellphone.EditValue, DBNull.Value)
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = If(object_text_address.EditValue, DBNull.Value)
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = If(object_text_neighborhood.EditValue, DBNull.Value)
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = object_listed_cities.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = If(object_text_email.EditValue, DBNull.Value)
                .Parameters.Add("@source_code", SqlDbType.TinyInt).Value = object_listed_source.EditValue
                .Parameters.Add("@knowledge_code", SqlDbType.TinyInt).Value = object_listed_knowledge.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = object_listed_person.EditValue
                .Parameters.Add("@code_search", SqlDbType.VarChar, 8).Value = object_text_lookup.EditValue
                .Parameters.Add("@creation_date", SqlDbType.Date).Value = Now
                .Parameters.Add("@opt_in", SqlDbType.Bit).Value = object_check_optin.Checked
                .Parameters.Add("@refered_code", SqlDbType.Int).Value = If(object_listed_refered.EditValue.ToString = "", DBNull.Value, object_listed_refered.EditValue)
                .Parameters.Add("@photo_avatar", SqlDbType.VarBinary).Value = If(object_image_photo.EditValue Is Nothing, DBNull.Value, fn_transform_bytes(object_image_photo.EditValue))
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = "00000000"
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_container)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If object_search.execute_procedure = True Then
                If object_check_form.Checked = True Then
                    defaults_objects(object_panel_container)
                Else
                    show_option(lasted_control)
                End If
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles object_button_closed.Click
        show_option(lasted_control)
    End Sub
#End Region
End Class
