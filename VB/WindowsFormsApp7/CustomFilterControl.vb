Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors

Namespace WindowsFormsApp7
	Partial Public Class CustomFilterControl
		Inherits XtraUserControl
		Implements IFilterContent

		Public Sub New()
			InitializeComponent()
			AddHandler Me.cbEdit.EditValueChanged, AddressOf TextEdit1_EditValueChanged
		End Sub

		Private ReadOnly Property IFilterContent_FilterValue() As Object Implements IFilterContent.FilterValue
			Get
				Return Me.cbEdit.EditValue
			End Get
		End Property
		Private ReadOnly Property IFilterContent_Control() As Control Implements IFilterContent.Control
			Get
				Return Me
			End Get
		End Property
		Private ReadOnly Property IFilterContent_LookAndFeel() As UserLookAndFeel Implements IFilterContent.LookAndFeel
			Get
				Return LookAndFeel
			End Get
		End Property

		Private changed As New Object()
		Private Sub TextEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim handler As EventHandler = TryCast(Events(changed), EventHandler)
			If handler IsNot Nothing Then
				handler(Me, EventArgs.Empty)
			End If
		End Sub
		Private Custom Event FilterValueChanged As EventHandler Implements IFilterContent.FilterValueChanged
			AddHandler(ByVal value As EventHandler)
				Events.AddHandler(changed, value)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				Events.RemoveHandler(changed, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		' Update any colors when the skin is changed.
		Private Sub IFilterContent_UpdateAppearance() Implements IFilterContent.UpdateAppearance
		End Sub
		' Update layout of controls when the size is changed.
		Private Sub IFilterContent_UpdateLayout() Implements IFilterContent.UpdateLayout
			' For example, update the combobox bounds.
			Me.cbEdit.Bounds = New Rectangle(20, (Height - Me.cbEdit.Height) \ 2, Width - 40, Me.cbEdit.Height)
		End Sub
	End Class
End Namespace
