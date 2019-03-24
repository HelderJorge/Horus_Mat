Public Class Geometria
    Private Sub BtnAreas_Click(sender As Object, e As EventArgs) Handles BtnAreas.Click
        Me.Hide()
        Areas.Show()
    End Sub

    Private Sub BtnPerimetros_Click(sender As Object, e As EventArgs) Handles BtnPerimetros.Click
        Me.Hide()
        Perimetros.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        MatMenu.Show()
    End Sub

    Private Sub Geometria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Geometria - Força " & Entrada.utilizador & " !"
    End Sub
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Me.Hide()
        Calculadora.Show()
    End Sub



    Private Sub NúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosToolStripMenuItem.Click
        Me.Hide()
        Números.Show()
    End Sub

    Private Sub TabuadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabuadaToolStripMenuItem.Click
        Me.Hide()
        Tabuada.Show()
    End Sub
End Class