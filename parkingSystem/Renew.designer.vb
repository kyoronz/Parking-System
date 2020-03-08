<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Renew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Renew))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.txtRenew = New System.Windows.Forms.TextBox()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.lblRenew = New System.Windows.Forms.Label()
        Me.rbo6 = New System.Windows.Forms.RadioButton()
        Me.rbo3 = New System.Windows.Forms.RadioButton()
        Me.btncan = New System.Windows.Forms.Button()
        Me.btncon = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.txtExp)
        Me.GroupBox1.Controls.Add(Me.txtRenew)
        Me.GroupBox1.Controls.Add(Me.lblExpired)
        Me.GroupBox1.Controls.Add(Me.lblRenew)
        Me.GroupBox1.Controls.Add(Me.rbo6)
        Me.GroupBox1.Controls.Add(Me.rbo3)
        Me.GroupBox1.Controls.Add(Me.btncan)
        Me.GroupBox1.Controls.Add(Me.btncon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(392, 366)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtExp
        '
        Me.txtExp.Enabled = False
        Me.txtExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExp.Location = New System.Drawing.Point(180, 201)
        Me.txtExp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(173, 29)
        Me.txtExp.TabIndex = 10
        '
        'txtRenew
        '
        Me.txtRenew.Enabled = False
        Me.txtRenew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRenew.Location = New System.Drawing.Point(180, 156)
        Me.txtRenew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRenew.Name = "txtRenew"
        Me.txtRenew.Size = New System.Drawing.Size(173, 29)
        Me.txtRenew.TabIndex = 9
        '
        'lblExpired
        '
        Me.lblExpired.AutoSize = True
        Me.lblExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpired.Location = New System.Drawing.Point(40, 204)
        Me.lblExpired.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(119, 24)
        Me.lblExpired.TabIndex = 8
        Me.lblExpired.Text = "Date Expired"
        '
        'lblRenew
        '
        Me.lblRenew.AutoSize = True
        Me.lblRenew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenew.Location = New System.Drawing.Point(40, 155)
        Me.lblRenew.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRenew.Name = "lblRenew"
        Me.lblRenew.Size = New System.Drawing.Size(113, 24)
        Me.lblRenew.TabIndex = 7
        Me.lblRenew.Text = "Date Renew"
        '
        'rbo6
        '
        Me.rbo6.AutoSize = True
        Me.rbo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbo6.Location = New System.Drawing.Point(208, 91)
        Me.rbo6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbo6.Name = "rbo6"
        Me.rbo6.Size = New System.Drawing.Size(108, 28)
        Me.rbo6.TabIndex = 6
        Me.rbo6.TabStop = True
        Me.rbo6.Text = "6 Months"
        Me.rbo6.UseVisualStyleBackColor = True
        '
        'rbo3
        '
        Me.rbo3.AutoSize = True
        Me.rbo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbo3.Location = New System.Drawing.Point(59, 91)
        Me.rbo3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbo3.Name = "rbo3"
        Me.rbo3.Size = New System.Drawing.Size(108, 28)
        Me.rbo3.TabIndex = 5
        Me.rbo3.TabStop = True
        Me.rbo3.Text = "3 Months"
        Me.rbo3.UseVisualStyleBackColor = True
        '
        'btncan
        '
        Me.btncan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncan.Location = New System.Drawing.Point(201, 268)
        Me.btncan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncan.Name = "btncan"
        Me.btncan.Size = New System.Drawing.Size(153, 63)
        Me.btncan.TabIndex = 4
        Me.btncan.Text = "Cancel"
        Me.btncan.UseVisualStyleBackColor = True
        '
        'btncon
        '
        Me.btncon.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btncon.Enabled = False
        Me.btncon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncon.Location = New System.Drawing.Point(43, 268)
        Me.btncon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncon.Name = "btncon"
        Me.btncon.Size = New System.Drawing.Size(153, 63)
        Me.btncon.TabIndex = 3
        Me.btncon.Text = "Confirm"
        Me.btncon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select duration:"
        '
        'Renew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(496, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Renew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Renew Carpark"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncan As Button
    Friend WithEvents btncon As Button
    Friend WithEvents rbo6 As RadioButton
    Friend WithEvents rbo3 As RadioButton
    Friend WithEvents lblExpired As Label
    Friend WithEvents lblRenew As Label
    Friend WithEvents txtExp As TextBox
    Friend WithEvents txtRenew As TextBox
End Class
