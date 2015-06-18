Imports System.IO
Imports MisMensajes
Imports MisLibrerias

Public Class SubsParaPremiere

#Region "--- atributos ---"

    Dim errMsg As New MensagesDeError
    Dim mxCh As Integer = My.Application.MaxCharsPorLinea

    Private _dt_colores As DataTable
    Private _actHelp As String = String.Empty

    Private Structure Tags
        Dim tag As String
        Dim colorAsoc As String
    End Structure

    Private Structure PreSubLinea
        Dim linea As String
        Dim color As String
    End Structure

    Dim _actTags() As Tags
    Dim _actCol As String
    Dim _despCol As String
    Dim _tempText As String

    Dim _cambiosEnRtb As Boolean = False
    Private _subs() As SubtituloPremiere
#End Region

#Region "--- Propiedades ---"

    Public ReadOnly Property Subs() As SubtituloPremiere()
        Get
            Return _subs
        End Get
    End Property

#End Region

#Region "--- init ---"

    Private Sub SubtitulosPremiere_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowInfo()
        ShowError()
        BtnsEnabled(False)

        Me.panel_2personas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_dgv.Dock = System.Windows.Forms.DockStyle.Fill

        Dim c As New Colores
        _dt_colores = c.Dt_colores

        LlenarCmbs_colores()
        LlenarDgv_tags()
        Panel2PersonasEnabled(True)
    End Sub

#End Region

#Region "--- Métodos privados ---"

    Private Sub BtnsEnabled(ByVal enable As Boolean)
        Me.btn_crear.Enabled = enable
        Me.btn_guardar.Enabled = enable
        Me.btn_preview.Enabled = enable
    End Sub

    Private Sub BtnPrevORestituir(ByVal aPreview As Boolean)
        If aPreview Then
            Me.btn_preview.Text = "Generar vista previa"
            Me.btn_preview.Image = My.Resources.Preview_26
            Me._toolTip.SetToolTip(Me.btn_preview, "Generar una vista previa de como quedarían los subtítulos antes de generarlos.")

        Else
            Me.btn_preview.Text = "Restituir texto"
            Me.btn_preview.Image = My.Resources.HojaBack_26
            Me._toolTip.SetToolTip(Me.btn_preview, "Restituir el texto")
        End If
    End Sub

    Private Sub LlenarCmbs_colores()
        Dim tempDv As New DataView(_dt_colores)
        Me.lbl_color1.Text = "1er Color:"
        With Me.cmb_col1
            .DataSource = tempDv
            .ValueMember = "col_nom"
            .DisplayMember = "col_nom"
            .SelectedValue = "Blanco"
        End With

        tempDv = New DataView(_dt_colores)
        Me.lbl_color2.Text = "2do Color:"
        With Me.cmb_col2
            .DataSource = tempDv
            .ValueMember = "col_nom"
            .DisplayMember = "col_nom"
            .SelectedValue = "Amarillo"
        End With

    End Sub

    Private Sub LlenarDgv_tags()
        Dim tempDv As New DataView(_dt_colores)
        Me.col_color.DataSource = tempDv
        Me.col_color.ValueMember = "col_nom"
        Me.col_color.DisplayMember = "col_nom"

        If Not _actTags Is Nothing Then
            With Me.dgv_tags
                .Rows.Clear()

                For i = 0 To _actTags.Length - 1
                    .Rows.Add()
                    .Rows(i).Cells(0).Value = _actTags(i).tag
                    If _actTags(i).colorAsoc Is Nothing Or _actTags(i).colorAsoc = String.Empty Then
                        .Rows(i).Cells(1).Value = SuponerColorAPartirDeTag(_actTags(i).tag)
                    Else
                        .Rows(i).Cells(1).Value = _actTags(i).colorAsoc
                    End If
                Next
            End With
        End If
    End Sub

    Private Sub Panel2PersonasEnabled(ByVal enable As Boolean)
        If enable = True Then
            Me.panel_2personas.Visible = True
            Me.panel_2personas.Enabled = True

            Me.panel_dgv.Visible = False
            Me.panel_dgv.Enabled = False
        Else
            LlenarDgv_tags()
            Me.panel_2personas.Visible = False
            Me.panel_2personas.Enabled = False

            Me.panel_dgv.Enabled = True
            Me.panel_dgv.Visible = True
        End If


    End Sub

    Private Function SeleccionarCarpetaDestino() As Boolean
        Dim folBrowDiag As New FolderBrowserDialog

        folBrowDiag.Description = "Seleccionar la carpeta de destino para los subtitulos."
        folBrowDiag.SelectedPath = My.Application.Config_carpetaSeleccionada

        Dim res As DialogResult = folBrowDiag.ShowDialog()

        If res = MsgBoxResult.Ok Then
            Me.txt_carpDest.Text = folBrowDiag.SelectedPath
            My.Application.Config_carpetaSeleccionada = folBrowDiag.SelectedPath
            folBrowDiag.Dispose()
            Return True
        Else
            folBrowDiag.Dispose()
            Return False
        End If

    End Function

