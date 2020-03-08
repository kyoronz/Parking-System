<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adduser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adduser))
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblic = New System.Windows.Forms.Label()
        Me.lblcn = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcarplate = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtic = New System.Windows.Forms.TextBox()
        Me.txtcarplate = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.msktxtcn = New System.Windows.Forms.MaskedTextBox()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblnamealr = New System.Windows.Forms.Label()
        Me.lblicalr = New System.Windows.Forms.Label()
        Me.lblcnalr = New System.Windows.Forms.Label()
        Me.lblemailalr = New System.Windows.Forms.Label()
        Me.lblcarplatealr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(96, 64)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(61, 24)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name"
        '
        'lblic
        '
        Me.lblic.AutoSize = True
        Me.lblic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblic.Location = New System.Drawing.Point(96, 117)
        Me.lblic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblic.Name = "lblic"
        Me.lblic.Size = New System.Drawing.Size(27, 24)
        Me.lblic.TabIndex = 1
        Me.lblic.Text = "IC"
        '
        'lblcn
        '
        Me.lblcn.AutoSize = True
        Me.lblcn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcn.Location = New System.Drawing.Point(96, 174)
        Me.lblcn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcn.Name = "lblcn"
        Me.lblcn.Size = New System.Drawing.Size(105, 24)
        Me.lblcn.TabIndex = 2
        Me.lblcn.Text = "Contact no."
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(96, 234)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(57, 24)
        Me.lblemail.TabIndex = 3
        Me.lblemail.Text = "Email"
        '
        'lblcarplate
        '
        Me.lblcarplate.AutoSize = True
        Me.lblcarplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarplate.Location = New System.Drawing.Point(96, 294)
        Me.lblcarplate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcarplate.Name = "lblcarplate"
        Me.lblcarplate.Size = New System.Drawing.Size(85, 24)
        Me.lblcarplate.TabIndex = 4
        Me.lblcarplate.Text = "Car Plate"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(225, 62)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(197, 28)
        Me.txtname.TabIndex = 0
        '
        'txtic
        '
        Me.txtic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtic.Location = New System.Drawing.Point(225, 114)
        Me.txtic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtic.Name = "txtic"
        Me.txtic.Size = New System.Drawing.Size(197, 28)
        Me.txtic.TabIndex = 1
        '
        'txtcarplate
        '
        Me.txtcarplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarplate.Location = New System.Drawing.Point(225, 292)
        Me.txtcarplate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcarplate.Name = "txtcarplate"
        Me.txtcarplate.Size = New System.Drawing.Size(197, 28)
        Me.txtcarplate.TabIndex = 4
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(225, 231)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(197, 28)
        Me.txtemail.TabIndex = 3
        '
        'msktxtcn
        '
        Me.msktxtcn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msktxtcn.Location = New System.Drawing.Point(225, 171)
        Me.msktxtcn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.msktxtcn.Mask = "(999) 000-0000"
        Me.msktxtcn.Name = "msktxtcn"
        Me.msktxtcn.Size = New System.Drawing.Size(197, 28)
        Me.msktxtcn.TabIndex = 2
        '
        'btnconfirm
        '
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(41, 329)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(153, 63)
        Me.btnconfirm.TabIndex = 11
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(231, 329)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(153, 63)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblnamealr
        '
        Me.lblnamealr.AutoSize = True
        Me.lblnamealr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamealr.ForeColor = System.Drawing.Color.Red
        Me.lblnamealr.Location = New System.Drawing.Point(221, 95)
        Me.lblnamealr.Name = "lblnamealr"
        Me.lblnamealr.Size = New System.Drawing.Size(0, 17)
        Me.lblnamealr.TabIndex = 13
        '
        'lblicalr
        '
        Me.lblicalr.AutoSize = True
        Me.lblicalr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblicalr.ForeColor = System.Drawing.Color.Red
        Me.lblicalr.Location = New System.Drawing.Point(221, 148)
        Me.lblicalr.Name = "lblicalr"
        Me.lblicalr.Size = New System.Drawing.Size(0, 17)
        Me.lblicalr.TabIndex = 14
        '
        'lblcnalr
        '
        Me.lblcnalr.AutoSize = True
        Me.lblcnalr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcnalr.ForeColor = System.Drawing.Color.Red
        Me.lblcnalr.Location = New System.Drawing.Point(221, 204)
        Me.lblcnalr.Name = "lblcnalr"
        Me.lblcnalr.Size = New System.Drawing.Size(0, 17)
        Me.lblcnalr.TabIndex = 15
        '
        'lblemailalr
        '
        Me.lblemailalr.AutoSize = True
        Me.lblemailalr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemailalr.ForeColor = System.Drawing.Color.Red
        Me.lblemailalr.Location = New System.Drawing.Point(221, 265)
        Me.lblemailalr.Name = "lblemailalr"
        Me.lblemailalr.Size = New System.Drawing.Size(0, 17)
        Me.lblemailalr.TabIndex = 16
        '
        'lblcarplatealr
        '
        Me.lblcarplatealr.AutoSize = True
        Me.lblcarplatealr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarplatealr.ForeColor = System.Drawing.Color.Red
        Me.lblcarplatealr.Location = New System.Drawing.Point(221, 325)
        Me.lblcarplatealr.Name = "lblcarplatealr"
        Me.lblcarplatealr.Size = New System.Drawing.Size(0, 17)
        Me.lblcarplatealr.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnconfirm)
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(49, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(465, 423)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'Adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(561, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblcarplatealr)
        Me.Controls.Add(Me.lblemailalr)
        Me.Controls.Add(Me.lblcnalr)
        Me.Controls.Add(Me.lblicalr)
        Me.Controls.Add(Me.lblnamealr)
        Me.Controls.Add(Me.msktxtcn)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtcarplate)
        Me.Controls.Add(Me.txtic)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblcarplate)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblcn)
        Me.Controls.Add(Me.lblic)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Adduser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents lblic As Label
    Friend WithEvents lblcn As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblcarplate As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtic As TextBox
    Friend WithEvents txtcarplate As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents msktxtcn As MaskedTextBox
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents lblnamealr As Label
    Friend WithEvents lblicalr As Label
    Friend WithEvents lblcnalr As Label
    Friend WithEvents lblemailalr As Label
    Friend WithEvents lblcarplatealr As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
