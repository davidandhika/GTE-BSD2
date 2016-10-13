<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarang))
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Label()
        Me.txtSpesifikasi = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.lblKodeBarang = New System.Windows.Forms.Label()
        Me.cmbNamaType = New System.Windows.Forms.ComboBox()
        Me.cmbNamaBrand = New System.Windows.Forms.ComboBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtKodeType = New System.Windows.Forms.TextBox()
        Me.txtKodeBrand = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(621, 0)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 24
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(483, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DimGray
        Me.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnBrowse.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnBrowse.Location = New System.Drawing.Point(427, 77)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(70, 23)
        Me.btnBrowse.TabIndex = 22
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSpesifikasi
        '
        Me.txtSpesifikasi.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpesifikasi.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtSpesifikasi.Location = New System.Drawing.Point(199, 201)
        Me.txtSpesifikasi.Multiline = True
        Me.txtSpesifikasi.Name = "txtSpesifikasi"
        Me.txtSpesifikasi.Size = New System.Drawing.Size(298, 45)
        Me.txtSpesifikasi.TabIndex = 20
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnDelete.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnDelete.Location = New System.Drawing.Point(427, 296)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DimGray
        Me.btnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnUpdate.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnUpdate.Location = New System.Drawing.Point(351, 296)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 23)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnSave.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.Location = New System.Drawing.Point(275, 296)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNamaBarang.Location = New System.Drawing.Point(199, 108)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(298, 23)
        Me.txtNamaBarang.TabIndex = 14
        '
        'lblKodeBarang
        '
        Me.lblKodeBarang.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKodeBarang.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeBarang.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblKodeBarang.Location = New System.Drawing.Point(199, 77)
        Me.lblKodeBarang.Name = "lblKodeBarang"
        Me.lblKodeBarang.Size = New System.Drawing.Size(170, 23)
        Me.lblKodeBarang.TabIndex = 13
        Me.lblKodeBarang.Text = "Label1"
        Me.lblKodeBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbNamaType
        '
        Me.cmbNamaType.FormattingEnabled = True
        Me.cmbNamaType.Location = New System.Drawing.Point(199, 141)
        Me.cmbNamaType.Name = "cmbNamaType"
        Me.cmbNamaType.Size = New System.Drawing.Size(170, 21)
        Me.cmbNamaType.TabIndex = 25
        '
        'cmbNamaBrand
        '
        Me.cmbNamaBrand.FormattingEnabled = True
        Me.cmbNamaBrand.Location = New System.Drawing.Point(199, 173)
        Me.cmbNamaBrand.Name = "cmbNamaBrand"
        Me.cmbNamaBrand.Size = New System.Drawing.Size(170, 21)
        Me.cmbNamaBrand.TabIndex = 26
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtStok.Location = New System.Drawing.Point(199, 252)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(62, 23)
        Me.txtStok.TabIndex = 27
        '
        'txtKodeType
        '
        Me.txtKodeType.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeType.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtKodeType.Location = New System.Drawing.Point(413, 139)
        Me.txtKodeType.Name = "txtKodeType"
        Me.txtKodeType.Size = New System.Drawing.Size(84, 23)
        Me.txtKodeType.TabIndex = 28
        Me.txtKodeType.Visible = False
        '
        'txtKodeBrand
        '
        Me.txtKodeBrand.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBrand.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtKodeBrand.Location = New System.Drawing.Point(413, 173)
        Me.txtKodeBrand.Name = "txtKodeBrand"
        Me.txtKodeBrand.Size = New System.Drawing.Size(84, 23)
        Me.txtKodeBrand.TabIndex = 29
        Me.txtKodeBrand.Visible = False
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_master_barang1
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.txtKodeBrand)
        Me.Controls.Add(Me.txtKodeType)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.cmbNamaBrand)
        Me.Controls.Add(Me.cmbNamaType)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtSpesifikasi)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.lblKodeBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Label
    Friend WithEvents txtSpesifikasi As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents lblKodeBarang As System.Windows.Forms.Label
    Friend WithEvents cmbNamaType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNamaBrand As System.Windows.Forms.ComboBox
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeType As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeBrand As System.Windows.Forms.TextBox
End Class
