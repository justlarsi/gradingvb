Public Class Grade

    Public Sub SetStudentInfo(ByVal studentName As String, ByVal studentClass As String, ByVal average As Integer, ByVal grade As Char)
        lblname.Text = "NAME: " & studentName
        lblclass.Text = "CLASS: " & studentClass
        lblaverage.Text = "AVERAGE: " & average.ToString()
        lblgrade.Text = "GRADE: " & grade.ToString()
    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        Me.Hide()
    End Sub
End Class