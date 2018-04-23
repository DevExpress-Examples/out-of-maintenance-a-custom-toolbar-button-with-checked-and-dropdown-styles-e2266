Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace CustomCheckAndDropDownButton
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.UserSkins.OfficeSkins.Register()
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Blue"
			ItemRegistrationHelper.RegisterCustomItems()

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New RibbonForm())
		End Sub
	End Class
End Namespace