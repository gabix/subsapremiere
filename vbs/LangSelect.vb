Imports SubsLib.lang

Public Class LangSelect

    Private _lang_selected As IdiomasEnum

    Public ReadOnly Property Lang_selected() As IdiomasEnum
        Get

            Return _lang_selected
        End Get
    End Property


    Private Sub LangSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each l As String In Idiomas
            Me.cmb_langSelect.Items.Add(l)
        Next
        Me.cmb_langSelect.SelectedItem = Me.cmb_langSelect.Items(0)
    End Sub


    Private Sub btn_sel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_sel.Click
        If Not Me.cmb_langSelect.SelectedItem Is Nothing Then
            Select Case Me.cmb_langSelect.SelectedItem.ToString
                Case "Español"
                    _lang_selected = IdiomasEnum.Español
                Case "English"
                    _lang_selected = IdiomasEnum.English
            End Select
            Me.Close()
        End If
    End Sub

    Private Sub btn_sel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btn_sel.KeyPress
        If e.KeyChar = Keys.Enter.ToString Then
            If Not Me.cmb_langSelect.SelectedItem Is Nothing Then
                Select Case Me.cmb_langSelect.SelectedItem.ToString
                    Case "Español"
                        _lang_selected = IdiomasEnum.Español
                    Case "English"
                        _lang_selected = IdiomasEnum.English
                End Select
                Me.Close()
            End If
        End If
    End Sub



End Class