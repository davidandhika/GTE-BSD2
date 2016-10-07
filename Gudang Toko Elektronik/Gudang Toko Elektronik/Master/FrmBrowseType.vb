﻿Imports Oracle.DataAccess.Client
Public Class FrmBrowseType
    Dim rd As OracleDataReader

    Sub isiTable()
        Dim cmd As New OracleCommand("SELECT * FROM TIPE", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE TYPE"
            .Columns(1).HeaderCell.Value = "NAMA TYPE"
        End With
    End Sub
    Sub cari()
        Dim cmd As New OracleCommand("SELECT * FROM TIPE WHERE NMTYPE LIKE'%" & UCase(TextBox1.Text) & "%'", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE TYPE"
            .Columns(1).HeaderCell.Value = "NAMA TYPE"
        End With
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        cari()
    End Sub

    Private Sub FrmBrowseType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then

            FrmType.lblKodeType.Text = DataGridView1.Item(0, barisdgv).Value
            FrmType.txtNamaType.Text = DataGridView1.Item(1, barisdgv).Value
        End If
        Me.Close()
    End Sub
End Class