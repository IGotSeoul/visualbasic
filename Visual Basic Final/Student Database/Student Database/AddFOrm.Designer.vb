<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtGender = New System.Windows.Forms.TextBox()
		Me.txtAge1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtLast = New System.Windows.Forms.TextBox()
		Me.txtFirst = New System.Windows.Forms.TextBox()
		Me.btnAddMember = New System.Windows.Forms.Button()
		Me.txtCode = New System.Windows.Forms.TextBox()
		Me.txtMemberType = New System.Windows.Forms.TextBox()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.lblDisplay = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(30, 285)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(118, 20)
		Me.Label5.TabIndex = 26
		Me.Label5.Text = "Gender:"
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(30, 234)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(118, 20)
		Me.Label6.TabIndex = 25
		Me.Label6.Text = "Age:"
		'
		'txtGender
		'
		Me.txtGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.txtGender.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGender.Location = New System.Drawing.Point(248, 282)
		Me.txtGender.Name = "txtGender"
		Me.txtGender.Size = New System.Drawing.Size(167, 28)
		Me.txtGender.TabIndex = 24
		Me.ToolTip1.SetToolTip(Me.txtGender, "Male or Female" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'txtAge1
		'
		Me.txtAge1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAge1.Location = New System.Drawing.Point(248, 231)
		Me.txtAge1.Name = "txtAge1"
		Me.txtAge1.Size = New System.Drawing.Size(167, 28)
		Me.txtAge1.TabIndex = 23
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(30, 182)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(118, 20)
		Me.Label3.TabIndex = 22
		Me.Label3.Text = "Last Name:"
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(30, 131)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(118, 20)
		Me.Label4.TabIndex = 21
		Me.Label4.Text = "First Name:"
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(30, 80)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(126, 25)
		Me.Label2.TabIndex = 20
		Me.Label2.Text = "Member Type: "
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(30, 31)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(164, 23)
		Me.Label1.TabIndex = 19
		Me.Label1.Text = "Member Code:"
		'
		'txtLast
		'
		Me.txtLast.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLast.Location = New System.Drawing.Point(248, 179)
		Me.txtLast.Name = "txtLast"
		Me.txtLast.Size = New System.Drawing.Size(167, 28)
		Me.txtLast.TabIndex = 18
		'
		'txtFirst
		'
		Me.txtFirst.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFirst.Location = New System.Drawing.Point(248, 128)
		Me.txtFirst.Name = "txtFirst"
		Me.txtFirst.Size = New System.Drawing.Size(167, 28)
		Me.txtFirst.TabIndex = 17
		'
		'btnAddMember
		'
		Me.btnAddMember.BackColor = System.Drawing.Color.MediumTurquoise
		Me.btnAddMember.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddMember.Location = New System.Drawing.Point(300, 334)
		Me.btnAddMember.Name = "btnAddMember"
		Me.btnAddMember.Size = New System.Drawing.Size(115, 60)
		Me.btnAddMember.TabIndex = 27
		Me.btnAddMember.Text = "Add"
		Me.btnAddMember.UseVisualStyleBackColor = False
		'
		'txtCode
		'
		Me.txtCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCode.Location = New System.Drawing.Point(248, 28)
		Me.txtCode.Name = "txtCode"
		Me.txtCode.Size = New System.Drawing.Size(167, 28)
		Me.txtCode.TabIndex = 28
		'
		'txtMemberType
		'
		Me.txtMemberType.AutoCompleteCustomSource.AddRange(New String() {"Single", "Couple", "Family"})
		Me.txtMemberType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.txtMemberType.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMemberType.Location = New System.Drawing.Point(248, 77)
		Me.txtMemberType.Name = "txtMemberType"
		Me.txtMemberType.Size = New System.Drawing.Size(167, 28)
		Me.txtMemberType.TabIndex = 29
		Me.ToolTip1.SetToolTip(Me.txtMemberType, "Single, Couple, or Family" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'ToolTip1
		'
		'
		'lblDisplay
		'
		Me.lblDisplay.Location = New System.Drawing.Point(12, 334)
		Me.lblDisplay.Name = "lblDisplay"
		Me.lblDisplay.Size = New System.Drawing.Size(264, 60)
		Me.lblDisplay.TabIndex = 30
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Label7.Location = New System.Drawing.Point(31, 105)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(211, 25)
		Me.Label7.TabIndex = 31
		Me.Label7.Text = "(Single, Couple, Family)"
		'
		'AddForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkOrange
		Me.ClientSize = New System.Drawing.Size(446, 414)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.lblDisplay)
		Me.Controls.Add(Me.txtMemberType)
		Me.Controls.Add(Me.txtCode)
		Me.Controls.Add(Me.btnAddMember)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtGender)
		Me.Controls.Add(Me.txtAge1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtLast)
		Me.Controls.Add(Me.txtFirst)
		Me.Name = "AddForm"
		Me.Text = "Add"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtGender As TextBox
	Friend WithEvents txtAge1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtLast As TextBox
	Friend WithEvents txtFirst As TextBox
	Friend WithEvents btnAddMember As Button
	Friend WithEvents txtCode As TextBox
	Friend WithEvents txtMemberType As TextBox
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents lblDisplay As Label
	Friend WithEvents Label7 As Label
End Class
