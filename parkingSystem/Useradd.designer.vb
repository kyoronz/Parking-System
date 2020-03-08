<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Useradd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Useradd))
        Me.btnclear = New System.Windows.Forms.Button()
        Me.cboxacctype = New System.Windows.Forms.ComboBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.lblacctype = New System.Windows.Forms.Label()
        Me.txtrepsw = New System.Windows.Forms.TextBox()
        Me.txtpsw = New System.Windows.Forms.TextBox()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblrepsw = New System.Windows.Forms.Label()
        Me.lblpsw = New System.Windows.Forms.Label()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.grpuserinfo = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.grpuserinfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(257, 372)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(153, 63)
        Me.btnclear.TabIndex = 32
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'cboxacctype
        '
        Me.cboxacctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxacctype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxacctype.FormattingEnabled = True
        Me.cboxacctype.Location = New System.Drawing.Point(257, 278)
        Me.cboxacctype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxacctype.Name = "cboxacctype"
        Me.cboxacctype.Size = New System.Drawing.Size(193, 30)
        Me.cboxacctype.TabIndex = 4
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(473, 372)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(153, 63)
        Me.btncancel.TabIndex = 27
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnconfirm
        '
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(35, 372)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(153, 63)
        Me.btnconfirm.TabIndex = 26
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'lblacctype
        '
        Me.lblacctype.AutoSize = True
        Me.lblacctype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacctype.Location = New System.Drawing.Point(45, 282)
        Me.lblacctype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblacctype.Name = "lblacctype"
        Me.lblacctype.Size = New System.Drawing.Size(128, 24)
        Me.lblacctype.TabIndex = 25
        Me.lblacctype.Text = "Account Type"
        '
        'txtrepsw
        '
        Me.txtrepsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepsw.Location = New System.Drawing.Point(257, 220)
        Me.txtrepsw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtrepsw.Name = "txtrepsw"
        Me.txtrepsw.Size = New System.Drawing.Size(193, 28)
        Me.txtrepsw.TabIndex = 3
        Me.txtrepsw.UseSystemPasswordChar = True
        '
        'txtpsw
        '
        Me.txtpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpsw.Location = New System.Drawing.Point(257, 162)
        Me.txtpsw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpsw.Name = "txtpsw"
        Me.txtpsw.Size = New System.Drawing.Size(193, 28)
        Me.txtpsw.TabIndex = 2
        Me.txtpsw.UseSystemPasswordChar = True
        '
        'txtusr
        '
        Me.txtusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusr.Location = New System.Drawing.Point(257, 105)
        Me.txtusr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(193, 28)
        Me.txtusr.TabIndex = 1
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(257, 48)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(193, 28)
        Me.txtname.TabIndex = 0
        '
        'lblrepsw
        '
        Me.lblrepsw.AutoSize = True
        Me.lblrepsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepsw.Location = New System.Drawing.Point(45, 224)
        Me.lblrepsw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrepsw.Name = "lblrepsw"
        Me.lblrepsw.Size = New System.Drawing.Size(170, 24)
        Me.lblrepsw.TabIndex = 20
        Me.lblrepsw.Text = "Re-enter Password"
        '
        'lblpsw
        '
        Me.lblpsw.AutoSize = True
        Me.lblpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpsw.Location = New System.Drawing.Point(45, 166)
        Me.lblpsw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpsw.Name = "lblpsw"
        Me.lblpsw.Size = New System.Drawing.Size(92, 24)
        Me.lblpsw.TabIndex = 18
        Me.lblpsw.Text = "Password"
        '
        'lblusr
        '
        Me.lblusr.AutoSize = True
        Me.lblusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusr.Location = New System.Drawing.Point(45, 108)
        Me.lblusr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusr.Name = "lblusr"
        Me.lblusr.Size = New System.Drawing.Size(97, 24)
        Me.lblusr.TabIndex = 17
        Me.lblusr.Text = "Username"
        '
        'grpuserinfo
        '
        Me.grpuserinfo.Controls.Add(Me.Label4)
        Me.grpuserinfo.Controls.Add(Me.Label3)
        Me.grpuserinfo.Controls.Add(Me.Label2)
        Me.grpuserinfo.Controls.Add(Me.Label1)
        Me.grpuserinfo.Controls.Add(Me.cboxacctype)
        Me.grpuserinfo.Controls.Add(Me.lblname)
        Me.grpuserinfo.Controls.Add(Me.btnclear)
        Me.grpuserinfo.Controls.Add(Me.txtname)
        Me.grpuserinfo.Controls.Add(Me.txtusr)
        Me.grpuserinfo.Controls.Add(Me.txtpsw)
        Me.grpuserinfo.Controls.Add(Me.txtrepsw)
        Me.grpuserinfo.Controls.Add(Me.btnconfirm)
        Me.grpuserinfo.Controls.Add(Me.btncancel)
        Me.grpuserinfo.Controls.Add(Me.lblacctype)
        Me.grpuserinfo.Controls.Add(Me.lblpsw)
        Me.grpuserinfo.Controls.Add(Me.lblusr)
        Me.grpuserinfo.Controls.Add(Me.lblrepsw)
        Me.grpuserinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpuserinfo.Location = New System.Drawing.Point(101, 33)
        Me.grpuserinfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpuserinfo.Name = "grpuserinfo"
        Me.grpuserinfo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpuserinfo.Size = New System.Drawing.Size(664, 464)
        Me.grpuserinfo.TabIndex = 33
        Me.grpuserinfo.TabStop = False
        Me.grpuserinfo.Text = "User Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(253, 252)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(253, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(253, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(253, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 34
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(45, 50)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(61, 24)
        Me.lblname.TabIndex = 33
        Me.lblname.Text = "Name"
        '
        'Useradd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 537)
        Me.Controls.Add(Me.grpuserinfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Useradd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new user"
        Me.grpuserinfo.ResumeLayout(False)
        Me.grpuserinfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnclear As Button
    Friend WithEvents cboxacctype As ComboBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnconfirm As Button
    Friend WithEvents lblacctype As Label
    Friend WithEvents txtrepsw As TextBox
    Friend WithEvents txtpsw As TextBox
    Friend WithEvents txtusr As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblrepsw As Label
    Friend WithEvents lblpsw As Label
    Friend WithEvents lblusr As Label
    Friend WithEvents grpuserinfo As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblname As Label
End Class
