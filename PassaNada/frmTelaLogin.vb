Imports System.ComponentModel

Public Class frmLogin
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limparFormulario()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
        conecta()
    End Sub

    Private Sub limparFormulario()
        txtEmail.Clear()
        txtSenha.Clear()
        txtEmail.Select()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim email As String = txtEmail.Text
        Dim senha As String = txtSenha.Text
        Dim sql As String

        If email = "" Or senha = "" Then
            MsgBox("Por Favor preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Campo Obrigatório")
            limparFormulario()
        Else
            sql = "
                SELECT PK_USUARIO, NOME FROM USUARIO 
                WHERE EMAIL = '" & email & "' AND SENHA = '" & senha & "'
            "

            vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vgRegistros.Open(sql, vgDados)

            If vgRegistros.RecordCount > 0 Then
                frmTelaInicial.ToolStripUsuario.Text = vgRegistros("NOME").Value
                vgRegistros.Close()
                Me.Visible = False
                frmTelaInicial.ShowDialog()
                Me.Visible = True
                limparFormulario()
            Else
                vgRegistros.Close()
                MsgBox("E-mail e/ou senha inválidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Dados incorretos")
                limparFormulario()
            End If
        End If

    End Sub
    Private Sub frmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        desconecta()
    End Sub
End Class
