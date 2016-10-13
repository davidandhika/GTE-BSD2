<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.login_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Transparent
        Me.login_btn.BackgroundImage = CType(resources.GetObject("login_btn.BackgroundImage"), System.Drawing.Image)
        Me.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.login_btn.Location = New System.Drawing.Point(76, 216)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(132, 36)
        Me.login_btn.TabIndex = 2
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(265, 58)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(24, 24)
        Me.close_btn.TabIndex = 3
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(35, 173)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(218, 20)
        Me.pass_txt.TabIndex = 2
        Me.pass_txt.UseSystemPasswordChar = True
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(35, 109)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(218, 20)
        Me.username_txt.TabIndex = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(298, 270)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.pass_txt)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.login_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents pass_txt As System.Windows.Forms.TextBox
    Friend WithEvents username_txt As System.Windows.Forms.TextBox

End Class
