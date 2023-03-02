using System;
using System.Windows.Forms;

namespace TicketsControl.view {

    public partial class TicketsControlForm : Form {

        public TicketsControlForm() {
            InitializeComponent();
        }

        private void empregadosToolStripMenuItem_Click(object sender, EventArgs e) {
            ListagemEmpregado listagemEmpregado = new ListagemEmpregado();
            listagemEmpregado.ShowDialog();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e) {
            ListagemTicket listagemTicket = new ListagemTicket();
            listagemTicket.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            SobreForm sobreForm = new SobreForm();
            sobreForm.ShowDialog();
        }

        private void empregadosToolStripMenuItem1_Click(object sender, EventArgs e) {
            RelatorioDeEmpregados relatorio = new RelatorioDeEmpregados();
            relatorio.ShowDialog();
        }

        private void ticketsToolStripMenuItem1_Click(object sender, EventArgs e) {
            RelatorioDeTicket relatorio = new RelatorioDeTicket();
            relatorio.ShowDialog();
        }
    }
}
