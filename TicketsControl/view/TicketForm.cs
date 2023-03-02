using System;
using System.Windows.Forms;
using TicketsControl.model;
using TicketsControl.dao;

namespace TicketsControl.view {

    public partial class TicketForm : Form {

        private enum Operacoes {
            CADASTRO,
            ATUALIZACAO
        };

        private Empregado empregadoSelecionado;
        private readonly ListagemTicket listagemTicket;
        private readonly Operacoes operacao;
        private Ticket ticketClone;
        private readonly int idTicket;

        public TicketForm(ListagemTicket listagemTicket, int idTicket) {
            this.listagemTicket = listagemTicket;
            this.idTicket = idTicket;
            InitializeComponent();

            if(idTicket != 0) {
                operacao = Operacoes.ATUALIZACAO;
                carregarInformacoes();
                exibirInformacoesCarregadasNaTela();
            } else {
                operacao = Operacoes.CADASTRO;
            }
        }

        private void bResetar_Click(object sender, System.EventArgs e) {
            if (operacao == Operacoes.CADASTRO) {
                tbId.Clear();
                tbQuantidade.Clear();
                dtpDataEntrega.Value = DateTime.Now;
                tbEmpregado.Clear();
                rbSituacaoAtivo.Checked = true;
                empregadoSelecionado = null;
            } else {
                carregarInformacoes();
                exibirInformacoesCarregadasNaTela();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TicketForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (ticketClone == null)
                return;

            Ticket ticketEditado = converterDadosInseridosEmObjeto();
            if (!ticketEditado.Equals(ticketClone)) {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja sair sem salvar?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }

        private void bSalvar_Click(object sender, EventArgs e) {
            try {
                validarDadosInseridos();
                Ticket ticket = converterDadosInseridosEmObjeto();

                bool estaSalvo = false;
                if(operacao == Operacoes.ATUALIZACAO)
                    estaSalvo = new TicketDao().change(ticket);
                else
                    estaSalvo = new TicketDao().insert(ticket);

                if (estaSalvo)
                    MessageBox.Show("Informações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ticketClone = null;
                this.Close();
                listagemTicket.carregarListagem();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSelecionarEmpregado_Click(object sender, EventArgs e) {
            int idEmpregadoSelecionado = empregadoSelecionado != null ? empregadoSelecionado.Id : 0;
            ListagemEmpregado listagemEmpregado = new ListagemEmpregado(this, idEmpregadoSelecionado);
            listagemEmpregado.ShowDialog();
        }

        public void setEmpregado(Empregado empregado) {
            this.empregadoSelecionado = empregado;
            tbEmpregado.Text = empregado.ToString();
        }

        private void tbQuantidade_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }

        private void validarDadosInseridos() {
            if (empregadoSelecionado == null)
                throw new Exception("Empregado deve ser informado.");

            if (getQuantidade() <= 0)
                throw new Exception("Informe a quantidade sendo que deverá ser maior que zero.");

            if (!rbSituacaoAtivo.Checked && operacao == Operacoes.CADASTRO)
                throw new Exception("Para novos cadastros de tickets a situação deverá ser ativa.");

            if (dtpDataEntrega.Value.ToShortDateString() != DateTime.Now.ToShortDateString() && operacao == Operacoes.CADASTRO)
                throw new Exception("Para novos cadastros de tickets a data de entrega deverá ser igual a hoje.");
        }

        private Ticket converterDadosInseridosEmObjeto() {
            return new Ticket() {
                Id = idTicket,
                Empregado = empregadoSelecionado,
                Quantidade = getQuantidade(),
                Situacao = rbSituacaoAtivo.Checked,
                DataEntrega = dtpDataEntrega.Value
            };
        }

        private int getQuantidade() {
            try {
                return Convert.ToInt32(tbQuantidade.Text);
            } catch {
                return 0;
            }
        }

        private void exibirInformacoesCarregadasNaTela() {
            tbId.Text = ticketClone.Id.ToString();
            tbQuantidade.Text = ticketClone.Quantidade.ToString();
            dtpDataEntrega.Value = ticketClone.DataEntrega;
            tbEmpregado.Text = ticketClone.Empregado.ToString();
            empregadoSelecionado = ticketClone.Empregado;

            if (ticketClone.Situacao)
                rbSituacaoAtivo.Checked = true;
            else
                rbSituacaoInativo.Checked = true;
        }

        public void carregarInformacoes() {
            ticketClone = (Ticket) new TicketDao().findById(idTicket).Clone();
        }
        
    }
}
