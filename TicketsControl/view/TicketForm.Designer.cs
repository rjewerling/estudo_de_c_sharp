namespace TicketsControl.view {

    partial class TicketForm {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.rbSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.lFoto = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lEmpregado = new System.Windows.Forms.Label();
            this.lCpf = new System.Windows.Forms.Label();
            this.lSituacao = new System.Windows.Forms.Label();
            this.lDataEntrega = new System.Windows.Forms.Label();
            this.tbEmpregado = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.bSelecionarEmpregado = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bSalvar = new System.Windows.Forms.Button();
            this.bResetar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.51639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.26229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.22132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lFoto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lEmpregado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lCpf, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lSituacao, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lDataEntrega, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbEmpregado, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbQuantidade, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataEntrega, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bSelecionarEmpregado, 3, 1);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 100);
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
            this.lFoto.Size = new System.Drawing.Size(98, 96);
            this.lFoto.TabIndex = 0;
            // 
            // lId
            // 
            this.lId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(107, 9);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 13);
            this.lId.TabIndex = 1;
            this.lId.Text = "Id:";
            // 
            // lEmpregado
            // 
            this.lEmpregado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lEmpregado.AutoSize = true;
            this.lEmpregado.Location = new System.Drawing.Point(107, 41);
            this.lEmpregado.Name = "lEmpregado";
            this.lEmpregado.Size = new System.Drawing.Size(64, 13);
            this.lEmpregado.TabIndex = 2;
            this.lEmpregado.Text = "Empregado:";
            // 
            // lCpf
            // 
            this.lCpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lCpf.AutoSize = true;
            this.lCpf.Location = new System.Drawing.Point(107, 73);
            this.lCpf.Name = "lCpf";
            this.lCpf.Size = new System.Drawing.Size(65, 13);
            this.lCpf.TabIndex = 3;
            this.lCpf.Text = "Quantidade:";
            // 
            // lSituacao
            // 
            this.lSituacao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lSituacao.AutoSize = true;
            this.lSituacao.Location = new System.Drawing.Point(107, 105);
            this.lSituacao.Name = "lSituacao";
            this.lSituacao.Size = new System.Drawing.Size(52, 13);
            this.lSituacao.TabIndex = 4;
            this.lSituacao.Text = "Situação:";
            // 
            // lDataEntrega
            // 
            this.lDataEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lDataEntrega.AutoSize = true;
            this.lDataEntrega.Location = new System.Drawing.Point(107, 138);
            this.lDataEntrega.Name = "lDataEntrega";
            this.lDataEntrega.Size = new System.Drawing.Size(87, 13);
            this.lDataEntrega.TabIndex = 5;
            this.lDataEntrega.Text = "Data de entrega:";
            // 
            // tbEmpregado
            // 
            this.tbEmpregado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbEmpregado.Location = new System.Drawing.Point(200, 38);
            this.tbEmpregado.Name = "tbEmpregado";
            this.tbEmpregado.ReadOnly = true;
            this.tbEmpregado.Size = new System.Drawing.Size(281, 20);
            this.tbEmpregado.TabIndex = 7;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbQuantidade.Location = new System.Drawing.Point(200, 70);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(281, 20);
            this.tbQuantidade.TabIndex = 8;
            this.tbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantidade_KeyPress);
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbId.Location = new System.Drawing.Point(200, 6);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(281, 20);
            this.tbId.TabIndex = 6;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDataEntrega.Enabled = false;
            this.dtpDataEntrega.Location = new System.Drawing.Point(200, 134);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(281, 20);
            this.dtpDataEntrega.TabIndex = 9;
            // 
            // bSelecionarEmpregado
            // 
            this.bSelecionarEmpregado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelecionarEmpregado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSelecionarEmpregado.Image = ((System.Drawing.Image)(resources.GetObject("bSelecionarEmpregado.Image")));
            this.bSelecionarEmpregado.Location = new System.Drawing.Point(487, 35);
            this.bSelecionarEmpregado.Name = "bSelecionarEmpregado";
            this.bSelecionarEmpregado.Size = new System.Drawing.Size(41, 26);
            this.bSelecionarEmpregado.TabIndex = 10;
            this.bSelecionarEmpregado.UseVisualStyleBackColor = false;
            this.bSelecionarEmpregado.Click += new System.EventHandler(this.bSelecionarEmpregado_Click);
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
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 190);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar ou Alterar Ticket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketForm_FormClosing);
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
        private System.Windows.Forms.Label lEmpregado;
        private System.Windows.Forms.Label lCpf;
        private System.Windows.Forms.Label lSituacao;
        private System.Windows.Forms.Label lDataEntrega;
        private System.Windows.Forms.TextBox tbEmpregado;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.Button bResetar;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Button bSelecionarEmpregado;
    }
}