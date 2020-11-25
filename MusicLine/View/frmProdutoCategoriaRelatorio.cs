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
    public partial class frmProdutoCategoriaRelatorio : Form
    {
        public int IdCategoria { get; set; }

        public frmProdutoCategoriaRelatorio()
        {
            InitializeComponent();
        }

        private void frmProdutoCategoriaRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProdutoCategoriaRelatorio = null;
        }

        private void frmProdutoCategoriaRelatorio_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Eduardo\Documents\GitHub\TCC\TCC-Musica\View\RPT\ProdutoCategoria.rpt");
            rd.Clone();
            rd.Refresh();
            ParameterField pf = rd.ParameterFields["idCategoria"];
            pf.CurrentValues.AddValue(this.IdCategoria);
            crvProdutoCategoria.ReportSource = rd;
        }
    }
}
