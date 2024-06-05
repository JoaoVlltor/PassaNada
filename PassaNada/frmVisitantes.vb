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
            Dim dataHoraAtual As DateTime = Now

            sql = "
             INSERT INTO VISITAS (VISITANTE, CPF, WHATSAPP, VEICULO, FK_MORADOR, DATA, HORA)
             VALUES (
             '" & txtVisitante.Text & "',
             '" & txtCpf.Text & "',
             '" & txtWhatsapp.Text & "',
             '" & txtVeiculo.Text & "',
             '" & id_morador & "',
             '" & Format(dataHoraAtual, "MM/dd/yyyy") & "',
             '" & dataHoraAtual.ToShortTimeString & "'
             )
            "
            vgDados.Execute(sql)

            MsgBox("Visitante registrado com sucesso!", MsgBoxStyle.Information, "SUCESSO")

            limparFormulario()
        End If
    End Sub

    Private Sub cmbMorador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMorador.SelectedValueChanged
        If cmbMorador.Text <> "" Then
            Dim id_morador As Integer = CInt(Mid(cmbMorador.Text, 1, 5))
            Dim sql As String

            sql = "SELECT WHATSAPP, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE FROM MORADOR WHERE PK_MORADOR = '" & id_morador & "' "

            vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vgRegistros.Open(sql, vgDados)

            If vgRegistros.RecordCount > 0 Then
                txtWhatsappM.Text = vgRegistros("WHATSAPP").Value
                txtLogradouro.Text = vgRegistros("LOGRADOURO").Value
                txtNumero.Text = vgRegistros("NUMERO").Value
                txtBairro.Text = vgRegistros("BAIRRO").Value
                txtCidade.Text = vgRegistros("CIDADE").Value
                txtComplemento.Text = vgRegistros("COMPLEMENTO").Value
            End If
            vgRegistros.Close()

        End If

    End Sub

    Private Sub mnNovo_Click(sender As Object, e As EventArgs) Handles mnNovo.Click
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