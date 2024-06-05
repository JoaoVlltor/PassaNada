Public Class frmTelaInicial

    Private Sub BtnVisitantes_Click(sender As Object, e As EventArgs) Handles BtnVisitantes.Click
        frmVisitantes.ShowDialog()
    End Sub

    Private Sub btnMoradores_Click(sender As Object, e As EventArgs) Handles btnMoradores.Click
        frmMoradores.ShowDialog()
    End Sub

    Private Sub VisitantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitantesToolStripMenuItem.Click
        frmVisitantes.ShowDialog()
    End Sub

    Private Sub MoradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem.Click
        frmMoradores.ShowDialog()
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        If MsgBox("Deseja realmente fechar o sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Fechar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As EventArgs) Handles btnHistorico.Click
        frmHistorico.ShowDialog()
    End Sub
End Class