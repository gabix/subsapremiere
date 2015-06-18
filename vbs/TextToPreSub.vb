#Region "--- commentarios y todo ---"

#End Region
Imports SubsLib

Public Class TextToPreSub

#Region "--- Atributos Generales ---"
    Dim lang As lang

    Dim pre_subs() As 

#End Region

#Region "--- Propiedades ---"

    Public rtb_text_input As String = String.Empty

#End Region

#Region "--- Inicializadores ---"

    'Private Sub New()
    '    InitializeComponent()

    '    Me.ShowInTaskbar = True
    'End Sub

    'Private Sub New(ByVal rtb_text As String)
    '    InitializeComponent()

    '    Me.ShowInTaskbar = False
    '    rtb_text_input = rtb_text
    'End Sub



    Private Sub TextToPreSub_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
                                                                    Handles Me.Load
        ShowInfo() : ShowError()

        lang = New lang(Me.Name, My.Application.Config_lang)
        LoadLang()
    End Sub


    Private Sub LoadLang()
        With lang
            Me.Text = .formTextToPreSub_text
            Me.tsbtn_open.Text = .formTextToPreSub_tsbtn_open
            Me.tsbtn_open.ToolTipText = .formTextToPreSub_tsbtn_open_tt
            Me.tsbtn_save.Text = .formTextToPreSub_tsbtn_save
            Me.tsbtn_save.ToolTipText = .formTextToPreSub_tsbtn_save_tt
            Me.tsbtn_validate.Text = .formTextToPreSub_tsbtn_validate
            Me.tsbtn_validate.ToolTipText = .formTextToPreSub_tsbtn_validate_tt
            Me.tsbtn_help.Text = .formTextToPreSub_tsbtn_help
            Me.tsbtn_help.ToolTipText = .formTextToPreSub_tsbtn_help_tt
            If rtb_text_input = String.Empty Then
                Me.rtb_text.Text = .formTextToPreSub_rtb_exampletext
            End If
            Me.ttCont.SetToolTip(Me.rtb_text, .formTextToPreSub_rtb_text_tt)
            Me.btn_ok.Text = .formTextToPreSub_btn_ok
            Me.ttCont.SetToolTip(Me.btn_ok, .formTextToPreSub_btn_ok_tt)
            Me.btn_cancel.Text = .formTextToPreSub_btn_cancel
            Me.ttCont.SetToolTip(Me.btn_cancel, .formTextToPreSub_btn_cancel_tt)
        End With
    End Sub

#End Region

#Region "--- Eventos Generales ---"

    Private Sub tsbtn_validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                                                    Handles tsbtn_validate.Click



    End Sub

#End Region

#Region "--- Métodos Públicos ---"

#End Region

#Region "--- Métodos Privados ---"

    Private Function Validar_rtb_text() As Boolean



    End Function

#End Region

#Region "--- Eventos de STATUS BAR ---"

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

    Public Sub ShowError(Optional ByVal errorStr As String = "")
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
    End Sub

    Public Sub ShowErrorConMsgBox(ByVal errorStr As String)
        With Me.lbl_error

            If Not errorStr = String.Empty Then
                .Visible = True
                .Enabled = True
                .Text = errorStr
                MsgBox(errorStr, MsgBoxStyle.Exclamation, Me.Text)
            Else
                .Visible = False
                .Enabled = False
                .Text = String.Empty

            End If
        End With
    End Sub

    Private Sub ToolTipAShowInfo(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                    Handles btn_cancel.MouseEnter, btn_ok.MouseEnter, tsbtn_help.MouseEnter, _
                                    tsbtn_open.MouseEnter, tsbtn_save.MouseEnter, tsbtn_validate.MouseEnter, _
                                    rtb_text.MouseEnter

        Try
            ShowInfo(ttCont.GetToolTip(DirectCast(sender, Control)))
        Catch ex As Exception
            ShowInfo()
        End Try
    End Sub

#End Region

End Class
