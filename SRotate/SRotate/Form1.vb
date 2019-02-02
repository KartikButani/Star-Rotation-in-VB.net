Public Class Form1
    Dim g As Graphics

    ' variable declaration
    Dim theta As Double = 3.1415 / 180
    Dim t(5) As Double
    Dim i As Integer = 1
    Dim xc, yc, r, cx, cy As Integer

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start() ' timer is star to draw the star
    End Sub

    Public Sub drawstar()
        g = Me.CreateGraphics
        g.Clear(Color.White)

     
        r = 80 ' size of object

        ' find a center point of the screen and assign a value of variable
        cx = (Me.Width / 2) - 30
        cy = (Me.Height / 2) - 30

        ' find out the xc and yc center point of the circle 
        xc = CInt(cx + Math.Cos(t(0)))
        yc = CInt(cy + Math.Sin(t(0)))

        ' find the acutal point of the draw the star
        Dim pts1(5) As Point
        For k As Integer = 0 To t.Length - 1
            pts1(k) = New Point(xc + CInt(r * Math.Cos(t(k))), yc + CInt(r * Math.Sin(t(k))))
        Next

        ' draw the star
        g.DrawPolygon(Pens.Black, pts1)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' this logic is apply for rotation of the star

        Dim angle As Integer = 360 / 5

        Dim j As Integer = 0 ' it is use to find the star 5 point 
        For k As Integer = 0 To t.Length - 1
            t(k) = theta * (angle + j + i) ' find out the theata value of the polygon
            j += 144
        Next
        i += 5 ' every time angle is change if i value is change to increment that is draw diffrent angle

        ' i += 10 then the rotation speed is increase
        ' i += 1 then the rotation speed is small

        ' so if you increase the value of i is high then speed is also high
        ' else speed is slow
        drawstar() ' call main star drawing funtion or may procedure
    End Sub
End Class
