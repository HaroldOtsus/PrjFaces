Public Class USwitch
    'N2itab, mis olekus nupp on
    Public currentState As Integer = 0
    'S6ndmus - kui vajutatakse hiirega graafilise liidese peale
    Public Event Clicked()
    'Kuvatava pildi m22ramiseks
    Private Sub selectSwitch(ByVal intState As Integer)
        pbSwitch.Image = imgSwitch.Images(intState)
    End Sub
    'M22rab, mis pilti kuvab, 0 = nupp on OFF olekus ja 1 = nupp on ON olekus
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
    'Nupu peale vajutamise tagaj2rjel t2idetav s6ndmus
    Public Sub pbSwitch_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click
        RaiseEvent Clicked()
        'Kui praegune olek(currentState) on 0, siis vajutamise peale muutub see 1-ks
        'Kui praegune olek(currentState) on 1, siis vajutamise peale muutub see 0-ks
        If currentState = 0 Then
            setSwitch(1)
            currentState = 1
        ElseIf currentState = 1 Then
            setSwitch(0)
            currentState = 0
        End If
    End Sub
End Class
