Public Class PERSONAL_DETAILS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MEDICAL_FITNESS_REPORTS.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        INDEX_FORM.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty


    End Sub

 

    Private Sub PERSONAL_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class