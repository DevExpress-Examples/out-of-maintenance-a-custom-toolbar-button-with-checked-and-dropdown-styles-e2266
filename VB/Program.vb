Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace CustomCheckAndDropDownButton
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Bezier"
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New RibbonForm1())
		End Sub
	End Module
End Namespace