Public Class Find
	Private Sub btnAddMemberForm_Click(sender As Object, e As EventArgs) Handles btnAddMemberForm.Click
		Dim add_form As New AddForm
		add_form.ShowDialog()
	End Sub

	Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
		lstSearchAll.Items.Clear()
		If count > 0 Then
			For i = 0 To count - 1
				lstSearchAll.Items.Add("Member Code: " + member_code_array(i).ToString + " | " + "Age: " + age_array(i).ToString + " | " + "Member Type: " + member_type_array(i) + " | " + "First Name: " + first_name_array(i) + " | " + "Last Name: " + last_name_array(i) + " | " + "Gender: " + gender_array(i))
			Next
			lblCount.Text = count.ToString
		Else
			lblCount.Text = ("0 items").ToString
		End If
	End Sub

	Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
		For index As Integer = lstSearchAll.SelectedItems.Count - 1 To 0 Step -1
			If index >= 0 Then
				lstSearchAll.Items.Remove(lstSearchAll.SelectedItems(index))
				count -= 1
				lblCount.Text = count.ToString
			Else
				lblCount.Text = "Please select an option"
			End If
		Next index
	End Sub
End Class