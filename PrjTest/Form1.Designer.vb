﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConfused = New System.Windows.Forms.Button()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.btnPuhasta = New System.Windows.Forms.Button()
        Me.UCtrlEmotion1 = New PrjFaces.UCtrlEmotion()
        Me.UBulb1 = New PrjBulbAndSwitch.UBulb()
        Me.USwitch1 = New PrjSwitch.USwitch()
        Me.SuspendLayout()
        '
        'btnConfused
        '
        Me.btnConfused.Location = New System.Drawing.Point(495, 56)
        Me.btnConfused.Name = "btnConfused"
        Me.btnConfused.Size = New System.Drawing.Size(75, 23)
        Me.btnConfused.TabIndex = 1
        Me.btnConfused.Text = "Confused"
        Me.btnConfused.UseVisualStyleBackColor = True
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(495, 114)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(75, 23)
        Me.btnCool.TabIndex = 2
        Me.btnCool.Text = "Cool"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(495, 171)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(75, 23)
        Me.btnSmile.TabIndex = 3
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(495, 229)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(75, 23)
        Me.btnStar.TabIndex = 4
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnTeeth
        '
        Me.btnTeeth.Location = New System.Drawing.Point(495, 290)
        Me.btnTeeth.Name = "btnTeeth"
        Me.btnTeeth.Size = New System.Drawing.Size(75, 23)
        Me.btnTeeth.TabIndex = 5
        Me.btnTeeth.Text = "Teeth"
        Me.btnTeeth.UseVisualStyleBackColor = True
        '
        'btnYell
        '
        Me.btnYell.Location = New System.Drawing.Point(495, 345)
        Me.btnYell.Name = "btnYell"
        Me.btnYell.Size = New System.Drawing.Size(75, 23)
        Me.btnYell.TabIndex = 6
        Me.btnYell.Text = "Yell"
        Me.btnYell.UseVisualStyleBackColor = True
        '
        'btnPuhasta
        '
        Me.btnPuhasta.Location = New System.Drawing.Point(495, 398)
        Me.btnPuhasta.Name = "btnPuhasta"
        Me.btnPuhasta.Size = New System.Drawing.Size(75, 23)
        Me.btnPuhasta.TabIndex = 7
        Me.btnPuhasta.Text = "Puhasta"
        Me.btnPuhasta.UseVisualStyleBackColor = True
        '
        'UCtrlEmotion1
        '
        Me.UCtrlEmotion1.Location = New System.Drawing.Point(12, 12)
        Me.UCtrlEmotion1.Name = "UCtrlEmotion1"
        Me.UCtrlEmotion1.Size = New System.Drawing.Size(168, 168)
        Me.UCtrlEmotion1.TabIndex = 0
        '
        'UBulb1
        '
        Me.UBulb1.Location = New System.Drawing.Point(635, 56)
        Me.UBulb1.Name = "UBulb1"
        Me.UBulb1.Size = New System.Drawing.Size(157, 257)
        Me.UBulb1.TabIndex = 9
        '
        'USwitch1
        '
        Me.USwitch1.Location = New System.Drawing.Point(650, 363)
        Me.USwitch1.Name = "USwitch1"
        Me.USwitch1.Size = New System.Drawing.Size(111, 58)
        Me.USwitch1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 465)
        Me.Controls.Add(Me.UBulb1)
        Me.Controls.Add(Me.USwitch1)
        Me.Controls.Add(Me.btnPuhasta)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.btnConfused)
        Me.Controls.Add(Me.UCtrlEmotion1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UCtrlEmotion1 As PrjFaces.UCtrlEmotion
    Friend WithEvents btnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnTeeth As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents btnPuhasta As Button
    Friend WithEvents USwitch1 As PrjSwitch.USwitch
    Friend WithEvents UBulb1 As PrjBulbAndSwitch.UBulb
End Class
