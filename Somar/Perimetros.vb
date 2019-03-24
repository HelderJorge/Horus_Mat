Public Class Perimetros
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Hide()
        MatMenu.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub btnQuadrado_Click(sender As Object, e As EventArgs) Handles btnQuadrado.Click
        Dim l, P As Double
        txbQuad.Text = ""
        l = InputBox("Digite o valor do lado:", "Dados")
        P = Math.Round(4 * l, 2)
        txbQuad.Text = "Perimetro = 4 x lado = " & P
        txbQuad.Show()

    End Sub

    Private Sub btnRetan_Click(sender As Object, e As EventArgs) Handles btnRetan.Click
        Dim l, c, p As Double
        TxbRet.Text = ""
        l = InputBox("Digite o valor da largura:", "Dados")
        c = InputBox("Digite o valor do comprimento:", "Dados")
        p = Math.Round(2 * l + 2 * c, 2)
        TxbRet.Text = "Perimetro = 2 x largura + 2 x comprimento = " & p
        TxbRet.Show()
    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
        Dim a, b, c, p As Double
        txbTri.Text = ""
        a = InputBox("Digite o valor da 1º lado:", "Dados")
        b = InputBox("Digite o valor da 2º lado:", "Dados")
        c = InputBox("Digite o valor da 3º lado:", "Dados")
        p = Math.Round(a + b + c, 2)
        txbTri.Text = "Perimetro = 1º lado + 2º lado + 3º lado = " & p
        txbTri.Show()
    End Sub

    Private Sub btnCirculo_Click(sender As Object, e As EventArgs) Handles btnCirculo.Click
        Dim r, pi, p As Double
        pi = 3.14159
        TxbCirc.Text = ""
        r = InputBox("Digite o valor do raio:", "Dados")
        p = Math.Round(2 * pi * r, 2)
        TxbCirc.Text = "Perimetro = 2 x pi x raio = " & p
        TxbCirc.Show()
    End Sub

    Private Sub Perimetros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " - Força " & Entrada.utilizador & " !"
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Me.Hide()
        Calculadora.Show()
    End Sub

    Private Sub ÁreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreasToolStripMenuItem.Click
        Me.Hide()
        Areas.Show()
    End Sub

    Private Sub NúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosToolStripMenuItem.Click
        Me.Hide()
        Números.Show()
    End Sub

    Private Sub TabuadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabuadaToolStripMenuItem.Click
        Me.Hide()
        Tabuada.Show()
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click
        MsgBox("Atenção! Usar ( , ) para casas decimais", MsgBoxStyle.OkOnly, "Casas Decimais")
    End Sub
End Class