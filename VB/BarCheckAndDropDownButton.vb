Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon

Namespace CustomCheckAndDropDownButton
	Friend Class BarCheckAndDropDownButton
		Inherits BarButtonItem
		Public Sub New()
			ActAsCheck = True
			ButtonStyle = BarButtonStyle.DropDown
		End Sub

		Private actAsCheck_Renamed As Boolean
		Public Property ActAsCheck() As Boolean
			Get
				Return actAsCheck_Renamed
			End Get
			Set(ByVal value As Boolean)
				actAsCheck_Renamed = value
			End Set
		End Property

		Public Overrides ReadOnly Property CanDown() As Boolean
			Get
				Return MyBase.CanDown OrElse (ActAsCheck AndAlso ButtonStyle = BarButtonStyle.DropDown)
			End Get
		End Property
		Protected Overrides Sub OnClick(ByVal link As BarItemLink)
			If ActAsCheck AndAlso ButtonStyle <> BarButtonStyle.Check Then
				Toggle()
			End If
			MyBase.OnClick(link)
		End Sub
	End Class

	Public Class BarCheckAndDropDownButtonLinkViewInfo
		Inherits BarButtonLinkViewInfo
		Public Sub New(ByVal parameters As BarDrawParameters, ByVal link As BarItemLink)
			MyBase.New(parameters, link)
		End Sub
		Protected Overrides Function CalcLinkState() As BarLinkState
			Dim state As BarLinkState = MyBase.CalcLinkState()
			'if(Link.Item.Down) state |= BarLinkState.Checked;
			Return state
		End Function
	End Class

	Public Class BarCheckAndDropDownButtonLinkPainter
		Inherits BarButtonOffice2003LinkPainter
		Public Sub New(ByVal style As BarManagerPaintStyle)
			MyBase.New(style)
		End Sub
		Protected Overrides Sub DrawLinkAdornments(ByVal e As BarLinkPaintArgs, ByVal drawState As BarLinkState)
			If e.LinkInfo.IsDrawPart(BarLinkParts.OpenArrow) Then
				'if((drawState & BarLinkState.Pressed) > 0) 
				'    drawState = (drawState | BarLinkState.Highlighted) & ~BarLinkState.Pressed;
				drawState = drawState And Not BarLinkState.Checked
				'Console.WriteLine(drawState);
			End If

			MyBase.DrawLinkAdornments(e, drawState)
		End Sub
	End Class

	Friend Class ItemRegistrationHelper
		Public Shared Sub RegisterCustomItems()
			Dim styles As BarManagerPaintStyleCollection = BarAndDockingController.Default.PaintStyles
			Dim style As BarManagerPaintStyle = styles("Skin")
			style.ItemInfoCollection.Add(New BarItemInfo("BarCheckAndDropDownButton", "Check && DropDown Button", 0, GetType(BarCheckAndDropDownButton), GetType(BarButtonItemLink), GetType(BarCheckAndDropDownButtonLinkViewInfo), New BarCheckAndDropDownButtonLinkPainter(style), True, True))
		End Sub
	End Class
End Namespace
