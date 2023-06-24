Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector(10), Vectors(15), A, S, I As Integer
        For I = 1 To 10
            vector(I) = Rnd() * 100
        Next
        For s = 1 To 15
            For a = 1 To 2
                I = I + 1
                Vectors(S) = vector(I)
                S = S + 1
            Next
            Vectors(S) = vector(I) + vector(I - 1)
        Next

    End Sub
End Class
