<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu_client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu_client))
        Me.opname_btn = New System.Windows.Forms.Button()
        Me.out_btn = New System.Windows.Forms.Button()
        Me.in_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCetakSJ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'opname_btn
        '
        Me.opname_btn.BackgroundImage = CType(resources.GetObject("opname_btn.BackgroundImage"), System.Drawing.Image)
        Me.opname_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.opname_btn.Location = New System.Drawing.Point(329, 114)
        Me.opname_btn.Name = "opname_btn"
        Me.opname_btn.Size = New System.Drawing.Size(100, 100)
        Me.opname_btn.TabIndex = 6
        Me.opname_btn.UseVisualStyleBackColor = True
        '
        'out_btn
        '
        Me.out_btn.BackgroundImage = CType(resources.GetObject("out_btn.BackgroundImage"), System.Drawing.Image)
        Me.out_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.out_btn.Location = New System.Drawing.Point(194, 114)
        Me.out_btn.Name = "out_btn"
        Me.out_btn.Size = New System.Drawing.Size(100, 100)
        Me.out_btn.TabIndex = 5
        Me.out_btn.UseVisualStyleBackColor = True
        '
        'in_btn
        '
        Me.in_btn.BackgroundImage = CType(resources.GetObject("in_btn.BackgroundImage"), System.Drawing.Image)
        Me.in_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.in_btn.Location = New System.Drawing.Point(53, 114)
        Me.in_btn.Name = "in_btn"
        Me.in_btn.Size = New System.Drawing.Size(100, 100)
        Me.in_btn.TabIndex = 4
        Me.in_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(590, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 8
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(466, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "SURAT JALAN"
        '
        'btnCetakSJ
        '
        Me.btnCetakSJ.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_report
        Me.btnCetakSJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCetakSJ.Location = New System.Drawing.Point(462, 114)
        Me.btnCetakSJ.Name = "btnCetakSJ"
        Me.btnCetakSJ.Size = New System.Drawing.Size(100, 100)
        Me.btnCetakSJ.TabIndex = 11
        Me.btnCetakSJ.UseVisualStyleBackColor = True
        '
        'MainMenu_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.MainMenuClient
        Me.ClientSize = New System.Drawing.Size(613, 319)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCetakSJ)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.opname_btn)
        Me.Controls.Add(Me.out_btn)
        Me.Controls.Add(Me.in_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu_client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu_client"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents opname_btn As System.Windows.Forms.Button
    Friend WithEvents out_btn As System.Windows.Forms.Button
    Friend WithEvents in_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCetakSJ As System.Windows.Forms.Button
End Class
