Public Class UBulb
    'Kuvatava pildi m22ramiseks
    Private Sub selectBulb(ByVal intState As Integer)
        pbBulb.Image = imgBulb.Images(intState)
    End Sub
    'M22rab, millise pildi kuvab, 0 = pirn ei p6le ja 1 = pirn p6leb
    Public Sub setBulb(ByVal intBulb As Integer)
        Select Case intBulb
            Case "0"
                Me.selectBulb(0)
            Case "1"
                Me.selectBulb(1)
            Case Else
                Me.selectBulb(1)
        End Select
    End Sub
End Class
