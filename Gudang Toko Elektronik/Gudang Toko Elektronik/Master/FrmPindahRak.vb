Imports Oracle.DataAccess.Client
Public Class FrmPindahRak
    Dim cmd As New OracleCommand("", conn)
    Dim rd As OracleDataReader
    '---------------------------------------
    Sub AutoGenerate()
        cmd.CommandText = "SELECT generateRakBarang from dual"
        lblKodeRak.Text = cmd.ExecuteScalar
    End Sub

    Sub dataComboBox()
        cmbKodeType.Items.Clear()
        cmd.CommandText = "select KDBARANG, NMBARANG from BARANG"
        rd = cmd.ExecuteReader
        While rd.Read
            cmbKodeType.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

  

    Sub dataComboBoxRak()
        RAK_CB.Items.Clear()
        cmd.CommandText = "select KDRAK from RAK"
        rd = cmd.ExecuteReader
        While rd.Read
            RAK_CB.Items.Add(rd(0))

        End While
        rd.Close()
    End Sub

    Sub start()
        AutoGenerate()
        Label1.Text = Date.Today.ToString("dd-MMM-yy")
        dataComboBox()
        dataComboBoxRak()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        FrmBrowseRakbarang.Show()
        'Me.Hide()
    End Sub

    Private Sub FrmRak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            start()
        End If
    End Sub

   

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New OracleCommand("INSERT INTO rak_barang (kdrakbarang, kdbarang, kdrak, label_barang)VALUES (:kdrakbarang, :kdbarang, :kdrak, :label_barang)", conn)

        With cmd
            .Parameters.Add(":kdrakbarang", lblKodeRak.Text)
            .Parameters.Add(":kdbarang", cmbKodeType.Text)
            .Parameters.Add(":kdrak", RAK_CB.Text)
            .Parameters.Add(":label_barang", TextBox1.Text)

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
        Dim cmd As New OracleCommand("UPDATE rak_barang SET kdbarang = :kdbarang, kdrak = :kdrak, label_barang = :label_barang WHERE kdrakbarang = :kdrakbarang", conn)

        With cmd

            .Parameters.Add(":kdbarang", cmbKodeType.Text)
            .Parameters.Add(":kdrak", RAK_CB.Text)
            .Parameters.Add(":label_barang", TextBox1.Text)
            .Parameters.Add(":kdrakbarang", lblKodeRak.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diperbaharui!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        start()
    End Sub

   

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub lblKodeRak_Click(sender As Object, e As EventArgs) Handles lblKodeRak.Click

    End Sub

    Private Sub cmbKodeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKodeType.SelectedIndexChanged
        Dim comboType As New OracleCommand("", conn)
        comboType.CommandText = "select NMBARANG FROM barang where NMBARANG='" & cmbKodeType.Text & "'"
        rd = comboType.ExecuteReader
        While rd.Read
            txtKodebarang.Text = rd(0)
        End While
        rd.Close()
    End Sub
End Class