using Musica.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
            MeusFormularios.FormProduto = null;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.produtoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dgvProduto.Refresh();
                MessageBox.Show("Armazenado com Sucesso!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.produtoBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                dgvProduto.Refresh();
                MessageBox.Show("Excluido com Sucesso!");
            }
        }

        private void dgvProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Nome;
        }

        private bool Valida()
        {
            if (txtProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo produto é obrigatório!");
                txtProduto.Focus();
                return false;
            }
            return true;
        }
    }
}
