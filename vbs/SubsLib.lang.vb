#Region "-------------------- commentarios y todo ----------------------"

#End Region

Public Class lang

#Region "-------------------- Atributos Generales ----------------------"
    Public Enum IdiomasEnum
        Español
        English
        NotSet
    End Enum

    Private Shared _idiomas() As String

    Public Shared ReadOnly Property Idiomas() As String()
        Get
            ReDim _idiomas(1)
            _idiomas(0) = IdiomasEnum.English.ToString
            _idiomas(1) = IdiomasEnum.Español.ToString
            Return _idiomas
        End Get
    End Property

    Public Sub New(ByVal formName As String, ByVal idioma As IdiomasEnum)
        Select Case formName
            Case "TextToPreSub"
                Asigna_formTextToPreSub(idioma)

            Case "start"
                Asigna_formStart(idioma)

        End Select
    End Sub

#End Region

#Region "--- Form Start ---"

    Public formStart_Name As String
    Public formStart_btn_new As String
    Public formStart_btn_loadTxt As String
    Public formStart_btn_loadSub As String

    Private Sub Asigna_formStart(ByVal idioma As IdiomasEnum)
        Select Case idioma
            Case IdiomasEnum.English
                formStart_Name = "Start"
                formStart_btn_new = "Start from scratch"
                formStart_btn_loadTxt = "Import a txt to generate a presub"
                formStart_btn_loadSub = "Start working with a .presub or an existing subtitle file"
            Case IdiomasEnum.Español
                formStart_Name = "Inicio"
                formStart_btn_new = "Empezar de cero"
                formStart_btn_loadTxt = "Importar un texto para generar un .presub"
                formStart_btn_loadSub = "Empezar a trabajar con un .presub o un subtítulo existente"
        End Select
    End Sub

#End Region

#Region "--- Form TextToPreSub ---"

    Public formTextToPreSub_text As String
    Public formTextToPreSub_tsbtn_open As String
    Public formTextToPreSub_tsbtn_open_tt As String
    Public formTextToPreSub_tsbtn_save As String
    Public formTextToPreSub_tsbtn_save_tt As String
    Public formTextToPreSub_tsbtn_validate As String
    Public formTextToPreSub_tsbtn_validate_tt As String
    Public formTextToPreSub_tsbtn_help As String
    Public formTextToPreSub_tsbtn_help_tt As String
    Public formTextToPreSub_rtb_exampletext As String
    Public formTextToPreSub_rtb_text_tt As String
    Public formTextToPreSub_btn_ok As String
    Public formTextToPreSub_btn_ok_tt As String
    Public formTextToPreSub_btn_cancel As String
    Public formTextToPreSub_btn_cancel_tt As String

    Private Sub Asigna_formTextToPreSub(ByVal idioma As IdiomasEnum)
        Select Case idioma
            Case IdiomasEnum.English
                formTextToPreSub_text = "Text to pre-subtitles"
                formTextToPreSub_tsbtn_open = "Open"
                formTextToPreSub_tsbtn_open_tt = "Open a text file"
                formTextToPreSub_tsbtn_save = "Save"
                formTextToPreSub_tsbtn_save_tt = "Save as text file"
                formTextToPreSub_tsbtn_validate = "Validate"
                formTextToPreSub_tsbtn_validate_tt = "Validate to check for errors"
                formTextToPreSub_tsbtn_help = "Ayuda"
                formTextToPreSub_tsbtn_help_tt = "Ayuda"
                formTextToPreSub_rtb_exampletext = _
                                            "//Example text:" & Environment.NewLine & _
                                            "                                   //All text that follows a double slash will be ignored by the program." & Environment.NewLine & _
                                            "*                                  //Use the * symbol or any number (1, 2, 100) to make the program understand that new subtitle line/s are following" & Environment.NewLine & _
                                            "This is a subtitle line            //The subtitle line, these must be longer than 2 chars and shorter than 50 chars to be valid" & Environment.NewLine & _
                                            "                                   //Leave an empty line if that subtitle is finished" & Environment.NewLine & _
                                            Environment.NewLine & _
                                            "*" & Environment.NewLine & _
                                            "My second sub" & Environment.NewLine & _
                                            "that has 2 lines" & Environment.NewLine & _
                                            Environment.NewLine & _
                                            "*" & Environment.NewLine & _
                                            "This sub wont be valid" & Environment.NewLine & _
                                            "because it has" & Environment.NewLine & _
                                            "more than 3 lines                  //only 2 lines per subtitle are allowed"
                formTextToPreSub_rtb_text_tt = "Type, edit or paste your text to transform it later to pre-subtitles"
                formTextToPreSub_btn_ok = "Ok"
                formTextToPreSub_btn_ok_tt = "Accept text and create pre-subtitles"
                formTextToPreSub_btn_cancel = "Cancel"
                formTextToPreSub_btn_cancel_tt = "Cancel changes"

            Case IdiomasEnum.Español
                formTextToPreSub_text = "Texto a pre-subtítulo"
                formTextToPreSub_tsbtn_open = "Abrir"
                formTextToPreSub_tsbtn_open_tt = "Abrir un archivo de texto"
                formTextToPreSub_tsbtn_save = "Guradar"
                formTextToPreSub_tsbtn_save_tt = "Guardar como archivo de texto"
                formTextToPreSub_tsbtn_validate = "Validar"
                formTextToPreSub_tsbtn_validate_tt = "Validar para comprobar errores"
                formTextToPreSub_rtb_exampletext = _
                                            "//Texto de ejemplo:" & Environment.NewLine & _
                                            "                                   //Todo texto que siga después de una doble barra será ignorado" & Environment.NewLine & _
                                            "*                                  //Use el símbolo * o cualquier número (1, 2, 100) para hacer entender al programa que nuevas lineas de subtítulos vienen a continuación" & Environment.NewLine & _
                                            "Esto es una linea de subtítulo     //La linea de subtítulo, estas deben contener más de 2 y menos de 50 caracteres para ser válidas" & Environment.NewLine & _
                                            "                                   //Deje una linea vacia para separar entre subtítulos" & Environment.NewLine & _
                                            Environment.NewLine & _
                                            "*" & Environment.NewLine & _
                                            "Mi segundo subtítulo" & Environment.NewLine & _
                                            "que tiene 2 lineas" & Environment.NewLine & _
                                            Environment.NewLine & _
                                            "*" & Environment.NewLine & _
                                            "Este subtítulo NO sera válido" & Environment.NewLine & _
                                            "debido a que tiene" & Environment.NewLine & _
                                            "más de tres lineas                 //Solo 2 lineas por subtítulo están permitidas"
                formTextToPreSub_rtb_text_tt = "Escriba, edite o pegue su texto para transformarlo en pre-subtítulos"
                formTextToPreSub_btn_ok = "Ok"
                formTextToPreSub_btn_ok_tt = "Aceptar el texto y crear los pre-subtítulos"
                formTextToPreSub_btn_cancel = "Cancelar"
                formTextToPreSub_btn_cancel_tt = "Cancelar los cambios"

        End Select
    End Sub

#End Region

End Class



