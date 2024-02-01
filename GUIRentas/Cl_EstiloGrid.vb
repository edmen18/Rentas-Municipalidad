Imports System.Windows.Forms
Imports System.Drawing

Public Class Cl_EstiloGrid

    Public Function AplicaStiloOrange(ByVal dgx As DataGridView)

        'Configurar opciones del DataGridView
        With dgx
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.Fixed3D
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        End With

        '1.- Estilo a la cabecera
        '
        Dim styEstiloHeader As New DataGridViewCellStyle
        With styEstiloHeader
            .BackColor = Color.FromArgb(245, 222, 179)
            .ForeColor = Color.FromArgb(30, 57, 95)
            .Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.BottomRight
        End With
        ' Aplicamos el estilo creado a la cabecera:
        dgx.ColumnHeadersDefaultCellStyle = styEstiloHeader

        '2.- Estilo para las celdas
        ' 
        Dim cellStyle As New DataGridViewCellStyle

        cellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgx.GridColor = Color.FromArgb(210, 180, 140)
        cellStyle.SelectionBackColor = Color.Khaki
        cellStyle.SelectionForeColor = Color.Black
        cellStyle.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        cellStyle.NullValue = "--"

        dgx.DefaultCellStyle = cellStyle

        ' Color de fondo de las celdas alternativas del control
        '
        cellStyle = New DataGridViewCellStyle

        dgx.AlternatingRowsDefaultCellStyle = cellStyle
        cellStyle.BackColor = Color.FromArgb(250, 239, 226)
        cellStyle.SelectionBackColor = Color.Khaki
        cellStyle.SelectionForeColor = Color.Black


        '---- Aca crearemos varios estilos pero por tipo de datos, para ser identificado en el Datagridview y su aplicacion:
        '4.- Definiendo formato por tipo de datos:
        ' Para tipo Texto: 
        Dim styleTexto As New DataGridViewCellStyle
        With styleTexto
            .Alignment = DataGridViewContentAlignment.MiddleLeft
            .WrapMode = DataGridViewTriState.False
        End With

        ' Para el tipo Fecha:
        Dim styleFecha As New DataGridViewCellStyle
        With styleFecha
            .Format = "dd/MM/yyyy"
            .NullValue = "Sin Fecha"
            .Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        'Para tipo Numericos:
        Dim styleInt As New DataGridViewCellStyle
        With styleInt
            .NullValue = "0"
            .Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        'Para tipo Decimales:
        Dim styleDec As New DataGridViewCellStyle
        With styleDec
            .Format = "#,##0.00"
            '.Format = "0,#.#0"
            .Alignment = DataGridViewContentAlignment.MiddleRight

        End With

        ' Comenzaremos recorriendo todas las columnas
        For Each dgColumn As DataGridViewColumn In dgx.Columns

            ' Por cada columna preguntamos si es del tipo string
            If dgColumn.ValueType Is GetType(String) Then
                ' Aplicamos a esta columna el estilo texto
                dgColumn.DefaultCellStyle = styleTexto
            End If

            'Preguntamos si es del tipo Fecha
            If dgColumn.ValueType Is GetType(DateTime) Then
                ' Aplicamos a esta columna el estilo Fecha
                dgColumn.DefaultCellStyle = styleFecha
                dgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If

            ' Preguntamos si es del tipo numerico
            If dgColumn.ValueType Is GetType(Integer) Then
                ' Aplicamos a esta columna el estilo numerico
                dgColumn.DefaultCellStyle = styleInt
            End If

            ' Preguntamos si es del tipo decimal
            If dgColumn.ValueType Is GetType(Decimal) Then
                ' Aplicamos a esta columna el estilo decimal
                dgColumn.DefaultCellStyle = styleDec
            End If
        Next
        Return dgx
    End Function

    Public Function AplicaStiloBlue(ByVal dgx As DataGridView)

        'Configurar opciones del DataGridView
        With dgx
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.Fixed3D
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        End With

        '1.- Estilo a la cabecera
        '
        Dim styEstiloHeader As New DataGridViewCellStyle
        With styEstiloHeader
            .BackColor = Color.FromArgb(193, 216, 247)
            .ForeColor = Color.FromArgb(30, 57, 95)
            .Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        ' Aplicamos el estilo creado a la cabecera:
        dgx.ColumnHeadersDefaultCellStyle = styEstiloHeader

        '2.- Estilo para las celdas
        ' 
        Dim cellStyle As New DataGridViewCellStyle

        cellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgx.GridColor = Color.FromArgb(99, 127, 196)
        'Seleccion
        cellStyle.SelectionBackColor = Color.FromArgb(141, 180, 226)
        cellStyle.SelectionForeColor = Color.White

        cellStyle.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        cellStyle.NullValue = "--"

        dgx.DefaultCellStyle = cellStyle

        ' Color de fondo de las celdas alternativas del control
        '
        cellStyle = New DataGridViewCellStyle

        dgx.AlternatingRowsDefaultCellStyle = cellStyle
        cellStyle.BackColor = Color.FromArgb(231, 242, 254)
        cellStyle.SelectionBackColor = Color.FromArgb(141, 180, 226)
        cellStyle.SelectionForeColor = Color.White


        '---- Aca crearemos varios estilos pero por tipo de datos, para ser identificado en el Datagridview y su aplicacion:
        '4.- Definiendo formato por tipo de datos:
        ' Para tipo Texto: 
        Dim styleTexto As New DataGridViewCellStyle
        With styleTexto
            .Alignment = DataGridViewContentAlignment.MiddleLeft
            .WrapMode = DataGridViewTriState.False
        End With

        ' Para el tipo Fecha:
        Dim styleFecha As New DataGridViewCellStyle
        With styleFecha
            .Format = "dd/MM/yyyy"
            .NullValue = "Sin Fecha"
            .Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        'Para tipo Numericos:
        Dim styleInt As New DataGridViewCellStyle
        With styleInt
            .NullValue = "0"
            .Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        'Para tipo Decimales:
        Dim styleDec As New DataGridViewCellStyle
        With styleDec
            .Format = "#,##0.00"
            '.Format = "0:#.##"
            .Alignment = DataGridViewContentAlignment.MiddleRight

        End With

        ' Comenzaremos recorriendo todas las columnas
        For Each dgColumn As DataGridViewColumn In dgx.Columns

            ' Por cada columna preguntamos si es del tipo string
            If dgColumn.ValueType Is GetType(String) Then
                ' Aplicamos a esta columna el estilo texto
                dgColumn.DefaultCellStyle = styleTexto
            End If

            'Preguntamos si es del tipo Fecha
            If dgColumn.ValueType Is GetType(DateTime) Then
                ' Aplicamos a esta columna el estilo Fecha
                dgColumn.DefaultCellStyle = styleFecha
                dgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If

            ' Preguntamos si es del tipo numerico
            If dgColumn.ValueType Is GetType(Integer) Then
                ' Aplicamos a esta columna el estilo numerico
                dgColumn.DefaultCellStyle = styleInt
            End If

            ' Preguntamos si es del tipo decimal
            If dgColumn.ValueType Is GetType(Decimal) Then
                ' Aplicamos a esta columna el estilo decimal
                dgColumn.DefaultCellStyle = styleDec
            End If
        Next
        Return dgx
    End Function



End Class
