Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo


Namespace CustomCheckAndDropDownButton
	Public Class MyRibbonControl
		Inherits RibbonControl
		Protected Overrides Function CreateBarManager() As RibbonBarManager
			Return New MyRibbonBarManager(Me)
		End Function
	End Class

	Public Class MyRibbonBarManager
		Inherits RibbonBarManager
		Public Sub New(ByVal ribbon As RibbonControl)
			MyBase.New(ribbon)
		End Sub
		Protected Overrides Function CreateItemViewInfo(ByVal viewInfo As BaseRibbonViewInfo, ByVal item As IRibbonItem) As RibbonItemViewInfo
			Dim link As BarButtonItemLink = TryCast(item, BarButtonItemLink)
			If link IsNot Nothing AndAlso TypeOf link.Item Is BarCheckAndDropDownButton Then
				Return New RibbonCheckAndDropDownButtonLinkViewInfo(viewInfo, item)
			End If
			Return MyBase.CreateItemViewInfo(viewInfo, item)
		End Function
	End Class

	Public Class RibbonCheckAndDropDownButtonLinkViewInfo
		Inherits RibbonSplitButtonItemViewInfo
		Public Sub New(ByVal viewInfo As BaseRibbonViewInfo, ByVal item As IRibbonItem)
			MyBase.New(viewInfo, item)
		End Sub

		Protected Overrides Function CalcImageIndex(ByVal state As ObjectState) As Integer
			Dim res As Integer = 0
			If state = ObjectState.Hot Then
				res = 1
			End If
			If (state And ObjectState.Pressed) <> 0 Then
				res = 2
			End If
			If Item.IsChecked Then
				res += 3
			End If
			Return res
		End Function

		Public Overrides Function GetItemInfo() As SkinElementInfo
			Dim info As New SkinElementInfo(RibbonSkins.GetSkin(ViewInfo.Provider)(RibbonSkins.SkinLargeButton))
			info.Bounds = PushButtonBounds
			info.State = CalcState()
			info.ImageIndex = CalcImageIndex(info.State)
			Return info
		End Function
	End Class
End Namespace