#End Region

#Region "--- Eventos StatusBar ---"

    Public Sub ShowInfo(Optional ByVal infoStr As String = "")
        With Me.lbl_info

            If Not infoStr = String.Empty Then
                .Visible = True
                .Enabled = True
                .Text = infoStr

            Else
                .Visible = False
                .Enabled = False
                .Text = String.Empty

            End If
        End With
    End Sub

    Public Sub ShowError(Optional ByVal errorStr As String = "", Optional ByVal conHelp As String = "")
        With Me.lbl_error

            If Not errorStr = String.Empty Then
                .Enabled = True
                .Visible = True
                .Text = errorStr

            Else
                .Visible = False
                .Enabled = False
                .Text = String.Empty

            End If
        End With

        With Me.lbl_help
            If Not conHelp = String.Empty Then
                .Enabled = True
                .Visible = True
                _actHelp = conHelp

            Else
                .Visible = False
                .Enabled = False
                _actHelp = String.Empty

            End If
        End With
    End Sub

    Public Sub ShowErrorConMsgBox(ByVal errorStr As String)
        With Me.lbl_error

            If Not errorStr = String.Empty Then
                .Visible = True
                .Enabled = True
                .Text = errorStr
                Dim msj As New Mensaje1btn(errorStr, "Planilla de días", Mensaje1btn.Mensaje1btnTipos.error_amarillo)
                msj.ShowDialog()
                msj.Dispose()

            Else
                .Visible = False
                .Enabled = False
                .Text = String.Empty

            End If
        End With
    End Sub

    Private Sub lbl_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_help.Click
        If Not _actHelp = String.Empty Then
            Dim msj As New Mensaje1btn(_actHelp, "Ayuda", Mensaje1btn.Mensaje1btnTipos.help, True)
            msj.ShowDialog()
            msj.Dispose()

        Else
            Me.lbl_help.Visible = False
            Me.lbl_help.Enabled = False
        End If
    End Sub

    Private Sub lbl_help_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_help.MouseHover
        Me.lbl_help.ForeColor = Color.Blue

    End Sub

    Private Sub lbl_help_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_help.MouseLeave
        Me.lbl_help.ForeColor = SystemColors.ControlText

    End Sub

#End Region

