
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "RAJU SHARMA"
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(TextBox2.Text) >= 0 And Val(TextBox2.Text) <= 39 Then
            TextBox3.Text = "FAIL"
        End If

        If Val(TextBox2.Text) >= 40 And Val(TextBox2.Text) <= 45 Then
            TextBox3.Text = "THIRD"
        End If

        If Val(TextBox2.Text) >= 46 And Val(TextBox2.Text) <= 59 Then
            TextBox3.Text = "SECOND"
        End If

        If Val(TextBox2.Text) >= 60 And Val(TextBox2.Text) <= 75 Then
            TextBox3.Text = "FIRST"
        End If

        If Val(TextBox2.Text) >= 76 And Val(TextBox2.Text) <= 100 Then
            TextBox3.Text = "DC"
        End If
    End Sub
End Class
