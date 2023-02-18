Public Class USwitch
    Public currentState As Integer = 0
    Public Event Clicked()
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

    Public Sub pbSwitch_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click
        RaiseEvent Clicked()
        If currentState = 0 Then
            setSwitch(1)
            currentState = 1
        ElseIf currentState = 1 Then
            setSwitch(0)
            currentState = 0
        End If
    End Sub
End Class
