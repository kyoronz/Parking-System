<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.pcbAdd = New System.Windows.Forms.PictureBox()
        Me.pcbView = New System.Windows.Forms.PictureBox()
        Me.pcbBack = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbltext = New System.Windows.Forms.Label()
        CType(Me.pcbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbAdd
        '
        Me.pcbAdd.Image = CType(resources.GetObject("pcbAdd.Image"), System.Drawing.Image)
        Me.pcbAdd.Location = New System.Drawing.Point(20, 224)
        Me.pcbAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbAdd.Name = "pcbAdd"
        Me.pcbAdd.Size = New System.Drawing.Size(437, 346)
        Me.pcbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbAdd.TabIndex = 6
        Me.pcbAdd.TabStop = False
        '
        'pcbView
        '
        Me.pcbView.Image = CType(resources.GetObject("pcbView.Image"), System.Drawing.Image)
        Me.pcbView.Location = New System.Drawing.Point(471, 224)
        Me.pcbView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbView.Name = "pcbView"
        Me.pcbView.Size = New System.Drawing.Size(437, 346)
        Me.pcbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbView.TabIndex = 7
        Me.pcbView.TabStop = False
        '
        'pcbBack
        '
        Me.pcbBack.Image = CType(resources.GetObject("pcbBack.Image"), System.Drawing.Image)
        Me.pcbBack.Location = New System.Drawing.Point(923, 224)
        Me.pcbBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbBack.Name = "pcbBack"
        Me.pcbBack.Size = New System.Drawing.Size(437, 346)
        Me.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBack.TabIndex = 8
        Me.pcbBack.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(373, 12)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(600, 185)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.Location = New System.Drawing.Point(580, 622)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(0, 69)
        Me.lbltext.TabIndex = 11
        Me.lbltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1360, 741)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pcbBack)
        Me.Controls.Add(Me.pcbView)
        Me.Controls.Add(Me.pcbAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pcbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbAdd As PictureBox
    Friend WithEvents pcbView As PictureBox
    Friend WithEvents pcbBack As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lbltext As Label
End Class
