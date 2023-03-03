using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsControl.dao;
using TicketsControl.model;
using static System.Windows.Forms.LinkLabel;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace TicketsControl.view {

    public partial class RelatorioDeTicket : Form {

        private Empregado empregadoSelecionado;

        public RelatorioDeTicket() {
            InitializeComponent();
        }

        private void bLimpar_Click(object sender, EventArgs e) {
            tbEmpregado.Clear();
            tbQtdDe.Clear();
            tbQtdAte.Clear();
            cbAtivo.Checked = false;
            cbInativo.Checked = false;
            mtbDataEntregaDe.Clear();
            mtbDataEntregaAte.Clear();
            empregadoSelecionado = null;
        }

        private void bSelecionaEmpregado_Click(object sender, EventArgs e) {
            int idEmpregadoSelecionado = empregadoSelecionado != null ? empregadoSelecionado.Id : 0;
            ListagemEmpregado listagemEmpregado = new ListagemEmpregado(this, idEmpregadoSelecionado);
            listagemEmpregado.ShowDialog();
        }

        public void setEmpregado(Empregado empregado) {
            this.empregadoSelecionado = empregado;
            tbEmpregado.Text = empregado.ToString();
        }

        private void bPesquisar_Click(object sender, EventArgs e) {
            char[] situacao = null;
            int? qtdDe = null;
            int? qtdAte = null;

            if (cbAtivo.Checked)
                situacao = new char[] { 'A' };
            if (cbInativo.Checked)
                situacao = new char[] { 'I' };
            if (cbAtivo.Checked && cbInativo.Checked)
                situacao = new char[] { 'A', 'I' };

            try {
                if (!strIsNulaOuVaziaOuEspacoEmBranco(tbQtdDe.Text))
                    qtdDe = converteStringParaInteiro(tbQtdDe.Text);
                if (!strIsNulaOuVaziaOuEspacoEmBranco(tbQtdAte.Text))
                    qtdAte = converteStringParaInteiro(tbQtdAte.Text);

                DateTime? dataDe = null;
                if (!strIsNulaOuVaziaOuEspacoEmBranco(getTextSemMascara(mtbDataEntregaDe))) {
                    dataDe = converteStringParaData(mtbDataEntregaDe.Text);
                    if (dataDe == null)
                        throw new Exception("Data inicial é inválida.");
                }

                DateTime? dataAte = null;
                if (!strIsNulaOuVaziaOuEspacoEmBranco(getTextSemMascara(mtbDataEntregaAte))) {
                    dataAte = converteStringParaData(mtbDataEntregaAte.Text);
                    if (dataAte == null)
                        throw new Exception("Data final é inválida.");

                    if (Nullable.Compare<DateTime>(DateTime.Now, dataAte) < 0)
                        throw new Exception("Data final não pode ser maior que data de hoje.");
                }

                if (dataDe != null && dataAte != null && Nullable.Compare<DateTime>(dataDe, dataAte) > 0)
                    throw new Exception("A data inicial não pode ser maior do que a data final.");

                DataTable dataTable = new TicketDao().find(empregadoSelecionado, qtdDe, qtdAte, situacao, dataDe, dataAte);
                dgvTickets.DataSource = dataTable;
                tsslQuantidadeRegistros.Text = dgvTickets.RowCount.ToString();

                int sum = 0;
                for (int i = 0; i < dgvTickets.Rows.Count; ++i) {
                    sum += Convert.ToInt32(dgvTickets.Rows[i].Cells["Quantidade"].Value);
                }
                tsslTotalTickets.Text = sum.ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbQtdDe_KeyPress(object sender, KeyPressEventArgs e) {
            permiteApenasCaracteresNumericosEComandoBackSpace(e);
        }

        private void tbQtdAte_KeyPress(object sender, KeyPressEventArgs e) {
            permiteApenasCaracteresNumericosEComandoBackSpace(e);
        }

        private void permiteApenasCaracteresNumericosEComandoBackSpace(KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }

        private bool strIsNulaOuVaziaOuEspacoEmBranco(string str) {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        private int? converteStringParaInteiro(string strInteiro) {
            int valor = 0;
            if (int.TryParse(strInteiro, out valor)) {
                return valor;
            }
            return null;
        }

        private string getTextSemMascara(MaskedTextBox mtb) {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string texto = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return texto;
        }

        private DateTime? converteStringParaData(string strData) {
            DateTime dateTime;
            if (DateTime.TryParse(strData, out dateTime)) {
                return dateTime;
            }
            return null;
        }

        private void dgvTickets_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewColumn column in dgvTickets.Columns) {
                if (column.DataPropertyName.Contains("Id") || column.DataPropertyName.Contains("Situação")) {
                    column.Width = 60;
                    continue;
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void bExportar_Click(object sender, EventArgs e) {
            if (dgvTickets.Rows.Count <= 0)
                return;

            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Title = "Salvar planilha do Excel";
            salvar.Filter = "Arquivo do Excel (*.xlsx)|*.xlsx";

            if (salvar.ShowDialog() != DialogResult.OK)
                return;

            Excel.Application excelApp = new Excel.Application();
            // Obtem uma nova pasta de trabalho:
            Workbook workbook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);
            // Obtem a planilha ativa e em seguida altera o nome:
            Excel.Worksheet sheet = workbook.Worksheets.get_Item(1);
            sheet.Name = "Relação de tickets entregues";
            // Configura para que as colunas sejam ajustadas automaticamente:
            sheet.Columns.AutoFit();
            // Cabeçalho:
            for (int colunaCabecalho = 0; colunaCabecalho < dgvTickets.Columns.Count; colunaCabecalho++) {
                sheet.Cells[1, colunaCabecalho + 1] = dgvTickets.Columns[colunaCabecalho].HeaderText;
            }

            // Armazena cada valor de linha e coluna:
            for (int linha = 0; linha < dgvTickets.Rows.Count; linha++) {
                for (int coluna = 0; coluna < dgvTickets.Columns.Count; coluna++) {
                    sheet.Cells[linha + 2, coluna + 1].Value = dgvTickets.Rows[linha].Cells[coluna].Value.ToString();
                }
            }

            Range rangeCabecalho = sheet.get_Range("1:1");
            rangeCabecalho.Font.Bold = true;
            rangeCabecalho.HorizontalAlignment = 3;
            rangeCabecalho.Font.Size = 12;
            rangeCabecalho.ColumnWidth = 25;

            Range rangeColunaId = sheet.get_Range("A2:A" + dgvTickets.Rows.Count + 1);
            rangeColunaId.HorizontalAlignment = 2;

            Range rangeColunaNome = sheet.get_Range("B2:B" + dgvTickets.Rows.Count + 1);
            rangeColunaNome.HorizontalAlignment = 1;

            Range rangeColunaCPF = sheet.get_Range("C2:C" + dgvTickets.Rows.Count + 1);
            rangeColunaCPF.NumberFormat = "000\".\"###\".\"###-##";
            rangeColunaCPF.HorizontalAlignment = 3;

            Range rangeColunaQuantidade = sheet.get_Range("D2:D" + dgvTickets.Rows.Count + 1);
            rangeColunaQuantidade.HorizontalAlignment = 3;

            Range rangeColunaSituacao = sheet.get_Range("E2:E" + dgvTickets.Rows.Count + 1);
            rangeColunaSituacao.HorizontalAlignment = 3;

            Range rangeColunaDataEntrega = sheet.get_Range("F2:F" + dgvTickets.Rows.Count + 1);
            rangeColunaDataEntrega.HorizontalAlignment = 3;


            Range rangeLabelTotal = sheet.Cells[dgvTickets.Rows.Count + 4, 3];
            rangeLabelTotal.Font.Bold = true;
            rangeLabelTotal.Font.Color = Color.Blue;
            rangeLabelTotal.Value = "Total de tickets:";

            Range rangeTotalTickets = sheet.Cells[dgvTickets.Rows.Count + 4, 4];
            rangeTotalTickets.Font.Bold = true;
            rangeTotalTickets.Font.Color = Color.Blue;
            rangeTotalTickets.Formula = "=SUM(D2:D" + (dgvTickets.Rows.Count + 1) + ")";
            rangeTotalTickets.HorizontalAlignment = 3;

            excelApp.DisplayAlerts = false;
            sheet.SaveAs(salvar.FileName);

            DialogResult dr = MessageBox.Show("Visualizar o arquivo gerado?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                excelApp.Visible = true;
            else {
                workbook.Close(true);
                excelApp.Quit();
            }
        }
    }
}
