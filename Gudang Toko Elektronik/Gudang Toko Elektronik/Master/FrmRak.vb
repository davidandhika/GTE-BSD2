Imports Oracle.DataAccess.Client
Public Class FrmRak
    Dim cmd As New OracleCommand("", conn)
    Dim rd As OracleDataReader
    '---------------------------------------
    Sub AutoGenerate()
        cmd.CommandText = "SELECT generateRak from dual"
        lblKodeRak.Text = cmd.ExecuteScalar
    End Sub

    Sub dataComboBox()
        cmbKodeType.Items.Clear()
        cmd.CommandText = "select KDTYPE from TIPE"
        rd = cmd.ExecuteReader
        While rd.Read
            cmbKodeType.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub
    Sub start()
        AutoGenerate()
        Label1.Text = Date.Today.ToString("dd-MMM-yy")
        lblNamaType.Text = ""
        cmbKodeType.Text = ""
        dataComboBox()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        FrmBrowseRak.Show()
        Me.Hide()
    End Sub

    Private Sub FrmRak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            start()
        End If
    End Sub

    Private Sub cmbKodeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKodeType.SelectedIndexChanged
        Dim comboType As New OracleCommand("", conn)
        comboType.CommandText = "select nmtype FROM TIPE where kdtype='" & cmbKodeType.Text & "'"
        rd = comboType.ExecuteReader
        While rd.Read
            lblNamaType.Text = rd(0)
        End While
        rd.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New OracleCommand("INSERT INTO rak (kdrak, kdtype)VALUES (:kdrak, :kdtype)", conn)

        With cmd
            .Parameters.Add(":kdrak", lblKodeRak.Text)
            .Parameters.Add(":kdtype", cmbKodeType.Text)

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
        Dim cmd As New OracleCommand("UPDATE rak SET kdtype = :kdtype WHERE kdrak = :kdrak", conn)

        With cmd
            .Parameters.Add(":kdtype", cmbKodeType.Text)
            .Parameters.Add(":kdrak", lblKodeRak.Text)
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
            Dim cmd As New OracleCommand("DELETE FROM rak WHERE kdrak = :kdrak", conn)

            With cmd
                .Parameters.Add(":kdrak", lblKodeRak.Text)
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