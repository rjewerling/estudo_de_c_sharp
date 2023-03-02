using System;
using System.Windows.Forms;
using TicketsControl.model;
using TicketsControl.dao;

namespace TicketsControl.view {

    public partial class EmpregadoForm : Form {

        public enum Operacoes {
            CADASTRO,
            ATUALIZACAO
        };

        private readonly ListagemEmpregado listagemEmpregado;
        private readonly int idEmpregado;
        private readonly Operacoes operacao;
        private Empregado empregadoClone;

        public EmpregadoForm(ListagemEmpregado listagemEmpregado, int idEmpregado) {
            this.listagemEmpregado = listagemEmpregado;
            this.idEmpregado = idEmpregado;
            InitializeComponent();

            mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (idEmpregado != 0) {
                operacao = Operacoes.ATUALIZACAO;
                carregarInformacoes();
                exibirInformacoesCarregadasNaTela();

                // TODO: Isso pode ser configuravel, e depois que a tela carregou e se for operação de atualização.
                // Ao Sair da janela, se não foi alterado nada, achar uma forma de ignorar as alterações indevidas.
                // Talvez um atributo(campo) informando para sair na força
                //try {
                //    validacaoBasicaDoNumeroCPF();
                //} catch(Exception e) {
                //    MessageBox.Show(e.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            } else {
                operacao = Operacoes.CADASTRO;
                dtpDataUltimaAlteracao.Visible = false;
                lUltimaAlteracao.Visible = false;
            }
        }

        private void bResetar_Click(object sender, System.EventArgs e) {
            if (operacao == Operacoes.CADASTRO) {
                tbId.Clear();
                tbNome.Clear();
                mtbCpf.Clear();
                rbSituacaoAtivo.Checked = true;

                dtpDataUltimaAlteracao.Visible = false;
                lUltimaAlteracao.Visible = false;
            } else {
                carregarInformacoes();
                exibirInformacoesCarregadasNaTela();
            }
        }

        private void bSalvar_Click(object sender, EventArgs e) {
            try {
                validarDadosInseridos();
                Empregado empregadoEditado = converterDadosInseridosEmObjeto();

                bool estaSalvo = false;
                if (operacao == Operacoes.ATUALIZACAO) {
                    estaSalvo = new EmpregadoDao().change(empregadoEditado);
                } else {
                    estaSalvo = new EmpregadoDao().insert(empregadoEditado);
                }
                if (estaSalvo)
                    MessageBox.Show("Informações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                empregadoClone = null;
                this.Close();
                listagemEmpregado.carregarListagem();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void EmpregadoForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (empregadoClone == null)
                return;

            Empregado empregadoEditado = converterDadosInseridosEmObjeto();
            if (!empregadoEditado.Equals(empregadoClone)) {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja sair sem salvar?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }

        private void validarDadosInseridos() {
            if (String.IsNullOrEmpty(tbNome.Text) || String.IsNullOrWhiteSpace(tbNome.Text))
                throw new Exception("Informe o nome do empregado.");

            validacaoBasicaDoNumeroCPF();

            if (!rbSituacaoAtivo.Checked && operacao == Operacoes.CADASTRO)
                throw new Exception("Para novos cadastros de empregado a situação deverá ser sempre ativa.");

            // XXX: Quando o registro é novo, não é enviado na instrução de insert valor no campo data.
            // XXX: Só para garantir que a data será igual a hoje, para quando for a primeira alteração.
            // XXX: Segunda alteração de registro, a data deve ser igual a mais atual possível.
            if ((DateTime.Compare(dtpDataUltimaAlteracao.Value, DateTime.Now) > 0) && operacao == Operacoes.ATUALIZACAO)
                throw new Exception("Data da última alteração deveria ser no máximo igual a hoje.");
        }

        private void validacaoBasicaDoNumeroCPF() {
            String cpf = mtbCpf.Text;

            if (String.IsNullOrEmpty(cpf))
                throw new Exception("Informe o número do cadastro de pessoa física.");

            if (cpf.Length != 11)
                throw new Exception("Número do cadastro de pessoa física incompleto.");

            if (cpf.Equals("00000000000") || cpf.Equals("11111111111") ||
                cpf.Equals("22222222222") || cpf.Equals("33333333333") ||
                cpf.Equals("44444444444") || cpf.Equals("55555555555") ||
                cpf.Equals("66666666666") || cpf.Equals("77777777777") ||
                cpf.Equals("88888888888") || cpf.Equals("99999999999"))
                throw new Exception("Número do cadastro de pessoa física inválida.");
        }

        private Empregado converterDadosInseridosEmObjeto() {
            Empregado empregado = new Empregado();
            empregado.Id = idEmpregado;
            empregado.Nome(tbNome.Text);
            empregado.Cpf = mtbCpf.Text;
            empregado.Situacao = rbSituacaoAtivo.Checked;
            empregado.DataUltimaAlteracao = dtpDataUltimaAlteracao.Value;
            return empregado;
        }

        private void exibirInformacoesCarregadasNaTela() {
            tbId.Text = empregadoClone.Id.ToString();
            tbNome.Text = empregadoClone.Nome();
            mtbCpf.Text = empregadoClone.Cpf;

            if (empregadoClone.DataUltimaAlteracao == DateTime.MinValue) {
                // INFO:Quando for novo ou editado pela primeira vez
                dtpDataUltimaAlteracao.Value = DateTime.Now;
                dtpDataUltimaAlteracao.Visible = false;
                lUltimaAlteracao.Visible = false;
            } else {
                // INFO:Quando for editado pela segunda vez.
                dtpDataUltimaAlteracao.Value = empregadoClone.DataUltimaAlteracao;
            }

            if (empregadoClone.Situacao)
                rbSituacaoAtivo.Checked = true;
            else
                rbSituacaoInativo.Checked = true;
        }

        public void carregarInformacoes() {
            empregadoClone = (Empregado)new EmpregadoDao().findById(idEmpregado).Clone();
        }

    }
}
