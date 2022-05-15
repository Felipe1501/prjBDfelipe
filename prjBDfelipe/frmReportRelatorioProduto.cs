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
    public partial class frmReportRelatorioProduto : Form
    {
        public frmReportRelatorioProduto()
        {
            InitializeComponent();
        }

        private void frmReportRelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProdutosDataSet.tb_produto' table. You can move, or remove it, as needed.
            this.tb_produtoTableAdapter.Fill(this.dbProdutosDataSet.tb_produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
