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
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lblpsw = New System.Windows.Forms.Label()
        Me.txtpsw = New System.Windows.Forms.TextBox()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(184, 287)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(125, 53)
        Me.btnclear.TabIndex = 24
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(81, 236)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 23
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(317, 287)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(125, 53)
        Me.btnexit.TabIndex = 21
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(51, 287)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(125, 53)
        Me.btnlogin.TabIndex = 20
        Me.btnlogin.Text = "Log in"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'lblpsw
        '
        Me.lblpsw.AutoSize = True
        Me.lblpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpsw.Location = New System.Drawing.Point(81, 185)
        Me.lblpsw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpsw.Name = "lblpsw"
        Me.lblpsw.Size = New System.Drawing.Size(102, 24)
        Me.lblpsw.TabIndex = 19
        Me.lblpsw.Text = "Password :"
        '
        'txtpsw
        '
        Me.txtpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpsw.Location = New System.Drawing.Point(200, 182)
        Me.txtpsw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpsw.Name = "txtpsw"
        Me.txtpsw.Size = New System.Drawing.Size(177, 28)
        Me.txtpsw.TabIndex = 18
        Me.txtpsw.UseSystemPasswordChar = True
        '
        'txtusr
        '
        Me.txtusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusr.Location = New System.Drawing.Point(200, 128)
        Me.txtusr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(177, 28)
        Me.txtusr.TabIndex = 17
        '
        'lblusr
        '
        Me.lblusr.AutoSize = True
        Me.lblusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusr.Location = New System.Drawing.Point(79, 130)
        Me.lblusr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusr.Name = "lblusr"
        Me.lblusr.Size = New System.Drawing.Size(107, 24)
        Me.lblusr.TabIndex = 16
        Me.lblusr.Text = "Username :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(499, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblpsw)
        Me.Controls.Add(Me.txtpsw)
        Me.Controls.Add(Me.txtusr)
        Me.Controls.Add(Me.lblusr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents lblpsw As Label
    Friend WithEvents txtpsw As TextBox
    Friend WithEvents txtusr As TextBox
    Friend WithEvents lblusr As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
