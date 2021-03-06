<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial_customer_transfered
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comercial_customer_transfered))
        Me.object_component_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.object_listed_person = New APDA.[Object].Controls.ComboboxSearch()
        Me.dgv_sales_sellers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.object_panel_container = New DevExpress.XtraEditors.PanelControl()
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_label_person = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.object_label_information = New DevExpress.XtraEditors.LabelControl()
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_listed_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
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
        Me.object_listed_person.Location = New System.Drawing.Point(44, 168)
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
        Me.object_listed_person.Size = New System.Drawing.Size(480, 35)
        Me.object_listed_person.TabIndex = 1
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
        Me.object_panel_container.Controls.Add(Me.object_listed_person)
        Me.object_panel_container.Controls.Add(Me.object_button_saved)
        Me.object_panel_container.Controls.Add(Me.object_label_person)
        Me.object_panel_container.Controls.Add(Me.object_label_title)
        Me.object_panel_container.Controls.Add(Me.object_label_information)
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
        Me.object_button_saved.TabIndex = 2
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
        Me.object_label_person.Location = New System.Drawing.Point(44, 148)
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
        Me.object_label_title.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.object_label_title.Appearance.Options.UseFont = True
        Me.object_label_title.Appearance.Options.UseForeColor = True
        Me.object_label_title.Location = New System.Drawing.Point(243, 40)
        Me.object_label_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_title.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_title.Name = "object_label_title"
        Me.object_label_title.Size = New System.Drawing.Size(88, 38)
        Me.object_label_title.TabIndex = 0
        Me.object_label_title.Text = "Transferir"
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
        Me.Size = New System.Drawing.Size(580, 400)
        CType(Me.object_component_validate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_listed_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sales_sellers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents object_component_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents object_panel_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents object_button_saved As Button
    Friend WithEvents object_label_person As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_label_information As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_listed_person As APDA.Object.Controls.ComboboxSearch
    Friend WithEvents dgv_sales_sellers As DevExpress.XtraGrid.Views.Grid.GridView
End Class
