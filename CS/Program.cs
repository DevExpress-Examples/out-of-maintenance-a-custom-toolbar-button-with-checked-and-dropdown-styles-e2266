using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomCheckAndDropDownButton {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Blue";
            ItemRegistrationHelper.RegisterCustomItems();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RibbonForm());
        }
    }
}