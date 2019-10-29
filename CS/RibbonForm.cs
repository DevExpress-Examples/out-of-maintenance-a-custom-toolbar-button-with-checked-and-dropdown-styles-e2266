using DevExpress.XtraBars.Ribbon;
using System;

namespace CustomCheckAndDropDownButton {
    public partial class RibbonForm1 : RibbonForm {
        public RibbonForm1() {
            InitializeComponent();
        }
        private void RibbonForm_Load(object sender, EventArgs e) {
            new XtraBarsForm().Show();
        }
    }
}