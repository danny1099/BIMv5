Imports System.Security.Permissions

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
<Runtime.InteropServices.ComVisible(True)>
Public Class settings_agencys_created
    Private object_search As object_data_search = object_data_search.Instance

#Region "constructor"
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
        With object_search
            object_listed_deptos.Datasources(.fn_procedure_search(dop.spSettingsGeneralSearch_Deparment, "d.row_visible=1"), "department_name")
            object_listed_person.Datasources(.fn_procedure_search(dop.spEntitiesBussinesPersonal_Leader, "p.row_visible=1"), "person_name")
            object_listed_type.Datasources(agencys_type, "agency_type")

            'Carga el mapa del modulo para la localizacion del punto
            location_maps(document_map("Colombia"))
        End With
    End Sub

    Private Sub deparments_change(sender As Object, e As EventArgs) Handles object_listed_deptos.EditValueChanged
        If object_listed_deptos.EditValue IsNot Nothing Then
            object_listed_cities.Datasources(object_search.fn_procedure_search(dop.spSettingsGeneralSearch_Cities, "c.row_visible=1 and c.depto_code=" & object_listed_deptos.EditValue), "city_name")
        End If
    End Sub

    Private Sub location_maps(search_location As String)
        With object_component_maps
            .Navigate("about:blank")

            'Carga el mapa con la variable de busqueda
            Try
                If .Document IsNot Nothing Then .Document.Write(String.Empty)
                .DocumentText = search_location
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub document_condition(sender As Object, e As EventArgs) Handles object_text_neighborhood.Leave, object_listed_deptos.Leave, object_listed_cities.Leave
        If sender.Text <> "" Then
            Dim builder_text As New System.Text.StringBuilder

            With builder_text
                .Append(If(object_listed_deptos.Text <> "", object_listed_deptos.Text & ",+", "") & If(object_listed_cities.Text <> "", object_listed_cities.Text & ",+", "") & If(object_text_neighborhood.Text <> "", object_text_neighborhood.Text & ",", ""))
            End With

            'Ejecuta la funcion de cargar el mapa con la condicion seleccionada
            location_maps(document_map(builder_text.ToString))
        End If
    End Sub

    Private Sub document_address(sender As Object, e As EventArgs) Handles object_text_address.Leave
        If sender.Text <> "" Then
            location_maps(document_map(Replace(object_text_address.Text, "#", ""), True))
        End If
    End Sub

    Private Function document_map(search_value As String, Optional mode_search As Boolean = False) As String
        Return "<!DOCTYPE html> 
                    <html> 
                         <head> 
    	                       <meta charset=""UTF-8"">
	                           <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
                               <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=n"">
                               <style type=""text/css""> html, body {height: 100%;margin: 0;padding: 0;}</style>
                        </head>
                        <body>
                                <iframe width=""830"" height=""300"" frameborder=""0"" style=""border0"" src=""https://www.google.com/maps/embed/v1/" & If(mode_search = False, "place?", "search?") & "key=AIzaSyAmb2MQwlvNRrDglVqwb68k0_xtmRt1h8E&q=" & search_value & """ allowfullscreen></iframe>
                        </body>
                    </html>"
    End Function

    Private Sub document_cardinates(sender As Object, e As EventArgs) Handles object_text_longitud.Leave
        If object_text_latitud.Text <> "" And object_text_longitud.Text <> "" Then
            location_maps(document_map(object_text_latitud.Text & "," & object_text_longitud.Text))
        End If
    End Sub

    Private Function agencys_type() As DataTable
        Dim source_table As New DataTable

        With source_table
            .Columns.Add("Id")
            .Columns.Add("agency_type")

            'Crea los tipos de agencia
            .Rows.Add("A", "Administrativa")
            .Rows.Add("S", "Sala de ventas")
            .Rows.Add("R", "Centro de pago")
            .Rows.Add("B", "Almacen y/o Bodega")
        End With

        Return source_table
    End Function

    Private Sub closed_module()
        start_home.removed_tabbed()
    End Sub
#End Region

#Region "options"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_saved.Click
        If object_component_validate.Validate = True Then
            With object_search.sql_command
                .CommandType = CommandType.StoredProcedure
                .CommandText = dop.spEntitiesBussinesAgency_Create.ToString

                .Parameters.Clear()
                .Parameters.Add("@agency_name", SqlDbType.VarChar, 50).Value = object_text_name.EditValue
                .Parameters.Add("@number_phone", SqlDbType.VarChar, 12).Value = If(object_text_phone.EditValue IsNot Nothing, object_text_phone.EditValue, DBNull.Value)
                .Parameters.Add("@number_cellphone", SqlDbType.VarChar, 19).Value = object_text_cellphone.EditValue
                .Parameters.Add("@place_address", SqlDbType.VarChar, 100).Value = object_text_address.EditValue
                .Parameters.Add("@neighborhood", SqlDbType.VarChar, 50).Value = object_text_neighborhood.EditValue
                .Parameters.Add("@email", SqlDbType.VarChar, 100).Value = object_text_email.EditValue
                .Parameters.Add("@city_code", SqlDbType.SmallInt).Value = object_listed_cities.EditValue
                .Parameters.Add("@agency_type", SqlDbType.Char, 1).Value = object_listed_type.EditValue
                .Parameters.Add("@person_code", SqlDbType.SmallInt).Value = object_listed_person.EditValue
                .Parameters.Add("@point_latitude", SqlDbType.Decimal, 18, 6).Value = CDec(object_text_latitud.EditValue)
                .Parameters.Add("@point_longitude", SqlDbType.Decimal, 18, 6).Value = CDec(object_text_longitud.EditValue)
                .Parameters.Add("@center_operation", SqlDbType.VarChar, 10).Value = object_text_center.EditValue
                .Parameters.Add("@fundation_date", SqlDbType.Date).Value = object_text_fundation.EditValue
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_container)
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@row_affected", SqlDbType.Int).Direction = ParameterDirection.Output
                .Parameters.Add("@text_message", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output
            End With

            If object_search.execute_create <> 0 Then
                If object_check_form.Checked = True Then
                    defaults_objects(object_panel_container)
                Else
                    closed_module()
                End If
            End If
        End If
    End Sub
#End Region
End Class
