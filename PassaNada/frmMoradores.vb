Public Class frmMoradores
    Private Sub frmMoradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
    End Sub
    Private Sub limparFormulario()
        txtCod.Clear()
        txtResponsavel.Clear()
        txtCpf.Clear()
        txtWhatsapp.Clear()
        txtEmail.Clear()
        txtLogradouro.Clear()
        txtNumero.Clear()
        txtComplemento.Clear()
        txtBairro.Clear()
        txtCidade.Clear()
        cmbEstado.SelectedText = -1
        txtCep.Clear()
        txtResponsavel.Select()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        If MsgBox("Deseja criar um novo registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            limparFormulario()
        End If
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        If MsgBox("Deseja realmente fechar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Fechar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class