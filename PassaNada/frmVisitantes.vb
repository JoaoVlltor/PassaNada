Imports System.Data.SqlTypes

Public Class frmVisitantes
    Private Sub frmVisitantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
        listarMoradores()
    End Sub

    Private Sub limparFormulario()
        'Dados do Visitante'
        txtCod.Clear()
        txtVisitante.Clear()
        txtCpf.Clear()
        txtWhatsapp.Clear()
        txtVeiculo.Clear()

        'Dados do Morador'
        cmbMorador.SelectedIndex = -1
        txtWhatsappM.Clear()
        txtLogradouro.Clear()
        txtCep.Clear()
        txtCidade.Clear()
        txtComplemento.Clear()
        txtBairro.Clear()
        txtNumero.Clear()

    End Sub

    Private Sub listarMoradores()
        cmbMorador.Items.Clear()

        Dim sql As String
        sql = "SELECT(LPAD(PK_MORADOR, 5,0) || ' - ' || RESPONSAVEL) RESPONSAVEL FROM MORADOR ORDER BY RESPONSAVEL"

        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then
            While Not vgRegistros.EOF
                cmbMorador.Items.Add(vgRegistros("RESPONSAVEL").Value)
                vgRegistros.MoveNext()
            End While
        End If

        vgRegistros.Close()
    End Sub
    Private Sub mnSalvar_Click(sender As Object, e As EventArgs) Handles mnSalvar.Click
        If txtVisitante.Text = "" Or txtVeiculo.Text = "  -  " Or cmbMorador.Text = "" Then
            MsgBox("Por favor, preencha os campos obrigatórios!",
                MsgBoxStyle.Information, "campos obrigatórios")
        Else
            Dim sql As String
            Dim id_morador As Integer = CInt(Mid(cmbMorador.Text, 1, 5))
            sql = "
             INSERT INTO VISITANTE(VISITANTE,CPF,WHATSAPP,VEICULO,ID_MORADOR)
             VALUES(
             '" & txtVisitante.Text & "'
             '" & txtCpf.Text & "'
             '" & txtWhatsapp.Text & "'
             '" & txtVeiculo.Text & "'
             '" & id_morador & "'
             )
            "
        End If
    End Sub
End Class