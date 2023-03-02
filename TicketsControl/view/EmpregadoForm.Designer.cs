namespace TicketsControl.view {
    partial class EmpregadoForm {
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpregadoForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.rbSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.lFoto = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lNome = new System.Windows.Forms.Label();
            this.lCpf = new System.Windows.Forms.Label();
            this.lSituacao = new System.Windows.Forms.Label();
            this.lUltimaAlteracao = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dtpDataUltimaAlteracao = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bSalvar = new System.Windows.Forms.Button();
            this.bResetar = new System.Windows.Forms.Button();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.51639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.26229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.22131F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lFoto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lCpf, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lSituacao, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lUltimaAlteracao, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbNome, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataUltimaAlteracao, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtbCpf, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.rbSituacaoAtivo);
            this.flowLayoutPanel1.Controls.Add(this.rbSituacaoInativo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(219, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(147, 23);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // rbSituacaoAtivo
            // 
            this.rbSituacaoAtivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbSituacaoAtivo.AutoSize = true;
            this.rbSituacaoAtivo.Checked = true;
            this.rbSituacaoAtivo.Location = new System.Drawing.Point(3, 3);
            this.rbSituacaoAtivo.Name = "rbSituacaoAtivo";
            this.rbSituacaoAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbSituacaoAtivo.TabIndex = 0;
            this.rbSituacaoAtivo.TabStop = true;
            this.rbSituacaoAtivo.Text = "Ativo";
            this.rbSituacaoAtivo.UseVisualStyleBackColor = true;
            // 
            // rbSituacaoInativo
            // 
            this.rbSituacaoInativo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbSituacaoInativo.AutoSize = true;
            this.rbSituacaoInativo.Location = new System.Drawing.Point(58, 3);
            this.rbSituacaoInativo.Name = "rbSituacaoInativo";
            this.rbSituacaoInativo.Size = new System.Drawing.Size(57, 17);
            this.rbSituacaoInativo.TabIndex = 1;
            this.rbSituacaoInativo.Text = "Inativo";
            this.rbSituacaoInativo.UseVisualStyleBackColor = true;
            // 
            // lFoto
            // 
            this.lFoto.AutoSize = true;
            this.lFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFoto.Image = ((System.Drawing.Image)(resources.GetObject("lFoto.Image")));
            this.lFoto.Location = new System.Drawing.Point(3, 32);
            this.lFoto.Name = "lFoto";
            this.tableLayoutPanel1.SetRowSpan(this.lFoto, 3);
            this.lFoto.Size = new System.Drawing.Size(108, 96);
            this.lFoto.TabIndex = 0;
            // 
            // lId
            // 
            this.lId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(117, 9);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 13);
            this.lId.TabIndex = 1;
            this.lId.Text = "Id:";
            // 
            // lNome
            // 
            this.lNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(117, 41);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(38, 13);
            this.lNome.TabIndex = 2;
            this.lNome.Text = "Nome:";
            // 
            // lCpf
            // 
            this.lCpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lCpf.AutoSize = true;
            this.lCpf.Location = new System.Drawing.Point(117, 73);
            this.lCpf.Name = "lCpf";
            this.lCpf.Size = new System.Drawing.Size(30, 13);
            this.lCpf.TabIndex = 3;
            this.lCpf.Text = "CPF:";
            // 
            // lSituacao
            // 
            this.lSituacao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lSituacao.AutoSize = true;
            this.lSituacao.Location = new System.Drawing.Point(117, 105);
            this.lSituacao.Name = "lSituacao";
            this.lSituacao.Size = new System.Drawing.Size(52, 13);
            this.lSituacao.TabIndex = 4;
            this.lSituacao.Text = "Situação:";
            // 
            // lUltimaAlteracao
            // 
            this.lUltimaAlteracao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lUltimaAlteracao.AutoSize = true;
            this.lUltimaAlteracao.Location = new System.Drawing.Point(117, 138);
            this.lUltimaAlteracao.Name = "lUltimaAlteracao";
            this.lUltimaAlteracao.Size = new System.Drawing.Size(86, 13);
            this.lUltimaAlteracao.TabIndex = 5;
            this.lUltimaAlteracao.Text = "Última alteração:";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNome.Location = new System.Drawing.Point(219, 38);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(283, 20);
            this.tbNome.TabIndex = 7;
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbId.Location = new System.Drawing.Point(219, 6);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(283, 20);
            this.tbId.TabIndex = 6;
            // 
            // dtpDataUltimaAlteracao
            // 
            this.dtpDataUltimaAlteracao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDataUltimaAlteracao.Enabled = false;
            this.dtpDataUltimaAlteracao.Location = new System.Drawing.Point(219, 134);
            this.dtpDataUltimaAlteracao.Name = "dtpDataUltimaAlteracao";
            this.dtpDataUltimaAlteracao.Size = new System.Drawing.Size(283, 20);
            this.dtpDataUltimaAlteracao.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bCancelar);
            this.flowLayoutPanel2.Controls.Add(this.bSalvar);
            this.flowLayoutPanel2.Controls.Add(this.bResetar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 160);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(531, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(453, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bSalvar
            // 
            this.bSalvar.Location = new System.Drawing.Point(372, 3);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(75, 23);
            this.bSalvar.TabIndex = 1;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // bResetar
            // 
            this.bResetar.Location = new System.Drawing.Point(291, 3);
            this.bResetar.Name = "bResetar";
            this.bResetar.Size = new System.Drawing.Size(75, 23);
            this.bResetar.TabIndex = 2;
            this.bResetar.Text = "Resetar";
            this.bResetar.UseVisualStyleBackColor = true;
            this.bResetar.Click += new System.EventHandler(this.bResetar_Click);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbCpf.Location = new System.Drawing.Point(219, 70);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(283, 20);
            this.mtbCpf.TabIndex = 10;
            // 
            // EmpregadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 190);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpregadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar ou Alterar Empregado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpregadoForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbSituacaoAtivo;
        private System.Windows.Forms.RadioButton rbSituacaoInativo;
        private System.Windows.Forms.Label lFoto;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label lCpf;
        private System.Windows.Forms.Label lSituacao;
        private System.Windows.Forms.Label lUltimaAlteracao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.Button bResetar;
        private System.Windows.Forms.DateTimePicker dtpDataUltimaAlteracao;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
    }
}