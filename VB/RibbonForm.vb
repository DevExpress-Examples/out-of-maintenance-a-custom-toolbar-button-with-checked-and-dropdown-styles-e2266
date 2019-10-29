Imports DevExpress.XtraBars.Ribbon
Imports System

Namespace CustomCheckAndDropDownButton
	Partial Public Class RibbonForm1
		Inherits RibbonForm

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub RibbonForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Call (New XtraBarsForm()).Show()
		End Sub
	End Class
End Namespace