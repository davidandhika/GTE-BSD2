﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAdministrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAdministrator))
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.BtnType = New System.Windows.Forms.Button()
        Me.BtnBrand = New System.Windows.Forms.Button()
        Me.BtnRak = New System.Windows.Forms.Button()
        Me.BtnGudang = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnUser
        '
        Me.BtnUser.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_user
        Me.BtnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUser.Location = New System.Drawing.Point(428, 215)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(100, 100)
        Me.BtnUser.TabIndex = 7
        Me.BtnUser.UseVisualStyleBackColor = True
        '
        'BtnBarang
        '
        Me.BtnBarang.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_barang
        Me.BtnBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBarang.Location = New System.Drawing.Point(271, 215)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(100, 100)
        Me.BtnBarang.TabIndex = 6
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'BtnType
        '
        Me.BtnType.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_type
        Me.BtnType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnType.Location = New System.Drawing.Point(113, 215)
        Me.BtnType.Name = "BtnType"
        Me.BtnType.Size = New System.Drawing.Size(100, 100)
        Me.BtnType.TabIndex = 5
        Me.BtnType.UseVisualStyleBackColor = True
        '
        'BtnBrand
        '
        Me.BtnBrand.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_brand
        Me.BtnBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBrand.Location = New System.Drawing.Point(428, 92)
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.Size = New System.Drawing.Size(100, 100)
        Me.BtnBrand.TabIndex = 10
        Me.BtnBrand.UseVisualStyleBackColor = True
        '
        'BtnRak
        '
        Me.BtnRak.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_rak
        Me.BtnRak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRak.Location = New System.Drawing.Point(271, 92)
        Me.BtnRak.Name = "BtnRak"
        Me.BtnRak.Size = New System.Drawing.Size(100, 100)
        Me.BtnRak.TabIndex = 9
        Me.BtnRak.UseVisualStyleBackColor = True
        '
        'BtnGudang
        '
        Me.BtnGudang.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_gudang
        Me.BtnGudang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGudang.Location = New System.Drawing.Point(113, 92)
        Me.BtnGudang.Name = "BtnGudang"
        Me.BtnGudang.Size = New System.Drawing.Size(100, 100)
        Me.BtnGudang.TabIndex = 8
        Me.BtnGudang.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(620, 1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 25
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'FrmMenuAdministrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_menu_administrator
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.BtnBrand)
        Me.Controls.Add(Me.BtnRak)
        Me.Controls.Add(Me.BtnGudang)
        Me.Controls.Add(Me.BtnUser)
        Me.Controls.Add(Me.BtnBarang)
        Me.Controls.Add(Me.BtnType)
        Me.Name = "FrmMenuAdministrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu Administrator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnUser As System.Windows.Forms.Button
    Friend WithEvents BtnBarang As System.Windows.Forms.Button
    Friend WithEvents BtnType As System.Windows.Forms.Button
    Friend WithEvents BtnBrand As System.Windows.Forms.Button
    Friend WithEvents BtnRak As System.Windows.Forms.Button
    Friend WithEvents BtnGudang As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
End Class
