Public Class USwitch
    Private Sub selectSwitch(ByVal intState As Integer)
        pbSwitch.Image = imgSwitch.Images(intState)
    End Sub

    Public Sub setSwitch(ByVal intBulb As Integer)
        Select Case intBulb
            Case "0"
                Me.selectSwitch(0)
            Case "1"
                Me.selectSwitch(1)
            Case Else
                Me.selectSwitch(1)
        End Select
    End Sub
End Class
