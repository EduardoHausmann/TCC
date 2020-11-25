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
    public partial class frmVendaCliente : Form
    {
        public frmVendaCliente()
        {
            InitializeComponent();
        }

        private void frmVendaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormVendaCliente = null;
        }

        private void frmVendaCliente_Load(object sender, EventArgs e)
        {
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.clienteBindingSource.DataSource = DataContextFactory.DataContext.Cliente;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)cbCliente.SelectedValue);
        }

        public void Pesquisar(int idCliente)
        {
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda.Where(x => x.IdCliente == idCliente);
        }
    }
}
