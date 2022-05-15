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
	public partial class frmCliente : Form
	{
		public frmCliente()
		{
			InitializeComponent();
			Des();
		}

		private void Hab() {
			nm_clienteTextBox.Enabled = true;
			ds_enderecoTextBox.Enabled = true;
			nr_enderecoTextBox.Enabled = true;
			nm_bairroTextBox.Enabled = true;
			nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
			cd_telefoneTextBox.Enabled = true;
            cd_rgMaskedTextBox.Enabled = true;
			ds_emailTextBox.Enabled = true;
			btnSave.Enabled = true;
			btnCanc.Enabled = true;
			btnAnt.Enabled = false;
			btnProx.Enabled = false;
			btnAlte.Enabled = false;
			btnExit.Enabled = false;
			btnExcl.Enabled = false;
			btnImp.Enabled = false;
			btnNew.Enabled = false;
			btnSearch.Enabled = false;
		}

		private void Des() {
			nm_clienteTextBox.Enabled = false;
			ds_enderecoTextBox.Enabled = false;
			nr_enderecoTextBox.Enabled = false;
			nm_bairroTextBox.Enabled = false;
			nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
			cd_telefoneTextBox.Enabled = false;
            cd_rgMaskedTextBox.Enabled = false;
			ds_emailTextBox.Enabled = false;
			btnSave.Enabled = false;
			btnCanc.Enabled = false;
			btnAnt.Enabled = true;
			btnProx.Enabled = true;
			btnAlte.Enabled = true;
			btnExit.Enabled = true;
			btnExcl.Enabled = true;
			btnImp.Enabled = true;
			btnNew.Enabled = true;
			btnSearch.Enabled = true;
		}

		private void frmCliente_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dbProdutosDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
			this.tb_clienteTableAdapter.Fill(this.dbProdutosDataSet.tb_cliente);

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAnt_Click(object sender, EventArgs e)
		{
			tb_clienteBindingSource.MovePrevious();
		}

		private void btnProx_Click(object sender, EventArgs e)
		{
			tb_clienteBindingSource.MoveNext();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			tb_clienteBindingSource.AddNew();
			Hab();

		}

		private void btnAlte_Click(object sender, EventArgs e)
		{
			Hab();
		}

		private void btnExcl_Click(object sender, EventArgs e)
		{
			tb_clienteBindingSource.RemoveCurrent();
			tb_clienteTableAdapter.Update(dbProdutosDataSet.tb_cliente);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Validate();
			tb_clienteBindingSource.EndEdit();
			tb_clienteTableAdapter.Update(dbProdutosDataSet.tb_cliente);
			Des();
		}

		private void btnCanc_Click(object sender, EventArgs e)
		{
			tb_clienteBindingSource.CancelEdit();
			Des();
		}

        private void cd_cpfMaskedTextBox_Leave(object sender, EventArgs e)
        {
            int somar = 0, dig;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 2;
            somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 2;
            dig = somar % 11;
            //dig = 11 - dig;
            if(dig < 2)
            {
                dig = 0;
            }
            else
            {
                dig = 11 - dig;
            }
            
            if (int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) == dig)
            {
                somar = 0;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 2;
                somar += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 2;
                dig = somar % 11;
                if (dig < 2)
                {
                    dig = 0;
                }
                else
                {
                    dig = 11 - dig;
                }
                
                if (int.Parse(cd_cpfMaskedTextBox.Text.Substring(13, 1)) != dig)
                {
                    MessageBox.Show("CPF INVÁLIDO!!!");
                    cd_cpfMaskedTextBox.Focus();
                }
                else {
                    MessageBox.Show("CPF INVÁLIDO!!!");
                    cd_cpfMaskedTextBox.Focus();
                }
            }
        }

		private void cd_cpfMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			int codd, regg;
			frmPesquisaCliente FPC = new frmPesquisaCliente();
			FPC.ShowDialog();
			codd = FPC.getCodigoo();
			if (codd > 0) 
			{
				regg = tb_clienteBindingSource.Find("cd_cliente", codd);
				tb_clienteBindingSource.Position = regg;
			}
		}

        private void btnImp_Click(object sender, EventArgs e)
        {
            ppdImp.ShowDialog();
        }

        private void pdImp_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados2;
            Graphics objImp = e.Graphics;

            strDados2 = "FICHA DE CLIENTES\n\n";
            strDados2 += "CÓDIGO: " + cd_clienteTextBox.Text + "\n\n";
            strDados2 += "NOME: " + nm_clienteTextBox.Text + "\n\n";
            strDados2 += "ENDEREÇO: " + ds_enderecoTextBox.Text + "\n\n";
            strDados2 += "NÚMERO: " + nr_enderecoTextBox.Text + "\n\n";
            strDados2 += "BAIRRO: " + nm_bairroTextBox.Text + "\n\n";
            strDados2 += "ESTADO: " + sg_estadoComboBox.Text + "\n\n";
            strDados2 += "CEP: " + cd_cepMaskedTextBox.Text + "\n\n";
            strDados2 += "TELEFONE: " + cd_telefoneTextBox.Text + "\n\n";
            strDados2 += "CPF: " + cd_cpfMaskedTextBox.Text + "\n\n";
            strDados2 += "RG: " + cd_rgMaskedTextBox.Text + "\n\n";
            strDados2 += "EMAIL: " + ds_emailTextBox.Text + "\n\n";

            objImp.DrawString(strDados2, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void cd_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
