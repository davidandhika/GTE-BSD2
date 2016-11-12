<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasuk))
        Me.rak_cb = New System.Windows.Forms.ComboBox()
        Me.gudang_cb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.noSuratJalan_txt = New System.Windows.Forms.TextBox()
        Me.tgl_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KdtransmasukDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdbarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KondisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailmasukBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds1 = New Gudang_Toko_Elektronik.Dslengkap()
        Me.kondisi_cb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jumlah_txt = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nmBarang_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.kdbarang_txt = New System.Windows.Forms.TextBox()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.satuan_cb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.spek_txt = New System.Windows.Forms.RichTextBox()
        Me.txtKodeGudang = New System.Windows.Forms.TextBox()
        Me.txtKodeRak = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailmasukBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jumlah_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rak_cb
        '
        Me.rak_cb.FormattingEnabled = True
        Me.rak_cb.Location = New System.Drawing.Point(126, 114)
        Me.rak_cb.Name = "rak_cb"
        Me.rak_cb.Size = New System.Drawing.Size(134, 21)
        Me.rak_cb.TabIndex = 37
        '
        'gudang_cb
        '
        Me.gudang_cb.FormattingEnabled = True
        Me.gudang_cb.Location = New System.Drawing.Point(126, 85)
        Me.gudang_cb.Name = "gudang_cb"
        Me.gudang_cb.Size = New System.Drawing.Size(134, 21)
        Me.gudang_cb.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Rak"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Gudang"
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(668, 60)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 33
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'noSuratJalan_txt
        '
        Me.noSuratJalan_txt.Location = New System.Drawing.Point(126, 58)
        Me.noSuratJalan_txt.Name = "noSuratJalan_txt"
        Me.noSuratJalan_txt.Size = New System.Drawing.Size(134, 20)
        Me.noSuratJalan_txt.TabIndex = 32
        '
        'tgl_lbl
        '
        Me.tgl_lbl.AutoSize = True
        Me.tgl_lbl.BackColor = System.Drawing.Color.Transparent
        Me.tgl_lbl.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_lbl.ForeColor = System.Drawing.Color.White
        Me.tgl_lbl.Location = New System.Drawing.Point(601, 62)
        Me.tgl_lbl.Name = "tgl_lbl"
        Me.tgl_lbl.Size = New System.Drawing.Size(61, 18)
        Me.tgl_lbl.TabIndex = 31
        Me.tgl_lbl.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "No. Surat Jalan"
        '
        'delete_btn
        '
        Me.delete_btn.BackgroundImage = CType(resources.GetObject("delete_btn.BackgroundImage"), System.Drawing.Image)
        Me.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete_btn.Location = New System.Drawing.Point(504, 319)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(132, 36)
        Me.delete_btn.TabIndex = 50
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.BackgroundImage = CType(resources.GetObject("save_btn.BackgroundImage"), System.Drawing.Image)
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.save_btn.Location = New System.Drawing.Point(439, 361)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(132, 36)
        Me.save_btn.TabIndex = 49
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdtransmasukDataGridViewTextBoxColumn, Me.KdbarangDataGridViewTextBoxColumn, Me.NamaBarang, Me.KondisiDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetailmasukBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(321, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(371, 171)
        Me.DataGridView1.TabIndex = 48
        '
        'KdtransmasukDataGridViewTextBoxColumn
        '
        Me.KdtransmasukDataGridViewTextBoxColumn.DataPropertyName = "kdtransmasuk"
        Me.KdtransmasukDataGridViewTextBoxColumn.HeaderText = "kdtransmasuk"
        Me.KdtransmasukDataGridViewTextBoxColumn.Name = "KdtransmasukDataGridViewTextBoxColumn"
        Me.KdtransmasukDataGridViewTextBoxColumn.Visible = False
        '
        'KdbarangDataGridViewTextBoxColumn
        '
        Me.KdbarangDataGridViewTextBoxColumn.DataPropertyName = "kdbarang"
        Me.KdbarangDataGridViewTextBoxColumn.HeaderText = "kdbarang"
        Me.KdbarangDataGridViewTextBoxColumn.Name = "KdbarangDataGridViewTextBoxColumn"
        Me.KdbarangDataGridViewTextBoxColumn.Visible = False
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        '
        'KondisiDataGridViewTextBoxColumn
        '
        Me.KondisiDataGridViewTextBoxColumn.DataPropertyName = "kondisi"
        Me.KondisiDataGridViewTextBoxColumn.HeaderText = "Kondisi"
        Me.KondisiDataGridViewTextBoxColumn.Name = "KondisiDataGridViewTextBoxColumn"
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "satuan"
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        '
        'DetailmasukBindingSource1
        '
        Me.DetailmasukBindingSource1.DataMember = "detail_masuk"
        Me.DetailmasukBindingSource1.DataSource = Me.ds1
        '
        'ds1
        '
        Me.ds1.DataSetName = "Dslengkap"
        Me.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'kondisi_cb
        '
        Me.kondisi_cb.FormattingEnabled = True
        Me.kondisi_cb.Items.AddRange(New Object() {"Baru", "Retur"})
        Me.kondisi_cb.Location = New System.Drawing.Point(126, 235)
        Me.kondisi_cb.Name = "kondisi_cb"
        Me.kondisi_cb.Size = New System.Drawing.Size(134, 21)
        Me.kondisi_cb.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Kondisi"
        '
        'jumlah_txt
        '
        Me.jumlah_txt.Location = New System.Drawing.Point(126, 206)
        Me.jumlah_txt.Name = "jumlah_txt"
        Me.jumlah_txt.Size = New System.Drawing.Size(134, 20)
        Me.jumlah_txt.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Nama Barang"
        '
        'nmBarang_txt
        '
        Me.nmBarang_txt.Location = New System.Drawing.Point(126, 174)
        Me.nmBarang_txt.Name = "nmBarang_txt"
        Me.nmBarang_txt.Size = New System.Drawing.Size(134, 20)
        Me.nmBarang_txt.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Kode Barang"
        '
        'search_btn
        '
        Me.search_btn.BackgroundImage = CType(resources.GetObject("search_btn.BackgroundImage"), System.Drawing.Image)
        Me.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.search_btn.Location = New System.Drawing.Point(265, 142)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(35, 23)
        Me.search_btn.TabIndex = 40
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'kdbarang_txt
        '
        Me.kdbarang_txt.Location = New System.Drawing.Point(126, 143)
        Me.kdbarang_txt.Name = "kdbarang_txt"
        Me.kdbarang_txt.Size = New System.Drawing.Size(134, 20)
        Me.kdbarang_txt.TabIndex = 39
        '
        'insert_btn
        '
        Me.insert_btn.BackgroundImage = CType(resources.GetObject("insert_btn.BackgroundImage"), System.Drawing.Image)
        Me.insert_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.insert_btn.Location = New System.Drawing.Point(366, 319)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(132, 36)
        Me.insert_btn.TabIndex = 38
        Me.insert_btn.UseVisualStyleBackColor = True
        '
        'satuan_cb
        '
        Me.satuan_cb.FormattingEnabled = True
        Me.satuan_cb.Items.AddRange(New Object() {"Unit", "Pcs"})
        Me.satuan_cb.Location = New System.Drawing.Point(126, 264)
        Me.satuan_cb.Name = "satuan_cb"
        Me.satuan_cb.Size = New System.Drawing.Size(134, 21)
        Me.satuan_cb.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Satuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Spesifikasi"
        '
        'spek_txt
        '
        Me.spek_txt.Location = New System.Drawing.Point(126, 299)
        Me.spek_txt.Name = "spek_txt"
        Me.spek_txt.Size = New System.Drawing.Size(174, 96)
        Me.spek_txt.TabIndex = 54
        Me.spek_txt.Text = ""
        '
        'txtKodeGudang
        '
        Me.txtKodeGudang.Location = New System.Drawing.Point(265, 85)
        Me.txtKodeGudang.Name = "txtKodeGudang"
        Me.txtKodeGudang.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeGudang.TabIndex = 55
        Me.txtKodeGudang.Visible = False
        '
        'txtKodeRak
        '
        Me.txtKodeRak.Location = New System.Drawing.Point(266, 115)
        Me.txtKodeRak.Name = "txtKodeRak"
        Me.txtKodeRak.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeRak.TabIndex = 56
        Me.txtKodeRak.Visible = False
        '
        'FormMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 431)
        Me.Controls.Add(Me.txtKodeRak)
        Me.Controls.Add(Me.txtKodeGudang)
        Me.Controls.Add(Me.spek_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.satuan_cb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.kondisi_cb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jumlah_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nmBarang_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.kdbarang_txt)
        Me.Controls.Add(Me.insert_btn)
        Me.Controls.Add(Me.rak_cb)
        Me.Controls.Add(Me.gudang_cb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.noSuratJalan_txt)
        Me.Controls.Add(Me.tgl_lbl)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMasuk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailmasukBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jumlah_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rak_cb As System.Windows.Forms.ComboBox
    Friend WithEvents gudang_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents noSuratJalan_txt As System.Windows.Forms.TextBox
    Friend WithEvents tgl_lbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents kondisi_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents jumlah_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nmBarang_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents kdbarang_txt As System.Windows.Forms.TextBox
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents satuan_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents spek_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents txtKodeGudang As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeRak As System.Windows.Forms.TextBox
    'Friend WithEvents KdbarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents NmbarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents DataColumn1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ds1 As Gudang_Toko_Elektronik.Dslengkap
    Friend WithEvents DetailmasukBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KdtransmasukDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KdbarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KondisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
