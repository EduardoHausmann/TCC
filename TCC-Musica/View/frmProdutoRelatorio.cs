using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class frmProdutoRelatorio : Form
    {
        public frmProdutoRelatorio()
        {
            InitializeComponent();
        }

        private void frmProdutoRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProdutoRelatorio = null;
        }

        private void frmProdutoRelatorio_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Eduardo\Documents\GitHub\TCC\TCC-Musica\View\RPT\Produto.rpt");
            rd.Refresh();
            crvProduto.ReportSource = rd;
        }
    }
}
