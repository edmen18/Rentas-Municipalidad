Public Class Cl_EstiloListView
    Overloads Sub colorearListView(ByRef list As ListView)
        Dim i As Integer
        For i = 0 To list.Items.Count - 1
            If i = Int(i / 2) * 2 Then
                list.Items.Item(i).BackColor = Color.White
            Else
                list.Items.Item(i).BackColor = Color.FromArgb(220, 230, 241)
            End If
        Next
        list.FullRowSelect = True
    End Sub


    Overloads Sub colorearListView(ByRef listView As ListView, ByVal numColunmaApintar As Integer, ByVal color As Color)
        Dim i As Integer
        For i = 0 To listView.Items.Count - 1

            listView.Items(i).UseItemStyleForSubItems = False

            If i = Int(i / 2) * 2 Then
                listView.Items.Item(i).BackColor = color.White
            Else
                listView.Items.Item(i).BackColor = color.LightGoldenrodYellow
            End If

            If listView.Items(i).SubItems.Count > 1 Then
                listView.Items(i).SubItems(numColunmaApintar).BackColor = color
            End If

        Next
        listView.FullRowSelect = True
    End Sub

    Overloads Sub colorearListView(ByRef listView As System.Windows.Forms.ListView, ByVal ColunmaApintar1 As Integer, ByVal color1 As Color, ByVal ColunmaApintar2 As Integer, ByVal color2 As Color)
        Dim i As Integer
        For i = 0 To listView.Items.Count - 1

            listView.Items(i).UseItemStyleForSubItems = False

            If i = Int(i / 2) * 2 Then
                listView.Items.Item(i).BackColor = Color.White
            Else
                listView.Items.Item(i).BackColor = Color.LightGoldenrodYellow
            End If
            If listView.Items(i).SubItems.Count > 1 Then
                listView.Items(i).SubItems(ColunmaApintar1).BackColor = color1
                listView.Items(i).SubItems(ColunmaApintar2).BackColor = color2
            End If
        Next

        listView.FullRowSelect = True
    End Sub

    Sub AplicaColorTotales(ByRef listView As ListView, ByVal Columna As Integer, ByVal color As Color)
        Dim i As Integer
        For i = 0 To listView.Items.Count - 1
            listView.Items(i).UseItemStyleForSubItems = False
            If listView.Items(i).SubItems.Count > 1 Then
                listView.Items(i).SubItems(Columna).BackColor = color
            End If
            listView.Columns(Columna).TextAlign = HorizontalAlignment.Right
        Next
        listView.Refresh()
    End Sub

End Class
