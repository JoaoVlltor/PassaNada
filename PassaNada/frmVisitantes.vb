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
        sql = "SELECT PK_MORADOR, RESPONSAVEL FROM MORADOR ORDER BY RESPONSAVEL"

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
End Class