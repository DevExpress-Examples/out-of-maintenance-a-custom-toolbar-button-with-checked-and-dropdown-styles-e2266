Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace CustomCheckAndDropDownButton
	Partial Public Class RibbonForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RibbonForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CType(New XtraBarsForm(), XtraBarsForm).Show()
		End Sub
	End Class
End Namespace