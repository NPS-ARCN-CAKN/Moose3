<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreenForm))
        Me.MoosePictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ApplicationNameLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.MoosePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MoosePictureBox
        '
        Me.MoosePictureBox.Image = CType(resources.GetObject("MoosePictureBox.Image"), System.Drawing.Image)
        Me.MoosePictureBox.Location = New System.Drawing.Point(232, 83)
        Me.MoosePictureBox.Name = "MoosePictureBox"
        Me.MoosePictureBox.Size = New System.Drawing.Size(222, 89)
        Me.MoosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MoosePictureBox.TabIndex = 0
        Me.MoosePictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 123)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "National Park Service"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.ApplicationNameLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 80)
        Me.Panel1.TabIndex = 2
        '
        'ApplicationNameLabel
        '
        Me.ApplicationNameLabel.BackColor = System.Drawing.Color.Black
        Me.ApplicationNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ApplicationNameLabel.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationNameLabel.ForeColor = System.Drawing.Color.White
        Me.ApplicationNameLabel.Location = New System.Drawing.Point(0, 46)
        Me.ApplicationNameLabel.Name = "ApplicationNameLabel"
        Me.ApplicationNameLabel.Size = New System.Drawing.Size(456, 34)
        Me.ApplicationNameLabel.TabIndex = 2
        Me.ApplicationNameLabel.Text = "Alaska Moose Monitoring Database Application"
        '
        'VersionLabel
        '
        Me.VersionLabel.Location = New System.Drawing.Point(2, 83)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(224, 89)
        Me.VersionLabel.TabIndex = 3
        Me.VersionLabel.Text = "VersionLabel"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DescriptionLabel.Location = New System.Drawing.Point(0, 182)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(456, 71)
        Me.DescriptionLabel.TabIndex = 4
        Me.DescriptionLabel.Text = "DescriptionLabel"
        '
        'SplashScreenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(456, 253)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.MoosePictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreenForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreenForm"
        CType(Me.MoosePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MoosePictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ApplicationNameLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents DescriptionLabel As Label
End Class
