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
    public partial class frmLogin : Form
    {

        public bool logado = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.Funcionario.Count(x => x.Usuario == txtUsuario.Text && x.Senha == txtSenha.Text);

            if (user > 0)
            {
                this.logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Erro!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtSenha.Focus();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                EfetuarLogin();
        }
    }
}
