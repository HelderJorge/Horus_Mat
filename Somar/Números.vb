Public Class Números
    Dim Num As Números
    Private Sub LblLimpar_Click(sender As Object, e As EventArgs) Handles LblLimpar.Click
        Me.Hide()
        Num = New Números
        Num.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub BtnExec_Click(sender As Object, e As EventArgs) Handles BtnExec.Click
        Dim escolha As Integer = InputBox("Quantos números quer inserir:", "1ªEscolha")
        Dim i As Integer
        Dim contPar = 0, contImp = 0, contPos = 0, contNeg = 0, maior, menor As Integer
        For i = 1 To escolha
            Dim num As Integer = InputBox("Digite um número inteiro:", "Números")
            If num > 0 Then
                TxtPos.Text = TxtPos.Text & num & vbNewLine
                contPos = contPos + 1
                TxtContPos.Text = contPos
            ElseIf num < 0 Then
                TxtNeg.Text = TxtNeg.Text & num & vbNewLine
                contNeg = contNeg + 1
                TxtContNeg.Text = contNeg
            End If
            If num Mod 2 = 0 Then
                TxtPares.Text = TxtPares.Text & num & vbNewLine
                contPar = contPar + 1
                TxtContPar.Text = contPar
            Else
                TxtImp.Text = TxtImp.Text & num & vbNewLine
                contImp = contImp + 1
                TxtContImp.Text = contImp
            End If
            If i = 1 Then
                menor = num
                maior = num
            End If

            If num <= menor Then
                TxtMenor.Text = num
                menor = num
            End If
            If num >= maior Then
                TxtMaior.Text = num
                maior = num
            End If
        Next
    End Sub

    Private Sub Números_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TabuadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabuadaToolStripMenuItem.Click
        Me.Hide()
        Tabuada.Show()
    End Sub
End Class