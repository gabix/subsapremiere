Imports System.IO
Imports MisLibrerias
Imports System.Xml

Public Class SubtituloPremiere

#Region "--- atributos ---"

    Private Shared _maxCharsPorLinea As Integer = My.Application.MaxCharsPorLinea

    Private _linea1 As String
    Private _linea2 As String
    Private _color As String
    Private _posición As Integer
    Private _dosLineas As Boolean
    Private _nombreSubtitulo As String

    Private _preSub As String
#End Region

#Region "--- Propiedades ---"

    Public Property Linea1() As String
        Get
            Return _linea1
        End Get
        Set(ByVal value As String)
            _linea1 = value
        End Set
    End Property

    Public Property Linea2() As String
        Get
            Return _linea2
        End Get
        Set(ByVal value As String)
            _linea2 = value
        End Set
    End Property

    Public Shared ReadOnly Property MaxCharsPorLinea() As Integer
        Get
            Return _maxCharsPorLinea
        End Get
    End Property

    Public ReadOnly Property NombreSubtitulo() As String
        Get
            Return _nombreSubtitulo
        End Get
    End Property

    Public Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property

    Public Property Posición() As Integer
        Get
            Return _posición
        End Get
        Set(ByVal value As Integer)
            _posición = value
        End Set
    End Property

    Public ReadOnly Property DosLineas() As Boolean
        Get
            Return _dosLineas
        End Get
    End Property

    Public ReadOnly Property PreSub() As String
        Get
            Return _preSub
        End Get
    End Property

#End Region

#Region "--- init ---"

    Public Sub New(ByVal posición As Integer, ByVal col As String, ByVal lin1 As String, ByVal lin2 As String)

        _posición = posición
        _color = col
        _linea1 = lin1
        _linea2 = lin2
        _dosLineas = True
        GenerarNombre()
        GenerarPRESubtitulo()
    End Sub

    Public Sub New(ByVal posición As Integer, ByVal col As String, ByVal lin1 As String)
        _posición = posición
        _color = col
        _linea1 = lin1
        _dosLineas = False
        GenerarNombre()
        GenerarPRESubtitulo()
    End Sub

#End Region

#Region "--- Métodos privados ---"

    Private Sub GenerarNombre()
        Dim posAstr As String = Tipos.CeroALaIzquierda(_posición, 3)
        _nombreSubtitulo = posAstr & "_" & _color & ".prtl"
    End Sub

    Private Sub GenerarPRESubtitulo()
        If _dosLineas = True Then
            _preSub = _linea1 & Environment.NewLine & _linea2
        Else
            _preSub = _linea1
        End If
    End Sub

    Private Function TraeSubXColorYlineas(ByVal col_nom As String, ByVal DosLineas As Boolean) As String
        Dim retStr As String = String.Empty

        Dim c As New Colores
        Dim dt_col As DataTable = c.Dt_colores

        For Each r As DataRow In dt_col.Rows
            If r.Item("col_nom") = col_nom Then
                If _dosLineas = False Then
                    retStr = r.Item("col_1lineaPath").ToString()
                Else
                    retStr = r.Item("col_2lineasPath").ToString()
                End If
                Exit For
            End If
        Next

        Return retStr
    End Function

    Private Function XmlASalvo(ByVal str As String) As String
        str = str.Replace("<", "&lt;")
        str = str.Replace(">", "&gt;")
        Return str
    End Function

#End Region

#Region "--- Métodos públicos ---"

    Public Sub GenerarSubtitulo(ByVal carpetaDestino As String)
        Try
            Dim x As XmlDocument = New XmlDocument
            x.Load(TraeSubXColorYlineas(_color, DosLineas))

            Dim elem_TRstr As XmlNodeList = x.GetElementsByTagName("TRString")
            Dim elem_RunCount As XmlNodeList = x.GetElementsByTagName("CharacterAttributes")

            elem_TRstr(0).InnerXml = XmlASalvo(_linea1)
            elem_RunCount(0).Attributes.Item(0).InnerXml = CStr(_linea1.Length + 1)

            If DosLineas = True Then
                elem_TRstr(1).InnerXml = XmlASalvo(_linea2)
                elem_RunCount(1).Attributes.Item(0).InnerXml = CStr(_linea2.Length + 1)
            End If

            Dim arch As FileStream = New FileStream(carpetaDestino & "\" & _nombreSubtitulo, FileMode.Create, FileAccess.Write)

            Dim sw As New StreamWriter(arch, System.Text.Encoding.Unicode)

            For Each cha In x.InnerXml.ToCharArray
                sw.Write(cha)
            Next

            sw.Close()
            arch.Dispose()

        Catch ioNoDirEx As System.IO.DirectoryNotFoundException
            Paths.CrearDirectorio(carpetaDestino)
            GenerarSubtitulo(carpetaDestino)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

End Class
