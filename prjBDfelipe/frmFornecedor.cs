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
	public partial class frmFornecedor : Form
	{
		public frmFornecedor()
		{
			InitializeComponent();
			Desabilitar();
		}

		private void Habilitar() {
			nm_fornecedorTextBox.Enabled = true;
			ds_enderecoTextBox.Enabled = true;
			nr_enderecoTextBox.Enabled = true;
			nm_bairroTextBox.Enabled = true;
			nm_cidadeTextBox.Enabled = true;
			sg_tipoTextBox.Enabled = true;
			sg_estadoComboBox.Enabled = true;
			cd_cepMaskedTextBox.Enabled = true;
			cd_cnpjMaskedTextBox.Enabled = true;
			cd_rgMaskedTextBox.Enabled = true;
			cd_telefoneTextBox.Enabled = true;
			ds_emailTextBox.Enabled = true;
			nm_contatoTextBox.Enabled = true;
			cd_cpfMaskedTextBox.Enabled = true;
			cd_ieMaskedTextBox.Enabled = true;
			btnSalvarr.Enabled = true;
			btnCancel.Enabled = true;
			btnPrevia.Enabled = false;
			btnProximoo.Enabled = false;
			btnNovoo.Enabled = false;
			btnAlterarr.Enabled = false;
			btnExclui.Enabled = false;
			btnNovoo.Enabled = false;
			btnPesquisa.Enabled = false;
			btnImprimirr.Enabled = false;
			btnExitt.Enabled = false;
			
		}

		private void Desabilitar() {
			nm_fornecedorTextBox.Enabled = false;
			ds_enderecoTextBox.Enabled = false;
			nr_enderecoTextBox.Enabled = false;
			nm_bairroTextBox.Enabled = false;
			nm_cidadeTextBox.Enabled = false;
			sg_tipoTextBox.Enabled = false;
			sg_estadoComboBox.Enabled = false;
			cd_cepMaskedTextBox.Enabled = false;
			cd_cnpjMaskedTextBox.Enabled = false;
			cd_rgMaskedTextBox.Enabled = false;
			cd_telefoneTextBox.Enabled = false;
			ds_emailTextBox.Enabled = false;
			nm_contatoTextBox.Enabled = false;
			cd_cpfMaskedTextBox.Enabled = false;
			cd_ieMaskedTextBox.Enabled = false;
			btnSalvarr.Enabled = false;
			btnCancel.Enabled = false;
			btnPrevia.Enabled = true;
			btnProximoo.Enabled = true;
			btnNovoo.Enabled = true;
			btnAlterarr.Enabled = true;
			btnExclui.Enabled = true;
			btnNovoo.Enabled = true;
			btnPesquisa.Enabled = true;
			btnImprimirr.Enabled = true;
			btnExitt.Enabled = true;

		}



		private void frmFornecedor_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dbProdutosDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
			this.tb_fornecedorTableAdapter.Fill(this.dbProdutosDataSet.tb_fornecedor);

		}

		private void btnExitt_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnPrevia_Click(object sender, EventArgs e)
		{
			tb_fornecedorBindingSource.MovePrevious();
		}

		private void btnProximoo_Click(object sender, EventArgs e)
		{
			tb_fornecedorBindingSource.MoveNext();
		}

		private void btnNovoo_Click(object sender, EventArgs e)
		{
			tb_fornecedorBindingSource.AddNew();
			Habilitar();

		}

		private void btnAlterarr_Click(object sender, EventArgs e)
		{
			Habilitar();
		}

		private void btnExclui_Click(object sender, EventArgs e)
		{
			tb_fornecedorBindingSource.RemoveCurrent();
			tb_fornecedorTableAdapter.Update(dbProdutosDataSet.tb_fornecedor);
		}

		private void btnSalvarr_Click(object sender, EventArgs e)
		{
			Validate();
			tb_fornecedorBindingSource.EndEdit();
			tb_fornecedorTableAdapter.Update(dbProdutosDataSet.tb_fornecedor);
			Desabilitar();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			tb_fornecedorBindingSource.CancelEdit();
			Desabilitar();
		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			int codigo, registro;
			frmPesquisaFornecedor FPF = new frmPesquisaFornecedor();
			FPF.ShowDialog();
			codigo = FPF.getCod();
			if (codigo > 0) 
			{
				registro = tb_fornecedorBindingSource.Find("cd_fornecedor", codigo);
				tb_fornecedorBindingSource.Position = registro;
			}
		}

		private void sg_tipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (sg_tipoComboBox_SelectedIndexChanged == 'FÍSICA') 
			//{
			//	cd_cpfMaskedTextBox.Enabled = true;
			//	cd_rgMaskedTextBox.Enabled = true;
			//}else
			//{
				//cd_ieMaskedTextBox.Enabled = true;
				//cd_cnpjMaskedTextBox.Enabled = true;
			//}
		}

		private void cd_cpfMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

        private void btnImprimirr_Click(object sender, EventArgs e)
        {
            ppdImpFornecedor.ShowDialog();
        }

        private void ppdImpFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void pdImpFornecedor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados3;
            Graphics objImpFornecedor = e.Graphics;

            strDados3 = "FICHA DE FORNECEDOR\n\n";
            strDados3 += "CÓDIGO: " + cd_fornecedorTextBox.Text + "\n\n";
            strDados3 += "NOME: " + nm_fornecedorTextBox.Text + "\n\n";
            strDados3 += "ENDEREÇO: " + ds_enderecoTextBox.Text + "\n\n";
            strDados3 += "NÚMERO: " + nr_enderecoTextBox.Text + "\n\n";
            strDados3 += "BAIRRO: " + nm_bairroTextBox.Text + "\n\n";
            strDados3 += "CIDADE: " + nm_cidadeTextBox.Text + "\n\n";
            strDados3 += "CEP: " + cd_cepMaskedTextBox.Text + "\n\n";
            strDados3 += "ESTADO: " + sg_estadoComboBox.Text + "\n\n";
            strDados3 += "TELEFONE: " + cd_telefoneTextBox.Text + "\n\n";
            strDados3 += "CONTATO: " + nm_contatoTextBox.Text + "\n\n";
            strDados3 += "TIPO: " + sg_tipoTextBox.Text + "\n\n";
            strDados3 += "CPF: " + cd_cpfMaskedTextBox.Text + "\n\n";
            strDados3 += "RG: " + cd_rgMaskedTextBox.Text + "\n\n";
            strDados3 += "CNPJ: " + cd_cnpjMaskedTextBox.Text + "\n\n";
            strDados3 += "INSCRIÇÃO ESTADUAL: " + cd_ieMaskedTextBox.Text + "\n\n";
            strDados3 += "EMAIL: " + ds_emailTextBox.Text + "\n\n";

            objImpFornecedor.DrawString(strDados3, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);                 
         }

        private void cd_fornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
