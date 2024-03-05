Public Class grading
    Private Sub calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate.Click
        Dim Mathematics As Integer
        Dim English As Integer
        Dim Kiswahili As Integer
        Dim Average As Integer
        Dim Grade As Char
        Dim Name As String
        Dim Clas As String
        Name = txtname.Text
        Clas = txtclass.Text




        If Integer.TryParse(txtmathematics.Text, Mathematics) AndAlso ValidMark(Mathematics) AndAlso Integer.TryParse(txtenglish.Text, English) AndAlso ValidMark(English) AndAlso Integer.TryParse(txtkiswahili.Text, Kiswahili) AndAlso ValidMark(Kiswahili) Then
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

            Dim form2 As New Grade()
            form2.SetStudentInfo(Name, Clas, Average, Grade)
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
        txtname.Text = String.Empty
        txtclass.Text = String.Empty


    End Sub
    Private Sub grade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade.Click
        Dim form2 As New Grade()
        form2.SetStudentInfo(txtname.Text, txtclass.Text, txtaverage.Text, txtgrade.Text)
        form2.Show()
    End Sub
    Private Sub leave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leave.Click
        Me.Close()
    End Sub


End Class


