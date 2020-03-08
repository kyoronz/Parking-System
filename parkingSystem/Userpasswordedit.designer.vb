<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Userpasswordedit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Userpasswordedit))
        Me.txtrepsw = New System.Windows.Forms.TextBox()
        Me.lblrepsw = New System.Windows.Forms.Label()
        Me.txtnewpsw = New System.Windows.Forms.TextBox()
        Me.txtoldpsw = New System.Windows.Forms.TextBox()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.lblnewpsw = New System.Windows.Forms.Label()
        Me.lbloldpsw = New System.Windows.Forms.Label()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtrepsw
        '
        Me.txtrepsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepsw.Location = New System.Drawing.Point(222, 146)
        Me.txtrepsw.Name = "txtrepsw"
        Me.txtrepsw.Size = New System.Drawing.Size(136, 24)
        Me.txtrepsw.TabIndex = 3
        Me.txtrepsw.UseSystemPasswordChar = True
        '
        'lblrepsw
        '
        Me.lblrepsw.AutoSize = True
        Me.lblrepsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepsw.Location = New System.Drawing.Point(82, 149)
        Me.lblrepsw.Name = "lblrepsw"
        Me.lblrepsw.Size = New System.Drawing.Size(132, 18)
        Me.lblrepsw.TabIndex = 18
        Me.lblrepsw.Text = "Confirm Password"
        '
        'txtnewpsw
        '
        Me.txtnewpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpsw.Location = New System.Drawing.Point(222, 110)
        Me.txtnewpsw.Name = "txtnewpsw"
        Me.txtnewpsw.Size = New System.Drawing.Size(136, 24)
        Me.txtnewpsw.TabIndex = 2
        Me.txtnewpsw.UseSystemPasswordChar = True
        '
        'txtoldpsw
        '
        Me.txtoldpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpsw.Location = New System.Drawing.Point(222, 74)
        Me.txtoldpsw.Name = "txtoldpsw"
        Me.txtoldpsw.Size = New System.Drawing.Size(136, 24)
        Me.txtoldpsw.TabIndex = 1
        Me.txtoldpsw.UseSystemPasswordChar = True
        '
        'txtusr
        '
        Me.txtusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusr.Location = New System.Drawing.Point(222, 38)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(136, 24)
        Me.txtusr.TabIndex = 0
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(311, 198)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(115, 51)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnconfirm
        '
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(29, 198)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(115, 51)
        Me.btnconfirm.TabIndex = 13
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'lblnewpsw
        '
        Me.lblnewpsw.AutoSize = True
        Me.lblnewpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewpsw.Location = New System.Drawing.Point(82, 113)
        Me.lblnewpsw.Name = "lblnewpsw"
        Me.lblnewpsw.Size = New System.Drawing.Size(107, 18)
        Me.lblnewpsw.TabIndex = 12
        Me.lblnewpsw.Text = "New password"
        '
        'lbloldpsw
        '
        Me.lbloldpsw.AutoSize = True
        Me.lbloldpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloldpsw.Location = New System.Drawing.Point(82, 77)
        Me.lbloldpsw.Name = "lbloldpsw"
        Me.lbloldpsw.Size = New System.Drawing.Size(100, 18)
        Me.lbloldpsw.TabIndex = 11
        Me.lbloldpsw.Text = "Old password"
        '
        'lblusr
        '
        Me.lblusr.AutoSize = True
        Me.lblusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusr.Location = New System.Drawing.Point(82, 41)
        Me.lblusr.Name = "lblusr"
        Me.lblusr.Size = New System.Drawing.Size(77, 18)
        Me.lblusr.TabIndex = 10
        Me.lblusr.Text = "Username"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncheck)
        Me.GroupBox1.Controls.Add(Me.txtrepsw)
        Me.GroupBox1.Controls.Add(Me.txtoldpsw)
        Me.GroupBox1.Controls.Add(Me.lblrepsw)
        Me.GroupBox1.Controls.Add(Me.lblusr)
        Me.GroupBox1.Controls.Add(Me.txtnewpsw)
        Me.GroupBox1.Controls.Add(Me.lbloldpsw)
        Me.GroupBox1.Controls.Add(Me.lblnewpsw)
        Me.GroupBox1.Controls.Add(Me.txtusr)
        Me.GroupBox1.Controls.Add(Me.btnconfirm)
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 282)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'btncheck
        '
        Me.btncheck.Location = New System.Drawing.Point(173, 198)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(115, 51)
        Me.btncheck.TabIndex = 19
        Me.btncheck.Text = "Check"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'Userpasswordedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(548, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Userpasswordedit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtrepsw As TextBox
    Friend WithEvents lblrepsw As Label
    Friend WithEvents txtnewpsw As TextBox
    Friend WithEvents txtoldpsw As TextBox
    Friend WithEvents txtusr As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnconfirm As Button
    Friend WithEvents lblnewpsw As Label
    Friend WithEvents lbloldpsw As Label
    Friend WithEvents lblusr As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncheck As Button
End Class
