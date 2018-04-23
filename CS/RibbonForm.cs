using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomCheckAndDropDownButton {
    public partial class RibbonForm : Form {
        public RibbonForm() {
            InitializeComponent();
        }

        private void RibbonForm_Load(object sender, EventArgs e) {
            new XtraBarsForm().Show();
        }
    }
}