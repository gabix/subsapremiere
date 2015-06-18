#Region "-------------------- commentarios y todo ----------------------"

#End Region

Imports MisLibrerias

Public Class MensagesDeError

#Region "-------------------- Atributos Generales ----------------------"
    Public Enum Idiomas
        Español
        Ingles
    End Enum

    Private _sinTags As String
    Private _tagInválido As String
    Private _carpDestNoExiste As String
    Private _carpDestNoEsValida As String
#End Region

#Region "-------------------- Propiedades ------------------------------"

    Public ReadOnly Property SinTags() As String
        Get
            Return _sinTags
        End Get
    End Property

    Public ReadOnly Property TagInválido() As String
        Get
            Return _tagInválido
        End Get
    End Property

    Public ReadOnly Property CarpDestNoExiste() As String
        Get
            Return _carpDestNoExiste
        End Get
    End Property

    Public ReadOnly Property CarpDestNoEsValida() As String
        Get
            Return _carpDestNoEsValida
        End Get
    End Property

#End Region

#Region "-------------------- Inicializadores --------------------------"

    Public Sub New()
        AsignaMsgs_esp()
    End Sub
    Public Sub New(ByVal Idioma As Idiomas)
        Select Case Idioma
            Case Idiomas.Español
                AsignaMsgs_esp()

            Case Idiomas.Ingles
                AsignaMsgs_ing()

            Case Else
                AsignaMsgs_esp()
        End Select
    End Sub

#End Region

#Region "-------------------- Métodos Públicos -------------------------"

#End Region

#Region "-------------------- Métodos Privados -------------------------"

    Private Sub AsignaMsgs_esp()

        _sinTags = _
                    "Al seleccionar que hay más de 2 personas que hablan en el texto, sobre cada párrafo (que representa todo el 'monólogo' de una persona) debe ir un tag." & Environment.NewLine & _
                    "Un ejemplo sería:" & Environment.NewLine & _
                    "   <b> (esto es un tag)" & Environment.NewLine & _
                    "   Ahora habla una persona." & Environment.NewLine & _
                    "" & Environment.NewLine & _
                    "   <a>" & Environment.NewLine & _
                    "   Ahora habla otra persona." & Environment.NewLine & _
                    "" & Environment.NewLine & _
                    "   <n>" & Environment.NewLine & _
                    "   Ahora habla una tercera persona." & Environment.NewLine & _
                    "" & Environment.NewLine & _
                    "Luego de ingresar los tags en el texto hay que 'declararlos' en lista, asignandole un color a cada tag." & Environment.NewLine & _
                    "Un ejemplo de como completar la lista sería:" & Environment.NewLine & _
                    "   1ra fila: 1ra columna: <b>, 2da columna: Blanco seleccionado" & Environment.NewLine & _
                    "   2da fila: 1ra columna: <a>, 2da columna: Amarillo seleccionado" & Environment.NewLine & _
                    "   3ra fila: 1ra columna: <n>, 2da columna: Naranja seleccionado"
        _tagInválido = _
                    "Los tags deben ser de 1 o dos letras de la 'a' a la 'z' y deben estar encerrados entre '<' y '>'." & Environment.NewLine & _
                    "También se diferencia de entre mayúsculas y minúsculas, <a> es distinto de <A>." & Environment.NewLine & _
                    "   Ejemplos de tags:   <a>, <z>, <VC>, <aO>, <O>, etc."

        _carpDestNoExiste = "La carpeta a la que quiere exportar los subtitulos no existe."

        _carpDestNoEsValida = "La carpeta a la que quiere exportar los subtitulos no es válida."

    End Sub

    Private Sub AsignaMsgs_ing()
    End Sub

#End Region

End Class

