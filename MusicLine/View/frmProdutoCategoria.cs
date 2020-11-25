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
    public partial class frmProdutoCategoria : Form
    {
        public frmProdutoCategoria()
        {
            InitializeComponent();
        }

        private void frmProdutoCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProdutoCategoria = null;
        }

        private void frmProdutoCategoria_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)cbCategoria.SelectedValue);
        }

        public void Pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto.Where(x => x.IdCategoria == codigoCategoria);
        }
    }
}
