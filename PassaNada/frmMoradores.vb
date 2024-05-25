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

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        If txtResponsavel.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Por favor, preencha os campos obrigatórios!", MsgBoxStyle.Information, "Campo obrigatório")
        Else
            Dim item As New ListViewItem

            With lsvDados.Items.Add(item)
                .Text = txtCod.Text
                .SubItems.Add(txtResponsavel.Text)
                .SubItems.Add(txtCpf.Text)
                .SubItems.Add(txtWhatsapp.Text)
                .SubItems.Add(txtEmail.Text)
            End With

            limparFormulario()
        End If
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.SelectedIndices(0) = "" Then
            txtCod.Text = lsvDados.SelectedItems(0).Text
            txtResponsavel.Text = lsvDados.SelectedItems(0).SubItems(1).Text
            txtCpf.Text = lsvDados.SelectedItems(0).SubItems(2).Text
            txtWhatsapp.Text = lsvDados.SelectedItems(0).SubItems(3).Text
            txtEmail.Text = lsvDados.SelectedItems(0).SubItems(4).Text



    End Sub

    Private Sub listarDados()
        Dim sql = "SELECT * FROM MORADOR ORDER BY RESPONSAVEL"

        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then

            While Not vgRegistros.EOF

                Dim item As New ListViewItem

                With lsvDados.Items.Add(item)
                    .Text = vgRegistros("PK_MORADOR").Value
                    .SubItems.Add(vgRegistros("RESPONSAVEL").Value)
                    .SubItems.Add(vgRegistros("CPF").Value)
                    .SubItems.Add(vgRegistros("WHATSAPP").Value)
                    .SubItems.Add(vgRegistros("EMAIL").Value)

                End With
                vgRegistros.MoveNext()
            End While

        End If

    End Sub
End Class