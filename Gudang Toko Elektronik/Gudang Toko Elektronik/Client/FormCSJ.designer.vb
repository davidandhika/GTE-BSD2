<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCSJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCSJ))
        Me.close_btn = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.noTransKeluar_txt = New System.Windows.Forms.TextBox()
        Me.tgl_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dslengkap = New Gudang_Toko_Elektronik.Dslengkap()
        Me.DetailkeluarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataSetSJ = New Gudang_Toko_Elektronik.DataSetSJ()
        Me.DataSetSJBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtSJBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KodeskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dslengkap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailkeluarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSJBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSJBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(615, 1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 74
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Location = New System.Drawing.Point(498, 391)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(132, 36)
        Me.btnPrint.TabIndex = 72
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'noTransKeluar_txt
        '
        Me.noTransKeluar_txt.Location = New System.Drawing.Point(136, 59)
        Me.noTransKeluar_txt.Name = "noTransKeluar_txt"
        Me.noTransKeluar_txt.Size = New System.Drawing.Size(134, 20)
        Me.noTransKeluar_txt.TabIndex = 70
        '
        'tgl_lbl
        '
        Me.tgl_lbl.AutoSize = True
        Me.tgl_lbl.BackColor = System.Drawing.Color.Transparent
        Me.tgl_lbl.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_lbl.ForeColor = System.Drawing.Color.White
        Me.tgl_lbl.Location = New System.Drawing.Point(569, 58)
        Me.tgl_lbl.Name = "tgl_lbl"
        Me.tgl_lbl.Size = New System.Drawing.Size(61, 18)
        Me.tgl_lbl.TabIndex = 63
        Me.tgl_lbl.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "No. Surat Keluar"
        '
        'Dslengkap
        '
        Me.Dslengkap.DataSetName = "Dslengkap"
        Me.Dslengkap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailkeluarBindingSource
        '
        Me.DetailkeluarBindingSource.DataMember = "detail_keluar"
        Me.DetailkeluarBindingSource.DataSource = Me.Dslengkap
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(614, 111)
        Me.DataGridView1.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Nama Barang"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(136, 206)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(254, 20)
        Me.txtNamaBarang.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(136, 236)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(55, 20)
        Me.txtJumlah.TabIndex = 79
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(197, 236)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 81
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeskDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.DtSJBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(16, 274)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(614, 111)
        Me.DataGridView2.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(520, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 22)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "PRINT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSetSJ
        '
        Me.DataSetSJ.DataSetName = "DataSetSJ"
        Me.DataSetSJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSetSJBindingSource
        '
        Me.DataSetSJBindingSource.DataSource = Me.DataSetSJ
        Me.DataSetSJBindingSource.Position = 0
        '
        'DtSJBindingSource
        '
        Me.DtSJBindingSource.DataMember = "dtSJ"
        Me.DtSJBindingSource.DataSource = Me.DataSetSJBindingSource
        '
        'KodeskDataGridViewTextBoxColumn
        '
        Me.KodeskDataGridViewTextBoxColumn.DataPropertyName = "kodesk"
        Me.KodeskDataGridViewTextBoxColumn.HeaderText = "No. SK"
        Me.KodeskDataGridViewTextBoxColumn.Name = "KodeskDataGridViewTextBoxColumn"
        Me.KodeskDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaDataGridViewTextBoxColumn.Width = 350
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        Me.JumlahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormCetakSuratJalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_keluar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(642, 442)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.noTransKeluar_txt)
        Me.Controls.Add(Me.tgl_lbl)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCetakSuratJalan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKeluar"
        CType(Me.Dslengkap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailkeluarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSJBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSJBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents noTransKeluar_txt As System.Windows.Forms.TextBox
    Friend WithEvents tgl_lbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dslengkap As Gudang_Toko_Elektronik.Dslengkap
    Friend WithEvents DetailkeluarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KodeskDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtSJBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetSJBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetSJ As Gudang_Toko_Elektronik.DataSetSJ
End Class
