Public Class model_object_notify
    Private tracing As Audited = Audited.Instance
    Public Property row_affected As Integer

#Region "constructor"
    Public Sub New()
        InitializeComponent()
        PerformAutoScale()
    End Sub

    Public Sub New(user_photo_ As Image, notification_text As String, event_date As String, row_selected As Integer, module_text As String)
        InitializeComponent()
        PerformAutoScale()

        'set values of parameters in variables
        pic_object_photo.Image = user_photo_
        txt_object_note.EditValue = notification_text
        lbl_text_event.Text = event_date
        lbl_text_module.Tag = module_text

        'set values of current row
        row_affected = row_selected
    End Sub
#End Region

#Region "options"
    Private Sub erased_option(sender As Object, e As EventArgs) Handles lbl_text_module.Click
        If row_affected <> 0 Then
            If tracing.tracing_notification_erased(row_affected, False) = True Then
                show_option(lbl_text_module.Tag.ToString)
            End If
        End If
    End Sub
#End Region
End Class
