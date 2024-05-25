Module Conexao
    'Variavel para comandos DDL - Insert, Update, Delet
    Public vgDados As New ADODB.Connection
    'Variavel para DML - Select
    Public vgRegistros As New ADODB.Recordset

    'conectar na base de dados
    Public Sub conecta()
        '0 = ligado, 1 = desligado
        If vgDados.State = 0 Then
            'utiliza a conexão do OBDC 
            vgDados.Open("dsn=passa_nada")
        End If
    End Sub

    'desconecta da base de dados
    Public Sub desconecta()
        If vgDados.State = 1 Then
            vgDados.Close()
        End If
    End Sub
End Module
