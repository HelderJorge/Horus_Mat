Public Class MatMenu
    Dim Calculadora1 As Calculadora
    Dim Geo1 As Geometria

    Private Sub BtnCalculadora_Click(sender As Object, e As EventArgs) Handles BtnCalculadora.Click
        'Me.Hide()
        Calculadora1 = New Calculadora
        Calculadora1.Show()
    End Sub

    Private Sub BtnTab_Click(sender As Object, e As EventArgs) Handles BtnTab.Click
        Me.Hide()
        Tabuada.Show()
    End Sub

    Private Sub BtnNumeros_Click(sender As Object, e As EventArgs) Handles BtnNumeros.Click

        Números.Show()
    End Sub

    Private Sub BtnGeo_Click(sender As Object, e As EventArgs) Handles BtnGeo.Click
        'Me.Hide()
        Geo1 = New Geometria()
        Geo1.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub MatMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MatMenu - Força " & Entrada.utilizador & " !"
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Me.Hide()
        Calculadora.Show()
    End Sub

    Private Sub ÁreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreasToolStripMenuItem.Click
        Me.Hide()
        Areas.Show()
    End Sub

    Private Sub PerímetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerímetrosToolStripMenuItem.Click
        Me.Hide()
        Perimetros.Show()
    End Sub

    Private Sub NúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosToolStripMenuItem.Click
        Me.Hide()
        Números.Show()
    End Sub

    Private Sub TabuadaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TabuadaToolStripMenuItem1.Click
        Me.Hide()
        Tabuada.Show()
    End Sub

    Private Sub lblArea_Click(sender As Object, e As EventArgs) Handles lblArea.Click

    End Sub
End Class