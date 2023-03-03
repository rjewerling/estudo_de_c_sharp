using System;
using System.Data;
using System.Windows.Forms;
using TicketsControl.dao;
using TicketsControl.model;

namespace TicketsControl.view {

    public partial class ListagemEmpregado : Form {

        private readonly RelatorioDeTicket relatorioDeTicketForm;
        private readonly TicketForm ticketForm;
        private readonly bool isOperacaoSelecao;
        private bool removerSelecaoDoRegistro = true; //XXX: Analisar mais tarde pois isso parece que da para substituir pelo isOperacaoSelecao

        public ListagemEmpregado() {
            InitializeComponent();
            configurarParaExibirOuEsconderBotoes();
            carregarListagem();
            configuraLarguraDasColunasDaTabela();
        }

        public ListagemEmpregado(TicketForm ticketForm, int idEmpregadoSelecionado) {
            this.ticketForm = ticketForm;
            isOperacaoSelecao = true;
            InitializeComponent();
            configurarParaExibirOuEsconderBotoes();
            carregarListagem();
            configuraLarguraDasColunasDaTabela();
            dgvEmpregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            destacaRegistroSelecionadoPeloUsuarioNaTabela(idEmpregadoSelecionado);
        }

        public ListagemEmpregado(RelatorioDeTicket relatorioDeTicketForm, int idEmpregadoSelecionado) {
            this.relatorioDeTicketForm = relatorioDeTicketForm;
            isOperacaoSelecao = true;
            InitializeComponent();
            configurarParaExibirOuEsconderBotoes();
            carregarListagem();
            configuraLarguraDasColunasDaTabela();
            dgvEmpregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            destacaRegistroSelecionadoPeloUsuarioNaTabela(idEmpregadoSelecionado);
        }

        private void configuraLarguraDasColunasDaTabela() {
            foreach (DataGridViewColumn column in dgvEmpregados.Columns) {
                if (column.DataPropertyName.Contains("Id") || column.DataPropertyName.Contains("Situação")) {
                    column.Width = 60;
                    continue;
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void carregarListagem() {
            dgvEmpregados.DataSource = new EmpregadoDao().list();
            tsslQuantidadeRegistros.Text = Convert.ToString(dgvEmpregados.RowCount);
        }

        private void abrirFormularioCadastro(int idEmpregado) {
            EmpregadoForm empregadoForm = new EmpregadoForm(this, idEmpregado);
            empregadoForm.ShowDialog();
        }

        private void configurarParaExibirOuEsconderBotoes() {
            if (!isOperacaoSelecao) {
                bSelecionar.Visible = false;
                return;
            }

            bAdicionar.Visible = false;
            bAlterar.Visible = false;
            bSelecionar.Visible = true;
        }

        private void bAdicionar_Click(object sender, EventArgs e) {
            abrirFormularioCadastro(0);
        }

        private void bAlterar_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection selectedRows = dgvEmpregados.SelectedRows;
            if (selectedRows.Count <= 0) {
                MessageBox.Show("Selecione um dos registros para a alteração de dados.");
                return;
            }

            DataGridViewRow dataGridViewRow = selectedRows[0];
            DataRow row = (dataGridViewRow.DataBoundItem as DataRowView).Row;
            int idEmpregado = Convert.ToInt32(row[0]);

            abrirFormularioCadastro(idEmpregado);
        }

        private void dgvEmpregados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            if (!isOperacaoSelecao || removerSelecaoDoRegistro)
                dgvEmpregados.ClearSelection();
        }

        private void bBuscar_Click(object sender, EventArgs e) {
            dgvEmpregados.DataSource = new EmpregadoDao().find(tbBuscar.Text);
            tsslQuantidadeRegistros.Text = Convert.ToString(dgvEmpregados.Rows.Count);

            if (dgvEmpregados.Rows.Count <= 0) {
                MessageBox.Show("Não foi encontrado nenhum registro.");
            }
        }

        private void tbBuscar_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                bBuscar_Click (sender, e);
            }
        }

        private void bSelecionar_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection selectedRows = dgvEmpregados.SelectedRows;
            if (selectedRows.Count <= 0) {
                MessageBox.Show("Selecione um empregado para continuar com o cadastro de ticket.");
                return;
            }

            DataGridViewRow dataGridViewRow = selectedRows[0];
            DataRow row = (dataGridViewRow.DataBoundItem as DataRowView).Row;
            int idEmpregado = Convert.ToInt32(row[0]);

            Empregado empregadoSelecionado = new EmpregadoDao().findById(idEmpregado);
            if (ticketForm != null)
                ticketForm.setEmpregado(empregadoSelecionado);

            if (relatorioDeTicketForm != null)
                relatorioDeTicketForm.setEmpregado(empregadoSelecionado);
            this.Close();
        }

        private void destacaRegistroSelecionadoPeloUsuarioNaTabela(int idEmpregadoSelecionado) {
            if (idEmpregadoSelecionado == 0) {
                return;
            }

            for (int i = 0; i < dgvEmpregados.Rows.Count; i++) {
                if (Convert.ToInt32(dgvEmpregados.Rows[i].Cells[0].Value) == idEmpregadoSelecionado) {
                    dgvEmpregados.CurrentCell = dgvEmpregados.Rows[i].Cells[0];
                    removerSelecaoDoRegistro = false;
                    break;
                }
            }
        }
    }
}
