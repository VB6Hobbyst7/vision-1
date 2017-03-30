Public Class StartScreen
    Public i As Double
    Dim points As String
    Private Sub StartScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Label1.Text = "程序加载中....."
        i = 0
        points = "."
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If startScreenState = True Then
            Label1.Text = "程序加载中" + points
            If i > 3 Then
                points = "."
                i = 0
            Else
                points += "."
                i += 1
            End If
        Else
            Timer1.Stop()
        End If
    End Sub
End Class