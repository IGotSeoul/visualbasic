<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Find
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
		Me.btnDisplay = New System.Windows.Forms.Button()
		Me.btnRemove = New System.Windows.Forms.Button()
		Me.btnAddMemberForm = New System.Windows.Forms.Button()
		Me.lstSearchAll = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblCount = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnDisplay
		'
		Me.btnDisplay.BackColor = System.Drawing.Color.MediumAquamarine
		Me.btnDisplay.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDisplay.Location = New System.Drawing.Point(922, 57)
		Me.btnDisplay.Name = "btnDisplay"
		Me.btnDisplay.Size = New System.Drawing.Size(115, 60)
		Me.btnDisplay.TabIndex = 4
		Me.btnDisplay.Text = "Search"
		Me.btnDisplay.UseVisualStyleBackColor = False
		'
		'btnRemove
		'
		Me.btnRemove.BackColor = System.Drawing.Color.MediumAquamarine
		Me.btnRemove.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRemove.Location = New System.Drawing.Point(922, 123)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(115, 60)
		Me.btnRemove.TabIndex = 5
		Me.btnRemove.Text = "Remove"
		Me.btnRemove.UseVisualStyleBackColor = False
		'
		'btnAddMemberForm
		'
		Me.btnAddMemberForm.BackColor = System.Drawing.Color.MediumAquamarine
		Me.btnAddMemberForm.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddMemberForm.Location = New System.Drawing.Point(922, 189)
		Me.btnAddMemberForm.Name = "btnAddMemberForm"
		Me.btnAddMemberForm.Size = New System.Drawing.Size(115, 60)
		Me.btnAddMemberForm.TabIndex = 6
		Me.btnAddMemberForm.Text = "Add"
		Me.btnAddMemberForm.UseVisualStyleBackColor = False
		'
		'lstSearchAll
		'
		Me.lstSearchAll.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstSearchAll.FormattingEnabled = True
		Me.lstSearchAll.ItemHeight = 21
		Me.lstSearchAll.Location = New System.Drawing.Point(12, 57)
		Me.lstSearchAll.Name = "lstSearchAll"
		Me.lstSearchAll.Size = New System.Drawing.Size(904, 382)
		Me.lstSearchAll.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(8, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(129, 21)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Total Members:"
		'
		'lblCount
		'
		Me.lblCount.AutoSize = True
		Me.lblCount.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCount.Location = New System.Drawing.Point(137, 20)
		Me.lblCount.Name = "lblCount"
		Me.lblCount.Size = New System.Drawing.Size(0, 21)
		Me.lblCount.TabIndex = 13
		'
		'Find
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkOrange
		Me.ClientSize = New System.Drawing.Size(1049, 458)
		Me.Controls.Add(Me.lblCount)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lstSearchAll)
		Me.Controls.Add(Me.btnAddMemberForm)
		Me.Controls.Add(Me.btnRemove)
		Me.Controls.Add(Me.btnDisplay)
		Me.Name = "Find"
		Me.Text = "Find"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnDisplay As Button
	Friend WithEvents btnRemove As Button
	Friend WithEvents btnAddMemberForm As Button
	Friend WithEvents lstSearchAll As ListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblCount As Label
End Class
