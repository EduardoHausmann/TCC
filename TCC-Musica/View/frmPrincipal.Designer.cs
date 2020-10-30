namespace View
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProdutoRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProdutoCategoriaRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProdutoCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVendaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastro,
            this.tsmVendas,
            this.tsmConsulta,
            this.tsmRelatorio});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(800, 28);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmCadastro
            // 
            this.tsmCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCategoria,
            this.tsmCliente,
            this.tsmFuncionario,
            this.tsmProduto});
            this.tsmCadastro.Name = "tsmCadastro";
            this.tsmCadastro.Size = new System.Drawing.Size(94, 24);
            this.tsmCadastro.Text = "Cadastros";
            // 
            // tsmVendas
            // 
            this.tsmVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVenda});
            this.tsmVendas.Name = "tsmVendas";
            this.tsmVendas.Size = new System.Drawing.Size(76, 24);
            this.tsmVendas.Text = "Vendas";
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProdutoCategoria,
            this.tsmVendaCliente});
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(84, 24);
            this.tsmConsulta.Text = "Consulta";
            // 
            // tsmRelatorio
            // 
            this.tsmRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProdutoRelatorio,
            this.tsmProdutoCategoriaRelatorio});
            this.tsmRelatorio.Name = "tsmRelatorio";
            this.tsmRelatorio.Size = new System.Drawing.Size(85, 24);
            this.tsmRelatorio.Text = "Relatório";
            // 
            // tsmCategoria
            // 
            this.tsmCategoria.Name = "tsmCategoria";
            this.tsmCategoria.Size = new System.Drawing.Size(180, 24);
            this.tsmCategoria.Text = "Categoria";
            this.tsmCategoria.Click += new System.EventHandler(this.tsmCategoria_Click);
            // 
            // tsmCliente
            // 
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(180, 24);
            this.tsmCliente.Text = "Cliente";
            this.tsmCliente.Click += new System.EventHandler(this.tsmCliente_Click);
            // 
            // tsmFuncionario
            // 
            this.tsmFuncionario.Name = "tsmFuncionario";
            this.tsmFuncionario.Size = new System.Drawing.Size(180, 24);
            this.tsmFuncionario.Text = "Funcionário";
            this.tsmFuncionario.Click += new System.EventHandler(this.tsmFuncionario_Click);
            // 
            // tsmProduto
            // 
            this.tsmProduto.Name = "tsmProduto";
            this.tsmProduto.Size = new System.Drawing.Size(180, 24);
            this.tsmProduto.Text = "Produto";
            this.tsmProduto.Click += new System.EventHandler(this.tsmProduto_Click);
            // 
            // tsmVenda
            // 
            this.tsmVenda.Name = "tsmVenda";
            this.tsmVenda.Size = new System.Drawing.Size(180, 24);
            this.tsmVenda.Text = "Venda";
            this.tsmVenda.Click += new System.EventHandler(this.tsmVenda_Click);
            // 
            // tsmProdutoRelatorio
            // 
            this.tsmProdutoRelatorio.Name = "tsmProdutoRelatorio";
            this.tsmProdutoRelatorio.Size = new System.Drawing.Size(224, 24);
            this.tsmProdutoRelatorio.Text = "Produto";
            this.tsmProdutoRelatorio.Click += new System.EventHandler(this.tsmProdutoRelatorio_Click);
            // 
            // tsmProdutoCategoriaRelatorio
            // 
            this.tsmProdutoCategoriaRelatorio.Name = "tsmProdutoCategoriaRelatorio";
            this.tsmProdutoCategoriaRelatorio.Size = new System.Drawing.Size(224, 24);
            this.tsmProdutoCategoriaRelatorio.Text = "Produto p/ Categoria";
            this.tsmProdutoCategoriaRelatorio.Click += new System.EventHandler(this.tsmProdutoCategoriaRelatorio_Click);
            // 
            // tsmProdutoCategoria
            // 
            this.tsmProdutoCategoria.Name = "tsmProdutoCategoria";
            this.tsmProdutoCategoria.Size = new System.Drawing.Size(224, 24);
            this.tsmProdutoCategoria.Text = "Produto p/ Categoria";
            this.tsmProdutoCategoria.Click += new System.EventHandler(this.tsmProdutoCategoria_Click);
            // 
            // tsmVendaCliente
            // 
            this.tsmVendaCliente.Name = "tsmVendaCliente";
            this.tsmVendaCliente.Size = new System.Drawing.Size(224, 24);
            this.tsmVendaCliente.Text = "Venda p/ Cliente";
            this.tsmVendaCliente.Click += new System.EventHandler(this.tsmVendaCliente_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.Text = ".: Tela Principal :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmFuncionario;
        private System.Windows.Forms.ToolStripMenuItem tsmProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmVenda;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsmProdutoCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmVendaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorio;
        private System.Windows.Forms.ToolStripMenuItem tsmProdutoRelatorio;
        private System.Windows.Forms.ToolStripMenuItem tsmProdutoCategoriaRelatorio;
    }
}

