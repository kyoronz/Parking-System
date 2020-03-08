<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminSubMenu))
        Me.pcbacc = New System.Windows.Forms.PictureBox()
        Me.pcbps = New System.Windows.Forms.PictureBox()
        Me.pcbrpt = New System.Windows.Forms.PictureBox()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltext1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.pcbacc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbrpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbacc
        '
        Me.pcbacc.BackColor = System.Drawing.SystemColors.Info
        Me.pcbacc.Image = CType(resources.GetObject("pcbacc.Image"), System.Drawing.Image)
        Me.pcbacc.Location = New System.Drawing.Point(8, 224)
        Me.pcbacc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbacc.Name = "pcbacc"
        Me.pcbacc.Size = New System.Drawing.Size(437, 346)
        Me.pcbacc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbacc.TabIndex = 4
        Me.pcbacc.TabStop = False
        '
        'pcbps
        '
        Me.pcbps.Image = CType(resources.GetObject("pcbps.Image"), System.Drawing.Image)
        Me.pcbps.Location = New System.Drawing.Point(461, 224)
        Me.pcbps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbps.Name = "pcbps"
        Me.pcbps.Size = New System.Drawing.Size(437, 346)
        Me.pcbps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbps.TabIndex = 5
        Me.pcbps.TabStop = False
        '
        'pcbrpt
        '
        Me.pcbrpt.Image = CType(resources.GetObject("pcbrpt.Image"), System.Drawing.Image)
        Me.pcbrpt.Location = New System.Drawing.Point(915, 224)
        Me.pcbrpt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbrpt.Name = "pcbrpt"
        Me.pcbrpt.Size = New System.Drawing.Size(437, 346)
        Me.pcbrpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbrpt.TabIndex = 6
        Me.pcbrpt.TabStop = False
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.Location = New System.Drawing.Point(453, 631)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(0, 69)
        Me.lbltext.TabIndex = 8
        Me.lbltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(373, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lbltext1
        '
        Me.lbltext1.AutoSize = True
        Me.lbltext1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext1.Location = New System.Drawing.Point(283, 631)
        Me.lbltext1.Name = "lbltext1"
        Me.lbltext1.Size = New System.Drawing.Size(0, 69)
        Me.lbltext1.TabIndex = 10
        Me.lbltext1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1360, 741)
        Me.Controls.Add(Me.lbltext1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.pcbrpt)
        Me.Controls.Add(Me.pcbps)
        Me.Controls.Add(Me.pcbacc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminSubMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AdminSubMenu"
        CType(Me.pcbacc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbrpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbacc As PictureBox
    Friend WithEvents pcbps As PictureBox
    Friend WithEvents pcbrpt As PictureBox
    Friend WithEvents lbltext As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltext1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
