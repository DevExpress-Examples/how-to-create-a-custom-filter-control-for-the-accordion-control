Namespace WindowsFormsApp7
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
			Me.customFilterControl1 = New WindowsFormsApp7.CustomFilterControl()
			Me.accordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
			Me.accordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
			Me.accordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
			Me.accordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
			CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.accordionControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' accordionControl1
			' 
			Me.accordionControl1.Controls.Add(Me.customFilterControl1)
			Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() { Me.accordionControlElement1})
			Me.accordionControl1.FilterControl = Me.customFilterControl1
			Me.accordionControl1.Location = New System.Drawing.Point(0, 0)
			Me.accordionControl1.Name = "accordionControl1"
			Me.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always
			Me.accordionControl1.Size = New System.Drawing.Size(260, 450)
			Me.accordionControl1.TabIndex = 0
			Me.accordionControl1.Text = "accordionControl1"
			' 
			' customFilterControl1
			' 
			Me.customFilterControl1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.customFilterControl1.Appearance.Options.UseBackColor = True
			Me.customFilterControl1.Location = New System.Drawing.Point(0, 0)
			Me.customFilterControl1.Name = "customFilterControl1"
			Me.customFilterControl1.Size = New System.Drawing.Size(260, 65)
			Me.customFilterControl1.TabIndex = 1
			' 
			' accordionControlElement1
			' 
			Me.accordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() { Me.accordionControlElement2, Me.accordionControlElement3, Me.accordionControlElement4})
			Me.accordionControlElement1.Expanded = True
			Me.accordionControlElement1.Name = "accordionControlElement1"
			Me.accordionControlElement1.Text = "Element1"
			' 
			' accordionControlElement2
			' 
			Me.accordionControlElement2.Name = "accordionControlElement2"
			Me.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
			Me.accordionControlElement2.Text = "Red"
			' 
			' accordionControlElement3
			' 
			Me.accordionControlElement3.Name = "accordionControlElement3"
			Me.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
			Me.accordionControlElement3.Text = "Green"
			' 
			' accordionControlElement4
			' 
			Me.accordionControlElement4.Name = "accordionControlElement4"
			Me.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
			Me.accordionControlElement4.Text = "Blue"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.accordionControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.accordionControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
		Private accordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private customFilterControl1 As CustomFilterControl
		Private accordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
	End Class
End Namespace

