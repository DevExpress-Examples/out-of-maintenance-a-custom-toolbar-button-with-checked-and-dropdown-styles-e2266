Imports Microsoft.VisualBasic
Imports System
Namespace CustomCheckAndDropDownButton
	Partial Public Class RibbonForm
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
			Me.components = New System.ComponentModel.Container()
			Me.ribbonControl1 = New CustomCheckAndDropDownButton.MyRibbonControl()
			Me.barButtonItem1 = New CustomCheckAndDropDownButton.BarCheckAndDropDownButton()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationIcon = Nothing
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(4)
			Me.ribbonControl1.MaxItemId = 3
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.SelectedPage = Me.ribbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(615, 149)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.ActAsCheck = True
			Me.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.barButtonItem1.Caption = "Bold Text"
			Me.barButtonItem1.DropDownControl = Me.popupMenu1
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.LargeGlyph = My.Resources.bold32x32
			Me.barButtonItem1.Name = "barButtonItem1"
			Me.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' popupMenu1
			' 
			Me.popupMenu1.ItemLinks.Add(Me.barButtonItem2)
			Me.popupMenu1.Name = "popupMenu1"
			Me.popupMenu1.Ribbon = Me.ribbonControl1
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "More Style Settings..."
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' RibbonForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(615, 238)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "RibbonForm"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.RibbonForm_Load);
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbonControl1 As MyRibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barButtonItem1 As BarCheckAndDropDownButton
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

