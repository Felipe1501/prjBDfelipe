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
	public partial class frmPesquisaCliente : Form
	{
		private int codigoo;
		public frmPesquisaCliente()
		{
			InitializeComponent();
		}

		public int getCodigoo() 
		{
			return codigoo;
		}

		private void frmPesquisaCliente_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dbProdutosDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
			this.tb_clienteTableAdapter.Fill(this.dbProdutosDataSet.tb_cliente);

		}


		private void btnSair_Click(object sender, EventArgs e)
		{
			codigoo = 0;
			Close();
		}

		private void tb_clienteDataGridView_DoubleClick(object sender, EventArgs e)
		{
			codigoo = Convert.ToInt32(tb_clienteDataGridView.CurrentRow.Cells[0].Value);
			Close();
		}

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_clienteTableAdapter.Fill(this.dbProdutosDataSet.tb_cliente);
            }
            else
            {
                this.tb_clienteTableAdapter.FillByName(this.dbProdutosDataSet.tb_cliente, "%" + txtNome.Text + "%");
            }
        }
    }
}
