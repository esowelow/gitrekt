<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.Login_btn = New System.Windows.Forms.Panel()
        Me.exit_btn = New System.Windows.Forms.Panel()
        Me.login = New System.Windows.Forms.Button()
        Me.eksit = New System.Windows.Forms.Button()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'username_txt
        '
        Me.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username_txt.Cursor = System.Windows.Forms.Cursors.Default
        Me.username_txt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txt.ForeColor = System.Drawing.Color.DarkGray
        Me.username_txt.Location = New System.Drawing.Point(49, 193)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(199, 16)
        Me.username_txt.TabIndex = 0
        Me.username_txt.Text = "Enter your Username / E-mail"
        '
        'Login_btn
        '
        Me.Login_btn.BackColor = System.Drawing.Color.Transparent
        Me.Login_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.Login_btn.Location = New System.Drawing.Point(40, 366)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(180, 51)
        Me.Login_btn.TabIndex = 3
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.exit_btn.Location = New System.Drawing.Point(422, 1)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(41, 19)
        Me.exit_btn.TabIndex = 4
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(517, 108)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(54, 32)
        Me.login.TabIndex = 3
        Me.login.Text = "login"
        Me.login.UseVisualStyleBackColor = True
        '
        'eksit
        '
        Me.eksit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.eksit.Location = New System.Drawing.Point(481, 124)
        Me.eksit.Name = "eksit"
        Me.eksit.Size = New System.Drawing.Size(54, 32)
        Me.eksit.TabIndex = 4
        Me.eksit.Text = "exit"
        Me.eksit.UseVisualStyleBackColor = True
        '
        'password_txt
        '
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password_txt.Cursor = System.Windows.Forms.Cursors.Default
        Me.password_txt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.DarkGray
        Me.password_txt.Location = New System.Drawing.Point(49, 232)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(199, 16)
        Me.password_txt.TabIndex = 1
        Me.password_txt.Text = "Enter your Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(58, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(103, 23)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(40, 469)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 23)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(192, 469)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(139, 23)
        Me.Panel3.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(42, 301)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 18)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Remember password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AcceptButton = Me.login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.eksit
        Me.ClientSize = New System.Drawing.Size(470, 590)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.eksit)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Login_btn)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(470, 590)
        Me.MinimumSize = New System.Drawing.Size(470, 590)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Garena+ (Beta)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents Login_btn As System.Windows.Forms.Panel
    Friend WithEvents exit_btn As System.Windows.Forms.Panel
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents eksit As System.Windows.Forms.Button
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
