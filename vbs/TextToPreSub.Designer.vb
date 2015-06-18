<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextToPreSub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextToPreSub))
        Me.BtnStrip = New System.Windows.Forms.ToolStrip
        Me.tsbtn_open = New System.Windows.Forms.ToolStripButton
        Me.tsbtn_save = New System.Windows.Forms.ToolStripButton
        Me.tsbtn_validate = New System.Windows.Forms.ToolStripButton
        Me.tsbtn_help = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.lbl_info = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_error = New System.Windows.Forms.ToolStripStatusLabel
        Me.sc1_rtb_btns = New System.Windows.Forms.SplitContainer
        Me.rtb_text = New System.Windows.Forms.RichTextBox
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.ttCont = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.sc1_rtb_btns.Panel1.SuspendLayout()
        Me.sc1_rtb_btns.Panel2.SuspendLayout()
        Me.sc1_rtb_btns.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnStrip
        '
        Me.BtnStrip.AutoSize = False
        Me.BtnStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtn_open, Me.tsbtn_save, Me.tsbtn_validate, Me.tsbtn_help})
        Me.BtnStrip.Location = New System.Drawing.Point(0, 0)
        Me.BtnStrip.Name = "BtnStrip"
        Me.BtnStrip.Size = New System.Drawing.Size(592, 32)
        Me.BtnStrip.TabIndex = 0
        Me.BtnStrip.Text = "ButtonStrip"
        '
        'tsbtn_open
        '
        Me.tsbtn_open.Image = Global.SubtitleGen.My.Resources.Resources.txtOpen_26
        Me.tsbtn_open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtn_open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_open.Name = "tsbtn_open"
        Me.tsbtn_open.Size = New System.Drawing.Size(66, 29)
        Me.tsbtn_open.Text = "Open"
        '
        'tsbtn_save
        '
        Me.tsbtn_save.Image = Global.SubtitleGen.My.Resources.Resources.txtSave_26
        Me.tsbtn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_save.Name = "tsbtn_save"
        Me.tsbtn_save.Size = New System.Drawing.Size(61, 29)
        Me.tsbtn_save.Text = "Save"
        '
        'tsbtn_validate
        '
        Me.tsbtn_validate.Image = CType(resources.GetObject("tsbtn_validate.Image"), System.Drawing.Image)
        Me.tsbtn_validate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtn_validate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_validate.Name = "tsbtn_validate"
        Me.tsbtn_validate.Size = New System.Drawing.Size(79, 29)
        Me.tsbtn_validate.Text = "Validate"
        '
        'tsbtn_help
        '
        Me.tsbtn_help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtn_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtn_help.Image = Global.SubtitleGen.My.Resources.Resources.help_26
        Me.tsbtn_help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtn_help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_help.Name = "tsbtn_help"
        Me.tsbtn_help.Size = New System.Drawing.Size(30, 29)
        Me.tsbtn_help.Text = "Help"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_info, Me.lbl_error})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 571)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(592, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lbl_info
        '
        Me.lbl_info.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_info.Image = Global.SubtitleGen.My.Resources.Resources.info_26
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(44, 17)
        Me.lbl_info.Text = "Info"
        '
        'lbl_error
        '
        Me.lbl_error.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_error.Image = Global.SubtitleGen.My.Resources.Resources.error_128
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(48, 17)
        Me.lbl_error.Text = "Error"
        '
        'sc1_rtb_btns
        '
        Me.sc1_rtb_btns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sc1_rtb_btns.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.sc1_rtb_btns.IsSplitterFixed = True
        Me.sc1_rtb_btns.Location = New System.Drawing.Point(0, 32)
        Me.sc1_rtb_btns.Name = "sc1_rtb_btns"
        Me.sc1_rtb_btns.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'sc1_rtb_btns.Panel1
        '
        Me.sc1_rtb_btns.Panel1.Controls.Add(Me.rtb_text)
        '
        'sc1_rtb_btns.Panel2
        '
        Me.sc1_rtb_btns.Panel2.Controls.Add(Me.btn_cancel)
        Me.sc1_rtb_btns.Panel2.Controls.Add(Me.btn_ok)
        Me.sc1_rtb_btns.Size = New System.Drawing.Size(592, 539)
        Me.sc1_rtb_btns.SplitterDistance = 513
        Me.sc1_rtb_btns.SplitterWidth = 1
        Me.sc1_rtb_btns.TabIndex = 2
        '
        'rtb_text
        '
        Me.rtb_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_text.Location = New System.Drawing.Point(0, 0)
        Me.rtb_text.Name = "rtb_text"
        Me.rtb_text.Size = New System.Drawing.Size(592, 513)
        Me.rtb_text.TabIndex = 0
        Me.rtb_text.Text = "//Example text:"
        Me.rtb_text.WordWrap = False
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_cancel.Image = Global.SubtitleGen.My.Resources.Resources.x_12
        Me.btn_cancel.Location = New System.Drawing.Point(432, 0)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 25)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_ok.Image = Global.SubtitleGen.My.Resources.Resources.ok_12
        Me.btn_ok.Location = New System.Drawing.Point(512, 0)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(80, 25)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'TextToPreSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(592, 593)
        Me.Controls.Add(Me.sc1_rtb_btns)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.BtnStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = Global.SubtitleGen.My.Resources.Resources.txtBlank
        Me.MinimumSize = New System.Drawing.Size(600, 374)
        Me.Name = "TextToPreSub"
        Me.Text = "Text to pre-subtitles"
        Me.BtnStrip.ResumeLayout(False)
        Me.BtnStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.sc1_rtb_btns.Panel1.ResumeLayout(False)
        Me.sc1_rtb_btns.Panel2.ResumeLayout(False)
        Me.sc1_rtb_btns.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tsbtn_open As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_error As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsbtn_save As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtn_validate As System.Windows.Forms.ToolStripButton
    Friend WithEvents sc1_rtb_btns As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents ttCont As System.Windows.Forms.ToolTip
    Friend WithEvents tsbtn_help As System.Windows.Forms.ToolStripButton
    Friend WithEvents rtb_text As System.Windows.Forms.RichTextBox

End Class
