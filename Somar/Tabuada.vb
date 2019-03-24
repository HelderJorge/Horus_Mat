Public Class Tabuada
    Private Sub BtnTabTxt_Click(sender As Object, e As EventArgs) Handles BtnTabTxt.Click
        Dim tabnum As Double = Val(InputBox("Digite o valor a tabuar", "Tabuada"))
        Dim Multi As Integer = InputBox("Digite um multiplo", "Tabuada")
        Dim i As Integer
        For i = 0 To Multi
            TxtTab.Text = TxtTab.Text & tabnum & " x " & i & " = " & i * tabnum & vbNewLine
        Next
    End Sub

    Private Sub BtnTabLB_Click(sender As Object, e As EventArgs) Handles BtnTabLB.Click
        Dim tabnum As Double = Val(InputBox("Digite o valor a tabuar", "Tabuada"))
        Dim Multi As Integer = InputBox("Digite um multiplo", "Tabuada")
        Dim i As Integer
        For i = 0 To Multi
            Dim obj As String = tabnum & " X " & i & " = " & tabnum * i
            LBoxTab.Items.Add(obj)
        Next
    End Sub



    Private Sub LblMenu_Click(sender As Object, e As EventArgs) Handles LblMenu.Click
        Me.Hide()
        MatMenu.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Dim escolha As String = InputBox("Qual deseja apagar? Digite TxBox ou LsBox")

        If escolha = "TxBox" Then
            TxtTab.Text = " "
        Else
            LBoxTab.Items.Clear()
        End If
    End Sub

    Private Sub Tabuada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub PerimetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerimetrosToolStripMenuItem.Click
        Me.Hide()
        Perimetros.Show()
    End Sub

    Private Sub NúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosToolStripMenuItem.Click
        Me.Hide()
        Números.Show()
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click
        MsgBox("Atenção! Usar (.) para casas decimais!", MsgBoxStyle.OkOnly, "Casas decimais")
    End Sub
End Class