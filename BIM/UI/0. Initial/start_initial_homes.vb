Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab

Public Class start_initial_homes
    Private object_look As SkinRegistration = SkinRegistration.Instance

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As System.Windows.Forms.CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H20000
            cp.Style = cp.Style Or &H40
            Return cp
        End Get
    End Property


#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()

        'Cambia el tamaño del formulario que abarque la pantalla del usuario
        Me.Size = My.Computer.Screen.WorkingArea.Size
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub module_frame(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Sub current_session()
        object_label_username.Text = "Hola, " & fn_text_spaces(sessions.person_name)
        object_label_version.Text = fn_version_number()
        object_label_work.Text = "WSID-" & Format(sessions.session_code, "D6")
        object_image_photo.Image = sessions.person_photo

        'Aplica los permisos a los que tenga acceso el usuario
        search_permits()
        ' search_notification()
    End Sub

    Private Sub closed_home(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If message_text("Está seguro que desea salir de la aplicación?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.ExitThread()
            objects_released(Me)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub element_click(sender As Object, e As ElementClickEventArgs) Handles object_menu_control.ElementClick
        Try
            If Not e.Element.Tag Is Nothing Then show_option(e.Element.Tag.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub search_permits()
        'Carga los permisos asociados al usuario
        Dim table_source As DataTable = sessions.search_permission

        'Recorre todas las opciones del menu
        With table_source
            For Each item As AccordionControlElement In object_menu_control.Elements
                If item.Style = ElementStyle.Group Then
                    For Each options As AccordionControlElement In item.Elements
                        If options.Name.Contains("group") Then
                            For Each rows As AccordionControlElement In options.Elements
                                rows.Visible = If(sessions.position_rol = 1, True, If(.Select("option_object='" & rows.Name & "'").Count = 0, False, True))
                            Next
                        End If
                    Next

                    'Oculta la opcion base del menu
                    item.Visible = If(sessions.position_rol = 1, True, If(.Select("module_object='" & item.Name & "'").Count = 0, False, True))

                ElseIf item.Style = ElementStyle.Item Then
                    item.Visible = If(sessions.position_rol = 1, True, If(.Select("module_object='" & item.Name & "'").Count = 0, False, True))
                End If
            Next
        End With
    End Sub

    Private Sub option_selected(sender As Object, e As EventArgs) Handles object_button_wholesales.Click, object_button_settleds.Click, object_button_settings.Click, object_button_relationship.Click, object_button_projects.Click, object_button_dashboard.Click
        If sender.Tag IsNot Nothing Then group_selected(object_menu_control.Elements.Item(sender.Tag.ToString), Nothing)
    End Sub

    Private Sub closed_tabbed(sender As Object, e As EventArgs) Handles object_panel_tabbed.CloseButtonClick
        removed_tabbed()
    End Sub

    Private Sub tabbed_added(sender As Object, e As ControlEventArgs) Handles object_panel_tabbed.ControlAdded
        If TypeOf (sender) Is XtraTabControl Then
            Try
                'Define la pestaña agregada como activa
                object_panel_tabbed.SelectedTabPage = TryCast(sender, XtraTabPage)
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub group_selected(sender As Object, e As EventArgs)
        If sender IsNot Nothing Then
            object_menu_control.ActiveGroup = sender
            object_label_title.Text = sender.Text
        End If
    End Sub

    Public Sub removed_tabbed()
        Try
            With object_panel_tabbed
                .TabPages.Remove(.SelectedTabPage)
            End With
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "options"
    Private Sub minimize_option(sender As Object, e As EventArgs) Handles object_button_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closed_session(sender As Object, e As EventArgs) Handles object_button_closed.Click
        Close()
    End Sub

    Private Sub update_option(sender As Object, e As EventArgs) Handles object_button_update.Click
    End Sub
#End Region
End Class