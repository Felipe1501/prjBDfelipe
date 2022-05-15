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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProdutosDataSet);

        }

        private void tb_usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProdutosDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProdutosDataSet.tb_usuario' table. You can move, or remove it, as needed.
            this.tb_usuarioTableAdapter.Fill(this.dbProdutosDataSet.tb_usuario);


        }

		private void nm_loginTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
            tb_usuarioTableAdapter.FillLogin(dbProdutosDataSet.tb_usuario, txtLogin.Text, txtSenha.Text);
            if (txtLogin.Text == "Felipe1501" && txtSenha.Text == "1501" || tb_usuarioBindingSource.Count > 0)
            {
                Form1 FP = new Form1();
                FP.Show();
            }
            else 
            {
            MessageBox.Show("LOGIN OU SENHA INVÁLIDOS HOMO SAPIENS !!!");
            }
		}

        private void tb_usuarioBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProdutosDataSet);

        }
    }
}
