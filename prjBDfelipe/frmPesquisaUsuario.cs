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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }
        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProdutosDataSet.tb_usuario' table. You can move, or remove it, as needed.
            this.tb_usuarioTableAdapter.Fill(this.dbProdutosDataSet.tb_usuario);

        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_usuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_usuarioTableAdapter.Fill(this.dbProdutosDataSet.tb_usuario);

            }
            else
            {
                this.tb_usuarioTableAdapter.FillByNome(this.dbProdutosDataSet.tb_usuario, "%" + txtNome.Text + "%");
            }
        }
    }
}
