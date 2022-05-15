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
	public partial class frmPesquisaProduto : Form
	{
		private int codigo;
		public frmPesquisaProduto()
		{
			InitializeComponent();
		}

		public int getCodigo() 
		{
			return codigo;
		}
		private void frmPesquisaProduto_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dbProdutosDataSet.tb_produto'. Você pode movê-la ou removê-la conforme necessário.
			this.tb_produtoTableAdapter.Fill(this.dbProdutosDataSet.tb_produto);

		}


		private void btnSair_Click(object sender, EventArgs e)
		{
			codigo = 0;
			Close();
		}

		private void tb_produtoDataGridView_DoubleClick(object sender, EventArgs e)
		{
			codigo = Convert.ToInt32(tb_produtoDataGridView.CurrentRow.Cells[0].Value);
			Close();
		}

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_produtoTableAdapter.Fill(this.dbProdutosDataSet.tb_produto);
            }
            else
            {
                this.tb_produtoTableAdapter.FillByNome(this.dbProdutosDataSet.tb_produto, "%" + txtNome.Text + "%");
            }
        }
    }
}
