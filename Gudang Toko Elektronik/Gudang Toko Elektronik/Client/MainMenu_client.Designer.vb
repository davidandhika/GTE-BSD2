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
        Me.report_btn = New System.Windows.Forms.Button()
        Me.opname_btn = New System.Windows.Forms.Button()
        Me.out_btn = New System.Windows.Forms.Button()
        Me.in_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'report_btn
        '
        Me.report_btn.BackgroundImage = CType(resources.GetObject("report_btn.BackgroundImage"), System.Drawing.Image)
        Me.report_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.report_btn.Location = New System.Drawing.Point(462, 121)
        Me.report_btn.Name = "report_btn"
        Me.report_btn.Size = New System.Drawing.Size(100, 100)
        Me.report_btn.TabIndex = 7
        Me.report_btn.UseVisualStyleBackColor = True
        '
        'opname_btn
        '
        Me.opname_btn.BackgroundImage = CType(resources.GetObject("opname_btn.BackgroundImage"), System.Drawing.Image)
        Me.opname_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.opname_btn.Location = New System.Drawing.Point(329, 121)
        Me.opname_btn.Name = "opname_btn"
        Me.opname_btn.Size = New System.Drawing.Size(100, 100)
        Me.opname_btn.TabIndex = 6
        Me.opname_btn.UseVisualStyleBackColor = True
        '
        'out_btn
        '
        Me.out_btn.BackgroundImage = CType(resources.GetObject("out_btn.BackgroundImage"), System.Drawing.Image)
        Me.out_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.out_btn.Location = New System.Drawing.Point(194, 121)
        Me.out_btn.Name = "out_btn"
        Me.out_btn.Size = New System.Drawing.Size(100, 100)
        Me.out_btn.TabIndex = 5
        Me.out_btn.UseVisualStyleBackColor = True
        '
        'in_btn
        '
        Me.in_btn.BackgroundImage = CType(resources.GetObject("in_btn.BackgroundImage"), System.Drawing.Image)
        Me.in_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.in_btn.Location = New System.Drawing.Point(53, 121)
        Me.in_btn.Name = "in_btn"
        Me.in_btn.Size = New System.Drawing.Size(100, 100)
        Me.in_btn.TabIndex = 4
        Me.in_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(577, 66)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 8
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'MainMenu_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gudang_Toko_Elektronik.My.Resources.Resources.MainMenuClient
        Me.ClientSize = New System.Drawing.Size(613, 319)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.report_btn)
        Me.Controls.Add(Me.opname_btn)
        Me.Controls.Add(Me.out_btn)
        Me.Controls.Add(Me.in_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu_client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu_client"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents report_btn As System.Windows.Forms.Button
    Friend WithEvents opname_btn As System.Windows.Forms.Button
    Friend WithEvents out_btn As System.Windows.Forms.Button
    Friend WithEvents in_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
End Class
