<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addsearchic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addsearchic))
        Me.lblenteric = New System.Windows.Forms.Label()
        Me.txtenteric = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcn = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcarplate = New System.Windows.Forms.TextBox()
        Me.lblcarplate = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcn = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblenteric
        '
        Me.lblenteric.AutoSize = True
        Me.lblenteric.BackColor = System.Drawing.SystemColors.Info
        Me.lblenteric.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenteric.Location = New System.Drawing.Point(25, 26)
        Me.lblenteric.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblenteric.Name = "lblenteric"
        Me.lblenteric.Size = New System.Drawing.Size(204, 24)
        Me.lblenteric.TabIndex = 0
        Me.lblenteric.Text = "Enter customer's IC :"
        '
        'txtenteric
        '
        Me.txtenteric.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtenteric.Location = New System.Drawing.Point(257, 22)
        Me.txtenteric.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtenteric.Name = "txtenteric"
        Me.txtenteric.Size = New System.Drawing.Size(204, 29)
        Me.txtenteric.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.txtenteric)
        Me.GroupBox2.Controls.Add(Me.lblenteric)
        Me.GroupBox2.Location = New System.Drawing.Point(63, 46)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(491, 73)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'txtcn
        '
        Me.txtcn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcn.Location = New System.Drawing.Point(225, 95)
        Me.txtcn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcn.Name = "txtcn"
        Me.txtcn.Size = New System.Drawing.Size(184, 29)
        Me.txtcn.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(225, 144)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(184, 29)
        Me.txtemail.TabIndex = 8
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(225, 46)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(184, 29)
        Me.txtname.TabIndex = 6
        '
        'txtcarplate
        '
        Me.txtcarplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarplate.Location = New System.Drawing.Point(225, 193)
        Me.txtcarplate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcarplate.Name = "txtcarplate"
        Me.txtcarplate.Size = New System.Drawing.Size(184, 29)
        Me.txtcarplate.TabIndex = 9
        '
        'lblcarplate
        '
        Me.lblcarplate.AutoSize = True
        Me.lblcarplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarplate.Location = New System.Drawing.Point(77, 197)
        Me.lblcarplate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcarplate.Name = "lblcarplate"
        Me.lblcarplate.Size = New System.Drawing.Size(85, 24)
        Me.lblcarplate.TabIndex = 5
        Me.lblcarplate.Text = "Car Plate"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(77, 148)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(57, 24)
        Me.lblemail.TabIndex = 4
        Me.lblemail.Text = "Email"
        '
        'lblcn
        '
        Me.lblcn.AutoSize = True
        Me.lblcn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcn.Location = New System.Drawing.Point(77, 98)
        Me.lblcn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcn.Name = "lblcn"
        Me.lblcn.Size = New System.Drawing.Size(105, 24)
        Me.lblcn.TabIndex = 3
        Me.lblcn.Text = "Contact no."
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(77, 49)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(61, 24)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Name"
        '
        'btncheck
        '
        Me.btncheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheck.Location = New System.Drawing.Point(168, 241)
        Me.btncheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(153, 63)
        Me.btncheck.TabIndex = 10
        Me.btncheck.Text = "Check"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'btnconfirm
        '
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(7, 241)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(153, 63)
        Me.btnconfirm.TabIndex = 12
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(329, 241)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(153, 63)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnconfirm)
        Me.GroupBox1.Controls.Add(Me.btncheck)
        Me.GroupBox1.Controls.Add(Me.lblname)
        Me.GroupBox1.Controls.Add(Me.lblcn)
        Me.GroupBox1.Controls.Add(Me.lblemail)
        Me.GroupBox1.Controls.Add(Me.lblcarplate)
        Me.GroupBox1.Controls.Add(Me.txtcarplate)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtcn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(63, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 324)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'Addsearchic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(616, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Addsearchic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblenteric As Label
    Friend WithEvents txtenteric As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcn As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtcarplate As TextBox
    Friend WithEvents lblcarplate As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblcn As Label
    Friend WithEvents lblname As Label
    Friend WithEvents btncheck As Button
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
