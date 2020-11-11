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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.clienteBindingSource.CancelEdit();
            MeusFormularios.FormCliente = null;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.clienteBindingSource.DataSource = DataContextFactory.DataContext.Cliente;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.clienteBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dgvCliente.Refresh();
                MessageBox.Show("Armazenado com Sucesso!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.clienteBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                dgvCliente.Refresh();
                MessageBox.Show("Excluido com sucesso!");
            }
        }

        private bool Valida()
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo nome é obrigatório");
                txtNome.Focus();
                return false;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo email é obrigatório");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        public Cliente ClienteCorrent
        {
            get
            {
                return (Cliente)this.clienteBindingSource.Current;
            }
        }
    }
}
