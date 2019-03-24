Public Class Areas

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Hide()
        MatMenu.Show()
    End Sub

    Private Sub btnQuadrado_Click(sender As Object, e As EventArgs) Handles btnQuadrado.Click
        Dim l, a As Double
        txbQuad.Text = ""
        l = InputBox("Digite o valor do lado:", "Dados")
        a = Math.Round(l * l, 2)
        txbQuad.Text = "Área = lado x lado = " & a
        txbQuad.Show()
    End Sub

    Private Sub btnRetan_Click(sender As Object, e As EventArgs) Handles btnRetan.Click
        Dim l, c, a As Double
        txbRet.Text = ""
        l = InputBox("Digite o valor da largura:", "Dados")
        c = InputBox("Digite o valor do comprimento:", "Dados")
        a = Math.Round(l * c, 2)
        txbRet.Text = "Área = largura x comprimento = " & a
        txbRet.Show()
    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
        Dim b, h, a As Double
        txbTri.Text = ""
        b = InputBox("Digite o valor da base:", "Dados")
        h = InputBox("Digite o valor da altura:", "Dados")
        a = Math.Round(b * h / 2, 2)
        txbTri.Text = "Área = base x altura / 2 = " & a
        txbTri.Show()
    End Sub

    Private Sub Areas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Áreas - Força " & Entrada.utilizador & " !"
    End Sub

    Private Sub btnCirculo_Click(sender As Object, e As EventArgs) Handles btnCirculo.Click
        Dim r, pi, a As Double
        pi = 3.14159
        txbCirc.Text = ""
        r = InputBox("Digite o valor do raio:", "Dados")
        a = Math.Round(r * r * pi, 2)
        txbCirc.Text = "Área = pi x raio x raio = " & a
        txbCirc.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Me.Hide()
        Calculadora.Show()
    End Sub

    Private Sub TabuadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabuadasToolStripMenuItem.Click
        Me.Hide()
        Tabuada.Show()
    End Sub

    Private Sub PerimetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerimetrosToolStripMenuItem.Click
        Me.Hide()
        Perimetros.Show()
    End Sub

    Private Sub NúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosToolStripMenuItem.Click
        Me.Hide()
        Números.Show()
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click
        MsgBox("Atenção! Usar ( , ) para casas decimais", MsgBoxStyle.OkOnly, "Casas Decimais")
    End Sub
End Class