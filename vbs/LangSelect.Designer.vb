<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LangSelect
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
        Me.cmb_langSelect = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_sel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmb_langSelect
        '
        Me.cmb_langSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_langSelect.FormattingEnabled = True
        Me.cmb_langSelect.Location = New System.Drawing.Point(143, 17)
        Me.cmb_langSelect.Name = "cmb_langSelect"
        Me.cmb_langSelect.Size = New System.Drawing.Size(177, 21)
        Me.cmb_langSelect.Sorted = True
        Me.cmb_langSelect.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose your language" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elija su idioma"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_sel
        '
        Me.btn_sel.Image = Global.SubtitleGen.My.Resources.Resources.ok_18
        Me.btn_sel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sel.Location = New System.Drawing.Point(326, 9)
        Me.btn_sel.Name = "btn_sel"
        Me.btn_sel.Size = New System.Drawing.Size(103, 37)
        Me.btn_sel.TabIndex = 2
        Me.btn_sel.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seleccionar"
        Me.btn_sel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sel.UseVisualStyleBackColor = True
        '
        'LangSelect
        '
        Me.AcceptButton = Me.btn_sel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 58)
        Me.Controls.Add(Me.btn_sel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_langSelect)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LangSelect"
        Me.Text = "Language selection"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_langSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_sel As System.Windows.Forms.Button
End Class
