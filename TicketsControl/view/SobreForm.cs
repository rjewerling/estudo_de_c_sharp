using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TicketsControl.view {

    public partial class SobreForm : Form {

        public SobreForm() {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/rjewerling/estudo_de_c_sharp.git");
            Process.Start(sInfo);
        }
    }
}
