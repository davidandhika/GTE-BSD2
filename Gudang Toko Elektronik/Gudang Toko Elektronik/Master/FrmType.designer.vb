<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmType))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.lblKodeType = New System.Windows.Forms.Label()
        Me.txtNamaType = New System.Windows.Forms.TextBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(487, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DimGray
        Me.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnBrowse.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnBrowse.Location = New System.Drawing.Point(339, 78)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(70, 23)
        Me.btnBrowse.TabIndex = 29
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnDelete.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnDelete.Location = New System.Drawing.Point(433, 173)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 23)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DimGray
        Me.btnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnUpdate.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnUpdate.Location = New System.Drawing.Point(357, 173)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 23)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnSave.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.Location = New System.Drawing.Point(281, 173)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 23)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKodeType
        '
        Me.lblKodeType.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKodeType.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeType.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblKodeType.Location = New System.Drawing.Point(205, 78)
        Me.lblKodeType.Name = "lblKodeType"
        Me.lblKodeType.Size = New System.Drawing.Size(128, 23)
        Me.lblKodeType.TabIndex = 25
        Me.lblKodeType.Text = "Label1"
        Me.lblKodeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaType
        '
        Me.txtNamaType.Location = New System.Drawing.Point(205, 109)
        Me.txtNamaType.Name = "txtNamaType"
        Me.txtNamaType.Size = New System.Drawing.Size(204, 20)
        Me.txtNamaType.TabIndex = 31
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(619, 0)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 32
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'FrmType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_master_type
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.txtNamaType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblKodeType)
        Me.Name = "FrmType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmType"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents lblKodeType As System.Windows.Forms.Label
    Friend WithEvents txtNamaType As System.Windows.Forms.TextBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
End Class
