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
	public partial class frmPesquisaFornecedor : Form
	{
		private int codigo;
		public frmPesquisaFornecedor()
		{
			InitializeComponent();
		}
		 
		public int getCod() 
		{
			return codigo;
		}


		private void PesquisaFornecedor_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dbProdutosDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
			this.tb_fornecedorTableAdapter.Fill(this.dbProdutosDataSet.tb_fornecedor);

		}


		private void btnSair_Click(object sender, EventArgs e)
		{
			codigo = 0;
			Close();
		}

		private void tb_fornecedorDataGridView_DoubleClick(object sender, EventArgs e)
		{
			codigo = Convert.ToInt32(tb_fornecedorDataGridView.CurrentRow.Cells[0].Value);
			Close();
		}

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                this.tb_fornecedorTableAdapter.Fill(this.dbProdutosDataSet.tb_fornecedor);
            }
            else
            {
                this.tb_fornecedorTableAdapter.FillByNome(this.dbProdutosDataSet.tb_fornecedor, "%" + txtName.Text + "%");
            }
        }
    }
}
