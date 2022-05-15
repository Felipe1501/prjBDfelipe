using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBDfelipe
{
	public partial class frmProduto : Form
	{
		public frmProduto()
		{
			InitializeComponent();
			Desabilit();
		}

		private void Habilit() {
			nm_produtoTextBox.Enabled = true;
			nm_categoriaTextBox.Enabled = true;
			qt_estoqueTextBox.Enabled = true;
			vl_custoTextBox.Enabled = true;
			vl_vendaTextBox.Enabled = true;
			btnSalvarrr.Enabled = true;
			btnCancell.Enabled = true;
			btnAlterarrr.Enabled = false;
			btnPreviaa.Enabled = false;
			btnProximooo.Enabled = false;
			btnNovooo.Enabled = false;
			btnExcluii.Enabled = false;
			btnImprimirrr.Enabled = false;
			btnPesquisaa.Enabled = false;
			btnExittt.Enabled = false;
		}

		private void Desabilit()
		{
			nm_produtoTextBox.Enabled = false;
			nm_categoriaTextBox.Enabled = false;
			qt_estoqueTextBox.Enabled = false;
			vl_custoTextBox.Enabled = false;
			vl_vendaTextBox.Enabled = false;
			btnSalvarrr.Enabled = false;
			btnCancell.Enabled = false;
			btnAlterarrr.Enabled = true;
			btnPreviaa.Enabled = true;
			btnProximooo.Enabled = true;
			btnNovooo.Enabled = true;
			btnExcluii.Enabled = true;
			btnImprimirrr.Enabled = true;
			btnPesquisaa.Enabled = true;
			btnExittt.Enabled = true;
		}

		private void frmProduto_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dbProdutosDataSet.tb_produto'. Você pode movê-la ou removê-la conforme necessário.
			this.tb_produtoTableAdapter.Fill(this.dbProdutosDataSet.tb_produto);

		}

		private void btnExittt_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnPreviaa_Click(object sender, EventArgs e)
		{
			tb_produtoBindingSource.MovePrevious();
		}

		private void btnProximooo_Click(object sender, EventArgs e)
		{
			tb_produtoBindingSource.MoveNext();
		}

		private void btnNovooo_Click(object sender, EventArgs e)
		{
			tb_produtoBindingSource.AddNew();
			Habilit();
		}

		private void btnAlterarrr_Click(object sender, EventArgs e)
		{
			Habilit();
		}

		private void btnExcluii_Click(object sender, EventArgs e)
		{
			tb_produtoBindingSource.RemoveCurrent();
			tb_produtoTableAdapter.Update(dbProdutosDataSet.tb_produto);
		}

		private void btnSalvarrr_Click(object sender, EventArgs e)
		{
			Validate();
			tb_produtoBindingSource.EndEdit();
			tb_produtoTableAdapter.Update(dbProdutosDataSet.tb_produto);
			Desabilit();
		}

		private void btnCancell_Click(object sender, EventArgs e)
		{
			tb_produtoBindingSource.CancelEdit();
			Desabilit();
		}

		private void btnPesquisaa_Click(object sender, EventArgs e)
		{
			int codig, regis;
			frmPesquisaProduto FPP = new frmPesquisaProduto();
			FPP.ShowDialog();
			codig = FPP.getCodigo();
			if (codig > 0) 
			{
				regis = tb_produtoBindingSource.Find("cd_produto", codig);
				tb_produtoBindingSource.Position = regis;
			}
		}

        private void btnImprimirrr_Click(object sender, EventArgs e)
        {
            ppdImpProduto.ShowDialog();
        }

        private void pdImpProduto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados4;
            Graphics objImpressaoProduto = e.Graphics;

            strDados4 = "FICHA DO PRODUTO\n\n";
            strDados4 += "CÓDIGO: " + cd_produtoTextBox.Text + "\n\n";
            strDados4 += "NOME PRODUTO: " + nm_produtoTextBox.Text + "\n\n";
            strDados4 += "CATEGORIA: " + nm_categoriaTextBox.Text + "\n\n";
            strDados4 += "VALOR CUSTO: " + vl_custoTextBox.Text + "\n\n";
            strDados4 += "VALOR VENDA: " + vl_vendaTextBox.Text + "\n\n";

            objImpressaoProduto.DrawString(strDados4, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