#Region "--- Eventos Botones ---"

    Private Sub btn_selCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selCarpeta.Click
        SeleccionarCarpetaDestino()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If Not Me.rtb_texto.Text = String.Empty Then

            Dim saveDiag As New SaveFileDialog
            With saveDiag
                .DefaultExt = ".rtf"
                .Filter = "Archivo de texto enriquecido (*.rtf)|*.rtf" & "|" & _
                          "Archivo de texto (*.txt)|*.txt"
                .AddExtension = True
                .InitialDirectory = My.Application.Config_carpetaDeGuardado
            End With

            Dim msjRes As DialogResult = saveDiag.ShowDialog()

            If (msjRes = MsgBoxResult.Ok) Then
                Try
                    Dim f As String = saveDiag.FileName
                    Dim ext As String = f.Substring(f.LastIndexOf(CChar(".")) + 1)

                    If ext = "txt" Then
                        Me.rtb_texto.SaveFile(f, RichTextBoxStreamType.PlainText)

                    ElseIf ext = "rtf" Then
                        Me.rtb_texto.SaveFile(f, RichTextBoxStreamType.RichText)

                    Else
                        Me.rtb_texto.SaveFile(f, RichTextBoxStreamType.UnicodePlainText)

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            saveDiag.Dispose()
        End If
    End Sub

    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        Dim opFiDiag As New OpenFileDialog
        With opFiDiag
            .Filter = "Todos los archivos aceptables (*.txt *.rtf)|*.txt;*.rtf" & "|" & _
                      "Archivo de texto (*.txt)|*.txt" & "|" & _
                      "Archivo de texto enriquecido (*.rtf)|*.rtf" & "|" & _
                      "Todos los archivos (*.*)|*.*"

            .InitialDirectory = My.Application.Config_carpetaDeGuardado
        End With

        Dim msjRes As DialogResult = opFiDiag.ShowDialog()

        If (msjRes = MsgBoxResult.Ok) Then
            Try
                Dim f As New FileInfo(opFiDiag.FileName)
                If f.Extension = ".txt" Then
                    Me.rtb_texto.LoadFile(f.FullName, RichTextBoxStreamType.PlainText)
                    _actTags = Nothing
                    CargarTagsEnTagsArray()

                ElseIf f.Extension = ".rtf" Then
                    Me.rtb_texto.LoadFile(f.FullName, RichTextBoxStreamType.RichText)

                Else
                    ShowErrorConMsgBox("El archivo no se puede abrir.")
                    _actTags = Nothing
                    CargarTagsEnTagsArray()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        opFiDiag.Dispose()
    End Sub

    Private Sub btn_resetTags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_resetTags.Click
        _actTags = Nothing
        CargarTagsEnTagsArray()
    End Sub

    Private Sub btn_preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preview.Click
        If Me.btn_preview.Text = "Generar vista previa" Then
            If ValidarPreSubear() = True Then
                GeneraSubtitulos(True)
            End If

            If Not _subs Is Nothing Then
                _tempText = Me.rtb_texto.Text
                Me.rtb_texto.BackColor = Color.Black
                Me.rtb_texto.Text = String.Empty

                For Each s As SubtituloPremiere In _subs
                    With Me.rtb_texto
                        .SelectionAlignment = HorizontalAlignment.Center
                        .SelectionColor = Color.DarkGray
                        .AppendText("--- subtítulo" & Tipos.CeroALaIzquierda(s.Posición, 3) & " ---" & Environment.NewLine)

                        .SelectionColor = Color.DarkGray
                        .SelectionFont = New System.Drawing.Font("Segoe UI", 9, FontStyle.Bold)
                        .AppendText(SuponerTagAPartirDeColor(s.Color) & Environment.NewLine)

                        .SelectionColor = Tipos.ColorAColor(s.Color)
                        .AppendText(s.Linea1 & Environment.NewLine)
                        If Not s.Linea2 Is Nothing Then
                            .SelectionColor = Tipos.ColorAColor(s.Color)
                            .AppendText(s.Linea2 & Environment.NewLine)
                        End If
                        .AppendText(Environment.NewLine)
                    End With
                Next

            End If

            BtnPrevORestituir(False)
        Else
            With Me.rtb_texto
                .Clear()
                .BackColor = SystemColors.Window
                .ForeColor = SystemColors.WindowText

                .SelectionAlignment = HorizontalAlignment.Left
                .SelectionColor = SystemColors.WindowText
                .SelectionFont = New System.Drawing.Font("Segoe UI", 9, FontStyle.Regular)

                Me.rtb_texto.Text = _tempText
            End With
            BtnPrevORestituir(True)
        End If




    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click
        Dim laCarpetaDestinoNoExiste As Boolean = False

        If Me.txt_carpDest.Text = String.Empty Then
            If Not SeleccionarCarpetaDestino() Then
                laCarpetaDestinoNoExiste = True
            End If
        Else
            If Not Paths.ExisteCarpeta(Me.txt_carpDest.Text) Then
                Try
                    Directory.CreateDirectory(Me.txt_carpDest.Text)
                Catch ex As Exception
                    laCarpetaDestinoNoExiste = True
                    ShowError(errMsg.CarpDestNoEsValida)
                    Me._toolTip.Show(errMsg.CarpDestNoEsValida, Me.txt_carpDest)
                End Try
            End If
        End If

        If Not laCarpetaDestinoNoExiste Then
            If ValidarPreSubear() = True Then
                GeneraSubtitulos(False)
            End If
        End If
    End Sub

#End Region

#Region "--- Eventos Otros ---"

    Private Sub rad_2personas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_2personas.CheckedChanged
        Panel2PersonasEnabled(Me.rad_2personas.Checked)
    End Sub

    Private Sub rtb_texto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb_texto.TextChanged
        'If Me.rtb_texto.Focused = True Then
        _cambiosEnRtb = True
        If (Me.rtb_texto.Text Is Nothing Or Me.rtb_texto.Text = String.Empty) Then
            BtnsEnabled(False)
            _actTags = Nothing

        Else
            BtnsEnabled(True)
            CargarTagsEnTagsArray()

        End If
        'End If
    End Sub

