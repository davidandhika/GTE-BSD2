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
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(92, 170)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(218, 20)
        Me.pass_txt.TabIndex = 2
        Me.pass_txt.UseSystemPasswordChar = True
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(92, 118)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(218, 20)
        Me.username_txt.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Gudang_Toko_Elektronik.My.Resources.Resources.small_loginTitle
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.Location = New System.Drawing.Point(271, 205)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(39, 43)
        Me.close_btn.TabIndex = 3
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Transparent
        Me.login_btn.BackgroundImage = CType(resources.GetObject("login_btn.BackgroundImage"), System.Drawing.Image)
        Me.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.login_btn.Location = New System.Drawing.Point(133, 205)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(132, 43)
        Me.login_btn.TabIndex = 2
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Minion Pro Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Minion Pro Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Username"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(393, 270)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.pass_txt)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.login_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents pass_txt As System.Windows.Forms.TextBox
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
