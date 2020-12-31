Public Class Report
	Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
		lstDisplayAll.Items.Clear()
		If count > 0 Then
			For i = 0 To count - 1
				lstDisplayAll.Items.Add("Member Code: " + member_code_array(i).ToString + " | " + "Age: " + age_array(i).ToString + " | " + "Member Type: " + member_type_array(i) + " | " + "First Name: " + first_name_array(i) + " | " + "Last Name: " + last_name_array(i) + " | " + "Gender: " + gender_array(i))
			Next
			lblCount.Text = count.ToString
		Else
			lblCount.Text = ("No Results")
		End If

	End Sub

	Private Sub btnSearchGender_Click(sender As Object, e As EventArgs) Handles btnSearchGender.Click
		Dim searchgender As String
		searchgender = CStr(InputBox("Enter Gender"))
		If searchgender.Equals("m", StringComparison.CurrentCultureIgnoreCase) Or searchgender.Equals("male", StringComparison.CurrentCultureIgnoreCase) Then
			searchgender = "male"
		ElseIf searchgender.Equals("f", StringComparison.CurrentCultureIgnoreCase) Or searchgender.Equals("female", StringComparison.CurrentCultureIgnoreCase) Then
			searchgender = "female"
		End If
		lstDisplayAll.Items.Clear()
		If count > 0 Then
			Dim gender_count As Integer = 0
			For i = 0 To count
				Try
					If gender_array(i).Equals(searchgender, StringComparison.CurrentCultureIgnoreCase) Or gender_array(i).Equals(searchgender, StringComparison.CurrentCultureIgnoreCase) Then
						lstDisplayAll.Items.Add("Member Code: " + member_code_array(i).ToString + " | " + "Age: " + age_array(i).ToString + " | " + "Member Type: " + member_type_array(i) + " | " + "First Name: " + first_name_array(i) + " | " + "Last Name: " + last_name_array(i) + " | " + "Gender: " + gender_array(i))
						gender_count += 1
					Else
						lblCount.Text = ("No Results")
					End If
				Catch
					lblCount.Text = ("No Results")
				End Try
			Next
			lblCount.Text = gender_count.ToString
		Else
			lblCount.Text = ("No Results")
		End If

	End Sub

	Private Sub btnSearchType_Click(sender As Object, e As EventArgs) Handles btnSearchType.Click
		Dim searchtype As String
		searchtype = CStr(InputBox("Enter Type (Single, Couple, or Family"))
		If searchtype.Equals("single", StringComparison.CurrentCultureIgnoreCase) Then
			searchtype = "Single"
		ElseIf searchtype.Equals("couple", StringComparison.CurrentCultureIgnoreCase) Then
			searchtype = "Couple"
		ElseIf searchtype.Equals("family", StringComparison.CurrentCultureIgnoreCase) Then
			searchtype = "Family"
		End If
		lstDisplayAll.Items.Clear()
		If count > 0 Then
			Dim search_type_count As Integer = 0
			For i = 0 To count
				Try
					If member_type_array(i).Equals(searchtype, StringComparison.CurrentCultureIgnoreCase) Then
						lstDisplayAll.Items.Add("Member Code: " + member_code_array(i).ToString + " | " + "Age: " + age_array(i).ToString + " | " + "Member Type: " + member_type_array(i) + " | " + "First Name: " + first_name_array(i) + " | " + "Last Name: " + last_name_array(i) + " | " + "Gender: " + gender_array(i))
						search_type_count += 1
					Else
						lblCount.Text = ("No Results")
					End If
				Catch
					lblCount.Text = ("No Results")
				End Try
			Next
			lblCount.Text = search_type_count.ToString
		Else
			lblCount.Text = ("No Results")
		End If

	End Sub

	Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
		Dim searchID As Integer
		Try
			searchID = CInt(InputBox("Enter ID"))
		Catch
			lblCount.Text = ("Please enter numeric ID")
		End Try

		lstDisplayAll.Items.Clear()
		Dim search_ID_count As Integer = 0
		If count > 0 Then
			For i = 0 To count
				Try
					If member_code_array(i).Equals(searchID) Then
						lstDisplayAll.Items.Add("Member Code: " + member_code_array(i).ToString + " | " + "Age: " + age_array(i).ToString + " | " + "Member Type: " + member_type_array(i) + " | " + "First Name: " + first_name_array(i) + " | " + "Last Name: " + last_name_array(i) + " | " + "Gender: " + gender_array(i))
						search_ID_count += 1
					Else
						lblCount.Text = ("No Results")
					End If
				Catch
					lblCount.Text = ("No Results")
				End Try
			Next
			lblCount.Text = search_ID_count.ToString
		Else
			lblCount.Text = ("No Results")
		End If

	End Sub
End Class