#End Region

#Region "--- Métodos Lógica ---"

    Private Function ValidarPreSubear() As Boolean
        _actCol = String.Empty
        _despCol = String.Empty

        ShowInfo()
        ShowError()

        Dim retBool As Boolean = True

        If Me.rad_mas2personas.Checked = True Then
            If _actTags Is Nothing Then
                ShowError("El texto ingresado no contiene tags de color.", errMsg.SinTags)
                _toolTip.Show("En modo de más de 2 personas se deben definir los tags de color", Me.rtb_texto)
                retBool = False

            Else
                retBool = CargarColoresAsocEnActTagsAPartorDeDgv_tags()
            End If


        ElseIf Me.rad_2personas.Checked = True Then

            If Not _actTags Is Nothing Then
                If _actTags.Length > 2 Then
                    ShowError("Hay más de 2 tags definidas en el texto, cambie el modo a más de 2 personas.")
                    _toolTip.Show("Modo para 2 o 1 persona.", Me.rad_2personas)
                    _toolTip.Show("Modo para más de 2 personas.", Me.rad_mas2personas)
                    retBool = False
                    Exit Function
                Else
                    If Me.cmb_col1.SelectedValue Is Nothing Or Me.cmb_col2.SelectedValue Is Nothing Then
                        ShowError("No hay ningún color seleccionado para generar los subtítulos.")
                        _toolTip.Show("Seleccione una opción", Me.cmb_col1)
                        _toolTip.Show("Seleccione una opción", Me.cmb_col2)
                        retBool = False
                        Exit Function
                    Else
                        _actTags(0).colorAsoc = Me.cmb_col1.SelectedValue.ToString
                        _actCol = Me.cmb_col1.SelectedValue.ToString
                    End If

                    If Me.cmb_col2.SelectedValue Is Nothing Then
                        ShowError("No hay ningún color seleccionado para generar los subtítulos.")
                        _toolTip.Show("Seleccione una opción", Me.cmb_col2)
                        retBool = False
                        Exit Function
                    Else
                        If Not _actTags(1).tag Is Nothing Then
                            _actTags(1).colorAsoc = Me.cmb_col2.SelectedValue.ToString
                            _despCol = Me.cmb_col2.SelectedValue.ToString
                        End If
                    End If
                End If
            Else
                If Me.cmb_col1.SelectedValue Is Nothing Or Me.cmb_col2.SelectedValue Is Nothing Then
                    ShowError("No hay ningún color seleccionado para generar los subtítulos.")
                    _toolTip.Show("Seleccione una opción", Me.cmb_col1)
                    _toolTip.Show("Seleccione una opción", Me.cmb_col2)
                    retBool = False
                    Exit Function
                Else
                    _actCol = Me.cmb_col1.SelectedValue.ToString
                    _despCol = Me.cmb_col2.SelectedValue.ToString
                End If

            End If
        End If

        Return retBool
    End Function

    Private Function ValidarTag(ByVal tag As String) As Boolean
        If (tag Like ("<[A-Za-z]>")) Or (tag Like ("<[A-Za-z][A-Za-z]>")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function SuponerColorAPartirDeTag(ByVal tag As String) As String
        Dim ret As String = "Blanco"
        Select Case tag.ToLower
            Case "<b>" : ret = "Blanco"
            Case "<a>" : ret = "Amarillo"
            Case "<c>" : ret = "Celeste"
            Case "<v>" : ret = "VerdeClaro"
            Case "<vc>" : ret = "VerdeClaro"
            Case "<n>" : ret = "Naranja"
            Case "<r>" : ret = "Rosa"
            Case "<l>" : ret = "Lila"
            Case "<ao>" : ret = "AzulOscuro"
            Case "<az>" : ret = "AzulOscuro"
            Case "<vo>" : ret = "VerdeOscuro"
            Case "<m>" : ret = "Marron"
        End Select
        Return ret
    End Function

    Private Function SuponerTagAPartirDeColor(ByVal Color As String) As String
        Dim ret As String = "<b>"
        Select Case Color
            Case "Blanco" : ret = "<b>"
            Case "Amarillo" : ret = "<a>"
            Case "Celeste" : ret = "<c>"
            Case "VerdeClaro" : ret = "<v>"
            Case "VerdeClaro" : ret = "<vc>"
            Case "Naranja" : ret = "<n>"
            Case "Rosa" : ret = "<r>"
            Case "Lila" : ret = "<l>"
            Case "AzulOscuro" : ret = "<ao>"
            Case "AzulOscuro" : ret = "<az>"
            Case "VerdeOscuro" : ret = "<vo>"
            Case "Marron" : ret = "<m>"
        End Select
        Return ret
    End Function

    Private Sub CargarTagsEnTagsArray()
        _actTags = Nothing
        Dim preFor() As String = Me.rtb_texto.Lines
        Dim i As Integer = -1
        Dim preTags() As String = Nothing

        For Each linea As String In preFor
            If linea Like ("<" & "[A-Za-z]" & ">") Then
                i += 1
                ReDim Preserve preTags(i)
                preTags(i) = linea.Substring(0, 3)
            ElseIf linea Like ("<[A-Za-z][A-Za-z]>") Then
                i += 1
                ReDim Preserve preTags(i)
                preTags(i) = linea.Substring(0, 4)
            End If
        Next

        If Not preTags Is Nothing Then
            Dim k As Integer = -1
            For j = 0 To preTags.Length - 1
                If _actTags Is Nothing Then
                    k += 1
                    ReDim Preserve _actTags(k)
                    _actTags(k).tag = preTags(j)

                Else
                    Dim existe As Boolean = False
                    For l = 0 To _actTags.Length - 1
                        If _actTags(l).tag = preTags(j) Then
                            existe = True
                            Exit For
                        End If
                    Next
                    If existe = False Then
                        k += 1
                        ReDim Preserve _actTags(k)
                        _actTags(k).tag = preTags(j)
                    End If
                End If
            Next
        End If


        If Not _actTags Is Nothing Then
            If _actTags.Length > 2 Then
                LlenarCmbs_colores()
                Me.rad_mas2personas.Checked = True
                LlenarDgv_tags()

            Else
                Me.rad_2personas.Checked = True
                _actTags(0).colorAsoc = Me.cmb_col1.SelectedValue.ToString
                Me.lbl_color1.Text = "Color de " & _actTags(0).tag
                If _actTags.Length > 1 Then
                    _actTags(1).colorAsoc = Me.cmb_col2.SelectedValue.ToString
                    Me.lbl_color2.Text = "Color de " & _actTags(1).tag
                End If
            End If
        End If
    End Sub

    Private Function CargarColoresAsocEnActTagsAPartorDeDgv_tags() As Boolean
        ShowError()
        ShowInfo()

        Dim todoOk As Boolean = True

        For Each row As DataGridViewRow In Me.dgv_tags.Rows
            If Not row.Cells(0).Value Is Nothing Then
                Dim tagValido As Boolean = ValidarTag(row.Cells(0).Value.ToString)
                If tagValido = True Then
                    For i = 0 To _actTags.Length - 1
                        If _actTags(i).tag = row.Cells(0).Value.ToString Then
                            If DirectCast(row.Cells(1), DataGridViewComboBoxCell).Value Is Nothing Then
                                ShowError("Un tag no tiene color asignado.")
                                _toolTip.Show("Seleccione una opción", row.Cells(1))
                                CargarColoresAsocEnActTagsAPartorDeDgv_tags = False
                                Exit Function
                            Else
                                _actTags(i).colorAsoc = DirectCast(row.Cells(1), DataGridViewComboBoxCell).Value.ToString
                                Exit For
                            End If
                        End If
                    Next
                Else
                    ShowError("El tag es inválido.", errMsg.TagInválido)
                    _toolTip.Show("Hay un tag mal escrito.", Me.dgv_tags)
                    CargarColoresAsocEnActTagsAPartorDeDgv_tags = False
                    Exit Function
                End If
            End If
        Next
        Return todoOk
    End Function

    Private Sub GeneraSubtitulos(ByVal esVistaPrevia As Boolean)
        If _cambiosEnRtb Then

            Dim _preSubsLineas() As PreSubLinea = GeneraPreSubs()
            _subs = GeneraSubs(_preSubsLineas)
            _cambiosEnRtb = False

            If Not _subs Is Nothing Then
                If esVistaPrevia Then
                    'genero vista previa

                Else
                    For Each _sub As SubtituloPremiere In _subs
                        _sub.GenerarSubtitulo(Me.txt_carpDest.Text)

                    Next
                End If
            End If
        End If
    End Sub

    Private Function GeneraPreSubs() As PreSubLinea()
        Dim _preSubsLineas() As PreSubLinea = Nothing

        Dim yaCambioColor As Boolean = False

        Dim lineas() As String = Me.rtb_texto.Lines
        For Each linea As String In lineas
            'chequeo que la linea tenga alfa numéricos
            'no queremos subtitulos del estilo de ',' o cosas chotas, si permito '...'
            Dim tieneAlfaNum As Boolean = False
            If linea = "..." Then
                tieneAlfaNum = True
            ElseIf linea Like "--- subtítulo[0-9][0-9][0-9] ---" Then
                'saltea
            Else
                For Each cha As Char In linea.ToCharArray
                    If cha Like "[A-Za-z0-9]" Then
                        tieneAlfaNum = True
                        Exit For
                    End If
                Next
            End If

            If tieneAlfaNum = True Then
                'chequeo si la linea es un tag
                Dim esUnTag As Boolean = False
                If Not _actTags Is Nothing Then
                    For Each t As Tags In _actTags
                        'si es un tag declarado...
                        If linea = t.tag Then
                            'seteo el color actual a
                            _actCol = t.colorAsoc
                            esUnTag = True
                            Exit For
                        End If
                    Next
                End If

                'si no lo es, creo un nuevo PREsub
                If Not esUnTag Then
                    yaCambioColor = False

                    If Not _preSubsLineas Is Nothing Then
                        ReDim Preserve _preSubsLineas(_preSubsLineas.Length)
                    Else
                        ReDim Preserve _preSubsLineas(0)
                    End If

                    _preSubsLineas(_preSubsLineas.Length - 1).linea = linea
                    _preSubsLineas(_preSubsLineas.Length - 1).color = _actCol
                End If

            Else
                If Me.rad_2personas.Checked = True Then
                    'el yaCambioColor es para que dos lineas vacias consecutivas no cambien el color actual
                    If Not yaCambioColor Then
                        'invierte el color actual
                        Dim tempCol As String = _actCol
                        _actCol = _despCol
                        _despCol = tempCol

                        yaCambioColor = True
                        'else saltea la linea
                    End If
                    'else saltea la linea
                End If

            End If
        Next

        Return _preSubsLineas
    End Function

    Private Function GeneraSubs(ByVal preSubLineas() As PreSubLinea) As SubtituloPremiere()
        Dim subsDeGenerados() As SubtituloPremiere = Nothing
        Dim j As Integer = 0

        For i = 0 To preSubLineas.Length - 1
            Dim recortado As String() = Tipos.RecortarUnStringYHacerUnArray(preSubLineas(i).linea, mxCh, CChar(" "))

            If Not recortado Is Nothing Then
                For k = 0 To recortado.Length - 1
                    Try
                        Dim strUnido As String = recortado(k) & " " & recortado(k + 1)
                        Dim mitad As Integer = CInt(Int(strUnido.Length / 2))
                        Dim cortaAca As Integer = (strUnido.Substring(0, mitad)).LastIndexOf(CChar(" "))

                        Dim lin1 As String = strUnido.Substring(0, cortaAca + 1)
                        Dim lin2 As String = strUnido.Substring(cortaAca + 1, strUnido.Length - cortaAca - 1)


                        ReDim Preserve subsDeGenerados(j)
                        subsDeGenerados(j) = New SubtituloPremiere(j, preSubLineas(i).color, _
                                                                  lin1, lin2)
                        j += 1

                        k += 1

                    Catch outOfRange As IndexOutOfRangeException
                        ReDim Preserve subsDeGenerados(j)
                        subsDeGenerados(j) = New SubtituloPremiere(j, preSubLineas(i).color, recortado(k))
                        j += 1

                    Catch ex As Exception
                        MsgBox("La pucha che!")

                    End Try
                Next

            Else
                ReDim Preserve subsDeGenerados(j)
                subsDeGenerados(j) = New SubtituloPremiere(j, preSubLineas(i).color, preSubLineas(i).linea)
                j += 1
            End If


        Next

        ShowInfo("Subtitulos generados")
        Return subsDeGenerados
    End Function

#End Region

End Class
