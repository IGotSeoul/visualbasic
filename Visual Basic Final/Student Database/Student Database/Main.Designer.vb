<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
		Me.btnModify = New System.Windows.Forms.Button()
		Me.btnReport = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnModify
		'
		Me.btnModify.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModify.Location = New System.Drawing.Point(12, 232)
		Me.btnModify.Name = "btnModify"
		Me.btnModify.Size = New System.Drawing.Size(118, 56)
		Me.btnModify.TabIndex = 0
		Me.btnModify.Text = "Modify"
		Me.btnModify.UseVisualStyleBackColor = True
		'
		'btnReport
		'
		Me.btnReport.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReport.Location = New System.Drawing.Point(307, 232)
		Me.btnReport.Name = "btnReport"
		Me.btnReport.Size = New System.Drawing.Size(118, 56)
		Me.btnReport.TabIndex = 1
		Me.btnReport.Text = "Report"
		Me.btnReport.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(60, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(326, 43)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Welcome To The YMCA"
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Student_Database.My.Resources.Resources.YMCA
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ClientSize = New System.Drawing.Size(437, 300)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnReport)
		Me.Controls.Add(Me.btnModify)
		Me.Name = "Main"
		Me.Text = "YMCA"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnModify As Button
	Friend WithEvents btnReport As Button
	Friend WithEvents Label1 As Label
End Class
