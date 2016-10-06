<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAwal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAwal))
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.BtnMaster = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.opname_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnReport
        '
        Me.BtnReport.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_report
        Me.BtnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReport.Location = New System.Drawing.Point(456, 145)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(100, 100)
        Me.BtnReport.TabIndex = 11
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'BtnMaster
        '
        Me.BtnMaster.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_master
        Me.BtnMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMaster.Location = New System.Drawing.Point(107, 145)
        Me.BtnMaster.Name = "BtnMaster"
        Me.BtnMaster.Size = New System.Drawing.Size(100, 100)
        Me.BtnMaster.TabIndex = 10
        Me.BtnMaster.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(621, 0)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 26
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'opname_btn
        '
        Me.opname_btn.BackgroundImage = CType(resources.GetObject("opname_btn.BackgroundImage"), System.Drawing.Image)
        Me.opname_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.opname_btn.Location = New System.Drawing.Point(280, 145)
        Me.opname_btn.Name = "opname_btn"
        Me.opname_btn.Size = New System.Drawing.Size(100, 100)
        Me.opname_btn.TabIndex = 27
        Me.opname_btn.UseVisualStyleBackColor = True
        '
        'FrmMenuAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.form_menu_administrator
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.opname_btn)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BtnMaster)
        Me.Name = "FrmMenuAwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu Awal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnReport As System.Windows.Forms.Button
    Friend WithEvents BtnMaster As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents opname_btn As System.Windows.Forms.Button
End Class
