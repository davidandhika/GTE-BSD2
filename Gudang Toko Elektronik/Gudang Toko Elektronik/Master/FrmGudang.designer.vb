<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGudang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGudang))
        Me.lblKodeGudang = New System.Windows.Forms.Label()
        Me.txtNamaGudang = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKodeGudang
        '
        Me.lblKodeGudang.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeGudang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKodeGudang.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeGudang.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblKodeGudang.Location = New System.Drawing.Point(198, 78)
        Me.lblKodeGudang.Name = "lblKodeGudang"
        Me.lblKodeGudang.Size = New System.Drawing.Size(170, 23)
        Me.lblKodeGudang.TabIndex = 0
        Me.lblKodeGudang.Text = "Label1"
        Me.lblKodeGudang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaGudang
        '
        Me.txtNamaGudang.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaGudang.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNamaGudang.Location = New System.Drawing.Point(198, 109)
        Me.txtNamaGudang.Name = "txtNamaGudang"
        Me.txtNamaGudang.Size = New System.Drawing.Size(298, 23)
        Me.txtNamaGudang.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnSave.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.Location = New System.Drawing.Point(274, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DimGray
        Me.btnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnUpdate.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnUpdate.Location = New System.Drawing.Point(350, 280)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnDelete.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnDelete.Location = New System.Drawing.Point(426, 280)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtAlamat.Location = New System.Drawing.Point(198, 140)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(298, 23)
        Me.txtAlamat.TabIndex = 6
        '
        'txtKota
        '
        Me.txtKota.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtKota.Location = New System.Drawing.Point(198, 171)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(298, 23)
        Me.txtKota.TabIndex = 7
        '
        'txtTelp
        '
        Me.txtTelp.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTelp.Location = New System.Drawing.Point(198, 202)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(298, 23)
        Me.txtTelp.TabIndex = 8
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPerson.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtContactPerson.Location = New System.Drawing.Point(198, 232)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(298, 23)
        Me.txtContactPerson.TabIndex = 9
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DimGray
        Me.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnBrowse.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnBrowse.Location = New System.Drawing.Point(426, 78)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(70, 23)
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(482, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(620, 1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 12
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'FrmGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_master_gudang1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNamaGudang)
        Me.Controls.Add(Me.lblKodeGudang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGudang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Gudang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKodeGudang As System.Windows.Forms.Label
    Friend WithEvents txtNamaGudang As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents close_btn As System.Windows.Forms.Button
End Class
