Imports Oracle.DataAccess.Client
Public Class FrmType
    Dim cmd As New OracleCommand("", conn)
    Dim rd As OracleDataReader
    '---------------------------------------
    Sub AutoGenerate()
        cmd.CommandText = "SELECT generateType from dual"
        lblKodeType.Text = cmd.ExecuteScalar
    End Sub

    Sub start()
        AutoGenerate()
        Label1.Text = Date.Today.ToString("dd-MMM-yy")
        txtNamaType.Text = ""
    End Sub
    Private Sub FrmType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            start()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'FrmBrowseType.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New OracleCommand("INSERT INTO tipe (kdtype, nmtype)VALUES (:kdtype, :nmtype)", conn)

        With cmd
            .Parameters.Add(":kdtype", lblKodeType.Text)
            .Parameters.Add(":nmtype", txtNamaType.Text)

        End With
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        start()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New OracleCommand("UPDATE tipe SET nmtype = :nmtype WHERE kdtype = :kdtype", conn)

        With cmd
            .Parameters.Add(":nmtype", txtNamaType.Text)
            .Parameters.Add(":kdtype", lblKodeType.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diperbaharui!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        start()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim msg = "Apakah Anda yakin akan menghapus data tersebut?"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style)
        If response = MsgBoxResult.Yes Then
            Dim cmd As New OracleCommand("DELETE FROM tipe WHERE kdtype = :kdtype", conn)

            With cmd
                .Parameters.Add(":kdtype", lblKodeType.Text)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            start()

        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        FrmMenuAdministrator.Show()
    End Sub
End Class