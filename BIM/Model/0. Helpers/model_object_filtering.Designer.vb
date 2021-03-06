<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class model_object_filtering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(model_object_filtering))
        Me.object_panel_container = New DevExpress.XtraEditors.PanelControl()
        Me.object_button_saved = New System.Windows.Forms.Button()
        Me.object_label_title = New DevExpress.XtraEditors.LabelControl()
        Me.object_filtering_criteria = New APDA.[Object].Controls.TextboxFilter()
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.object_panel_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'object_panel_container
        '
        Me.object_panel_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_panel_container.Controls.Add(Me.object_filtering_criteria)
        Me.object_panel_container.Controls.Add(Me.object_button_saved)
        Me.object_panel_container.Controls.Add(Me.object_label_title)
        Me.object_panel_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.object_panel_container.Location = New System.Drawing.Point(1, 1)
        Me.object_panel_container.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_panel_container.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_panel_container.Margin = New System.Windows.Forms.Padding(0)
        Me.object_panel_container.Name = "object_panel_container"
        Me.object_panel_container.Padding = New System.Windows.Forms.Padding(1)
        Me.object_panel_container.Size = New System.Drawing.Size(798, 498)
        Me.object_panel_container.TabIndex = 1
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
        Me.object_button_saved.Location = New System.Drawing.Point(282, 420)
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
        'object_label_title
        '
        Me.object_label_title.Appearance.Font = New System.Drawing.Font("Open Sans Condensed Light", 21.0!)
        Me.object_label_title.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.object_label_title.Appearance.Options.UseFont = True
        Me.object_label_title.Appearance.Options.UseForeColor = True
        Me.object_label_title.Location = New System.Drawing.Point(304, 28)
        Me.object_label_title.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_label_title.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_label_title.Margin = New System.Windows.Forms.Padding(0)
        Me.object_label_title.Name = "object_label_title"
        Me.object_label_title.Size = New System.Drawing.Size(200, 38)
        Me.object_label_title.TabIndex = 0
        Me.object_label_title.Text = "Criterios de búsqueda"
        '
        'object_filtering_criteria
        '
        Me.object_filtering_criteria.Appearance.BackColor = System.Drawing.Color.White
        Me.object_filtering_criteria.Appearance.BackColor2 = System.Drawing.Color.White
        Me.object_filtering_criteria.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.object_filtering_criteria.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.object_filtering_criteria.Appearance.Options.UseBackColor = True
        Me.object_filtering_criteria.Appearance.Options.UseBorderColor = True
        Me.object_filtering_criteria.Appearance.Options.UseForeColor = True
        Me.object_filtering_criteria.AppearanceFieldNameColor = System.Drawing.Color.LightSeaGreen
        Me.object_filtering_criteria.AppearanceGroupOperatorColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.object_filtering_criteria.AppearanceOperatorColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.object_filtering_criteria.AppearanceTreeLine.BackColor = System.Drawing.Color.Silver
        Me.object_filtering_criteria.AppearanceTreeLine.BackColor2 = System.Drawing.Color.Silver
        Me.object_filtering_criteria.AppearanceTreeLine.BorderColor = System.Drawing.Color.Silver
        Me.object_filtering_criteria.AppearanceTreeLine.Options.UseBackColor = True
        Me.object_filtering_criteria.AppearanceTreeLine.Options.UseBorderColor = True
        Me.object_filtering_criteria.AppearanceValueColor = System.Drawing.Color.Black
        Me.object_filtering_criteria.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.object_filtering_criteria.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.object_filtering_criteria.Location = New System.Drawing.Point(62, 86)
        Me.object_filtering_criteria.LookAndFeel.SkinName = "Office 2019 White"
        Me.object_filtering_criteria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.object_filtering_criteria.Margin = New System.Windows.Forms.Padding(0)
        Me.object_filtering_criteria.MaxOperandsCount = 10
        Me.object_filtering_criteria.Name = "object_filtering_criteria"
        Me.object_filtering_criteria.Padding = New System.Windows.Forms.Padding(1)
        Me.object_filtering_criteria.ShowDateTimeFunctions = DevExpress.XtraEditors.DateTimeFunctionsShowMode.Advanced
        Me.object_filtering_criteria.ShowOperandTypeIcon = True
        Me.object_filtering_criteria.Size = New System.Drawing.Size(666, 316)
        Me.object_filtering_criteria.TabIndex = 1
        Me.object_filtering_criteria.Tag = "Condición"
        '
        'model_object_filtering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.object_panel_container)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "model_object_filtering"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(800, 500)
        CType(Me.object_panel_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.object_panel_container.ResumeLayout(False)
        Me.object_panel_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents object_panel_container As DevExpress.XtraEditors.PanelControl
    Friend WithEvents object_button_saved As Button
    Friend WithEvents object_label_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents object_filtering_criteria As APDA.Object.Controls.TextboxFilter
End Class
