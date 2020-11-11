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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormVenda = null;
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            this.clienteBindingSource.DataSource = DataContextFactory.DataContext.Cliente;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;

            this.vendaBindingSource.AddNew();

            this.contaReceberBindingSource.DataSource = DataContextFactory.DataContext.ContaReceber;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamento;
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItemVenda ItemCorrente
        {
            get
            {
                return (ItemVenda)this.itemVendaBindingSource.Current;
            }
        }

        public ContaReceber ContaCorrente
        {
            get
            {
                return (ContaReceber)this.contaReceberBindingSource.Current;
            }
        }

        private void NovoItem()
        {
            this.itemVendaBindingSource.AddNew();
            this.ItemCorrente.IdVenda = this.VendaCorrente.Id;
            this.ItemCorrente.Quantidade = 1;
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in dgvItem.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }
            this.VendaCorrente.Valor = total;
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            cbCliente.Enabled = false;
            gbVenda.Visible = true;
            btnNovaVenda.Enabled = false;
            this.itemVendaBindingSource.DataSource = DataContextFactory.DataContext.ItemVenda.Where(x => x.IdProduto == this.VendaCorrente.Id);
            NovoItem();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            this.itemVendaBindingSource.EndEdit();
            dgvItem.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }

        private void dgvItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Nome;
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduto.SelectedItem != null)
            {
                var pro = (Produto)cbProduto.SelectedItem;
                this.ItemCorrente.IdProduto = (int)pro.Id;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }

        private void btnFP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar esta venda?\nNão sera possivel adicionar um novo item!", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itemVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btnNovoItem.Enabled = false;
                cbProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;
                txtCodVenda.Enabled = false;
                txtDesconto.ReadOnly = false;
                txtDesconto.Focus();
                btnFP.Enabled = false;
                btnFV.Enabled = true;
            }
        }

        private void btnFV_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txtDesconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txtDesconto.Enabled = false;
            btnFV.Enabled = false;
            //Conta Receber
            this.contaReceberBindingSource.AddNew();
            cbStatus.Enabled = true;
            this.ContaCorrente.IdVenda = this.VendaCorrente.Id;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
            dtpDataVencimento.Enabled = true;
            btnFinalizar.Enabled = true;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem != null)
            {
                var status = (StatusPagamento)cbStatus.SelectedItem;
                if (status.Id == 1)
                {
                    this.ContaCorrente.IdStatus = (int)status.Id;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    btnFinalizar.Enabled = true;
                    dtpDataVencimento.Enabled = false;
                }
                else if (status.Id == 2)
                {
                    this.ContaCorrente.IdStatus = (int)status.Id;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    this.ContaCorrente.DataPagamento = null;
                    dtpDataVencimento.Enabled = true;
                    btnFinalizar.Enabled = true;
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.contaReceberBindingSource.EndEdit();
            dtpDataVencimento.Enabled = false;
            cbStatus.Enabled = false;
            DataContextFactory.DataContext.SubmitChanges();
            btnImprimir.Enabled = true;
            btnFinalizar.Enabled = false;
            MessageBox.Show("Venda finalizada com sucesso!\nImprima o cupom da venda!", "Venda Finalizada");
            cbCliente.Enabled = true;
            gbVenda.Visible = false;
            cbCliente.SelectedItem = null;
            btnNovaVenda.Enabled = true;
        }
    }
}
