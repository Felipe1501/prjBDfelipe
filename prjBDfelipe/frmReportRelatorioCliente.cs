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
    public partial class frmReportRelatorioCliente : Form
    {
        public frmReportRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmReportRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProdutosDataSet.tb_cliente' table. You can move, or remove it, as needed.
            this.tb_clienteTableAdapter.Fill(this.dbProdutosDataSet.tb_cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
