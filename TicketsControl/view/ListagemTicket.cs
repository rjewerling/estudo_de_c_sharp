using System;
using System.Data;
using System.Windows.Forms;
using TicketsControl.dao;

namespace TicketsControl.view {

    public partial class ListagemTicket : Form {

        public ListagemTicket() {
            InitializeComponent();
            carregarListagem();
            configuraLarguraDasColunasDaTabela();
        }

        private void configuraLarguraDasColunasDaTabela() {
            foreach (DataGridViewColumn column in dgvTickets.Columns) {
                if (column.DataPropertyName.Contains("Nome")) {
                    column.MinimumWidth = 200;
                }
                if (column.DataPropertyName.Contains("Id") || column.DataPropertyName.Contains("Situação")) {
                    column.Width = 60;
                    continue;
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void carregarListagem() {
            dgvTickets.DataSource = new TicketDao().list();
            tsslQuantidadeRegistros.Text = dgvTickets.RowCount.ToString();
        }

        private void abrirFormularioCadastro(int idTicket) {
            TicketForm ticketForm = new TicketForm(this, idTicket);
            ticketForm.ShowDialog();
        }

        private void bAdicionar_Click(object sender, EventArgs e) {
            abrirFormularioCadastro(0);
        }

        private void bAlterar_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection selectedRows = dgvTickets.SelectedRows;

            if (selectedRows.Count <= 0) {
                MessageBox.Show("Selecione um dos registros para a alteração de dados.");
                return;
            }

            DataGridViewRow dataGridViewRow = selectedRows[0];
            DataRow row = (dataGridViewRow.DataBoundItem as DataRowView).Row;
            int idTicket = Convert.ToInt32(row[0]);

            abrirFormularioCadastro(idTicket);
        }

        private void bBuscar_Click(object sender, EventArgs e) {
            dgvTickets.DataSource = new TicketDao().find(tbBuscar.Text);
            tsslQuantidadeRegistros.Text = Convert.ToString(dgvTickets.Rows.Count);

            if (dgvTickets.Rows.Count <= 0) {
                MessageBox.Show("Não foi encontrado nenhum registro.");
            }
        }

        private void tbBuscar_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                bBuscar_Click(sender, e);
            }
        }

        private void dgvTickets_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            dgvTickets.ClearSelection();
        }

    }
}
