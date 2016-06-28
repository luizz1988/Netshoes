namespace TesteImposto
{
    partial class FormImposto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brinde = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonGerarNotaFiscal = new System.Windows.Forms.Button();
            this.cboEstadoOrigem = new System.Windows.Forms.ComboBox();
            this.cboEstadoDestino = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Destino";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomeCliente.Location = new System.Drawing.Point(95, 9);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(585, 20);
            this.textBoxNomeCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Itens do pedido";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.CodigoProduto,
            this.Valor,
            this.Brinde});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(6, 109);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(674, 325);
            this.dataGridViewPedidos.TabIndex = 7;
            this.dataGridViewPedidos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewPedidos_EditingControlShowing_1);
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome do Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Width = 250;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.HeaderText = "Codigo do Produto";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.Width = 150;
            // 
            // Valor
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Brinde
            // 
            this.Brinde.HeaderText = "Brinde";
            this.Brinde.Name = "Brinde";
            // 
            // buttonGerarNotaFiscal
            // 
            this.buttonGerarNotaFiscal.Location = new System.Drawing.Point(558, 440);
            this.buttonGerarNotaFiscal.Name = "buttonGerarNotaFiscal";
            this.buttonGerarNotaFiscal.Size = new System.Drawing.Size(122, 23);
            this.buttonGerarNotaFiscal.TabIndex = 8;
            this.buttonGerarNotaFiscal.Text = "Gerar Nota Fiscal";
            this.buttonGerarNotaFiscal.UseVisualStyleBackColor = true;
            this.buttonGerarNotaFiscal.Click += new System.EventHandler(this.buttonGerarNotaFiscal_Click);
            // 
            // cboEstadoOrigem
            // 
            this.cboEstadoOrigem.FormattingEnabled = true;
            this.cboEstadoOrigem.Location = new System.Drawing.Point(95, 31);
            this.cboEstadoOrigem.Name = "cboEstadoOrigem";
            this.cboEstadoOrigem.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoOrigem.TabIndex = 9;
            // 
            // cboEstadoDestino
            // 
            this.cboEstadoDestino.FormattingEnabled = true;
            this.cboEstadoDestino.Location = new System.Drawing.Point(322, 31);
            this.cboEstadoDestino.Name = "cboEstadoDestino";
            this.cboEstadoDestino.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoDestino.TabIndex = 10;
            // 
            // FormImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 477);
            this.Controls.Add(this.cboEstadoDestino);
            this.Controls.Add(this.cboEstadoOrigem);
            this.Controls.Add(this.buttonGerarNotaFiscal);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormImposto";
            this.Text = "Calculo de imposto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button buttonGerarNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Brinde;
        private System.Windows.Forms.ComboBox cboEstadoOrigem;
        private System.Windows.Forms.ComboBox cboEstadoDestino;
    }
}

