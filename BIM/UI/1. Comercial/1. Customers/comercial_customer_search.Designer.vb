<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class comercial_customer_search
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.object_search_search = New DevExpress.XtraEditors.PanelControl()
        Me.object_label_information = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_search_separator1 = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.CustomButton1 = New APDA.[Object].Controls.CustomButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CustomButton2 = New APDA.[Object].Controls.CustomButton()
        Me.object_panel_container = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.object_panel_customer = New DevExpress.XtraEditors.PanelControl()
        Me.CustomButton3 = New APDA.[Object].Controls.CustomButton()
        Me.CustomButton4 = New APDA.[Object].Controls.CustomButton()
        CType(Me.object_search_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_search_search.SuspendLayout()
        CType(Me.CustomButton1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomButton2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
        CType(Me.object_panel_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_customer.SuspendLayout()
        CType(Me.CustomButton3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomButton4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'object_search_search
        '
        Me.object_search_search.Appearance.BackColor = System.Drawing.Color.White
        Me.object_search_search.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_search_search.Appearance.BorderColor = System.Drawing.Color.White
        Me.object_search_search.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_search_search.Appearance.Options.UseBackColor = True
        Me.object_search_search.Appearance.Options.UseBorderColor = True
        Me.object_search_search.Appearance.Options.UseForeColor = True
        Me.object_search_search.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_search_search.Controls.Add(Me.CustomButton4)
        Me.object_search_search.Controls.Add(Me.object_label_information)
        Me.object_search_search.Controls.Add(Me.lbl_search_separator1)
        Me.object_search_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.object_search_search.Location = New System.Drawing.Point(1, 71)
        Me.object_search_search.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_search_search.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_search_search.Margin = New System.Windows.Forms.Padding(0)
        Me.object_search_search.Name = "object_search_search"
        Me.object_search_search.Padding = New System.Windows.Forms.Padding(5, 5, 45, 5)
        Me.object_search_search.Size = New System.Drawing.Size(1008, 43)
        Me.object_search_search.TabIndex = 0
        '
        'object_label_information
        '
        Me.object_label_information.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_information.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_information.Appearance.Options.UseFont = True
        Me.object_label_information.Appearance.Options.UseForeColor = True
        Me.object_label_information.Appearance.Options.UseTextOptions = True
        Me.object_label_information.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.object_label_information.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.object_label_information.Dock = System.Windows.Forms.DockStyle.Left
        Me.object_label_information.Location = New System.Drawing.Point(5, 5)
        Me.object_label_information.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_information.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_information.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_information.Name = "object_label_information"
        Me.object_label_information.Padding = New System.Windows.Forms.Padding(60, 0, 0, 0)
        Me.object_label_information.Size = New System.Drawing.Size(491, 33)
        Me.object_label_information.TabIndex = 0
        Me.object_label_information.Text = "Las opciones del modulo están condicionadas a los permisos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "asignados al usuario" &
    "*"
        '
        'lbl_search_separator1
        '
        Me.lbl_search_separator1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search_separator1.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_search_separator1.Appearance.Options.UseFont = True
        Me.lbl_search_separator1.Appearance.Options.UseForeColor = True
        Me.lbl_search_separator1.Appearance.Options.UseTextOptions = True
        Me.lbl_search_separator1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_search_separator1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_search_separator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_search_separator1.Location = New System.Drawing.Point(958, 5)
        Me.lbl_search_separator1.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_search_separator1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_search_separator1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_search_separator1.Name = "lbl_search_separator1"
        Me.lbl_search_separator1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lbl_search_separator1.Size = New System.Drawing.Size(5, 33)
        Me.lbl_search_separator1.TabIndex = 0
        '
        'object_label_title
        '
        Me.object_label_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.25!)
        Me.object_label_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.object_label_title.Appearance.Options.UseFont = True
        Me.object_label_title.Appearance.Options.UseForeColor = True
        Me.object_label_title.Appearance.Options.UseTextOptions = True
        Me.object_label_title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.object_label_title.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.object_label_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.object_label_title.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_label_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.object_label_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.object_label_title.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.object_label_title.Location = New System.Drawing.Point(1, 1)
        Me.object_label_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_title.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_title.Name = "object_label_title"
        Me.object_label_title.Padding = New System.Windows.Forms.Padding(62, 20, 0, 0)
        Me.object_label_title.Size = New System.Drawing.Size(1008, 70)
        Me.object_label_title.TabIndex = 0
        Me.object_label_title.Text = "Consulta de clientes"
        '
        'CustomButton1
        '
        Me.CustomButton1.EditValue = "Danny Alexander Mosquera"
        Me.CustomButton1.line_color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CustomButton1.Location = New System.Drawing.Point(61, 77)
        Me.CustomButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomButton1.Name = "CustomButton1"
        Me.CustomButton1.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton1.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton1.Properties.AdvancedModeOptions.Label = "Nombre de cliente"
        Me.CustomButton1.Properties.AdvancedModeOptions.LabelAppearance.ForeColor = System.Drawing.Color.Gray
        Me.CustomButton1.Properties.AdvancedModeOptions.LabelAppearance.Options.UseForeColor = True
        Me.CustomButton1.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = True
        Me.CustomButton1.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.CustomButton1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CustomButton1.Properties.Appearance.Options.UseForeColor = True
        Me.CustomButton1.Properties.Appearance.Options.UseTextOptions = True
        Me.CustomButton1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CustomButton1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.CustomButton1.Properties.AutoHeight = False
        Me.CustomButton1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CustomButton1.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.CustomButton1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CustomButton1.Properties.ReadOnly = True
        Me.CustomButton1.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton1.Size = New System.Drawing.Size(350, 40)
        Me.CustomButton1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 15.75!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl1.Location = New System.Drawing.Point(63, 45)
        Me.LabelControl1.LookAndFeel.SkinName = "Office 2019 White"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(157, 28)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Información del cliente"
        '
        'CustomButton2
        '
        Me.CustomButton2.EditValue = "1130634217"
        Me.CustomButton2.line_color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CustomButton2.Location = New System.Drawing.Point(61, 130)
        Me.CustomButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomButton2.Name = "CustomButton2"
        Me.CustomButton2.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton2.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton2.Properties.AdvancedModeOptions.Label = "Documento"
        Me.CustomButton2.Properties.AdvancedModeOptions.LabelAppearance.ForeColor = System.Drawing.Color.Gray
        Me.CustomButton2.Properties.AdvancedModeOptions.LabelAppearance.Options.UseForeColor = True
        Me.CustomButton2.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = True
        Me.CustomButton2.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.CustomButton2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CustomButton2.Properties.Appearance.Options.UseForeColor = True
        Me.CustomButton2.Properties.Appearance.Options.UseTextOptions = True
        Me.CustomButton2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CustomButton2.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.CustomButton2.Properties.AutoHeight = False
        Me.CustomButton2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CustomButton2.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.CustomButton2.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CustomButton2.Properties.ReadOnly = True
        Me.CustomButton2.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton2.Size = New System.Drawing.Size(350, 40)
        Me.CustomButton2.TabIndex = 1
        '
        'object_panel_container
        '
        Me.object_panel_container.Controls.Add(Me.object_panel_customer)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 114)
        Me.object_panel_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_container.Size = New System.Drawing.Size(1008, 2385)
        Me.object_panel_container.TabIndex = 0
        '
        'object_panel_customer
        '
        Me.object_panel_customer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_customer.Controls.Add(Me.CustomButton3)
        Me.object_panel_customer.Controls.Add(Me.LabelControl1)
        Me.object_panel_customer.Controls.Add(Me.CustomButton1)
        Me.object_panel_customer.Controls.Add(Me.CustomButton2)
        Me.object_panel_customer.Dock = System.Windows.Forms.DockStyle.Top
        Me.object_panel_customer.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_customer.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_customer.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_customer.Name = "object_panel_customer"
        Me.object_panel_customer.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_customer.Size = New System.Drawing.Size(1006, 444)
        Me.object_panel_customer.TabIndex = 0
        '
        'CustomButton3
        '
        Me.CustomButton3.EditValue = "07/06/1987"
        Me.CustomButton3.line_color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CustomButton3.Location = New System.Drawing.Point(61, 183)
        Me.CustomButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomButton3.Name = "CustomButton3"
        Me.CustomButton3.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton3.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton3.Properties.AdvancedModeOptions.Label = "Fecha de nacimiento"
        Me.CustomButton3.Properties.AdvancedModeOptions.LabelAppearance.ForeColor = System.Drawing.Color.Gray
        Me.CustomButton3.Properties.AdvancedModeOptions.LabelAppearance.Options.UseForeColor = True
        Me.CustomButton3.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = True
        Me.CustomButton3.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.CustomButton3.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CustomButton3.Properties.Appearance.Options.UseForeColor = True
        Me.CustomButton3.Properties.Appearance.Options.UseTextOptions = True
        Me.CustomButton3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CustomButton3.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.CustomButton3.Properties.AutoHeight = False
        Me.CustomButton3.Properties.BeepOnError = False
        Me.CustomButton3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CustomButton3.Properties.DisplayFormat.FormatString = "d"
        Me.CustomButton3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CustomButton3.Properties.EditFormat.FormatString = "d"
        Me.CustomButton3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CustomButton3.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.CustomButton3.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CustomButton3.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.CustomButton3.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.CustomButton3.Properties.MaskSettings.Set("mask", "d")
        Me.CustomButton3.Properties.ReadOnly = True
        Me.CustomButton3.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton3.Properties.UseMaskAsDisplayFormat = True
        Me.CustomButton3.Size = New System.Drawing.Size(350, 40)
        Me.CustomButton3.TabIndex = 0
        '
        'CustomButton4
        '
        Me.CustomButton4.Dock = System.Windows.Forms.DockStyle.Right
        Me.CustomButton4.EditValue = ""
        Me.CustomButton4.line_color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CustomButton4.Location = New System.Drawing.Point(608, 5)
        Me.CustomButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomButton4.Name = "CustomButton4"
        Me.CustomButton4.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton4.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton4.Properties.AdvancedModeOptions.Label = "Número de documento:"
        Me.CustomButton4.Properties.AdvancedModeOptions.LabelAppearance.ForeColor = System.Drawing.Color.Gray
        Me.CustomButton4.Properties.AdvancedModeOptions.LabelAppearance.Options.UseForeColor = True
        Me.CustomButton4.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = True
        Me.CustomButton4.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.CustomButton4.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CustomButton4.Properties.Appearance.Options.UseForeColor = True
        Me.CustomButton4.Properties.Appearance.Options.UseTextOptions = True
        Me.CustomButton4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CustomButton4.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.CustomButton4.Properties.AutoHeight = False
        Me.CustomButton4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CustomButton4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.CustomButton4.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.CustomButton4.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CustomButton4.Properties.NullText = "Buscar por número de documento"
        Me.CustomButton4.Properties.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.CustomButton4.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.CustomButton4.Size = New System.Drawing.Size(350, 33)
        Me.CustomButton4.TabIndex = 1
        '
        'comercial_customer_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Controls.Add(Me.object_search_search)
        Me.Controls.Add(Me.object_label_title)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "comercial_customer_search"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1010, 2500)
        Me.Tag = "Consulta de clientes"
        CType(Me.object_search_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_search_search.ResumeLayout(False)
        CType(Me.CustomButton1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomButton2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        CType(Me.object_panel_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_customer.ResumeLayout(False)
        Me.object_panel_customer.PerformLayout()
        CType(Me.CustomButton3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomButton4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents object_search_search As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_search_separator1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_information As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CustomButton1 As APDA.Object.Controls.CustomButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CustomButton2 As APDA.Object.Controls.CustomButton
    Friend WithEvents object_panel_container As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents object_panel_customer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CustomButton3 As APDA.Object.Controls.CustomButton
    Friend WithEvents CustomButton4 As APDA.Object.Controls.CustomButton
End Class
