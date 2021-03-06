Imports System.IO

Public Class start_initial_restored
    Private object_look As SkinRegistration = SkinRegistration.Instance
    Private object_search As object_data_search = object_data_search.Instance


#Region "contructors"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Private Sub module_load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub module_frame(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        frame_form(sender, e)
    End Sub
#End Region

#Region "behaviors"
    Private Function local_photo() As Boolean
        Return File.Exists(My.Settings.remember_photo)
    End Function

    Private Sub generate_password(sender As Object, e As EventArgs) Handles object_label_generate.Click
        txt_object_password.EditValue = fn_generate_password(10)
    End Sub

    Private Sub keypress_event(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then closed_option(object_button_closed, Nothing)
    End Sub
#End Region

#Region "methods"
    Private Sub saved_option(sender As Object, e As EventArgs) Handles object_button_accept.Click
        If object_component_validate.Validate = True Then
            With object_search.sql_command
                .CommandType = CommandType.StoredProcedure
                ' .CommandText = dop.entities_workforce_password_create.ToString

                .Parameters.Clear()
                .Parameters.Add("@user_name", SqlDbType.VarChar, 50).Value = txt_object_account.EditValue
                .Parameters.Add("@password_text", SqlDbType.VarChar, 50).Value = txt_object_password.EditValue
                .Parameters.Add("@temporary", SqlDbType.Char, 1).Value = "N"
                .Parameters.Add("@pc_name", SqlDbType.VarChar, 50).Value = fn_pc_name() & " |" & fn_version_number()
                .Parameters.Add("@ethernet_address", SqlDbType.VarChar, 100).Value = fn_ip_address()
                .Parameters.Add("@physical_address", SqlDbType.VarChar, 100).Value = fn_pc_mac()
                .Parameters.Add("@trace_number", SqlDbType.Char, 10).Value = fn_trace_number()
                .Parameters.Add("@trace_objects", SqlDbType.VarChar, 3000).Value = trace_to_create(object_panel_layout)
                .Parameters.Add("@event_date", SqlDbType.DateTime).Value = Now
                .Parameters.Add("@user_code", SqlDbType.SmallInt).Value = sessions.person_code
            End With

            If object_search.execute_create <> 0 Then
                Close()
            End If
        End If
    End Sub

    Private Sub closed_option(sender As Object, e As EventArgs) Handles object_button_closed.Click
        Close()
    End Sub
#End Region
End Class