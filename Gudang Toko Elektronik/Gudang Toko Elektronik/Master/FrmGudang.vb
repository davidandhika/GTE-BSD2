Imports Oracle.DataAccess.Client
Public Class FrmGudang
    Dim cmd As New OracleCommand("", conn)
    
    Private Sub FrmGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            start()
        End If
    End Sub
    '-------------------------------------------
    Sub AutoGenerate()
        cmd.CommandText = "SELECT generate from dual"
        lblKodeGudang.Text = cmd.ExecuteScalar
    End Sub

   

    Sub start()
        AutoGenerate()
        Label1.Text = Date.Today.ToString("dd-MMM-yy")
        txtNamaGudang.Text = ""
        txtAlamat.Text = ""
        txtKota.Text = ""
        txtTelp.Text = ""
        txtContactPerson.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim cmd As New OracleCommand("INSERT INTO gudang (kdgudang, nmgudang, alamat, kota,telp,pic) VALUES (:kdgudang, :nmgudang, :alamat,:kota,:telp,:pic)", conn)

        With cmd
            .Parameters.Add(":kdgudang", lblKodeGudang.Text)
            .Parameters.Add(":nmgudang", txtNamaGudang.Text)
            .Parameters.Add(":alamat", txtAlamat.Text)
            .Parameters.Add(":kota", txtKota.Text)
            .Parameters.Add(":telp", txtTelp.Text)
            .Parameters.Add(":pic", txtContactPerson.Text)

        End With
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        start()
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        FrmBrowseGudang.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim cmd As New OracleCommand("UPDATE GUDANG SET NMGUDANG = :nmgudang , ALAMAT = :alamat , KOTA = :kota , TELP = :telp, PIC = :pic WHERE KDGUDANG = :kdgudang", conn)

        With cmd
            .Parameters.Add(":nmgudang", txtNamaGudang.Text)
            .Parameters.Add(":alamat", txtAlamat.Text)
            .Parameters.Add(":kota", txtKota.Text)
            .Parameters.Add(":telp", txtTelp.Text)
            .Parameters.Add(":pic", txtContactPerson.Text)
            .Parameters.Add(":kdgudang", lblKodeGudang.Text)
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
            Dim cmd As New OracleCommand("DELETE FROM GUDANG WHERE KDGUDANG = :kdgudang", conn)

            With cmd
                .Parameters.Add(":kdgudang", lblKodeGudang.Text)
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