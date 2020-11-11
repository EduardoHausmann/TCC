namespace View
{
    partial class frmVenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCliente;
            System.Windows.Forms.Label lblCodVenda;
            System.Windows.Forms.Label lblProduto;
            System.Windows.Forms.Label lblQuantidade;
            System.Windows.Forms.Label lblValor;
            System.Windows.Forms.Label lblValorVenda;
            System.Windows.Forms.Label lblDesconto;
            System.Windows.Forms.Label lblValorPago;
            System.Windows.Forms.Label lblDataVencimento;
            System.Windows.Forms.Label lblStatus;
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFV = new System.Windows.Forms.Button();
            this.btnFP = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.contaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            lblCliente = new System.Windows.Forms.Label();
            lblCodVenda = new System.Windows.Forms.Label();
            lblProduto = new System.Windows.Forms.Label();
            lblQuantidade = new System.Windows.Forms.Label();
            lblValor = new System.Windows.Forms.Label();
            lblValorVenda = new System.Windows.Forms.Label();
            lblDesconto = new System.Windows.Forms.Label();
            lblValorPago = new System.Windows.Forms.Label();
            lblDataVencimento = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.gbVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCliente.Location = new System.Drawing.Point(12, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new System.Drawing.Size(58, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblCodVenda
            // 
            lblCodVenda.AutoSize = true;
            lblCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodVenda.Location = new System.Drawing.Point(6, 16);
            lblCodVenda.Name = "lblCodVenda";
            lblCodVenda.Size = new System.Drawing.Size(110, 20);
            lblCodVenda.TabIndex = 0;
            lblCodVenda.Text = "Código Venda";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProduto.Location = new System.Drawing.Point(6, 68);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new System.Drawing.Size(65, 20);
            lblProduto.TabIndex = 2;
            lblProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblQuantidade.Location = new System.Drawing.Point(6, 129);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new System.Drawing.Size(92, 20);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblValor.Location = new System.Drawing.Point(6, 189);
            lblValor.Name = "lblValor";
            lblValor.Size = new System.Drawing.Size(46, 20);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor";
            // 
            // lblValorVenda
            // 
            lblValorVenda.AutoSize = true;
            lblValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblValorVenda.Location = new System.Drawing.Point(153, 474);
            lblValorVenda.Name = "lblValorVenda";
            lblValorVenda.Size = new System.Drawing.Size(46, 20);
            lblValorVenda.TabIndex = 10;
            lblValorVenda.Text = "Valor";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDesconto.Location = new System.Drawing.Point(153, 526);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new System.Drawing.Size(78, 20);
            lblDesconto.TabIndex = 12;
            lblDesconto.Text = "Desconto";
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblValorPago.Location = new System.Drawing.Point(153, 579);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new System.Drawing.Size(87, 20);
            lblValorPago.TabIndex = 14;
            lblValorPago.Text = "Valor Pago";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDataVencimento.Location = new System.Drawing.Point(285, 526);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new System.Drawing.Size(133, 20);
            lblDataVencimento.TabIndex = 16;
            lblDataVencimento.Text = "Data Vencimento";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStatus.Location = new System.Drawing.Point(285, 472);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(56, 20);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Status";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Musica.DAL.Venda);
            // 
            // cbCliente
            // 
            this.cbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "IdCliente", true));
            this.cbCliente.DataSource = this.clienteBindingSource;
            this.cbCliente.DisplayMember = "Nome";
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(16, 32);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(316, 28);
            this.cbCliente.TabIndex = 2;
            this.cbCliente.ValueMember = "Id";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Musica.DAL.Cliente);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.Location = new System.Drawing.Point(363, 32);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(114, 27);
            this.btnNovaVenda.TabIndex = 3;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // gbVenda
            // 
            this.gbVenda.Controls.Add(this.btnImprimir);
            this.gbVenda.Controls.Add(this.btnFV);
            this.gbVenda.Controls.Add(this.btnFP);
            this.gbVenda.Controls.Add(this.btnFinalizar);
            this.gbVenda.Controls.Add(lblStatus);
            this.gbVenda.Controls.Add(this.cbStatus);
            this.gbVenda.Controls.Add(lblDataVencimento);
            this.gbVenda.Controls.Add(this.dtpDataVencimento);
            this.gbVenda.Controls.Add(lblValorPago);
            this.gbVenda.Controls.Add(this.txtValorPago);
            this.gbVenda.Controls.Add(lblDesconto);
            this.gbVenda.Controls.Add(this.txtDesconto);
            this.gbVenda.Controls.Add(lblValorVenda);
            this.gbVenda.Controls.Add(this.txtValorVenda);
            this.gbVenda.Controls.Add(this.dgvItem);
            this.gbVenda.Controls.Add(this.btnNovoItem);
            this.gbVenda.Controls.Add(lblValor);
            this.gbVenda.Controls.Add(this.txtValor);
            this.gbVenda.Controls.Add(lblQuantidade);
            this.gbVenda.Controls.Add(this.txtQuantidade);
            this.gbVenda.Controls.Add(lblProduto);
            this.gbVenda.Controls.Add(this.cbProduto);
            this.gbVenda.Controls.Add(lblCodVenda);
            this.gbVenda.Controls.Add(this.txtCodVenda);
            this.gbVenda.Location = new System.Drawing.Point(12, 66);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(480, 634);
            this.gbVenda.TabIndex = 4;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Nova Venda";
            this.gbVenda.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(24, 602);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 26);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            // 
            // btnFV
            // 
            this.btnFV.Enabled = false;
            this.btnFV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFV.Location = new System.Drawing.Point(5, 545);
            this.btnFV.Name = "btnFV";
            this.btnFV.Size = new System.Drawing.Size(141, 29);
            this.btnFV.TabIndex = 22;
            this.btnFV.Text = "Finalizar Venda";
            this.btnFV.UseVisualStyleBackColor = true;
            this.btnFV.Click += new System.EventHandler(this.btnFV_Click);
            // 
            // btnFP
            // 
            this.btnFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFP.Location = new System.Drawing.Point(6, 494);
            this.btnFP.Name = "btnFP";
            this.btnFP.Size = new System.Drawing.Size(140, 28);
            this.btnFP.TabIndex = 21;
            this.btnFP.Text = "Finalizar Pedido";
            this.btnFP.UseVisualStyleBackColor = true;
            this.btnFP.Click += new System.EventHandler(this.btnFP_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(320, 602);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(108, 26);
            this.btnFinalizar.TabIndex = 20;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contaReceberBindingSource, "IdStatus", true));
            this.cbStatus.DataSource = this.statusPagamentoBindingSource;
            this.cbStatus.DisplayMember = "Status";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(289, 495);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(172, 28);
            this.cbStatus.TabIndex = 19;
            this.cbStatus.ValueMember = "Id";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // contaReceberBindingSource
            // 
            this.contaReceberBindingSource.DataSource = typeof(Musica.DAL.ContaReceber);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(Musica.DAL.StatusPagamento);
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contaReceberBindingSource, "DataVencimento", true));
            this.dtpDataVencimento.Enabled = false;
            this.dtpDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(289, 548);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(172, 26);
            this.dtpDataVencimento.TabIndex = 17;
            // 
            // txtValorPago
            // 
            this.txtValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(153, 602);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.ReadOnly = true;
            this.txtValorPago.Size = new System.Drawing.Size(122, 26);
            this.txtValorPago.TabIndex = 15;
            // 
            // txtDesconto
            // 
            this.txtDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(153, 548);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(122, 26);
            this.txtDesconto.TabIndex = 13;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(153, 495);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.ReadOnly = true;
            this.txtValorVenda.Size = new System.Drawing.Size(122, 26);
            this.txtValorVenda.TabIndex = 11;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AutoGenerateColumns = false;
            this.dgvItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1});
            this.dgvItem.DataSource = this.itemVendaBindingSource;
            this.dgvItem.Location = new System.Drawing.Point(6, 247);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.Size = new System.Drawing.Size(455, 220);
            this.dgvItem.TabIndex = 9;
            this.dgvItem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItem_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataSource = typeof(Musica.DAL.ItemVenda);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.Location = new System.Drawing.Point(202, 215);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(101, 27);
            this.btnNovoItem.TabIndex = 8;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Valor", true));
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(6, 212);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(164, 26);
            this.txtValor.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Quantidade", true));
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(6, 152);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(170, 26);
            this.txtQuantidade.TabIndex = 5;
            // 
            // cbProduto
            // 
            this.cbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemVendaBindingSource, "IdProduto", true));
            this.cbProduto.DataSource = this.produtoBindingSource;
            this.cbProduto.DisplayMember = "Nome";
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(6, 91);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(231, 28);
            this.cbProduto.TabIndex = 3;
            this.cbProduto.ValueMember = "Id";
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Musica.DAL.Produto);
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Id", true));
            this.txtCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVenda.Location = new System.Drawing.Point(6, 39);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.ReadOnly = true;
            this.txtCodVenda.Size = new System.Drawing.Size(145, 26);
            this.txtCodVenda.TabIndex = 1;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 703);
            this.Controls.Add(this.gbVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(lblCliente);
            this.Controls.Add(this.cbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVenda";
            this.Text = ".: Venda :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVenda_FormClosed);
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource contaReceberBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFV;
        private System.Windows.Forms.Button btnFP;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}