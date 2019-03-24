Public Class Calculadora

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        TextResultado.Text = Val(TxtVal1.Text) + Val(TxtVal2.Text)
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        TextResultado.Text = Val(TxtVal1.Text) - Val(TxtVal2.Text)
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        TextResultado.Text = Val(TxtVal1.Text) * Val(TxtVal2.Text)
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        TextResultado.Text = Val(TxtVal1.Text) / Val(TxtVal2.Text)
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        TxtVal1.Text = ""
        TxtVal2.Text = ""
        TextResultado.Text = ""
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Hide()
        MatMenu.Show()
    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Calculadora - Força " & Entrada.utilizador & " !"
    End Sub



    Private Sub ÁreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreasToolStripMenuItem.Click
        Me.Hide()
        Areas.Show()
    End Sub

    Private Sub PerimetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerimetrosToolStripMenuItem.Click
        Me.Hide()
        Perimetros.Show()
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
        MsgBox("Atenção! Usar (.) para casas decimais!", MsgBoxStyle.OkOnly, "Casas decimais")
    End Sub
End Class