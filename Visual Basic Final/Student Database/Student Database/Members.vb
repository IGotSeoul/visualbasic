Module Members
	Const intMax As Integer = 100
	Public member_code_array(intMax) As Integer
	Public age_array(intMax) As Integer
	Public member_type_array(intMax) As String
	Public first_name_array(intMax) As String
	Public last_name_array(intMax) As String
	Public gender_array(intMax) As String
	Public new_array_age(intMax) As Integer

	Public count As Integer = -1
	Public i As Integer

	Public Sub AddMember(ByVal age As String, ByVal member_code As String, ByVal first As String, ByVal last As String, ByVal member_type As String, ByVal gender As String)
		Dim age_test As Boolean
		age_array(count) = CInt(age)
		member_code_array(count) = CInt(member_code)
			member_type_array(count) = CStr(member_type)
			first_name_array(count) = CStr(first)
			last_name_array(count) = CStr(last)
		gender_array(count) = CStr(gender)

		If age_test = True Then


			If gender.Equals("m", StringComparison.CurrentCultureIgnoreCase) Or gender.Equals("male", StringComparison.CurrentCultureIgnoreCase) Then
				gender = "male"
			ElseIf gender.Equals("f", StringComparison.CurrentCultureIgnoreCase) Or gender.Equals("female", StringComparison.CurrentCultureIgnoreCase) Then
				gender = "female"
			End If

			If member_type.Equals("single", StringComparison.CurrentCultureIgnoreCase) Then
				member_type = "Single"
			ElseIf member_type.Equals("couple", StringComparison.CurrentCultureIgnoreCase) Then
				member_type = "Couple"
			ElseIf member_type.Equals("family", StringComparison.CurrentCultureIgnoreCase) Then
				member_type = "Family"
			End If
		Else
			MsgBox("Please correct input")
		End If
	End Sub
End Module