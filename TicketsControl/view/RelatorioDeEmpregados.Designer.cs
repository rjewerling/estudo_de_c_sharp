namespace TicketsControl.view {
    partial class RelatorioDeEmpregados {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.bExportar = new System.Windows.Forms.Button();
            this.bLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbDataUltimaAlteracaoAte = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataUltimaAlteracaoDe = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSituacaoInativo = new System.Windows.Forms.CheckBox();
            this.cbSituacaoAtivo = new System.Windows.Forms.CheckBox();
            this.dgvEmpregados = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslQuantidadeRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.7868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.09137F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.84772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.52792F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtbCPF, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.bPesquisar);
            this.panel1.Controls.Add(this.bExportar);
            this.panel1.Controls.Add(this.bLimpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 24);
            this.panel1.TabIndex = 0;
            // 
            // bPesquisar
            // 
            this.bPesquisar.Dock = System.Windows.Forms.DockStyle.Left;
            this.bPesquisar.Location = new System.Drawing.Point(150, 0);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(75, 24);
            this.bPesquisar.TabIndex = 2;
            this.bPesquisar.Text = "Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // bExportar
            // 
            this.bExportar.Dock = System.Windows.Forms.DockStyle.Left;
            this.bExportar.Location = new System.Drawing.Point(75, 0);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(75, 24);
            this.bExportar.TabIndex = 1;
            this.bExportar.Text = "Exportar";
            this.bExportar.UseVisualStyleBackColor = true;
            this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
            // 
            // bLimpar
            // 
            this.bLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.bLimpar.Location = new System.Drawing.Point(0, 0);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(75, 24);
            this.bLimpar.TabIndex = 0;
            this.bLimpar.Text = "Limpar";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbCPF.Location = new System.Drawing.Point(87, 35);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(221, 20);
            this.mtbCPF.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNome.Location = new System.Drawing.Point(87, 5);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(221, 20);
            this.tbNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Situação:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.37885F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.3348F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.61674F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.mtbDataUltimaAlteracaoAte, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mtbDataUltimaAlteracaoDe, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(331, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 24);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Última alteração de:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Até:";
            // 
            // mtbDataUltimaAlteracaoAte
            // 
            this.mtbDataUltimaAlteracaoAte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbDataUltimaAlteracaoAte.Location = new System.Drawing.Point(317, 3);
            this.mtbDataUltimaAlteracaoAte.Mask = "00/00/0000";
            this.mtbDataUltimaAlteracaoAte.Name = "mtbDataUltimaAlteracaoAte";
            this.mtbDataUltimaAlteracaoAte.Size = new System.Drawing.Size(134, 20);
            this.mtbDataUltimaAlteracaoAte.TabIndex = 3;
            this.mtbDataUltimaAlteracaoAte.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataUltimaAlteracaoDe
            // 
            this.mtbDataUltimaAlteracaoDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbDataUltimaAlteracaoDe.Location = new System.Drawing.Point(116, 3);
            this.mtbDataUltimaAlteracaoDe.Mask = "00/00/0000";
            this.mtbDataUltimaAlteracaoDe.Name = "mtbDataUltimaAlteracaoDe";
            this.mtbDataUltimaAlteracaoDe.Size = new System.Drawing.Size(140, 20);
            this.mtbDataUltimaAlteracaoDe.TabIndex = 4;
            this.mtbDataUltimaAlteracaoDe.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSituacaoInativo);
            this.panel2.Controls.Add(this.cbSituacaoAtivo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(447, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 24);
            this.panel2.TabIndex = 8;
            // 
            // cbSituacaoInativo
            // 
            this.cbSituacaoInativo.AutoSize = true;
            this.cbSituacaoInativo.Location = new System.Drawing.Point(129, 4);
            this.cbSituacaoInativo.Name = "cbSituacaoInativo";
            this.cbSituacaoInativo.Size = new System.Drawing.Size(58, 17);
            this.cbSituacaoInativo.TabIndex = 1;
            this.cbSituacaoInativo.Text = "Inativo";
            this.cbSituacaoInativo.UseVisualStyleBackColor = true;
            // 
            // cbSituacaoAtivo
            // 
            this.cbSituacaoAtivo.AutoSize = true;
            this.cbSituacaoAtivo.Location = new System.Drawing.Point(3, 4);
            this.cbSituacaoAtivo.Name = "cbSituacaoAtivo";
            this.cbSituacaoAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbSituacaoAtivo.TabIndex = 0;
            this.cbSituacaoAtivo.Text = "Ativo";
            this.cbSituacaoAtivo.UseVisualStyleBackColor = true;
            // 
            // dgvEmpregados
            // 
            this.dgvEmpregados.AllowUserToAddRows = false;
            this.dgvEmpregados.AllowUserToDeleteRows = false;
            this.dgvEmpregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpregados.Location = new System.Drawing.Point(0, 112);
            this.dgvEmpregados.Name = "dgvEmpregados";
            this.dgvEmpregados.ReadOnly = true;
            this.dgvEmpregados.Size = new System.Drawing.Size(794, 316);
            this.dgvEmpregados.TabIndex = 1;
            this.dgvEmpregados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmpregados_DataBindingComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslQuantidadeRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabel1.Text = "Quantidade de registros:";
            // 
            // tsslQuantidadeRegistros
            // 
            this.tsslQuantidadeRegistros.Name = "tsslQuantidadeRegistros";
            this.tsslQuantidadeRegistros.Size = new System.Drawing.Size(13, 17);
            this.tsslQuantidadeRegistros.Text = "0";
            // 
            // RelatorioDeEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.dgvEmpregados);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelatorioDeEmpregados";
            this.Text = "RelatorioDeEmpregados";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bExportar;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.Button bPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEmpregados;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslQuantidadeRegistros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbSituacaoInativo;
        private System.Windows.Forms.CheckBox cbSituacaoAtivo;
        private System.Windows.Forms.MaskedTextBox mtbDataUltimaAlteracaoAte;
        private System.Windows.Forms.MaskedTextBox mtbDataUltimaAlteracaoDe;
    }
}