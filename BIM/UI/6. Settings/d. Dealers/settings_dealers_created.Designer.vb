<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings_dealers_created
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
        Dim HunspellDictionary1 As DevExpress.XtraSpellChecker.HunspellDictionary = New DevExpress.XtraSpellChecker.HunspellDictionary()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings_dealers_created))
        Me.object_component_spelling = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        Me.object_text_description = New DevExpress.XtraEditors.MemoEdit()
        Me.object_component_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.object_listed_operator = New APDA.[Object].Controls.ComboboxEdit()
        Me.object_text_external = New DevExpress.XtraEditors.ButtonEdit()
        Me.object_text_name = New DevExpress.XtraEditors.ButtonEdit()
        Me.object_listed_agency = New APDA.[Object].Controls.ComboboxCheck()
        Me.object_panel_container = New DevExpress.XtraEditors.PanelControl()
        Me.object_label_operator = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_external = New DevExpress.XtraEditors.LabelControl()
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_check_form = New APDA.[Object].Controls.TextboxCheck()
        Me.object_label_description = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_name = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_agency = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_module = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_information = New DevExpress.XtraEditors.LabelControl()
        CType(Me.object_text_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_listed_operator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_external.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_text_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_listed_agency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
        CType(Me.object_check_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'object_component_spelling
        '
        Me.object_component_spelling.CheckAsYouTypeOptions.Color = System.Drawing.Color.LightSeaGreen
        Me.object_component_spelling.Culture = New System.Globalization.CultureInfo("es-CO")
        HunspellDictionary1.Culture = New System.Globalization.CultureInfo("es-CO")
        HunspellDictionary1.DictionaryPath = "C:\Users\Danny\Documents\Visual Studio 2015\APDA\BIM\BIM\Model\6. Database\Dictio" &
    "naries\es_CO.dic"
        HunspellDictionary1.GrammarPath = "C:\Users\Danny\Documents\Visual Studio 2015\APDA\BIM\BIM\Model\6. Database\Dictio" &
    "naries\es_CO.aff"
        Me.object_component_spelling.Dictionaries.Add(HunspellDictionary1)
        Me.object_component_spelling.LoadOnDemand = True
        Me.object_component_spelling.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_component_spelling.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_component_spelling.ParentContainer = Me.object_text_description
        Me.object_component_spelling.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.object_component_spelling.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'object_text_description
        '
        Me.object_component_validate.SetIconAlignment(Me.object_text_description, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.object_text_description.Location = New System.Drawing.Point(562, 189)
        Me.object_text_description.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_description.Name = "object_text_description"
        Me.object_text_description.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_description.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_description.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_description.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_text_description.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_description.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_description.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_description.Properties.Appearance.Options.UseFont = True
        Me.object_text_description.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_description.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_description.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_component_spelling.SetShowSpellCheckMenu(Me.object_text_description, True)
        Me.object_text_description.Size = New System.Drawing.Size(380, 158)
        Me.object_component_spelling.SetSpellCheckerOptions(Me.object_text_description, OptionsSpelling1)
        Me.object_text_description.TabIndex = 5
        Me.object_text_description.Tag = "Descripción"
        '
        'object_component_validate
        '
        Me.object_component_validate.ValidateHiddenControls = False
        Me.object_component_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'object_listed_operator
        '
        Me.object_listed_operator.Location = New System.Drawing.Point(303, 317)
        Me.object_listed_operator.Margin = New System.Windows.Forms.Padding(0)
        Me.object_listed_operator.Name = "object_listed_operator"
        Me.object_listed_operator.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_listed_operator.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_listed_operator.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_operator.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_listed_operator.Properties.Appearance.Options.UseBackColor = True
        Me.object_listed_operator.Properties.Appearance.Options.UseBorderColor = True
        Me.object_listed_operator.Properties.Appearance.Options.UseForeColor = True
        Me.object_listed_operator.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_operator.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.object_listed_operator.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.object_listed_operator.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_operator.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.object_listed_operator.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.object_listed_operator.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_operator.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.object_listed_operator.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.object_listed_operator.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_operator.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_listed_operator.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_listed_operator.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_listed_operator.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_operator.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_listed_operator.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_listed_operator.Properties.AutoHeight = False
        Me.object_listed_operator.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_listed_operator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.object_listed_operator.Properties.DropDownItemHeight = 30
        Me.object_listed_operator.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_listed_operator.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_listed_operator.Properties.NullText = ""
        Me.object_listed_operator.Properties.ShowFooter = False
        Me.object_listed_operator.Properties.ShowHeader = False
        Me.object_listed_operator.Size = New System.Drawing.Size(153, 30)
        Me.object_listed_operator.TabIndex = 4
        Me.object_listed_operator.Tag = "Operador"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_listed_operator, ConditionValidationRule1)
        '
        'object_text_external
        '
        Me.object_component_validate.SetIconAlignment(Me.object_text_external, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.object_text_external.Location = New System.Drawing.Point(76, 317)
        Me.object_text_external.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_external.Name = "object_text_external"
        Me.object_text_external.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_external.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_external.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_external.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_external.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_external.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_external.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_external.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_text_external.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_text_external.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_external.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_text_external.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_text_external.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_text_external.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_text_external.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_text_external.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_text_external.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_external.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_text_external.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_text_external.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_text_external.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_text_external.Properties.AutoHeight = False
        Me.object_text_external.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_external.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_external.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_external.Size = New System.Drawing.Size(218, 30)
        Me.object_text_external.TabIndex = 3
        Me.object_text_external.Tag = "Codigo"
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_text_external, ConditionValidationRule2)
        '
        'object_text_name
        '
        Me.object_component_validate.SetIconAlignment(Me.object_text_name, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.object_text_name.Location = New System.Drawing.Point(76, 189)
        Me.object_text_name.Margin = New System.Windows.Forms.Padding(0)
        Me.object_text_name.Name = "object_text_name"
        Me.object_text_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_text_name.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_text_name.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.object_text_name.Properties.Appearance.Options.UseBackColor = True
        Me.object_text_name.Properties.Appearance.Options.UseBorderColor = True
        Me.object_text_name.Properties.Appearance.Options.UseForeColor = True
        Me.object_text_name.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_text_name.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_text_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_name.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_text_name.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_text_name.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_text_name.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_text_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.object_text_name.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.object_text_name.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_text_name.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.object_text_name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.object_text_name.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.object_text_name.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.object_text_name.Properties.AutoHeight = False
        Me.object_text_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_text_name.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_text_name.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_text_name.Size = New System.Drawing.Size(380, 30)
        Me.object_text_name.TabIndex = 1
        Me.object_text_name.Tag = "Nombre"
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_text_name, ConditionValidationRule3)
        '
        'object_listed_agency
        '
        Me.object_listed_agency.EditValue = ""
        Me.object_listed_agency.Location = New System.Drawing.Point(76, 253)
        Me.object_listed_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.object_listed_agency.Name = "object_listed_agency"
        Me.object_listed_agency.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.Appearance.Options.UseBackColor = True
        Me.object_listed_agency.Properties.Appearance.Options.UseBorderColor = True
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
        Me.object_listed_agency.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.object_listed_agency.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_listed_agency.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.object_listed_agency.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.object_listed_agency.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.object_listed_agency.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.object_listed_agency.Properties.AutoHeight = False
        Me.object_listed_agency.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.object_listed_agency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.object_listed_agency.Properties.DropDownRows = 20
        Me.object_listed_agency.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_listed_agency.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_listed_agency.Size = New System.Drawing.Size(380, 30)
        Me.object_listed_agency.TabIndex = 2
        Me.object_listed_agency.Tag = "Agencias"
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "This value is not valid"
        Me.object_component_validate.SetValidationRule(Me.object_listed_agency, ConditionValidationRule4)
        '
        'object_panel_container
        '
        Me.object_panel_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_container.Controls.Add(Me.object_label_operator)
        Me.object_panel_container.Controls.Add(Me.object_listed_operator)
        Me.object_panel_container.Controls.Add(Me.object_text_external)
        Me.object_panel_container.Controls.Add(Me.object_label_external)
        Me.object_panel_container.Controls.Add(Me.object_button_saved)
        Me.object_panel_container.Controls.Add(Me.object_check_form)
        Me.object_panel_container.Controls.Add(Me.object_label_description)
        Me.object_panel_container.Controls.Add(Me.object_text_description)
        Me.object_panel_container.Controls.Add(Me.object_label_name)
        Me.object_panel_container.Controls.Add(Me.object_label_agency)
        Me.object_panel_container.Controls.Add(Me.object_text_name)
        Me.object_panel_container.Controls.Add(Me.object_label_module)
        Me.object_panel_container.Controls.Add(Me.object_label_information)
        Me.object_panel_container.Controls.Add(Me.object_listed_agency)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_container.Size = New System.Drawing.Size(1008, 548)
        Me.object_panel_container.TabIndex = 0
        '
        'object_label_operator
        '
        Me.object_label_operator.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_operator.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_operator.Appearance.Options.UseFont = True
        Me.object_label_operator.Appearance.Options.UseForeColor = True
        Me.object_label_operator.Location = New System.Drawing.Point(303, 297)
        Me.object_label_operator.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_operator.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_operator.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_operator.Name = "object_label_operator"
        Me.object_label_operator.Size = New System.Drawing.Size(50, 16)
        Me.object_label_operator.TabIndex = 0
        Me.object_label_operator.Text = "Operador*"
        '
        'object_label_external
        '
        Me.object_label_external.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_external.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_external.Appearance.Options.UseFont = True
        Me.object_label_external.Appearance.Options.UseForeColor = True
        Me.object_label_external.Location = New System.Drawing.Point(76, 297)
        Me.object_label_external.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_external.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_external.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_external.Name = "object_label_external"
        Me.object_label_external.Size = New System.Drawing.Size(103, 16)
        Me.object_label_external.TabIndex = 0
        Me.object_label_external.Text = "Código de referencia*"
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
        Me.object_button_saved.Location = New System.Drawing.Point(394, 441)
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
        'object_check_form
        '
        Me.object_check_form.Location = New System.Drawing.Point(676, 350)
        Me.object_check_form.Margin = New System.Windows.Forms.Padding(0)
        Me.object_check_form.Name = "object_check_form"
        Me.object_check_form.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_check_form.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_check_form.Properties.Appearance.Options.UseFont = True
        Me.object_check_form.Properties.Appearance.Options.UseForeColor = True
        Me.object_check_form.Properties.Appearance.Options.UseTextOptions = True
        Me.object_check_form.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.object_check_form.Properties.AutoHeight = False
        Me.object_check_form.Properties.Caption = "Desea conservar el formulario?"
        Me.object_check_form.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox
        Me.object_check_form.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.object_check_form.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_check_form.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_check_form.Size = New System.Drawing.Size(266, 22)
        Me.object_check_form.TabIndex = 6
        Me.object_check_form.Tag = ""
        '
        'object_label_description
        '
        Me.object_label_description.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_description.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_description.Appearance.Options.UseFont = True
        Me.object_label_description.Appearance.Options.UseForeColor = True
        Me.object_label_description.Location = New System.Drawing.Point(562, 169)
        Me.object_label_description.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_description.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_description.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_description.Name = "object_label_description"
        Me.object_label_description.Size = New System.Drawing.Size(132, 16)
        Me.object_label_description.TabIndex = 0
        Me.object_label_description.Text = "Descripción y/o comentarios"
        '
        'object_label_name
        '
        Me.object_label_name.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_name.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_name.Appearance.Options.UseFont = True
        Me.object_label_name.Appearance.Options.UseForeColor = True
        Me.object_label_name.Location = New System.Drawing.Point(76, 169)
        Me.object_label_name.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_name.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_name.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_name.Name = "object_label_name"
        Me.object_label_name.Size = New System.Drawing.Size(224, 16)
        Me.object_label_name.TabIndex = 0
        Me.object_label_name.Text = "Defina el nombre del distribuidor y/o plataforma*"
        '
        'object_label_agency
        '
        Me.object_label_agency.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_agency.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_label_agency.Appearance.Options.UseFont = True
        Me.object_label_agency.Appearance.Options.UseForeColor = True
        Me.object_label_agency.Location = New System.Drawing.Point(76, 233)
        Me.object_label_agency.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_agency.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_agency.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_agency.Name = "object_label_agency"
        Me.object_label_agency.Size = New System.Drawing.Size(228, 16)
        Me.object_label_agency.TabIndex = 0
        Me.object_label_agency.Text = "Seleccione las agencias a mostrar el distribuidor*"
        '
        'object_label_module
        '
        Me.object_label_module.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_module.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.object_label_module.Appearance.Options.UseFont = True
        Me.object_label_module.Appearance.Options.UseForeColor = True
        Me.object_label_module.Appearance.Options.UseTextOptions = True
        Me.object_label_module.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.object_label_module.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.object_label_module.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_label_module.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.object_label_module.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.object_label_module.Location = New System.Drawing.Point(75, 45)
        Me.object_label_module.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_module.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_module.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_module.Name = "object_label_module"
        Me.object_label_module.Size = New System.Drawing.Size(154, 37)
        Me.object_label_module.TabIndex = 0
        Me.object_label_module.Text = "Crear Distribuidor"
        '
        'object_label_information
        '
        Me.object_label_information.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_label_information.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.object_label_information.Appearance.Options.UseFont = True
        Me.object_label_information.Appearance.Options.UseForeColor = True
        Me.object_label_information.Location = New System.Drawing.Point(76, 83)
        Me.object_label_information.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_information.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_information.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_information.Name = "object_label_information"
        Me.object_label_information.Size = New System.Drawing.Size(255, 16)
        Me.object_label_information.TabIndex = 0
        Me.object_label_information.Text = "Los campos marcados con asterico (*) son obligatorios"
        '
        'settings_dealers_created
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "settings_dealers_created"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(1010, 550)
        Me.Tag = "Crear Distribuidor"
        CType(Me.object_text_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_listed_operator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_external.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_text_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_listed_agency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        CType(Me.object_check_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents object_component_spelling As DevExpress.XtraSpellChecker.SpellChecker
    Friend WithEvents object_component_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents object_panel_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents object_label_external As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_button_saved As Button
    Friend WithEvents object_check_form As APDA.Object.Controls.TextboxCheck
    Friend WithEvents object_label_description As DevExpress.XtraEditors.LabelControl
    Private WithEvents object_text_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents object_label_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_agency As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_text_name As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents object_label_module As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_information As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_listed_agency As APDA.Object.Controls.ComboboxCheck
    Friend WithEvents object_text_external As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents object_label_operator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_listed_operator As APDA.Object.Controls.ComboboxEdit
End Class
