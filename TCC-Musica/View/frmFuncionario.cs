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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.funcionarioBindingSource.CancelEdit();
            MeusFormularios.FormFuncionario = null;
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.DataSource = DataContextFactory.DataContext.Funcionario;
            this.funcionarioBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.funcionarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dgvFuncionario.Refresh();
                MessageBox.Show("Armazenado com Sucesso!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.funcionarioBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                dgvFuncionario.Refresh();
                MessageBox.Show("Excluido com Sucesso!");
            }
        }

        private bool Valida()
        {
            if (txtUsuario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo usúario é obrigatório");
                return false;
            }
            else if (txtSenha.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo senha é obrigatório");
                return false;
            }
            else if (txtCargo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo cargo é obrigatório");
                return false;
            }
            return true;
        }

        public Funcionario FuncionarioCorrente
        {
            get
            {
                return (Funcionario)this.funcionarioBindingSource.Current;
            }
        }
    }
}
