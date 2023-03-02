using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TicketsControl.dao;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Drawing.Drawing2D;

namespace TicketsControl.view {

    public partial class RelatorioDeEmpregados : Form {

        public RelatorioDeEmpregados() {
            InitializeComponent();
            mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void bLimpar_Click(object sender, EventArgs e) {
            tbNome.Clear();
            mtbCPF.Clear();
            cbSituacaoAtivo.Checked = false;
            cbSituacaoInativo.Checked = false;
            mtbDataUltimaAlteracaoDe.Clear();
            mtbDataUltimaAlteracaoAte.Clear();

            // XXX: poderiamos colocar um botão a mais ali para setar um intervalo pré definido
            //mtbDataUltimaAlteracaoDe.Text = DateTime.Now.AddMonths(-1).ToShortDateString();
            //mtbDataUltimaAlteracaoAte.Text = DateTime.Now.ToShortDateString();
        }

        private void bExportar_Click(object sender, EventArgs e) {
            if (dgvEmpregados.Rows.Count <= 0)
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
            sheet.Name = "Relação de empregados";
            // Configura para que as colunas sejam ajustadas automaticamente:
            sheet.Columns.AutoFit();
            // Cabeçalho:
            for (int colunaCabecalho = 0; colunaCabecalho < dgvEmpregados.Columns.Count; colunaCabecalho++) {
                sheet.Cells[1, colunaCabecalho + 1] = dgvEmpregados.Columns[colunaCabecalho].HeaderText;
            }

            // Armazena cada valor de linha e coluna:
            for (int linha = 0; linha < dgvEmpregados.Rows.Count; linha++) {
                for (int coluna = 0; coluna < dgvEmpregados.Columns.Count; coluna++) {
                    // XXX: Poderia fazer a formatação da coluna data, mas como que fica quando for null o valor?
                    //if (coluna == 4)
                    //    sheet.Cells[linha + 2, coluna + 1].NumberFormat = "dd\"/\"mm\"/\"aaaa";
                    //    ((DateTime)dgvEmpregados.Rows[linha].Cells[coluna].Value).ToShortDateString();
                    sheet.Cells[linha + 2, coluna + 1].Value = dgvEmpregados.Rows[linha].Cells[coluna].Value.ToString();
                }
            }

            Range rangeCabecalho = sheet.get_Range("1:1");
            rangeCabecalho.Font.Bold = true;
            rangeCabecalho.HorizontalAlignment = 3;
            rangeCabecalho.Font.Size = 12;
            rangeCabecalho.ColumnWidth = 25;

            Range rangeColunaId = sheet.get_Range("A2:A" + dgvEmpregados.Rows.Count + 1);
            rangeColunaId.HorizontalAlignment = 2;

            Range rangeColunaNome = sheet.get_Range("B2:B" + dgvEmpregados.Rows.Count + 1);
            rangeColunaNome.HorizontalAlignment = 1;

            Range rangeColunaCPF = sheet.get_Range("C2:C" + dgvEmpregados.Rows.Count + 1);
            rangeColunaCPF.NumberFormat = "000\".\"###\".\"###-##";
            rangeColunaCPF.HorizontalAlignment = 3;

            Range rangeColunaSituacao = sheet.get_Range("D2:D" + dgvEmpregados.Rows.Count + 1);
            rangeColunaSituacao.HorizontalAlignment = 3;

            Range rangeColunaDataUltimaAlteracao = sheet.get_Range("E2:E" + dgvEmpregados.Rows.Count + 1);
            rangeColunaDataUltimaAlteracao.HorizontalAlignment = 3;

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

        private void bPesquisar_Click(object sender, EventArgs e) {
            string nome = tbNome.Text;
            string cpf = mtbCPF.Text;
            char[] situacao = null;

            if (strIsNulaOuVaziaOuEspacoEmBranco(nome))
                nome = null;
            if (strIsNulaOuVaziaOuEspacoEmBranco(cpf))
                cpf = null;
            if (cbSituacaoAtivo.Checked)
                situacao = new char[] { 'A' };
            if (cbSituacaoInativo.Checked)
                situacao = new char[] { 'I' };
            if (cbSituacaoAtivo.Checked && cbSituacaoInativo.Checked)
                situacao = new char[] { 'A', 'I' };

            try {
                DateTime? dataDe = null;
                if (!strIsNulaOuVaziaOuEspacoEmBranco(getTextSemMascara(mtbDataUltimaAlteracaoDe))) {
                    dataDe = converteStringParaData(mtbDataUltimaAlteracaoDe.Text);
                    if (dataDe == null)
                        throw new Exception("Data inicial é inválida.");
                }

                DateTime? dataAte = null;
                if (!strIsNulaOuVaziaOuEspacoEmBranco(getTextSemMascara(mtbDataUltimaAlteracaoAte))) {
                    dataAte = converteStringParaData(mtbDataUltimaAlteracaoAte.Text);
                    if (dataAte == null)
                        throw new Exception("Data final é inválida.");

                    if (Nullable.Compare<DateTime>(DateTime.Now, dataAte) < 0)
                        throw new Exception("Data final não pode ser maior que data de hoje.");
                }

                if (dataDe != null && dataAte != null && Nullable.Compare<DateTime>(dataDe, dataAte) > 0)
                    throw new Exception("A data inicial não pode ser maior do que a data final.");

                DataTable dataTable = new EmpregadoDao().find(nome, cpf, situacao, dataDe, dataAte);
                dgvEmpregados.DataSource = dataTable;
                tsslQuantidadeRegistros.Text = dgvEmpregados.RowCount.ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmpregados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewColumn column in dgvEmpregados.Columns) {
                if (column.DataPropertyName.Contains("Id") || column.DataPropertyName.Contains("Situação")) {
                    column.Width = 60;
                    continue;
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // XXX: Poderia formatar a data mas deixa quieto por enquanto.
            //dgvEmpregados.Columns[4].DefaultCellStyle.Format = "dd/mm/yyyy";
        }

        private string getTextSemMascara(MaskedTextBox mtb) {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string texto = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return texto;
        }

        private bool strIsNulaOuVaziaOuEspacoEmBranco(string str) {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        private DateTime? converteStringParaData(string strData) {
            DateTime dateTime;
            if (DateTime.TryParse(strData, out dateTime)) {
                return dateTime;
            }
            return null;
        }
    }
}
