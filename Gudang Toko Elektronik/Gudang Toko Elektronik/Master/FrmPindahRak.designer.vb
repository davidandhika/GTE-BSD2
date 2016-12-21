<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPindahRak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPindahRak))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.lblKodeRak = New System.Windows.Forms.Label()
        Me.cmbKodeType = New System.Windows.Forms.ComboBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.RAK_CB = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtKodebarang = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(489, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DimGray
        Me.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnBrowse.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnBrowse.Location = New System.Drawing.Point(341, 116)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(70, 23)
        Me.btnBrowse.TabIndex = 23
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnSave.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.Location = New System.Drawing.Point(283, 244)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKodeRak
        '
        Me.lblKodeRak.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeRak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKodeRak.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeRak.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblKodeRak.Location = New System.Drawing.Point(207, 116)
        Me.lblKodeRak.Name = "lblKodeRak"
        Me.lblKodeRak.Size = New System.Drawing.Size(128, 23)
        Me.lblKodeRak.TabIndex = 19
        Me.lblKodeRak.Text = "Label1"
        Me.lblKodeRak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbKodeType
        '
        Me.cmbKodeType.FormattingEnabled = True
        Me.cmbKodeType.Location = New System.Drawing.Point(207, 146)
        Me.cmbKodeType.Name = "cmbKodeType"
        Me.cmbKodeType.Size = New System.Drawing.Size(204, 21)
        Me.cmbKodeType.TabIndex = 25
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(621, 0)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 27
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'RAK_CB
        '
        Me.RAK_CB.FormattingEnabled = True
        Me.RAK_CB.Location = New System.Drawing.Point(207, 175)
        Me.RAK_CB.Name = "RAK_CB"
        Me.RAK_CB.Size = New System.Drawing.Size(204, 21)
        Me.RAK_CB.TabIndex = 28
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DimGray
        Me.btnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnUpdate.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnUpdate.Location = New System.Drawing.Point(359, 245)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 23)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(207, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 20)
        Me.TextBox1.TabIndex = 29
        '
        'txtKodebarang
        '
        Me.txtKodebarang.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodebarang.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtKodebarang.Location = New System.Drawing.Point(426, 144)
        Me.txtKodebarang.Name = "txtKodebarang"
        Me.txtKodebarang.Size = New System.Drawing.Size(84, 23)
        Me.txtKodebarang.TabIndex = 30
        Me.txtKodebarang.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox2.Location = New System.Drawing.Point(426, 173)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(84, 23)
        Me.TextBox2.TabIndex = 31
        Me.TextBox2.Visible = False
        '
        'FrmPindahRak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.master_form_pindah_rak
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtKodebarang)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RAK_CB)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.cmbKodeType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblKodeRak)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPindahRak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents lblKodeRak As System.Windows.Forms.Label
    Friend WithEvents cmbKodeType As System.Windows.Forms.ComboBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents RAK_CB As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtKodebarang As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
