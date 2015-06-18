Imports MisLibrerias

Public Class Colores

    Private _dt_colores As DataTable

    Public ReadOnly Property Dt_colores() As DataTable
        Get
            Return _dt_colores
        End Get
    End Property

    Public Sub New()
        _dt_colores = New DataTable

        Dim colId As DataColumn = New DataColumn("col_id")
        colId.DataType = System.Type.GetType("System.Int32")
        _dt_colores.Columns.Add(colId)

        Dim colNom As DataColumn = New DataColumn("col_nom")
        colNom.DataType = System.Type.GetType("System.String")
        _dt_colores.Columns.Add(colNom)

        Dim col1lineaPath As DataColumn = New DataColumn("col_1lineaPath")
        col1lineaPath.DataType = System.Type.GetType("System.String")
        _dt_colores.Columns.Add(col1lineaPath)

        Dim col2lineasPath As DataColumn = New DataColumn("col_2lineasPath")
        col2lineasPath.DataType = System.Type.GetType("System.String")
        _dt_colores.Columns.Add(col2lineasPath)

        Dim p As String = My.MyApplication.Config_instalDir & "\incluir\"

        Dim custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 0
        custRow.Item("col_nom") = "Amarillo"
        custRow.Item("col_1lineaPath") = p & "amarillo_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "amarillo_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 1
        custRow.Item("col_nom") = "Blanco"
        custRow.Item("col_1lineaPath") = p & "blanco_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "blanco_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 2
        custRow.Item("col_nom") = "Celeste"
        custRow.Item("col_1lineaPath") = p & "celeste_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "celeste_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 3
        custRow.Item("col_nom") = "VerdeClaro"
        custRow.Item("col_1lineaPath") = p & "verdeClaro_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "verdeClaro_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 4
        custRow.Item("col_nom") = "Naranja"
        custRow.Item("col_1lineaPath") = p & "naranja_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "naranja_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 5
        custRow.Item("col_nom") = "Rosa"
        custRow.Item("col_1lineaPath") = p & "rosa_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "rosa_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 6
        custRow.Item("col_nom") = "Lila"
        custRow.Item("col_1lineaPath") = p & "lila_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "lila_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 7
        custRow.Item("col_nom") = "AzulOscuro"
        custRow.Item("col_1lineaPath") = p & "azulOscuro_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "azulOscuro_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 8
        custRow.Item("col_nom") = "VerdeOscuro"
        custRow.Item("col_1lineaPath") = p & "verdeOscuro_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "verdeOscuro_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)

        custRow = _dt_colores.NewRow()
        custRow.Item("col_id") = 9
        custRow.Item("col_nom") = "Marron"
        custRow.Item("col_1lineaPath") = p & "marron_1linea.prtl"
        custRow.Item("col_2lineasPath") = p & "marron_2lineas.prtl"
        _dt_colores.Rows.Add(custRow)
    End Sub

End Class
