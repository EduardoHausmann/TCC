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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
            MeusFormularios.FormCategoria = null;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
            this.categoriaBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dgvCategoria.Refresh();
                MessageBox.Show("Armazenado com Sucesso!");
            }

            if (MessageBox.Show("Adinionar outra?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.categoriaBindingSource.AddNew();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.categoriaBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                dgvCategoria.Refresh();
                MessageBox.Show("Excluido com Sucesso!");
            }
        }

        private bool Valida()
        {
            if (txtCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatório!");
                txtCategoria.Focus();
                return false;
            }
            return true;
        }

        public Categoria CategoriaCorrente
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Produto.Where(x => x.IdCategoria == categoria.Id);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }
    }
}
