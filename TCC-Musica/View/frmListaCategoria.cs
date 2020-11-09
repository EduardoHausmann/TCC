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
    public partial class frmListaCategoria : Form
    {
        public frmListaCategoria()
        {
            InitializeComponent();
        }

        private void frmListaCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormListaCategoria = null;
        }

        private void frmListaCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void brnGeral_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProdutoCategoriaRelatorio == null)
                MeusFormularios.FormProdutoCategoriaRelatorio = new frmProdutoCategoriaRelatorio();

            MeusFormularios.FormProdutoCategoriaRelatorio.IdCategoria = (int)cbCategoria.SelectedValue;
            MeusFormularios.FormProdutoCategoriaRelatorio.Show();
            MeusFormularios.FormProdutoCategoriaRelatorio.Focus();
        }
    }
}
