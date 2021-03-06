<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial_customer_transfer
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
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_customer_transfer))
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.object_component_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.object_listed_person = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_sellers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.object_panel_container = New DevExpress.XtraEditors.PanelControl()
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_label_person = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_amount = New DevExpress.XtraEditors.LabelControl()
        Me.object_text_amount = New APDA.[Object].Controls.TextboxEdit()
        Me.object_label_dates = New DevExpress.XtraEditors.LabelControl()
        Me.object_text_dates = New APDA.[Object].Controls.TextboxDates()
        Me.object_listed_agency = New APDA.[Object].Controls.ComboboxEdit()
        Me.lbl_attention_desc = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_agency = New DevExpress.XtraEditors.LabelControl()
        Me.object_text_comment = New DevExpress.XtraEditors.MemoEdit()
        Me.object_label_information = New DevExpress.XtraEditors.LabelControl()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_listed_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
        CType(Me.object_text_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_dates.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_dates.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_listed_agency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_comment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'object_component_validate
        '
        Me.object_component_validate.ValidateHiddenControls = False
        Me.object_component_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'object_listed_person
        '
        Me.object_listed_person.EditValue = ""
        Me.object_component_validate.SetIconAlignment(Me.object_listed_person, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.object_listed_person.Location = New System.Drawing.Point(48, 217)
        Me.object_listed_person.Margin = New System.Windows.Forms.Padding(0)
        Me.object_listed_person.Name = "object_listed_person"
        Me.object_listed_person.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_listed_person.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_listed_person.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_person.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_listed_person.Properties.Appearance.Options.UseBackColor = True
        Me.object_listed_person.Properties.Appearance.Options.UseBorderColor = True
        Me.object_listed_person.Properties.Appearance.Options.UseForeColor = True
        Me.object_listed_person.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_person.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.object_listed_person.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_listed_person.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_listed_person.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.object_listed_person.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_person.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.object_listed_person.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.object_listed_person.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.object_listed_person.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.object_listed_person.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_person.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_listed_person.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_listed_person.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_listed_person.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_listed_person.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_listed_person.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_person.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_listed_person.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_listed_person.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_listed_person.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_listed_person.Properties.AutoHeight = False
        Me.object_listed_person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_listed_person.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.object_listed_person.Properties.LookAndFeel.SkinName = "My Office 2019 White"
        Me.object_listed_person.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_listed_person.Properties.NullText = ""
        Me.object_listed_person.Properties.PopupView = Me.dgv_sales_sellers
        Me.object_listed_person.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.object_listed_person.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.object_listed_person.Size = New System.Drawing.Size(350, 30)
        Me.object_listed_person.TabIndex = 2
        Me.object_listed_person.Tag = "Responsable"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_listed_person, ConditionValidationRule1)
        '
        'dgv_sales_sellers
        '
        Me.dgv_sales_sellers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.dgv_sales_sellers.Name = "dgv_sales_sellers"
        Me.dgv_sales_sellers.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgv_sales_sellers.OptionsView.ShowGroupPanel = False
        Me.dgv_sales_sellers.OptionsView.ShowIndicator = False
        '
        'object_panel_container
        '
        Me.object_panel_container.Appearance.BackColor = System.Drawing.Color.White
        Me.object_panel_container.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_panel_container.Appearance.BorderColor = System.Drawing.Color.White
        Me.object_panel_container.Appearance.Options.UseBackColor = True
        Me.object_panel_container.Appearance.Options.UseBorderColor = True
        Me.object_panel_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_container.Controls.Add(Me.object_label_information)
        Me.object_panel_container.Controls.Add(Me.object_listed_agency)
        Me.object_panel_container.Controls.Add(Me.lbl_attention_desc)
        Me.object_panel_container.Controls.Add(Me.object_label_agency)
        Me.object_panel_container.Controls.Add(Me.object_text_comment)
        Me.object_panel_container.Controls.Add(Me.object_label_amount)
        Me.object_panel_container.Controls.Add(Me.object_listed_person)
        Me.object_panel_container.Controls.Add(Me.object_text_amount)
        Me.object_panel_container.Controls.Add(Me.object_button_saved)
        Me.object_panel_container.Controls.Add(Me.object_label_dates)
        Me.object_panel_container.Controls.Add(Me.object_label_person)
        Me.object_panel_container.Controls.Add(Me.object_text_dates)
        Me.object_panel_container.Controls.Add(Me.object_label_title)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_container.Size = New System.Drawing.Size(878, 445)
        Me.object_panel_container.TabIndex = 0
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
        Me.object_button_saved.Location = New System.Drawing.Point(311, 361)
        Me.object_button_saved.Margin = New System.Windows.Forms.Padding(0)
        Me.object_button_saved.MaximumSize = New System.Drawing.Size(240, 60)
        Me.object_button_saved.MinimumSize = New System.Drawing.Size(240, 60)
        Me.object_button_saved.Name = "object_button_saved"
        Me.object_button_saved.Size = New System.Drawing.Size(240, 60)
        Me.object_button_saved.TabIndex = 0
        Me.object_button_saved.TabStop = False
        Me.object_button_saved.Text = "Guardar"
        Me.object_button_saved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.object_button_saved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.object_button_saved.UseVisualStyleBackColor = False
        '
        'object_label_person
        '
        Me.object_label_person.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_person.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_person.Appearance.Options.UseFont = True
        Me.object_label_person.Appearance.Options.UseForeColor = True
        Me.object_label_person.Location = New System.Drawing.Point(48, 197)
        Me.object_label_person.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_person.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_person.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_person.Name = "object_label_person"
        Me.object_label_person.Size = New System.Drawing.Size(246, 16)
        Me.object_label_person.TabIndex = 0
        Me.object_label_person.Text = "Defina el nombre del vendedor a transferir el cliente*"
        '
        'object_label_title
        '
        Me.object_label_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 21.0!)
        Me.object_label_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.object_label_title.Appearance.Options.UseFont = True
        Me.object_label_title.Appearance.Options.UseForeColor = True
        Me.object_label_title.Location = New System.Drawing.Point(47, 32)
        Me.object_label_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_title.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_title.Name = "object_label_title"
        Me.object_label_title.Size = New System.Drawing.Size(88, 38)
        Me.object_label_title.TabIndex = 0
        Me.object_label_title.Text = "Transferir"
        '
        'object_label_amount
        '
        Me.object_label_amount.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_amount.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_amount.Appearance.Options.UseFont = True
        Me.object_label_amount.Appearance.Options.UseForeColor = True
        Me.object_label_amount.Location = New System.Drawing.Point(292, 261)
        Me.object_label_amount.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_amount.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_amount.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_amount.Name = "object_label_amount"
        Me.object_label_amount.Size = New System.Drawing.Size(46, 16)
        Me.object_label_amount.TabIndex = 0
        Me.object_label_amount.Text = "Cantidad*"
        '
        'object_text_amount
        '
        Me.object_component_validate.SetIconAlignment(Me.object_text_amount, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.object_text_amount.Location = New System.Drawing.Point(292, 281)
        Me.object_text_amount.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_amount.Name = "object_text_amount"
        Me.object_text_amount.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_amount.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_amount.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_amount.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_amount.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_amount.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_amount.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_amount.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_text_amount.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_text_amount.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_amount.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.object_text_amount.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_text_amount.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_text_amount.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.object_text_amount.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_text_amount.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_text_amount.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_amount.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_text_amount.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_text_amount.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_text_amount.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_text_amount.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_text_amount.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_text_amount.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_amount.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_text_amount.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_text_amount.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_text_amount.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_text_amount.Properties.AutoHeight = False
        Me.object_text_amount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_amount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.object_text_amount.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_amount.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_amount.Properties.Mask.BeepOnError = True
        Me.object_text_amount.Properties.MaskSettings.Set("mask", "(2) \d\d\d-\d\d\d\d")
        Me.object_text_amount.Properties.ReadOnly = True
        Me.object_text_amount.Size = New System.Drawing.Size(106, 30)
        Me.object_text_amount.TabIndex = 4
        Me.object_text_amount.Tag = "Cantidad"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_text_amount, ConditionValidationRule3)
        '
        'object_label_dates
        '
        Me.object_label_dates.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_dates.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_dates.Appearance.Options.UseFont = True
        Me.object_label_dates.Appearance.Options.UseForeColor = True
        Me.object_label_dates.Location = New System.Drawing.Point(48, 261)
        Me.object_label_dates.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_dates.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_dates.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_dates.Name = "object_label_dates"
        Me.object_label_dates.Size = New System.Drawing.Size(87, 16)
        Me.object_label_dates.TabIndex = 0
        Me.object_label_dates.Text = "Fecha de registro*"
        '
        'object_text_dates
        '
        Me.object_text_dates.EditValue = Nothing
        Me.object_component_validate.SetIconAlignment(Me.object_text_dates, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.object_text_dates.Location = New System.Drawing.Point(48, 281)
        Me.object_text_dates.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_dates.Name = "object_text_dates"
        Me.object_text_dates.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_dates.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_dates.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_dates.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_dates.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_dates.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_dates.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_dates.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_dates.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.object_text_dates.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_text_dates.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_text_dates.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.object_text_dates.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.object_text_dates.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.object_text_dates.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.object_text_dates.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.object_text_dates.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.object_text_dates.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_dates.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_text_dates.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_text_dates.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_text_dates.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_text_dates.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_text_dates.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_dates.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_text_dates.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_text_dates.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_text_dates.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_text_dates.Properties.AutoHeight = False
        Me.object_text_dates.Properties.BeepOnError = False
        Me.object_text_dates.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.object_text_dates.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.object_text_dates.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.object_text_dates.Properties.DisplayFormat.FormatString = "g"
        Me.object_text_dates.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.object_text_dates.Properties.EditFormat.FormatString = "g"
        Me.object_text_dates.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.object_text_dates.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_dates.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_dates.Properties.MaskSettings.Set("mask", "g")
        Me.object_text_dates.Properties.ReadOnly = True
        Me.object_text_dates.Properties.UseMaskAsDisplayFormat = True
        Me.object_text_dates.Size = New System.Drawing.Size(232, 30)
        Me.object_text_dates.TabIndex = 3
        Me.object_text_dates.Tag = "Fecha de creación"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_text_dates, ConditionValidationRule4)
        '
        'object_listed_agency
        '
        Me.object_component_validate.SetIconAlignment(Me.object_listed_agency, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.object_listed_agency.Location = New System.Drawing.Point(48, 153)
        Me.object_listed_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.object_listed_agency.Name = "object_listed_agency"
        Me.object_listed_agency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_listed_agency.Properties.Appearance.Options.UseBackColor = True
        Me.object_listed_agency.Properties.Appearance.Options.UseBorderColor = True
        Me.object_listed_agency.Properties.Appearance.Options.UseForeColor = True
        Me.object_listed_agency.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_listed_agency.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_listed_agency.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.object_listed_agency.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.object_listed_agency.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.object_listed_agency.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.object_listed_agency.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_listed_agency.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_listed_agency.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_listed_agency.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_listed_agency.Properties.AutoHeight = False
        Me.object_listed_agency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_listed_agency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.object_listed_agency.Properties.DropDownItemHeight = 30
        Me.object_listed_agency.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_listed_agency.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_listed_agency.Properties.NullText = ""
        Me.object_listed_agency.Properties.ShowFooter = False
        Me.object_listed_agency.Properties.ShowHeader = False
        Me.object_listed_agency.Size = New System.Drawing.Size(350, 30)
        Me.object_listed_agency.TabIndex = 1
        Me.object_listed_agency.Tag = "Agencia"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_listed_agency, ConditionValidationRule2)
        '
        'lbl_attention_desc
        '
        Me.lbl_attention_desc.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_desc.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_attention_desc.Appearance.Options.UseFont = True
        Me.lbl_attention_desc.Appearance.Options.UseForeColor = True
        Me.lbl_attention_desc.Location = New System.Drawing.Point(472, 133)
        Me.lbl_attention_desc.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_attention_desc.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_attention_desc.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_attention_desc.Name = "lbl_attention_desc"
        Me.lbl_attention_desc.Size = New System.Drawing.Size(210, 16)
        Me.lbl_attention_desc.TabIndex = 0
        Me.lbl_attention_desc.Text = "Descripción de la gestión comercial realizada"
        '
        'object_label_agency
        '
        Me.object_label_agency.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_agency.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_agency.Appearance.Options.UseFont = True
        Me.object_label_agency.Appearance.Options.UseForeColor = True
        Me.object_label_agency.Location = New System.Drawing.Point(48, 133)
        Me.object_label_agency.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_agency.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_agency.Name = "object_label_agency"
        Me.object_label_agency.Size = New System.Drawing.Size(171, 16)
        Me.object_label_agency.TabIndex = 0
        Me.object_label_agency.Text = "Seleccione el nombre de la agencia*"
        '
        'object_text_comment
        '
        Me.object_text_comment.Location = New System.Drawing.Point(472, 153)
        Me.object_text_comment.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_comment.Name = "object_text_comment"
        Me.object_text_comment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_comment.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_comment.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_comment.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_text_comment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_comment.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_comment.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_comment.Properties.Appearance.Options.UseFont = True
        Me.object_text_comment.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_comment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_comment.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_comment.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_comment.Size = New System.Drawing.Size(364, 158)
        Me.object_text_comment.TabIndex = 5
        Me.object_text_comment.Tag = "Comentarios"
        '
        'object_label_information
        '
        Me.object_label_information.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_information.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_information.Appearance.Options.UseFont = True
        Me.object_label_information.Appearance.Options.UseForeColor = True
        Me.object_label_information.Location = New System.Drawing.Point(48, 68)
        Me.object_label_information.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_information.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_information.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_information.Name = "object_label_information"
        Me.object_label_information.Size = New System.Drawing.Size(232, 18)
        Me.object_label_information.TabIndex = 0
        Me.object_label_information.Text = "Los campos marcados con asterico (*) son requeridos..."
        '
        'comercial_customer_transfered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "comercial_customer_transfered"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(880, 447)
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_listed_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        CType(Me.object_text_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_dates.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_dates.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_listed_agency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_comment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents object_component_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents object_panel_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents object_button_saved As Button
    Friend WithEvents object_label_person As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_listed_person As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_sellers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents object_label_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_text_amount As APDA.Object.Controls.TextboxEdit
    Friend WithEvents object_label_dates As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_text_dates As APDA.Object.Controls.TextboxDates
    Friend WithEvents object_listed_agency As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents lbl_attention_desc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_agency As DevExpress.XtraEditors.LabelControl
    Private WithEvents object_text_comment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents object_label_information As DevExpress.XtraEditors.LabelControl
End Class
