Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab
Imports APDA.Object.Controls

Public Module Interfaces
    Property start_home As start_initial_homes = Application.OpenForms.Cast(Of Form)().FirstOrDefault(Function(x) TypeOf x Is start_initial_homes)
    Property flyout_action As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction

#Region "helpers"
    Private Function search_module(control_name As String) As Control
        Return DirectCast(Activator.CreateInstance(Type.GetType("BIM." + control_name)), Control)
    End Function

    Private Function search_modparameter(control_name As String, parameter As Object) As Control
        Return DirectCast(Activator.CreateInstance(Type.GetType("BIM." + control_name), parameter), Control)
    End Function

    Public Sub search_form(control_name As String)
        Try
            Dim form_object As Form = DirectCast(Activator.CreateInstance(Type.GetType("BIM." + control_name)), Form)
            form_object.BringToFront()
            form_object.ShowDialog(start_home)

        Catch ex As Exception
        Finally
        End Try
    End Sub

    Public Sub search_form(control_name As String, parameter As Object)
        Try
            Dim form_object As Form = DirectCast(Activator.CreateInstance(Type.GetType("BIM." + control_name), parameter), Form)
            form_object.BringToFront()
            form_object.ShowDialog(start_home)

        Catch ex As Exception
        Finally
        End Try
    End Sub

    Public Sub defaults_objects(panel_ As Control)
        Try
            For Each c As Object In panel_.Controls
                If Not TypeOf c Is LabelControl And Not TypeOf c Is PictureEdit And Not TypeOf c Is Button And Not TypeOf c Is ListBoxControl And Not TypeOf c Is PanelControl And Not TypeOf c Is XtraScrollableControl And Not TypeOf c Is SimpleButton Then
                    If TypeOf c Is CheckEdit Or TypeOf c Is TextboxCheck Then
                        If c.Name.ToString.Contains("form") Or c.Name.ToString.Contains("conserved") Then
                        Else
                            c.Checked = False
                        End If
                    ElseIf TypeOf c Is RadioGroup Or TypeOf c Is TextboxDates Then
                        c.EditValue = Nothing
                    Else
                        If c.Properties.ReadOnly = False Then
                            c.Text = ""
                            c.EditValue = Nothing
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            message_text("Error en el proceso 'defaults_objects' al intentar ejecutarse: " & ex.Message.ToString, MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function search_home() As start_initial_homes
        Return Application.OpenForms.Cast(Of Form)().FirstOrDefault(Function(x) TypeOf x Is start_initial_homes)
    End Function
#End Region

#Region "methods"
    Public Sub show_option(control_name As String)
        windows_tabbed(search_module(control_name))
    End Sub

    Public Sub show_option(control_object As Control)
        windows_tabbed(control_object)
    End Sub

    Public Sub show_flyout(control_object As Control)
        Using fly_out As New model_object_flyout(Application.OpenForms.Cast(Of Form)().FirstOrDefault(Function(x) TypeOf x Is start_initial_homes), control_object)
            fly_out.ShowDialog(start_home)
        End Using
    End Sub

    Private Sub windows_tabbed(object_control As Control)
        Try
            If object_control IsNot Nothing Then
                'Comprueba que la variable menu no sea nula
                If start_home Is Nothing Then start_home = search_home()

                With start_home
                    If find_tabbed(object_control.Name) Is Nothing Then
                        Dim tabbed_page As New XtraTabPage

                        'Define el control en el contenedor de pestaña
                        object_control.Dock = DockStyle.Fill
                        tabbed_page.Controls.Add(object_control)
                        tabbed_page.Name = object_control.Name.ToString
                        tabbed_page.Text = object_control.Tag.ToString & "     "

                        'Agrega la pestaña creada  a la vista de pestañas
                        .object_panel_tabbed.TabPages.Add(tabbed_page)
                    End If
                End With
            End If
        Catch ex As Exception
            message_text("Error en el proceso 'windows_tabbed' al intentar ejecutarse: " & ex.Message.ToString, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Function find_tabbed(control_name As String) As Control
        Try
            With start_home.object_panel_tabbed
                For Each c As XtraTabPage In .TabPages
                    If c.Name = control_name Then
                        .SelectedTabPage = c
                        .SelectedTabPage.BringToFront()
                        Return c
                    End If
                Next
            End With
        Catch ex As Exception
        End Try

        Return Nothing
    End Function
#End Region
End Module
