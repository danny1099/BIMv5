<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class model_object_notify
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.pnl_object_users = New System.Windows.Forms.Panel()
        Me.txt_object_note = New APDA.[Object].Controls.TextboxMemo()
        Me.pnl_object_bottom = New System.Windows.Forms.Panel()
        Me.lbl_text_module = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_text_event = New DevExpress.XtraEditors.LabelControl()
        Me.pic_object_photo = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        Me.pnl_object_users.SuspendLayout()
        CType(Me.txt_object_note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_bottom.SuspendLayout()
        CType(Me.pic_object_photo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_object_container
        '
        Me.pnl_object_container.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BackColor2 = System.Drawing.Color.White
        Me.pnl_object_container.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_object_container.Appearance.Options.UseBackColor = True
        Me.pnl_object_container.Appearance.Options.UseBorderColor = True
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.pnl_object_users)
        Me.pnl_object_container.Controls.Add(Me.pnl_object_bottom)
        Me.pnl_object_container.Controls.Add(Me.pic_object_photo)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(288, 78)
        Me.pnl_object_container.TabIndex = 1
        '
        'pnl_object_users
        '
        Me.pnl_object_users.Controls.Add(Me.txt_object_note)
        Me.pnl_object_users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_users.Location = New System.Drawing.Point(51, 1)
        Me.pnl_object_users.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_users.Name = "pnl_object_users"
        Me.pnl_object_users.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.pnl_object_users.Size = New System.Drawing.Size(236, 48)
        Me.pnl_object_users.TabIndex = 0
        '
        'txt_object_note
        '
        Me.txt_object_note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_object_note.EditValue = ""
        Me.txt_object_note.Tag = "Nota"
        Me.txt_object_note.Location = New System.Drawing.Point(10, 5)
        Me.txt_object_note.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_object_note.Name = "txt_object_note"
        Me.txt_object_note.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_object_note.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txt_object_note.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_object_note.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.txt_object_note.Properties.Appearance.Options.UseBackColor = True
        Me.txt_object_note.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_object_note.Properties.Appearance.Options.UseForeColor = True
        Me.txt_object_note.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_object_note.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.txt_object_note.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_object_note.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_object_note.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_object_note.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txt_object_note.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_object_note.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txt_object_note.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txt_object_note.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_object_note.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_object_note.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_object_note.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txt_object_note.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_object_note.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_object_note.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txt_object_note.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_object_note.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_object_note.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_object_note.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txt_object_note.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_object_note.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_object_note.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.txt_object_note.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_object_note.Properties.MaxLength = 500
        Me.txt_object_note.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_object_note.Size = New System.Drawing.Size(221, 38)
        Me.txt_object_note.TabIndex = 0
        '
        'pnl_object_bottom
        '
        Me.pnl_object_bottom.Controls.Add(Me.lbl_text_module)
        Me.pnl_object_bottom.Controls.Add(Me.lbl_text_event)
        Me.pnl_object_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_object_bottom.Location = New System.Drawing.Point(51, 49)
        Me.pnl_object_bottom.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_bottom.Name = "pnl_object_bottom"
        Me.pnl_object_bottom.Padding = New System.Windows.Forms.Padding(10, 5, 5, 1)
        Me.pnl_object_bottom.Size = New System.Drawing.Size(236, 28)
        Me.pnl_object_bottom.TabIndex = 0
        '
        'lbl_text_module
        '
        Me.lbl_text_module.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text_module.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_text_module.Appearance.Options.UseFont = True
        Me.lbl_text_module.Appearance.Options.UseForeColor = True
        Me.lbl_text_module.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_text_module.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_text_module.Location = New System.Drawing.Point(208, 5)
        Me.lbl_text_module.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_text_module.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_text_module.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_text_module.Name = "lbl_text_module"
        Me.lbl_text_module.Size = New System.Drawing.Size(23, 18)
        Me.lbl_text_module.TabIndex = 0
        Me.lbl_text_module.Text = "Ir a..."
        '
        'lbl_text_event
        '
        Me.lbl_text_event.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text_event.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_text_event.Appearance.Options.UseFont = True
        Me.lbl_text_event.Appearance.Options.UseForeColor = True
        Me.lbl_text_event.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_text_event.Location = New System.Drawing.Point(10, 5)
        Me.lbl_text_event.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_text_event.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_text_event.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_text_event.Name = "lbl_text_event"
        Me.lbl_text_event.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lbl_text_event.Size = New System.Drawing.Size(20, 18)
        Me.lbl_text_event.TabIndex = 0
        '
        'pic_object_photo
        '
        Me.pic_object_photo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_object_photo.EditValue = Global.BIM.My.Resources.Resources.photo_men
        Me.pic_object_photo.Location = New System.Drawing.Point(1, 1)
        Me.pic_object_photo.Margin = New System.Windows.Forms.Padding(0)
        Me.pic_object_photo.MaximumSize = New System.Drawing.Size(50, 50)
        Me.pic_object_photo.Name = "pic_object_photo"
        Me.pic_object_photo.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.pic_object_photo.Properties.Appearance.Options.UseForeColor = True
        Me.pic_object_photo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pic_object_photo.Properties.InitialImageOptions.Image = Global.BIM.My.Resources.Resources.photo_men
        Me.pic_object_photo.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.pic_object_photo.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pic_object_photo.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle
        Me.pic_object_photo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pic_object_photo.Properties.ShowMenu = False
        Me.pic_object_photo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pic_object_photo.Size = New System.Drawing.Size(50, 50)
        Me.pic_object_photo.TabIndex = 1
        '
        'model_object_notify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnl_object_container)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Name = "model_object_notify"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(290, 80)
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_users.ResumeLayout(False)
        CType(Me.txt_object_note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_bottom.ResumeLayout(False)
        Me.pnl_object_bottom.PerformLayout()
        CType(Me.pic_object_photo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnl_object_users As Panel
    Friend WithEvents pnl_object_bottom As Panel
    Friend WithEvents lbl_text_event As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_object_note As APDA.Object.Controls.TextboxMemo
    Friend WithEvents pic_object_photo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lbl_text_module As DevExpress.XtraEditors.LabelControl
End Class
