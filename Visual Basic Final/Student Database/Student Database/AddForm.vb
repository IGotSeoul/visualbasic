Public Class AddForm
	Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
		If Len(txtCode.Text) > 4 Then
			lblDisplay.Text = "Code too long".ToString
		ElseIf Len(txtCode.Text) < 4 Then
			lblDisplay.Text = "Code too short".ToString
		Else
			Try
				member_code_array(count) = CInt(txtCode.Text)
				If String.IsNullOrEmpty(txtMemberType.Text) Or IsNumeric(txtMemberType.Text) Then
					lblDisplay.Text = "Please enter member type as Single, Couple, or Family"
				Else
					Try
						member_type_array(count) = CStr(txtMemberType.Text)
						If txtMemberType.Text.Equals("single", StringComparison.CurrentCultureIgnoreCase) Then
							txtMemberType.Text = "Single"
						ElseIf txtMemberType.Text.Equals("couple", StringComparison.CurrentCultureIgnoreCase) Then
							txtMemberType.Text = "Couple"
						ElseIf txtMemberType.Text.Equals("family", StringComparison.CurrentCultureIgnoreCase) Then
							txtMemberType.Text = "Family"
						End If
						If String.IsNullOrEmpty(txtFirst.Text) Or IsNumeric(txtFirst.Text) Then
							lblDisplay.Text = "Please enter first name"
						Else
							first_name_array(count) = CStr(txtFirst.Text)

							If String.IsNullOrEmpty(txtLast.Text) Or IsNumeric(txtLast.Text) Then
								lblDisplay.Text = "Please enter last name"
							Else
								first_name_array(count) = CStr(txtFirst.Text)

								Try
									age_array(count) = CInt(txtAge1.Text)
									If String.IsNullOrEmpty(txtGender.Text) Or IsNumeric(txtGender.Text) Then
										lblDisplay.Text = "Please enter gender"
									Else
										Try
											gender_array(count) = CStr(txtGender.Text)
											If txtGender.Text.Equals("m", StringComparison.CurrentCultureIgnoreCase) Or txtGender.Text.Equals("male", StringComparison.CurrentCultureIgnoreCase) Then
												gender_array(count) = "male"
											ElseIf txtGender.Text.Equals("f", StringComparison.CurrentCultureIgnoreCase) Or txtGender.Text.Equals("female", StringComparison.CurrentCultureIgnoreCase) Then
												gender_array(count) = "female"
											End If
											count += 1
											Me.Hide()
										Catch
											lblDisplay.Text = "Please enter gender "
										End Try
									End If
								Catch
									lblDisplay.Text = "Please enter numeric age"
								End Try
							End If
						End If
					Catch
						lblDisplay.Text = "Please enter Single, Couple, or Family"
					End Try
				End If
			Catch
				lblDisplay.Text = "Please enter 4 digit code"
			End Try
		End If
	End Sub


	Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

	End Sub

End Class