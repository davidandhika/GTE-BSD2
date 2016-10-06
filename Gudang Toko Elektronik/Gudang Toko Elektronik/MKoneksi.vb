Imports Oracle.DataAccess.Client
Module MKoneksi
    Public conn As New OracleConnection()
    Sub koneksi(datasource As String, id As String, pass As String)
        conn.ConnectionString = "data source=" & datasource & "; user id=" & id & "; password=" & pass
        Try
            conn.Open()

            'catatLog(id)
            'sender.hide()
            'Transaksi.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub catatLog(id As String)
        Try
            Dim cmd As New OracleCommand("insert into loguser(iduser) values('" & id & "')", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
