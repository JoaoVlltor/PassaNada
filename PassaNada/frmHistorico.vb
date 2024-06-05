Public Class frmHistorico

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        If MsgBox("Deseja realmente fechar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Fechar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarDados()
    End Sub

    Private Sub listarDados()
        lsvDados.Items.Clear()
        Dim sql As String

        sql = "
        SELECT v.PK_VISITA, (V.DATA || ' - ' || V.HORA) DATA_HORA, V.VISITANTE, V.CPF CPF_V, V.WHATSAPP, V.VEICULO,
               M.RESPONSAVEL, M.CPF CPF_M
        FROM VISITAS V
        JOIN MORADOR M ON PK_MORADOR = FK_MORADOR
        WHERE V.DATA LIKE '%" & txtBuscar.Text & "%'
                OR V.HORA LIKE '%" & txtBuscar.Text & "%'
                OR V.VISITANTE LIKE '%" & txtBuscar.Text & "%'
                OR V.CPF LIKE '%" & txtBuscar.Text & "%'
                OR V.WHATSAPP LIKE '%" & txtBuscar.Text & "%'
                OR V.VEICULO LIKE '%" & txtBuscar.Text & "%'
                OR M.RESPONSAVEL LIKE '%" & txtBuscar.Text & "%'
                OR M.CPF LIKE '%" & txtBuscar.Text & "%'
        ORDER BY DATA DESC, HORA DESC
        "

        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then
            While Not vgRegistros.EOF
                Dim item As New ListViewItem

                With lsvDados.Items.Add(item)
                    .Text = vgRegistros("PK_VISITA").Value
                    .SubItems.Add(vgRegistros("DATA_HORA").Value)
                    .SubItems.Add(vgRegistros("VISITANTE").Value)
                    .SubItems.Add(vgRegistros("CPF_V").Value)
                    .SubItems.Add(vgRegistros("WHATSAPP").Value)
                    .SubItems.Add(vgRegistros("VEICULO").Value)
                    .SubItems.Add(vgRegistros("RESPONSAVEL").Value)
                    .SubItems.Add(vgRegistros("CPF_M").Value)
                End With
                vgRegistros.MoveNext()
            End While

        End If

        vgRegistros.Close()

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listarDados()
    End Sub
End Class