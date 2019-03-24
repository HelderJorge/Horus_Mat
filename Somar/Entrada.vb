Public Class Entrada

    Dim cont As Int16
    Public utilizador As String

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        utilizador = txbUti.Text
        If (txbUti.Text = "Mat" And txbPass.Text = "Ica") Then
            MsgBox("Bem-vindo ao Hórus_Mat!", MsgBoxStyle.OkOnly, "Hórus_Mat")
            Me.Hide()
            MatMenu.Show()
            cont = 0
        ElseIf cont < 2 Then
            MsgBox("Corrija os dados de entrada!", MsgBoxStyle.Exclamation, "Hórus_Mat")
            txbUti.Text = ""
            txbPass.Text = ""
            cont = cont + 1
        Else
            MsgBox("Só admitimos 2 erros de entrada!", MsgBoxStyle.OkOnly, "Hórus_Mat")
            End
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        MsgBox("Tem ainda " & (3 - cont) & " tentativas", , "Hórus_Mat")
    End Sub

    Private Sub txbUti_TextChanged(sender As Object, e As EventArgs) Handles txbUti.TextChanged
        If txbUti.Text = "Mat" Then
            Me.Width = 800
            PictureBox1.Visible() = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txbPass_TextChanged(sender As Object, e As EventArgs) Handles txbPass.TextChanged
        If txbPass.Text = "Ica" Then
            btnEntrar.Text = "Vamos Entrar!"
        End If
    End Sub
End Class