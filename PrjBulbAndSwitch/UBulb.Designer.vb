<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UBulb
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UBulb))
        Me.pbBulb = New System.Windows.Forms.PictureBox()
        Me.imgBulb = New System.Windows.Forms.ImageList(Me.components)
        Me.UCtrlEmotion1 = New PrjFaces.UCtrlEmotion()
        CType(Me.pbBulb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbBulb
        '
        Me.pbBulb.Location = New System.Drawing.Point(131, 113)
        Me.pbBulb.Name = "pbBulb"
        Me.pbBulb.Size = New System.Drawing.Size(143, 155)
        Me.pbBulb.TabIndex = 1
        Me.pbBulb.TabStop = False
        '
        'imgBulb
        '
        Me.imgBulb.ImageStream = CType(resources.GetObject("imgBulb.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBulb.TransparentColor = System.Drawing.Color.Transparent
        Me.imgBulb.Images.SetKeyName(0, "bulb.PNG")
        Me.imgBulb.Images.SetKeyName(1, "bulb2.PNG")
        '
        'UCtrlEmotion1
        '
        Me.UCtrlEmotion1.Location = New System.Drawing.Point(93, 64)
        Me.UCtrlEmotion1.Name = "UCtrlEmotion1"
        Me.UCtrlEmotion1.Size = New System.Drawing.Size(231, 229)
        Me.UCtrlEmotion1.TabIndex = 0
        '
        'UBulb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbBulb)
        Me.Controls.Add(Me.UCtrlEmotion1)
        Me.Name = "UBulb"
        Me.Size = New System.Drawing.Size(401, 372)
        CType(Me.pbBulb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UCtrlEmotion1 As PrjFaces.UCtrlEmotion
    Friend WithEvents pbBulb As PictureBox
    Friend WithEvents imgBulb As ImageList
End Class
