Public Class UBulb
    Private Sub selectBulb(ByVal intState As Integer)
        pbBulb.Image = imgBulb.Images(intState)
    End Sub

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
