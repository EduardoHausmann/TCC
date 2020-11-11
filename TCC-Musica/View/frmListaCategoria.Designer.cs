namespace View
{
    partial class frmListaCategoria
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
            System.Windows.Forms.Label lblCategoria;
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.brnGeral = new System.Windows.Forms.Button();
            lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCategoria.Location = new System.Drawing.Point(12, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(178, 20);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Selecione um Categoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Musica.DAL.Categoria);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.categoriaBindingSource;
            this.cbCategoria.DisplayMember = "Nome";
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(16, 32);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(344, 28);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.ValueMember = "Id";
            // 
            // brnGeral
            // 
            this.brnGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGeral.Location = new System.Drawing.Point(103, 70);
            this.brnGeral.Name = "brnGeral";
            this.brnGeral.Size = new System.Drawing.Size(148, 37);
            this.brnGeral.TabIndex = 3;
            this.brnGeral.Text = "Gerar Relatório";
            this.brnGeral.UseVisualStyleBackColor = true;
            this.brnGeral.Click += new System.EventHandler(this.brnGeral_Click);
            // 
            // frmListaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 119);
            this.Controls.Add(this.brnGeral);
            this.Controls.Add(lblCategoria);
            this.Controls.Add(this.cbCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaCategoria";
            this.Text = ".: Lista de Categoria :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaCategoria_FormClosed);
            this.Load += new System.EventHandler(this.frmListaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button brnGeral;
    }
}