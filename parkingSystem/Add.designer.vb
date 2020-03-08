<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add))
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblic = New System.Windows.Forms.Label()
        Me.lblcn = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcarplate = New System.Windows.Forms.Label()
        Me.lblpsid = New System.Windows.Forms.Label()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.lbldeposit = New System.Windows.Forms.Label()
        Me.grpadduser = New System.Windows.Forms.GroupBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtcn = New System.Windows.Forms.TextBox()
        Me.txtcarplate = New System.Windows.Forms.TextBox()
        Me.txtic = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.grpps = New System.Windows.Forms.GroupBox()
        Me.txtdatereg = New System.Windows.Forms.TextBox()
        Me.lbldatereg = New System.Windows.Forms.Label()
        Me.txtdeposit = New System.Windows.Forms.TextBox()
        Me.txtpayment = New System.Windows.Forms.TextBox()
        Me.txtpsid = New System.Windows.Forms.TextBox()
        Me.cboxduration = New System.Windows.Forms.ComboBox()
        Me.lblduration = New System.Windows.Forms.Label()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.btnsearchic = New System.Windows.Forms.Button()
        Me.grpadduser.SuspendLayout()
        Me.grpps.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(27, 31)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(61, 24)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name"
        '
        'lblic
        '
        Me.lblic.AutoSize = True
        Me.lblic.Location = New System.Drawing.Point(27, 70)
        Me.lblic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblic.Name = "lblic"
        Me.lblic.Size = New System.Drawing.Size(27, 24)
        Me.lblic.TabIndex = 1
        Me.lblic.Text = "IC"
        '
        'lblcn
        '
        Me.lblcn.AutoSize = True
        Me.lblcn.Location = New System.Drawing.Point(27, 110)
        Me.lblcn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcn.Name = "lblcn"
        Me.lblcn.Size = New System.Drawing.Size(105, 24)
        Me.lblcn.TabIndex = 2
        Me.lblcn.Text = "Contact no."
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(25, 149)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(132, 24)
        Me.lblemail.TabIndex = 3
        Me.lblemail.Text = "Email Address"
        '
        'lblcarplate
        '
        Me.lblcarplate.AutoSize = True
        Me.lblcarplate.Location = New System.Drawing.Point(27, 188)
        Me.lblcarplate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcarplate.Name = "lblcarplate"
        Me.lblcarplate.Size = New System.Drawing.Size(85, 24)
        Me.lblcarplate.TabIndex = 4
        Me.lblcarplate.Text = "Car Plate"
        '
        'lblpsid
        '
        Me.lblpsid.AutoSize = True
        Me.lblpsid.Location = New System.Drawing.Point(27, 39)
        Me.lblpsid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpsid.Name = "lblpsid"
        Me.lblpsid.Size = New System.Drawing.Size(131, 24)
        Me.lblpsid.TabIndex = 5
        Me.lblpsid.Text = "Parking Slot ID"
        '
        'lblpayment
        '
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Location = New System.Drawing.Point(27, 118)
        Me.lblpayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(151, 24)
        Me.lblpayment.TabIndex = 7
        Me.lblpayment.Text = "Parking Payment"
        '
        'lbldeposit
        '
        Me.lbldeposit.AutoSize = True
        Me.lbldeposit.Location = New System.Drawing.Point(27, 158)
        Me.lbldeposit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldeposit.Name = "lbldeposit"
        Me.lbldeposit.Size = New System.Drawing.Size(144, 24)
        Me.lbldeposit.TabIndex = 8
        Me.lbldeposit.Text = "Deposit needed"
        '
        'grpadduser
        '
        Me.grpadduser.BackColor = System.Drawing.SystemColors.Info
        Me.grpadduser.Controls.Add(Me.txtemail)
        Me.grpadduser.Controls.Add(Me.lblname)
        Me.grpadduser.Controls.Add(Me.txtcn)
        Me.grpadduser.Controls.Add(Me.txtcarplate)
        Me.grpadduser.Controls.Add(Me.lblic)
        Me.grpadduser.Controls.Add(Me.txtic)
        Me.grpadduser.Controls.Add(Me.lblcarplate)
        Me.grpadduser.Controls.Add(Me.txtname)
        Me.grpadduser.Controls.Add(Me.lblemail)
        Me.grpadduser.Controls.Add(Me.lblcn)
        Me.grpadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpadduser.Location = New System.Drawing.Point(45, 15)
        Me.grpadduser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpadduser.Name = "grpadduser"
        Me.grpadduser.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpadduser.Size = New System.Drawing.Size(421, 233)
        Me.grpadduser.TabIndex = 9
        Me.grpadduser.TabStop = False
        Me.grpadduser.Text = "Owner Details"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(195, 145)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(187, 29)
        Me.txtemail.TabIndex = 14
        '
        'txtcn
        '
        Me.txtcn.Location = New System.Drawing.Point(195, 106)
        Me.txtcn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcn.Name = "txtcn"
        Me.txtcn.Size = New System.Drawing.Size(187, 29)
        Me.txtcn.TabIndex = 13
        '
        'txtcarplate
        '
        Me.txtcarplate.Location = New System.Drawing.Point(195, 185)
        Me.txtcarplate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcarplate.Name = "txtcarplate"
        Me.txtcarplate.Size = New System.Drawing.Size(187, 29)
        Me.txtcarplate.TabIndex = 15
        '
        'txtic
        '
        Me.txtic.Location = New System.Drawing.Point(195, 66)
        Me.txtic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtic.Name = "txtic"
        Me.txtic.Size = New System.Drawing.Size(187, 29)
        Me.txtic.TabIndex = 12
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(195, 27)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(187, 29)
        Me.txtname.TabIndex = 11
        '
        'grpps
        '
        Me.grpps.BackColor = System.Drawing.SystemColors.Info
        Me.grpps.Controls.Add(Me.txtdatereg)
        Me.grpps.Controls.Add(Me.lbldatereg)
        Me.grpps.Controls.Add(Me.txtdeposit)
        Me.grpps.Controls.Add(Me.txtpayment)
        Me.grpps.Controls.Add(Me.txtpsid)
        Me.grpps.Controls.Add(Me.cboxduration)
        Me.grpps.Controls.Add(Me.lblduration)
        Me.grpps.Controls.Add(Me.lblpsid)
        Me.grpps.Controls.Add(Me.lbldeposit)
        Me.grpps.Controls.Add(Me.lblpayment)
        Me.grpps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpps.Location = New System.Drawing.Point(45, 255)
        Me.grpps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpps.Name = "grpps"
        Me.grpps.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpps.Size = New System.Drawing.Size(421, 244)
        Me.grpps.TabIndex = 10
        Me.grpps.TabStop = False
        Me.grpps.Text = "Parking Slot Details"
        '
        'txtdatereg
        '
        Me.txtdatereg.Location = New System.Drawing.Point(195, 196)
        Me.txtdatereg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtdatereg.Name = "txtdatereg"
        Me.txtdatereg.Size = New System.Drawing.Size(187, 29)
        Me.txtdatereg.TabIndex = 21
        '
        'lbldatereg
        '
        Me.lbldatereg.AutoSize = True
        Me.lbldatereg.Location = New System.Drawing.Point(27, 197)
        Me.lbldatereg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldatereg.Name = "lbldatereg"
        Me.lbldatereg.Size = New System.Drawing.Size(144, 24)
        Me.lbldatereg.TabIndex = 20
        Me.lbldatereg.Text = "Date Registered"
        '
        'txtdeposit
        '
        Me.txtdeposit.Location = New System.Drawing.Point(195, 156)
        Me.txtdeposit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtdeposit.Name = "txtdeposit"
        Me.txtdeposit.Size = New System.Drawing.Size(187, 29)
        Me.txtdeposit.TabIndex = 16
        '
        'txtpayment
        '
        Me.txtpayment.Location = New System.Drawing.Point(195, 117)
        Me.txtpayment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(187, 29)
        Me.txtpayment.TabIndex = 19
        '
        'txtpsid
        '
        Me.txtpsid.Location = New System.Drawing.Point(195, 36)
        Me.txtpsid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpsid.Name = "txtpsid"
        Me.txtpsid.Size = New System.Drawing.Size(187, 29)
        Me.txtpsid.TabIndex = 18
        '
        'cboxduration
        '
        Me.cboxduration.FormattingEnabled = True
        Me.cboxduration.Location = New System.Drawing.Point(195, 75)
        Me.cboxduration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxduration.Name = "cboxduration"
        Me.cboxduration.Size = New System.Drawing.Size(187, 32)
        Me.cboxduration.TabIndex = 17
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Location = New System.Drawing.Point(27, 79)
        Me.lblduration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(80, 24)
        Me.lblduration.TabIndex = 9
        Me.lblduration.Text = "Duration"
        '
        'btnconfirm
        '
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(487, 290)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(153, 63)
        Me.btnconfirm.TabIndex = 11
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(487, 361)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(153, 63)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(487, 431)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(153, 63)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnadduser
        '
        Me.btnadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadduser.Location = New System.Drawing.Point(487, 42)
        Me.btnadduser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(153, 86)
        Me.btnadduser.TabIndex = 14
        Me.btnadduser.Text = "Add New Car Owner"
        Me.btnadduser.UseVisualStyleBackColor = True
        '
        'btnsearchic
        '
        Me.btnsearchic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchic.Location = New System.Drawing.Point(487, 135)
        Me.btnsearchic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsearchic.Name = "btnsearchic"
        Me.btnsearchic.Size = New System.Drawing.Size(153, 94)
        Me.btnsearchic.TabIndex = 20
        Me.btnsearchic.Text = "Search Existing Car Owner"
        Me.btnsearchic.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(677, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnsearchic)
        Me.Controls.Add(Me.btnadduser)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.grpps)
        Me.Controls.Add(Me.grpadduser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Parking Slot"
        Me.grpadduser.ResumeLayout(False)
        Me.grpadduser.PerformLayout()
        Me.grpps.ResumeLayout(False)
        Me.grpps.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents lblic As Label
    Friend WithEvents lblcn As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblcarplate As Label
    Friend WithEvents lblpsid As Label
    Friend WithEvents lblpayment As Label
    Friend WithEvents lbldeposit As Label
    Friend WithEvents grpadduser As GroupBox
    Friend WithEvents grpps As GroupBox
    Friend WithEvents txtcarplate As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtcn As TextBox
    Friend WithEvents txtic As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblduration As Label
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents txtpsid As TextBox
    Friend WithEvents cboxduration As ComboBox
    Friend WithEvents btnadduser As Button
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents btnsearchic As Button
    Friend WithEvents txtdeposit As TextBox
    Friend WithEvents txtdatereg As TextBox
    Friend WithEvents lbldatereg As Label
End Class
