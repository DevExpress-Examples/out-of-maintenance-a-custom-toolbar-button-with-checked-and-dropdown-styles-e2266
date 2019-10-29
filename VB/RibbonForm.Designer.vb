Namespace CustomCheckAndDropDownButton
	Partial Public Class RibbonForm1
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
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 3
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.barButtonItem2, Me.barButtonItem3})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 5
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(546, 143)
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "More Style Settings..."
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
			Me.barButtonItem3.Caption = "Bold Text"
			Me.barButtonItem3.DropDownControl = Me.popupMenu1
			Me.barButtonItem3.Id = 4
			Me.barButtonItem3.ImageOptions.Image = My.Resources.bold32x32
			Me.barButtonItem3.Name = "barButtonItem3"
			Me.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' popupMenu1
			' 
			Me.popupMenu1.ItemLinks.Add(Me.barButtonItem2)
			Me.popupMenu1.Name = "popupMenu1"
			Me.popupMenu1.Ribbon = Me.ribbonControl1
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem3)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' RibbonForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(546, 246)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "RibbonForm1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.RibbonForm_Load);
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

