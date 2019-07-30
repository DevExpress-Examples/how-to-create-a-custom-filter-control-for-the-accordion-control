Namespace WindowsFormsApp7
	Partial Public Class CustomFilterControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.cbEdit = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.cbEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cbEdit
			' 
			Me.cbEdit.Location = New System.Drawing.Point(25, 23)
			Me.cbEdit.Name = "cbEdit"
			Me.cbEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbEdit.Properties.Items.AddRange(New Object() { "Red", "Green", "Blue"})
			Me.cbEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbEdit.Size = New System.Drawing.Size(100, 20)
			Me.cbEdit.TabIndex = 0
			' 
			' CustomFilterControl
			' 
			Me.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.cbEdit)
			Me.Name = "CustomFilterControl"
			Me.Size = New System.Drawing.Size(163, 65)
			CType(Me.cbEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cbEdit As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
