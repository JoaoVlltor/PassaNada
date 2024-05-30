Public Class frmMoradores
    Private Sub frmMoradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
        listarDados()
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
            Dim sql As String

            If txtCod.Text = "" Then
                sql = "INSERT INTO MORADOR (RESPONSAVEL, CPF, EMAIL, WHATSAPP, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO) VALUES 
                    ( 
                    '" & txtResponsavel.Text & "',  
                    '" & txtCpf.Text & "',
                    '" & txtEmail.Text & "',
                    '" & txtWhatsapp.Text & "',
                    '" & txtLogradouro.Text & "',
                    '" & txtNumero.Text & "',
                    '" & txtComplemento.Text & "',
                    '" & txtBairro.Text & "',
                    '" & txtCidade.Text & "',
                    '" & cmbEstado.Text & "'
                    )
                    "
                limparFormulario()
                listarDados()
            Else
                sql = "
                    UPDATE MORADOR SET
                    RESPONSAVEL = '" & txtResponsavel.Text & "',
                    CPF = '" & txtCpf.Text & "',
                    EMAIL = '" & txtEmail.Text & "',
                    WHATSAPP = '" & txtWhatsapp.Text & "',
                    LOGRADOURO = '" & txtLogradouro.Text & "',
                    NUMERO = '" & txtNumero.Text & "',
                    COMPLEMENTO = '" & txtComplemento.Text & "',
                    BAIRRO = '" & txtBairro.Text & "',
                    CIDADE = '" & txtCidade.Text & "',
                    ESTADO = '" & cmbEstado.Text & "',
                    WHERE PK_MORADORES = '" & txtCod.Text & "'
                    "

            End If
            vgDados.Execute(sql)

            limparFormulario()
            listarDados()
        End If
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        txtCod.Text = lsvDados.SelectedItems(0).Text

        Dim sql As String

        sql = "SELECT * FROM MORADOR WHERE PK_MORADOR = '" & txtCod.Text & "'"

        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then
            txtResponsavel.Text = vgRegistros("RESPONSAVEL").Value
            txtCpf.Text = vgRegistros("CPF").Value
            txtWhatsapp.Text = vgRegistros("WHATSAPP").Value
            txtEmail.Text = vgRegistros("EMAIL").Value
            txtLogradouro.Text = vgRegistros("LOGRADOURO").Value
            txtNumero.Text = vgRegistros("NUMERO").Value
            txtComplemento.Text = vgRegistros("COMPLEMENTO").Value
            txtBairro.Text = vgRegistros("BAIRRO").Value
            txtCidade.Text = vgRegistros("CIDADE").Value
            cmbEstado.Text = vgRegistros("ESTADO").Value
        End If
        vgRegistros.Close()

    End Sub

    Private Sub listarDados()
        Dim sql As String

        lsvDados.Items.Clear()

        sql = "
        SELECT * FROM MORADOR 
        WHERE PK_MORADOR LIKE '%" & txtBuscar.Text & "%'
        OR LOWER(RESPONSAVEL) LIKE '%" & LCase(txtBuscar.Text) & "%' 
        OR LOWER(CPF) LIKE '%" & LCase(txtBuscar.Text) & "%'                             
        OR LOWER(EMAIL) LIKE '%" & LCase(txtBuscar.Text) & "%'                             
        ORDER BY RESPONSAVEL                            
        "

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
        vgRegistros.Close()
    End Sub

    Private Sub mnExcluir_Click(sender As Object, e As EventArgs) Handles mnExcluir.Click
        If txtCod.Text <> "" Then
            Dim sql As String

            sql = "DELETE FROM MORADOR WHERE PK_MORADOR = '" & txtCod.Text & "'"

            vgDados.Execute(sql)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listarDados()
    End Sub
End Class