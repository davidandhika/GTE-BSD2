Imports Oracle.DataAccess.Client
Public Class FrmBarang
    Dim cmd As New OracleCommand("", conn)
    Dim rd As OracleDataReader

 
    '-------------------------------------------
    Sub AutoGenerate()
        cmd.CommandText = "SELECT generateBarang from dual"
        lblKodeBarang.Text = cmd.ExecuteScalar
    End Sub
    Sub start()
        AutoGenerate()
        Label1.Text = Date.Today.ToString("dd-MMM-yy")
        txtNamaBarang.Text = ""
        txtSpesifikasi.Text = ""
        txtStok.Text = ""
        cmbNamaType.Text = "-- pilih --"
        cmbNamaBrand.Text = "-- pilih --"
        dataComboBox()
    End Sub

    Sub dataComboBox()
        cmbNamaType.Items.Clear()
        cmbNamaBrand.Items.Clear()


        cmd.CommandText = "select NMTYPE from TIPE"
        rd = cmd.ExecuteReader
        While rd.Read
            cmbNamaType.Items.Add(rd(0))
        End While

        cmd.CommandText = "select NMBRAND from BRAND"
        rd = cmd.ExecuteReader
        While rd.Read
            cmbNamaBrand.Items.Add(rd(0))
        End While

        rd.Close()
    End Sub
    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load   
        If conn.State = ConnectionState.Open Then
            start()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNamaBarang.Text = "" Or txtSpesifikasi.Text = "" Or txtKodeType.Text = "" Or txtKodeBrand.Text = "" Or txtStok.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim trans As OracleTransaction = conn.BeginTransaction
            Dim cmd As New OracleCommand("INSERT INTO barang(kdbarang, nmbarang, spesifikasi, kdtype,kdbrand,stok) VALUES (:kdbarang, :nmbarang, :spesifikasi,:kdtype,:kdbrand,:stok)", conn)

            With cmd
                .Parameters.Add(":kdbarang", lblKodeBarang.Text)
                .Parameters.Add(":nmbarang", txtNamaBarang.Text)
                .Parameters.Add(":spesifikasi", txtSpesifikasi.Text)
                .Parameters.Add(":kdtype", txtKodeType.Text)
                .Parameters.Add(":kdbrand", txtKodeBrand.Text)
                .Parameters.Add(":stok", txtStok.Text)
            End With
            Try
                cmd.ExecuteNonQuery()
                trans.Commit()

                MsgBox("Data Berhasil Disimpan!")
            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
            End Try
            start()


        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim trans As OracleTransaction = conn.BeginTransaction
        Dim cmd As New OracleCommand("UPDATE BARANG SET NMBARANG = :NMBARANG , SPESIFIKASI = :SPESIFIKASI , KDTYPE = :KDTYPE , KDBRAND = :KDBRAND, STOK = :STOK WHERE KDBARANG = :KDBARANG", conn)

        With cmd
            .Parameters.Add(":NMBARANG", txtNamaBarang.Text)
            .Parameters.Add(":SPESIFIKASI", txtSpesifikasi.Text)
            .Parameters.Add(":KDTYPE", txtKodeType.Text)
            .Parameters.Add(":KDBRAND", txtKodeBrand.Text)
            .Parameters.Add(":STOK", txtStok.Text)
            .Parameters.Add(":KDBARANG", lblKodeBarang.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
            trans.Commit()
            MsgBox("Data Berhasil Diperbaharui!")
        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        start()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim trans As OracleTransaction = conn.BeginTransaction
        Dim msg = "Apakah Anda yakin akan menghapus data tersebut?"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style)
        If response = MsgBoxResult.Yes Then
            Dim cmd As New OracleCommand("DELETE FROM BARANG WHERE KDBARANG = :KDBARANG", conn)

            With cmd
                .Parameters.Add(":KDBARANG", lblKodeBarang.Text)
            End With
            Try
                cmd.ExecuteNonQuery()
                trans.Commit()
            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
            End Try
            start()

        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        FrmBrowseBarang.Show()
        Me.Hide()
    End Sub

    Private Sub cmbNamaType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaType.SelectedIndexChanged
        Dim comboType As New OracleCommand("", conn)
        comboType.CommandText = "select kdtype FROM TIPE where nmtype='" & cmbNamaType.Text & "'"
        rd = comboType.ExecuteReader
        While rd.Read
            txtKodeType.Text = rd(0)
        End While
        rd.Close()
    End Sub

    Private Sub cmbNamaBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaBrand.SelectedIndexChanged
        Dim comboBrand As New OracleCommand("", conn)
        comboBrand.CommandText = "select kdbrand FROM BRAND where nmbrand='" & cmbNamaBrand.Text & "'"
        rd = comboBrand.ExecuteReader
        While rd.Read
            txtKodeBrand.Text = rd(0)
        End While
        rd.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        FrmMenuAdministrator.Show()
    End Sub

    Private Sub txtKodeBrand_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBrand.TextChanged

    End Sub

    Private Sub txtKodeType_TextChanged(sender As Object, e As EventArgs) Handles txtKodeType.TextChanged

    End Sub
End Class