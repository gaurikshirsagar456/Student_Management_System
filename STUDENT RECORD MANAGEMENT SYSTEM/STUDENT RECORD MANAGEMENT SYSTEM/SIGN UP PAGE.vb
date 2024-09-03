Imports System.Text.RegularExpressions
Public Class SIGN_UP_PAGE

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regex As Regex = New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$")
        Dim Isvalid As Boolean = regex.IsMatch(TextBox1.Text.Trim)
        If Not Isvalid Then
            MessageBox.Show("INVALID EMAIL.")
        Else
            MessageBox.Show("VALID EMAIL.")
        End If
        LOGIN_PAGE.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_Keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("This Field Will Accept Letters Only")


        End If

    End Sub

    Private Sub TextBox1_Keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("This Field Will Accept Letters Only")


        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub



    Private Sub TextBox5_Keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
 And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("This Field Will Accept Numbers Only")


        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
       
    End Sub
End Class