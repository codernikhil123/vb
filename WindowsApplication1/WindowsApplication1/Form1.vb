Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As Double
        Dim c As Double

        f = Val(TextBox1.Text)
        If Val(f) = 0 And TextBox1.Text = "" Then
            MsgBox("Enter Any number", vbInformation, "Result")
            TextBox1.Focus()
        Else
            c = (f * 9 / 5) + 32
            'c = 9 * f \ 5 + 32
            MsgBox("celsius :" & " " & , vbInformation, "Result")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As Double
        Dim k As Double

        f = Val(TextBox1.Text)
        If Val(f) = 0 And TextBox1.Text = "" Then
            MsgBox("Enter Any number", vbInformation, "Result")
            TextBox1.Focus()
        Else
            k = 273.5 + ((f - 32.0) * (5.0 / 9.0))
            'K = 273.5 + ((F - 32.0) * (5.0/9.0))
            MsgBox("kelvin :" & " " & k, vbInformation, "Result")
        End If
    End Sub
End Class
