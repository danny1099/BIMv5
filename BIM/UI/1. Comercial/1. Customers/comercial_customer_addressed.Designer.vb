<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class comercial_customer_addressed
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_customer_addressed))
        Me.object_panel_container = New DevExpress.XtraEditors.PanelControl()
        Me.object_label_separator = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_number = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_address_name = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_information = New DevExpress.XtraEditors.LabelControl()
        Me.object_component_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_text_house = New APDA.[Object].Controls.TextboxEdit()
        Me.object_text_number = New APDA.[Object].Controls.TextboxEdit()
        Me.object_text_address = New APDA.[Object].Controls.TextboxEdit()
        Me.object_listed_address = New APDA.[Object].Controls.ComboboxEdit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_house.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_listed_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'object_panel_container
        '
        Me.object_panel_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_container.Controls.Add(Me.object_button_saved)
        Me.object_panel_container.Controls.Add(Me.object_text_house)
        Me.object_panel_container.Controls.Add(Me.object_label_separator)
        Me.object_panel_container.Controls.Add(Me.object_text_number)
        Me.object_panel_container.Controls.Add(Me.object_label_number)
        Me.object_panel_container.Controls.Add(Me.object_text_address)
        Me.object_panel_container.Controls.Add(Me.lbl_address_name)
        Me.object_panel_container.Controls.Add(Me.object_label_title)
        Me.object_panel_container.Controls.Add(Me.object_label_information)
        Me.object_panel_container.Controls.Add(Me.object_listed_address)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_container.Size = New System.Drawing.Size(578, 398)
        Me.object_panel_container.TabIndex = 0
        '
        'object_label_separator
        '
        Me.object_label_separator.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_separator.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_separator.Appearance.Options.UseFont = True
        Me.object_label_separator.Appearance.Options.UseForeColor = True
        Me.object_label_separator.Location = New System.Drawing.Point(443, 178)
        Me.object_label_separator.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_separator.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_separator.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_separator.Name = "object_label_separator"
        Me.object_label_separator.Size = New System.Drawing.Size(4, 16)
        Me.object_label_separator.TabIndex = 0
        Me.object_label_separator.Text = "-"
        '
        'object_label_number
        '
        Me.object_label_number.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_number.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_number.Appearance.Options.UseFont = True
        Me.object_label_number.Appearance.Options.UseForeColor = True
        Me.object_label_number.Location = New System.Drawing.Point(333, 178)
        Me.object_label_number.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_number.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_number.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_number.Name = "object_label_number"
        Me.object_label_number.Size = New System.Drawing.Size(8, 16)
        Me.object_label_number.TabIndex = 0
        Me.object_label_number.Text = "#"
        '
        'lbl_address_name
        '
        Me.lbl_address_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_address_name.Appearance.Options.UseFont = True
        Me.lbl_address_name.Appearance.Options.UseForeColor = True
        Me.lbl_address_name.Location = New System.Drawing.Point(44, 148)
        Me.lbl_address_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_address_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_address_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_address_name.Name = "lbl_address_name"
        Me.lbl_address_name.Size = New System.Drawing.Size(227, 16)
        Me.lbl_address_name.TabIndex = 0
        Me.lbl_address_name.Text = "Defina la composición de la dirección a registrar*"
        '
        'object_label_title
        '
        Me.object_label_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 21.0!)
        Me.object_label_title.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.object_label_title.Appearance.Options.UseFont = True
        Me.object_label_title.Appearance.Options.UseForeColor = True
        Me.object_label_title.Location = New System.Drawing.Point(188, 36)
        Me.object_label_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_title.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_title.Name = "object_label_title"
        Me.object_label_title.Size = New System.Drawing.Size(197, 38)
        Me.object_label_title.TabIndex = 0
        Me.object_label_title.Text = "Gestor de direcciones"
        '
        'object_label_information
        '
        Me.object_label_information.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_information.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.object_label_information.Appearance.Options.UseFont = True
        Me.object_label_information.Appearance.Options.UseForeColor = True
        Me.object_label_information.Location = New System.Drawing.Point(44, 207)
        Me.object_label_information.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_information.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_information.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_information.Name = "object_label_information"
        Me.object_label_information.Size = New System.Drawing.Size(232, 18)
        Me.object_label_information.TabIndex = 0
        Me.object_label_information.Text = "Los campos marcados con asterico (*) son requeridos..."
        '
        'object_component_validate
        '
        Me.object_component_validate.ValidateHiddenControls = False
        Me.object_component_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'object_button_saved
        '
        Me.object_button_saved.BackColor = System.Drawing.Color.White
        Me.object_button_saved.BackgroundImage = CType(resources.GetObject("object_button_saved.BackgroundImage"), System.Drawing.Image)
        Me.object_button_saved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.object_button_saved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.object_button_saved.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.object_button_saved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.object_button_saved.Font = New System.Drawing.Font("Open Sans Condensed Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_button_saved.ForeColor = System.Drawing.Color.White
        Me.object_button_saved.Image = CType(resources.GetObject("object_button_saved.Image"), System.Drawing.Image)
        Me.object_button_saved.Location = New System.Drawing.Point(167, 306)
        Me.object_button_saved.Margin = New System.Windows.Forms.Padding(0)
        Me.object_button_saved.MaximumSize = New System.Drawing.Size(240, 60)
        Me.object_button_saved.MinimumSize = New System.Drawing.Size(240, 60)
        Me.object_button_saved.Name = "object_button_saved"
        Me.object_button_saved.Size = New System.Drawing.Size(240, 60)
        Me.object_button_saved.TabIndex = 5
        Me.object_button_saved.TabStop = False
        Me.object_button_saved.Text = "Guardar"
        Me.object_button_saved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.object_button_saved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.object_button_saved.UseVisualStyleBackColor = False
        '
        'object_text_house
        '
        Me.object_text_house.Location = New System.Drawing.Point(455, 168)
        Me.object_text_house.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_house.Name = "object_text_house"
        Me.object_text_house.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_house.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_house.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_house.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_house.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_house.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_house.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_house.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_text_house.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_text_house.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_house.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.object_text_house.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_text_house.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_text_house.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.object_text_house.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_text_house.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_text_house.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_house.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_text_house.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_text_house.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_text_house.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_text_house.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_text_house.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_text_house.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_house.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_text_house.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_text_house.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_text_house.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_text_house.Properties.AutoHeight = False
        Me.object_text_house.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_house.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_house.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_house.Properties.Mask.BeepOnError = True
        Me.object_text_house.Size = New System.Drawing.Size(80, 35)
        Me.object_text_house.TabIndex = 4
        '
        'object_text_number
        '
        Me.object_text_number.Location = New System.Drawing.Point(355, 168)
        Me.object_text_number.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_number.Name = "object_text_number"
        Me.object_text_number.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_number.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_number.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_number.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_number.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_number.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_number.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_number.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_text_number.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_text_number.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_number.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.object_text_number.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_text_number.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_text_number.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.object_text_number.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_text_number.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_text_number.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_number.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_text_number.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_text_number.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_text_number.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_text_number.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_text_number.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_text_number.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_number.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_text_number.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_text_number.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_text_number.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_text_number.Properties.AutoHeight = False
        Me.object_text_number.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_number.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_number.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_number.Properties.Mask.BeepOnError = True
        Me.object_text_number.Size = New System.Drawing.Size(80, 35)
        Me.object_text_number.TabIndex = 3
        '
        'object_text_address
        '
        Me.object_text_address.Location = New System.Drawing.Point(228, 168)
        Me.object_text_address.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_address.Name = "object_text_address"
        Me.object_text_address.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_address.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_address.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_address.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_address.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_address.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_address.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_address.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_text_address.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_text_address.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_address.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.object_text_address.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_text_address.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_text_address.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.object_text_address.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_text_address.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_text_address.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_address.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_text_address.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_text_address.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_text_address.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_text_address.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_text_address.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_text_address.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_address.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_text_address.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_text_address.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_text_address.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_text_address.Properties.AutoHeight = False
        Me.object_text_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_address.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_address.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_address.Properties.Mask.BeepOnError = True
        Me.object_text_address.Size = New System.Drawing.Size(89, 35)
        Me.object_text_address.TabIndex = 2
        '
        'object_listed_address
        '
        Me.object_listed_address.Location = New System.Drawing.Point(44, 168)
        Me.object_listed_address.Margin = New System.Windows.Forms.Padding(0)
        Me.object_listed_address.Name = "object_listed_address"
        Me.object_listed_address.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_listed_address.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_listed_address.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_address.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_listed_address.Properties.Appearance.Options.UseBackColor = True
        Me.object_listed_address.Properties.Appearance.Options.UseBorderColor = True
        Me.object_listed_address.Properties.Appearance.Options.UseForeColor = True
        Me.object_listed_address.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_address.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_listed_address.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_listed_address.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_address.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.object_listed_address.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.object_listed_address.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_address.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.object_listed_address.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.object_listed_address.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_address.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_listed_address.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_listed_address.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_listed_address.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_address.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_listed_address.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_listed_address.Properties.AutoHeight = False
        Me.object_listed_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_listed_address.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.object_listed_address.Properties.DropDownItemHeight = 30
        Me.object_listed_address.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_listed_address.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_listed_address.Properties.NullText = ""
        Me.object_listed_address.Properties.ShowFooter = False
        Me.object_listed_address.Properties.ShowHeader = False
        Me.object_listed_address.Size = New System.Drawing.Size(170, 35)
        Me.object_listed_address.TabIndex = 1
        '
        'comercial_customer_addressed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "comercial_customer_addressed"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(580, 400)
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_house.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_listed_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents object_panel_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents object_text_house As APDA.Object.Controls.TextboxEdit
    Friend WithEvents object_label_separator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_text_number As APDA.Object.Controls.TextboxEdit
    Friend WithEvents object_label_number As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_text_address As APDA.Object.Controls.TextboxEdit
    Friend WithEvents lbl_address_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_listed_address As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents object_button_saved As Button
    Friend WithEvents object_component_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents object_label_information As DevExpress.XtraEditors.LabelControl
End Class
