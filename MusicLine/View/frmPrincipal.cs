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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmCategoria_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
                MeusFormularios.FormCategoria = new frmCategoria();

            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
        }

        private void tsmCliente_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCliente == null)
                MeusFormularios.FormCliente = new frmCliente();

            MeusFormularios.FormCliente.Show();
            MeusFormularios.FormCliente.Focus();
        }

        private void tsmFuncionario_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFuncionario == null)
                MeusFormularios.FormFuncionario = new frmFuncionario();

            MeusFormularios.FormFuncionario.Show();
            MeusFormularios.FormFuncionario.Focus();
        }

        private void tsmProduto_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
                MeusFormularios.FormProduto = new frmProduto();

            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }

        private void tsmVenda_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormVenda == null)
                MeusFormularios.FormVenda = new frmVenda();

            MeusFormularios.FormVenda.Show();
            MeusFormularios.FormVenda.Focus();
        }

        private void tsmProdutoCategoria_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProdutoCategoria == null)
                MeusFormularios.FormProdutoCategoria = new frmProdutoCategoria();

            MeusFormularios.FormProdutoCategoria.Show();
            MeusFormularios.FormProdutoCategoria.Focus();
        }

        private void tsmVendaCliente_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormVendaCliente == null)
                MeusFormularios.FormVendaCliente = new frmVendaCliente();

            MeusFormularios.FormVendaCliente.Show();
            MeusFormularios.FormVendaCliente.Focus();
        }

        private void tsmProdutoRelatorio_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProdutoRelatorio == null)
                MeusFormularios.FormProdutoRelatorio = new frmProdutoRelatorio();

            MeusFormularios.FormProdutoRelatorio.Show();
            MeusFormularios.FormProdutoRelatorio.Focus();
        }

        private void tsmProdutoCategoriaRelatorio_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormListaCategoria == null)
                MeusFormularios.FormListaCategoria = new frmListaCategoria();

            MeusFormularios.FormListaCategoria.Show();
            MeusFormularios.FormListaCategoria.Focus();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
