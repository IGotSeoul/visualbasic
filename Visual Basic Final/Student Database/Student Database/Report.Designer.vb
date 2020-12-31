<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.btnSearchGender = New System.Windows.Forms.Button()
		Me.btnSearchType = New System.Windows.Forms.Button()
		Me.btnSearchID = New System.Windows.Forms.Button()
		Me.btnDisplayAll = New System.Windows.Forms.Button()
		Me.lstDisplayAll = New System.Windows.Forms.ListBox()
		Me.lblCount = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnSearchGender
		'
		Me.btnSearchGender.BackColor = System.Drawing.Color.MediumAquamarine
		Me.btnSearchGender.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchGender.Location = New System.Drawing.Point(930, 55)
		Me.btnSearchGender.Name = "btnSearchGender"
		Me.btnSearchGender.Size = New System.Drawing.Size(115, 60)
		Me.btnSearchGender.TabIndex = 5
		Me.btnSearchGender.Text = "Display By Gender"
		Me.btnSearchGender.UseVisualStyleBackColor = False
		'
		'btnSearchType
		'
		Me.btnSearchType.BackColor = System.Drawing.Color.MediumAquamarine
		Me.btnSearchType.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchType.Location = New System.Drawing.Point(930, 121)
		Me.btnSearchType.Name = "btnSearchType"
		Me.btnSearchType.Size = New System.Drawing.Size(115, 60)
		Me.btnSearchType.TabIndex = 6
		Me.btnSearchType.Text = "Display By Type"
		Me.btnSearchType.UseVisualStyleBackColor = False
		'
		'btnSearchID
		'
		Me.btnSearchID.BackColor = System.Drawing.Color.MediumAquamarine
		Me.btnSearchID.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearchID.Location = New System.Drawing.Point(930, 187)
		Me.btnSearchID.Name = "btnSearchID"
		Me.btnSearchID.Size = New System.Drawing.Size(115, 60)
		Me.btnSearchID.TabIndex = 7
		Me.btnSearchID.Text = "Display By ID"
		Me.btnSearchID.UseVisualStyleBackColor = False
		'
		'btnDisplayAll
		'
		Me.btnDisplayAll.BackColor = System.Drawing.Color.MediumAquamarine
		Me.btnDisplayAll.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDisplayAll.Location = New System.Drawing.Point(930, 253)
		Me.btnDisplayAll.Name = "btnDisplayAll"
		Me.btnDisplayAll.Size = New System.Drawing.Size(115, 60)
		Me.btnDisplayAll.TabIndex = 8
		Me.btnDisplayAll.Text = "Display All"
		Me.btnDisplayAll.UseVisualStyleBackColor = False
		'
		'lstDisplayAll
		'
		Me.lstDisplayAll.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstDisplayAll.FormattingEnabled = True
		Me.lstDisplayAll.ItemHeight = 21
		Me.lstDisplayAll.Location = New System.Drawing.Point(12, 55)
		Me.lstDisplayAll.Name = "lstDisplayAll"
		Me.lstDisplayAll.Size = New System.Drawing.Size(912, 382)
		Me.lstDisplayAll.TabIndex = 9
		'
		'lblCount
		'
		Me.lblCount.AutoSize = True
		Me.lblCount.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCount.Location = New System.Drawing.Point(147, 18)
		Me.lblCount.Name = "lblCount"
		Me.lblCount.Size = New System.Drawing.Size(0, 21)
		Me.lblCount.TabIndex = 10
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(129, 21)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Total Members:"
		'
		'Report
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkOrange
		Me.ClientSize = New System.Drawing.Size(1057, 467)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblCount)
		Me.Controls.Add(Me.lstDisplayAll)
		Me.Controls.Add(Me.btnDisplayAll)
		Me.Controls.Add(Me.btnSearchID)
		Me.Controls.Add(Me.btnSearchType)
		Me.Controls.Add(Me.btnSearchGender)
		Me.Name = "Report"
		Me.Text = "Report"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnSearchGender As Button
	Friend WithEvents btnSearchType As Button
	Friend WithEvents btnSearchID As Button
	Friend WithEvents btnDisplayAll As Button
	Friend WithEvents lstDisplayAll As ListBox
	Friend WithEvents lblCount As Label
	Friend WithEvents Label1 As Label
End Class
