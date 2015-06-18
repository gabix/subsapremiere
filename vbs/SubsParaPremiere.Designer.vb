<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubsParaPremiere
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.barr_abajo = New System.Windows.Forms.StatusStrip
        Me.lbl_info = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_error = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_help = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.btn_crear = New System.Windows.Forms.Button
        Me.btn_preview = New System.Windows.Forms.Button
        Me.btn_cargar = New System.Windows.Forms.Button
        Me.btn_guardar = New System.Windows.Forms.Button
        Me.btn_selCarpeta = New System.Windows.Forms.Button
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.btn_resetTags = New System.Windows.Forms.Button
        Me.rad_mas2personas = New System.Windows.Forms.RadioButton
        Me.rad_2personas = New System.Windows.Forms.RadioButton
        Me.panel_2personas = New System.Windows.Forms.Panel
        Me.cmb_col2 = New System.Windows.Forms.ComboBox
        Me.cmb_col1 = New System.Windows.Forms.ComboBox
        Me.lbl_color2 = New System.Windows.Forms.Label
        Me.lbl_color1 = New System.Windows.Forms.Label
        Me.panel_dgv = New System.Windows.Forms.Panel
        Me.dgv_tags = New System.Windows.Forms.DataGridView
        Me.col_tag = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_color = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.lbl_carpetaDestino = New System.Windows.Forms.Label
        Me.txt_carpDest = New System.Windows.Forms.TextBox
        Me.rtb_texto = New System.Windows.Forms.RichTextBox
        Me._toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.barr_abajo.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.panel_2personas.SuspendLayout()
        Me.panel_dgv.SuspendLayout()
        CType(Me.dgv_tags, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barr_abajo
        '
        Me.barr_abajo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_info, Me.lbl_error, Me.lbl_help})
        Me.barr_abajo.Location = New System.Drawing.Point(0, 614)
        Me.barr_abajo.Name = "barr_abajo"
        Me.barr_abajo.Padding = New System.Windows.Forms.Padding(1, 0, 17, 0)
        Me.barr_abajo.Size = New System.Drawing.Size(561, 22)
        Me.barr_abajo.TabIndex = 5
        Me.barr_abajo.Text = "Barra de información"
        '
        'lbl_info
        '
        Me.lbl_info.Image = Global.APremiere.My.Resources.Resources.comment_26
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(53, 17)
        Me.lbl_info.Text = "info..."
        '
        'lbl_error
        '
        Me.lbl_error.Image = Global.APremiere.My.Resources.Resources.error_rojo_26
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(57, 17)
        Me.lbl_error.Text = "error..."
        '
        'lbl_help
        '
        Me.lbl_help.Image = Global.APremiere.My.Resources.Resources.Help_128
        Me.lbl_help.Name = "lbl_help"
        Me.lbl_help.Size = New System.Drawing.Size(132, 17)
        Me.lbl_help.Text = "Ayuda con este error"
        Me.lbl_help.ToolTipText = "Muestra ayuda extra en relación al error actual."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1MinSize = 141
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rtb_texto)
        Me.SplitContainer1.Size = New System.Drawing.Size(561, 614)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.TabIndex = 6
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_crear)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_preview)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_cargar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_guardar)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_selCarpeta)
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lbl_carpetaDestino)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txt_carpDest)
        Me.SplitContainer2.Size = New System.Drawing.Size(561, 200)
        Me.SplitContainer2.SplitterDistance = 132
        Me.SplitContainer2.TabIndex = 0
        '
        'btn_crear
        '
        Me.btn_crear.AutoSize = True
        Me.btn_crear.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_crear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_crear.Image = Global.APremiere.My.Resources.Resources.Font_Type_26
        Me.btn_crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_crear.Location = New System.Drawing.Point(0, 141)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(132, 47)
        Me.btn_crear.TabIndex = 5
        Me.btn_crear.Text = "Generar los subtítulos"
        Me.btn_crear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_crear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me._toolTip.SetToolTip(Me.btn_crear, "Genera los subtítulos en la carpeta específicada.")
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'btn_preview
        '
        Me.btn_preview.AutoSize = True
        Me.btn_preview.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_preview.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_preview.Image = Global.APremiere.My.Resources.Resources.Preview_26
        Me.btn_preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_preview.Location = New System.Drawing.Point(0, 94)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(132, 47)
        Me.btn_preview.TabIndex = 4
        Me.btn_preview.Text = "Generar vista previa"
        Me.btn_preview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_preview.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me._toolTip.SetToolTip(Me.btn_preview, "Generar una vista previa de como quedarían los subtítulos antes de generarlos.")
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'btn_cargar
        '
        Me.btn_cargar.AutoSize = True
        Me.btn_cargar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_cargar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cargar.Image = Global.APremiere.My.Resources.Resources.Open_26
        Me.btn_cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar.Location = New System.Drawing.Point(0, 47)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(132, 47)
        Me.btn_cargar.TabIndex = 3
        Me.btn_cargar.Text = "Cargar texto"
        Me.btn_cargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me._toolTip.SetToolTip(Me.btn_cargar, "Cargue el fragmento desde un archivo.")
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.AutoSize = True
        Me.btn_guardar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_guardar.Image = Global.APremiere.My.Resources.Resources.Save_26
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(0, 0)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(132, 47)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar texto"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me._toolTip.SetToolTip(Me.btn_guardar, "Guardar el fragmento.")
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_selCarpeta
        '
        Me.btn_selCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_selCarpeta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selCarpeta.Location = New System.Drawing.Point(375, 4)
        Me.btn_selCarpeta.Name = "btn_selCarpeta"
        Me.btn_selCarpeta.Size = New System.Drawing.Size(38, 23)
        Me.btn_selCarpeta.TabIndex = 4
        Me.btn_selCarpeta.Text = "..."
        Me._toolTip.SetToolTip(Me.btn_selCarpeta, "Seleccione la carpeta de destino.")
        Me.btn_selCarpeta.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(5, 33)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_resetTags)
        Me.SplitContainer3.Panel1.Controls.Add(Me.rad_mas2personas)
        Me.SplitContainer3.Panel1.Controls.Add(Me.rad_2personas)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.panel_2personas)
        Me.SplitContainer3.Panel2.Controls.Add(Me.panel_dgv)
        Me.SplitContainer3.Size = New System.Drawing.Size(408, 166)
        Me.SplitContainer3.SplitterDistance = 26
        Me.SplitContainer3.SplitterWidth = 2
        Me.SplitContainer3.TabIndex = 3
        '
        'btn_resetTags
        '
        Me.btn_resetTags.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_resetTags.Location = New System.Drawing.Point(107, 0)
        Me.btn_resetTags.Name = "btn_resetTags"
        Me.btn_resetTags.Size = New System.Drawing.Size(146, 24)
        Me.btn_resetTags.TabIndex = 4
        Me.btn_resetTags.Text = "resetear tags"
        Me.btn_resetTags.UseVisualStyleBackColor = True
        '
        'rad_mas2personas
        '
        Me.rad_mas2personas.AutoSize = True
        Me.rad_mas2personas.Dock = System.Windows.Forms.DockStyle.Right
        Me.rad_mas2personas.Location = New System.Drawing.Point(274, 0)
        Me.rad_mas2personas.Name = "rad_mas2personas"
        Me.rad_mas2personas.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.rad_mas2personas.Size = New System.Drawing.Size(132, 24)
        Me.rad_mas2personas.TabIndex = 3
        Me.rad_mas2personas.Text = "más de 2 personas"
        Me._toolTip.SetToolTip(Me.rad_mas2personas, "Seleccione si hay más de 2 personas que hablan en el fragmento de texto.")
        Me.rad_mas2personas.UseVisualStyleBackColor = True
        '
        'rad_2personas
        '
        Me.rad_2personas.AutoSize = True
        Me.rad_2personas.Checked = True
        Me.rad_2personas.Dock = System.Windows.Forms.DockStyle.Left
        Me.rad_2personas.Location = New System.Drawing.Point(0, 0)
        Me.rad_2personas.Name = "rad_2personas"
        Me.rad_2personas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rad_2personas.Size = New System.Drawing.Size(91, 24)
        Me.rad_2personas.TabIndex = 2
        Me.rad_2personas.TabStop = True
        Me.rad_2personas.Text = "2 personas"
        Me._toolTip.SetToolTip(Me.rad_2personas, "Seleccione si hay solo 2 personas que hablan en el fragmento de texto.")
        Me.rad_2personas.UseVisualStyleBackColor = True
        '
        'panel_2personas
        '
        Me.panel_2personas.Controls.Add(Me.cmb_col2)
        Me.panel_2personas.Controls.Add(Me.cmb_col1)
        Me.panel_2personas.Controls.Add(Me.lbl_color2)
        Me.panel_2personas.Controls.Add(Me.lbl_color1)
        Me.panel_2personas.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_2personas.Location = New System.Drawing.Point(0, 0)
        Me.panel_2personas.Name = "panel_2personas"
        Me.panel_2personas.Size = New System.Drawing.Size(181, 136)
        Me.panel_2personas.TabIndex = 16
        '
        'cmb_col2
        '
        Me.cmb_col2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_col2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_col2.FormattingEnabled = True
        Me.cmb_col2.Location = New System.Drawing.Point(107, 42)
        Me.cmb_col2.Name = "cmb_col2"
        Me.cmb_col2.Size = New System.Drawing.Size(62, 23)
        Me.cmb_col2.TabIndex = 11
        '
        'cmb_col1
        '
        Me.cmb_col1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_col1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_col1.FormattingEnabled = True
        Me.cmb_col1.Location = New System.Drawing.Point(107, 11)
        Me.cmb_col1.Name = "cmb_col1"
        Me.cmb_col1.Size = New System.Drawing.Size(62, 23)
        Me.cmb_col1.TabIndex = 10
        '
        'lbl_color2
        '
        Me.lbl_color2.Location = New System.Drawing.Point(0, 42)
        Me.lbl_color2.Name = "lbl_color2"
        Me.lbl_color2.Size = New System.Drawing.Size(101, 23)
        Me.lbl_color2.TabIndex = 9
        Me.lbl_color2.Text = "2do Color:"
        Me.lbl_color2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_color1
        '
        Me.lbl_color1.Location = New System.Drawing.Point(0, 11)
        Me.lbl_color1.Name = "lbl_color1"
        Me.lbl_color1.Size = New System.Drawing.Size(101, 23)
        Me.lbl_color1.TabIndex = 8
        Me.lbl_color1.Text = "1er Color:"
        Me.lbl_color1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_dgv
        '
        Me.panel_dgv.Controls.Add(Me.dgv_tags)
        Me.panel_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_dgv.Location = New System.Drawing.Point(0, 0)
        Me.panel_dgv.Name = "panel_dgv"
        Me.panel_dgv.Size = New System.Drawing.Size(406, 136)
        Me.panel_dgv.TabIndex = 15
        '
        'dgv_tags
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tags.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tags.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_tag, Me.col_color})
        Me.dgv_tags.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tags.Location = New System.Drawing.Point(0, 0)
        Me.dgv_tags.Name = "dgv_tags"
        Me.dgv_tags.RowHeadersVisible = False
        Me.dgv_tags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_tags.Size = New System.Drawing.Size(406, 136)
        Me.dgv_tags.TabIndex = 0
        Me._toolTip.SetToolTip(Me.dgv_tags, "Ejempo: tag: <b> con color blanco. Cada vez que encuentre <b> sobre un párrafo se" & _
                " le asignará el color seleccionado al generar el subtítulo.")
        '
        'col_tag
        '
        Me.col_tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_tag.FillWeight = 80.0!
        Me.col_tag.HeaderText = "tag"
        Me.col_tag.Name = "col_tag"
        '
        'col_color
        '
        Me.col_color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_color.HeaderText = "color"
        Me.col_color.Name = "col_color"
        '
        'lbl_carpetaDestino
        '
        Me.lbl_carpetaDestino.AutoSize = True
        Me.lbl_carpetaDestino.Location = New System.Drawing.Point(2, 7)
        Me.lbl_carpetaDestino.Name = "lbl_carpetaDestino"
        Me.lbl_carpetaDestino.Size = New System.Drawing.Size(93, 15)
        Me.lbl_carpetaDestino.TabIndex = 1
        Me.lbl_carpetaDestino.Text = "Carpeta destino:"
        Me.lbl_carpetaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_carpDest
        '
        Me.txt_carpDest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_carpDest.Location = New System.Drawing.Point(101, 4)
        Me.txt_carpDest.Name = "txt_carpDest"
        Me.txt_carpDest.Size = New System.Drawing.Size(267, 23)
        Me.txt_carpDest.TabIndex = 0
        '
        'rtb_texto
        '
        Me.rtb_texto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_texto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rtb_texto.Location = New System.Drawing.Point(0, 0)
        Me.rtb_texto.Name = "rtb_texto"
        Me.rtb_texto.Size = New System.Drawing.Size(561, 410)
        Me.rtb_texto.TabIndex = 0
        Me.rtb_texto.Text = ""
        '
        'SubtitulosPremiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 636)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barr_abajo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = Global.APremiere.My.Resources.Resources.Font_Type
        Me.MinimumSize = New System.Drawing.Size(419, 380)
        Me.Name = "SubtitulosPremiere"
        Me.Text = "Subtitulador para Premiere"
        Me.barr_abajo.ResumeLayout(False)
        Me.barr_abajo.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.panel_2personas.ResumeLayout(False)
        Me.panel_dgv.ResumeLayout(False)
        CType(Me.dgv_tags, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barr_abajo As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_error As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents _toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_carpetaDestino As System.Windows.Forms.Label
    Friend WithEvents txt_carpDest As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents rad_mas2personas As System.Windows.Forms.RadioButton
    Friend WithEvents rad_2personas As System.Windows.Forms.RadioButton
    Friend WithEvents btn_selCarpeta As System.Windows.Forms.Button
    Friend WithEvents panel_2personas As System.Windows.Forms.Panel
    Friend WithEvents cmb_col2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_col1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_color2 As System.Windows.Forms.Label
    Friend WithEvents lbl_color1 As System.Windows.Forms.Label
    Friend WithEvents panel_dgv As System.Windows.Forms.Panel
    Friend WithEvents dgv_tags As System.Windows.Forms.DataGridView
    Friend WithEvents col_tag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_color As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents rtb_texto As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_help As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_resetTags As System.Windows.Forms.Button
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents btn_preview As System.Windows.Forms.Button
    Friend WithEvents btn_cargar As System.Windows.Forms.Button

End Class
