<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class model_object_export
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(model_object_export))
        Me.pnl_object_container = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_object_info = New DevExpress.XtraEditors.LabelControl()
        Me.btn_object_accept = New System.Windows.Forms.Button()
        Me.lbl_object_export = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_object_export = New APDA.[Object].Controls.ComboboxEdit()
        Me.btn_object_cancel = New System.Windows.Forms.Button()
        Me.lbl_object_subtitle = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_object_title = New DevExpress.XtraEditors.LabelControl()
        Me.xvp_validate = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.xfs_path = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_object_container.SuspendLayout()
        CType(Me.cmb_object_export.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_object_container
        '
        Me.pnl_object_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_object_container.Controls.Add(Me.lbl_object_info)
        Me.pnl_object_container.Controls.Add(Me.btn_object_accept)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_export)
        Me.pnl_object_container.Controls.Add(Me.cmb_object_export)
        Me.pnl_object_container.Controls.Add(Me.btn_object_cancel)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_subtitle)
        Me.pnl_object_container.Controls.Add(Me.lbl_object_title)
        Me.pnl_object_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_object_container.Location = New System.Drawing.Point(1, 1)
        Me.pnl_object_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.pnl_object_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnl_object_container.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_object_container.Name = "pnl_object_container"
        Me.pnl_object_container.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_object_container.Size = New System.Drawing.Size(484, 482)
        Me.pnl_object_container.TabIndex = 0
        '
        'lbl_object_info
        '
        Me.lbl_object_info.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_info.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_info.Appearance.Options.UseFont = True
        Me.lbl_object_info.Appearance.Options.UseForeColor = True
        Me.lbl_object_info.Location = New System.Drawing.Point(41, 447)
        Me.lbl_object_info.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_info.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_info.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_info.Name = "lbl_object_info"
        Me.lbl_object_info.Size = New System.Drawing.Size(232, 18)
        Me.lbl_object_info.TabIndex = 0
        Me.lbl_object_info.Text = "Los campos marcados con asterico (*) son requeridos..."
        '
        'btn_object_accept
        '
        Me.btn_object_accept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_accept.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_accept.Font = New System.Drawing.Font("Open Sans Condensed Light", 20.0!)
        Me.btn_object_accept.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btn_object_accept.Location = New System.Drawing.Point(390, 432)
        Me.btn_object_accept.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_accept.Name = "btn_object_accept"
        Me.btn_object_accept.Size = New System.Drawing.Size(93, 49)
        Me.btn_object_accept.TabIndex = 0
        Me.btn_object_accept.TabStop = False
        Me.btn_object_accept.Text = "Aceptar"
        Me.btn_object_accept.UseVisualStyleBackColor = False
        '
        'lbl_object_export
        '
        Me.lbl_object_export.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_export.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_export.Appearance.Options.UseFont = True
        Me.lbl_object_export.Appearance.Options.UseForeColor = True
        Me.lbl_object_export.Location = New System.Drawing.Point(40, 208)
        Me.lbl_object_export.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_export.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_export.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_export.Name = "lbl_object_export"
        Me.lbl_object_export.Size = New System.Drawing.Size(189, 16)
        Me.lbl_object_export.TabIndex = 2
        Me.lbl_object_export.Text = "Selecciona el tipo de formato a exportar*"
        '
        'cmb_object_export
        '
        Me.xvp_validate.SetIconAlignment(Me.cmb_object_export, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.cmb_object_export.Location = New System.Drawing.Point(40, 228)
        Me.cmb_object_export.Margin = New System.Windows.Forms.Padding(0)
        Me.cmb_object_export.Name = "cmb_object_export"
        Me.cmb_object_export.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmb_object_export.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cmb_object_export.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_object_export.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmb_object_export.Properties.Appearance.Options.UseBackColor = True
        Me.cmb_object_export.Properties.Appearance.Options.UseBorderColor = True
        Me.cmb_object_export.Properties.Appearance.Options.UseForeColor = True
        Me.cmb_object_export.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_object_export.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmb_object_export.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cmb_object_export.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_object_export.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.cmb_object_export.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.cmb_object_export.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceDropDownHeader.BackColor2 = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceDropDownHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_object_export.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.cmb_object_export.Properties.AppearanceDropDownHeader.Options.UseBorderColor = True
        Me.cmb_object_export.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_object_export.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmb_object_export.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cmb_object_export.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.cmb_object_export.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_object_export.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmb_object_export.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cmb_object_export.Properties.AutoHeight = False
        Me.cmb_object_export.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmb_object_export.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_object_export.Properties.DropDownItemHeight = 30
        Me.cmb_object_export.Properties.LookAndFeel.SkinName = "Office 2019 White"
        Me.cmb_object_export.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmb_object_export.Properties.NullText = ""
        Me.cmb_object_export.Properties.ShowFooter = False
        Me.cmb_object_export.Properties.ShowHeader = False
        Me.cmb_object_export.Size = New System.Drawing.Size(400, 35)
        Me.cmb_object_export.TabIndex = 1
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo es requerido..."
        Me.xvp_validate.SetValidationRule(Me.cmb_object_export, ConditionValidationRule1)
        '
        'btn_object_cancel
        '
        Me.btn_object_cancel.BackColor = System.Drawing.Color.White
        Me.btn_object_cancel.CausesValidation = False
        Me.btn_object_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_object_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_object_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatAppearance.BorderSize = 0
        Me.btn_object_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_object_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_object_cancel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_object_cancel.ForeColor = System.Drawing.Color.DimGray
        Me.btn_object_cancel.Location = New System.Drawing.Point(452, 3)
        Me.btn_object_cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_object_cancel.Name = "btn_object_cancel"
        Me.btn_object_cancel.Size = New System.Drawing.Size(28, 31)
        Me.btn_object_cancel.TabIndex = 0
        Me.btn_object_cancel.TabStop = False
        Me.btn_object_cancel.Text = "X"
        Me.btn_object_cancel.UseVisualStyleBackColor = False
        '
        'lbl_object_subtitle
        '
        Me.lbl_object_subtitle.Appearance.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_subtitle.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_object_subtitle.Appearance.Options.UseFont = True
        Me.lbl_object_subtitle.Appearance.Options.UseForeColor = True
        Me.lbl_object_subtitle.Location = New System.Drawing.Point(41, 86)
        Me.lbl_object_subtitle.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_subtitle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_subtitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_subtitle.Name = "lbl_object_subtitle"
        Me.lbl_object_subtitle.Size = New System.Drawing.Size(266, 32)
        Me.lbl_object_subtitle.TabIndex = 0
        Me.lbl_object_subtitle.Text = "Exporta los datos seleccionados en la vista de resultados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a la ubicación selecci" &
    "onada"
        '
        'lbl_object_title
        '
        Me.lbl_object_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_object_title.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_object_title.Appearance.Options.UseFont = True
        Me.lbl_object_title.Appearance.Options.UseForeColor = True
        Me.lbl_object_title.Location = New System.Drawing.Point(39, 48)
        Me.lbl_object_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.lbl_object_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_object_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_object_title.Name = "lbl_object_title"
        Me.lbl_object_title.Size = New System.Drawing.Size(134, 38)
        Me.lbl_object_title.TabIndex = 0
        Me.lbl_object_title.Text = "Exportar Datos"
        '
        'xvp_validate
        '
        Me.xvp_validate.ValidateHiddenControls = False
        Me.xvp_validate.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'xfs_path
        '
        Me.xfs_path.Title = "Seleccionar Ubicación"
        '
        'model_object_export
        '
        Me.AcceptButton = Me.btn_object_accept
        Me.AccessibleName = ""
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Appearance.BorderColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btn_object_cancel
        Me.ClientSize = New System.Drawing.Size(486, 484)
        Me.Controls.Add(Me.pnl_object_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Icon = CType(resources.GetObject("model_object_export.IconOptions.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Office 2019 White"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "model_object_export"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Export Data"
        CType(Me.pnl_object_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_object_container.ResumeLayout(False)
        Me.pnl_object_container.PerformLayout()
        CType(Me.cmb_object_export.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xvp_validate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_object_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_object_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_object_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_object_cancel As Button
    Friend WithEvents lbl_object_export As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_object_export As APDA.Object.Controls.ComboboxEdit
    Friend WithEvents btn_object_accept As Button
    Friend WithEvents lbl_object_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents xvp_validate As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents xfs_path As DevExpress.XtraEditors.XtraSaveFileDialog
End Class
