Public Class Main

	Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
		Dim modify_form As New Find
		modify_form.ShowDialog()
	End Sub

	Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
		Dim display_form As New Report
		display_form.ShowDialog()
	End Sub
End Class
