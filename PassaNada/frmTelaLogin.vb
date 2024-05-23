Public Class frmLogin
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limparFormulario()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
    End Sub

    Private Sub limparFormulario()
        txtEmail.Clear()
        txtSenha.Clear()
        txtEmail.Select()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim email As String = txtEmail.Text
        Dim senha As String = txtSenha.Text

        If email = "" Or senha = "" Then
            MsgBox("Por Favor preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Campo Obrigatório")
            limparFormulario()
        Else
            If email = "admin" And senha = "1234" Then
                Me.Visible = False
                frmTelaInicial.ShowDialog()
                Me.Visible = True
                limparFormulario()
            Else
                MsgBox("E-mail e/ou senha inválidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Dados incorretos")
                limparFormulario()
            End If
        End If

    End Sub
End Class
