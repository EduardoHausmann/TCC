namespace View
{
    partial class frmProdutoCategoriaRelatorio
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
            this.crvProdutoCategoria = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProdutoCategoria
            // 
            this.crvProdutoCategoria.ActiveViewIndex = -1;
            this.crvProdutoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProdutoCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProdutoCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProdutoCategoria.Location = new System.Drawing.Point(0, 0);
            this.crvProdutoCategoria.Name = "crvProdutoCategoria";
            this.crvProdutoCategoria.Size = new System.Drawing.Size(877, 450);
            this.crvProdutoCategoria.TabIndex = 0;
            this.crvProdutoCategoria.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmProdutoCategoriaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.crvProdutoCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProdutoCategoriaRelatorio";
            this.Text = ".: Relatório de Produtos por Categoria :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProdutoCategoriaRelatorio_FormClosed);
            this.Load += new System.EventHandler(this.frmProdutoCategoriaRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProdutoCategoria;
    }
}