Public Class grading
    Private Sub calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate.Click
        Dim Mathematics As Integer
        Dim English As Integer
        Dim Kiswahili As Integer
        Dim Average As Integer
        Dim Grade As Char

        If Integer.TryParse(txtmathematics.Text, Mathematics) AndAlso Integer.TryParse(txtenglish.Text, English) AndAlso Integer.TryParse(txtkiswahili.Text, Kiswahili) AndAlso ValidMark(Mathematics) AndAlso ValidMark(English) AndAlso ValidMark(Kiswahili) Then
            Mathematics = txtmathematics.Text
            English = txtenglish.Text
            Kiswahili = txtkiswahili.Text
            Average = ((Mathematics + English + Kiswahili) / 3)
            txtaverage.Text = Average.ToString


            If Average >= 85 AndAlso Average <= 100 Then
                Grade = "A"
            ElseIf Average >= 75 AndAlso Average < 85 Then
                Grade = "B"
            ElseIf Average >= 65 AndAlso Average < 75 Then
                Grade = "C"
            ElseIf Average >= 55 AndAlso Average < 65 Then
                Grade = "D"
            ElseIf Average >= 45 AndAlso Average < 55 Then
                Grade = "E"
            Else : Grade = "Fail"
            End If

            txtgrade.Text = Grade.ToString()
        Else
            MessageBox.Show("Please enter valid numeric scores in Mathematics, English and Kiswahili.")

        End If
    End Sub
    Private Function ValidMark(ByVal score As Integer) As Boolean
        Return score >= 1 AndAlso score <= 100
    End Function

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        txtmathematics.Text = String.Empty
        txtenglish.Text = String.Empty
        txtkiswahili.Text = String.Empty
        txtaverage.Text = String.Empty
        txtgrade.Text = String.Empty
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty


    End Sub
    Private Sub grade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade.Click
        txtgrade.Focus()
    End Sub
    Private Sub leave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leave.Click
        Me.Close()
    End Sub

End Class


