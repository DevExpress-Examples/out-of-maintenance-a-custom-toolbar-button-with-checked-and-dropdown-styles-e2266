Imports Microsoft.VisualBasic
Imports System
Namespace CustomCheckAndDropDownButton
	Partial Public Class XtraBarsForm
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
            Me.components = New System.ComponentModel.Container
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar
            Me.barCheckAndDropDownButton1 = New CustomCheckAndDropDownButton.BarCheckAndDropDownButton
            Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barCheckAndDropDownButton1, Me.BarButtonItem1})
            Me.barManager1.MaxItemId = 2
            '
            'bar1
            '
            Me.bar1.BarName = "Custom 1"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckAndDropDownButton1)})
            Me.bar1.Text = "Custom 1"
            '
            'barCheckAndDropDownButton1
            '
            Me.barCheckAndDropDownButton1.ActAsCheck = True
            Me.barCheckAndDropDownButton1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.barCheckAndDropDownButton1.Caption = "Check&&DropDown"
            Me.barCheckAndDropDownButton1.DropDownControl = Me.PopupMenu1
            Me.barCheckAndDropDownButton1.Id = 0
            Me.barCheckAndDropDownButton1.Name = "barCheckAndDropDownButton1"
            '
            'PopupMenu1
            '
            Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
            Me.PopupMenu1.Manager = Me.barManager1
            Me.PopupMenu1.Name = "PopupMenu1"
            '
            'BarButtonItem1
            '
            Me.BarButtonItem1.Caption = "More options..."
            Me.BarButtonItem1.Id = 1
            Me.BarButtonItem1.Name = "BarButtonItem1"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
            '
            'XtraBarsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(389, 200)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "XtraBarsForm"
            Me.Text = "Form2"
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barCheckAndDropDownButton1 As BarCheckAndDropDownButton
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
        Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace