using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace prjBDfelipe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormSplashScreen FSS = new FormSplashScreen();
            FSS.Show();
            Thread.Sleep(3000);
            FSS.Hide();
        }

		private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Close();
		}

		private void rELATÓRIOToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

        private void uSUÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

		private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmCliente fcl = new frmCliente();
            fcl.ShowDialog();
		}

		private void fORNECEDORESToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmFornecedor ffc = new frmFornecedor();
            ffc.ShowDialog();
		}

		private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProduto pdt = new frmProduto();
			pdt.ShowDialog();
		}

        private void uSUÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportRelatorioUsuario FRU = new frmReportRelatorioUsuario();
            FRU.ShowDialog();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportRelatorioCliente FRC = new frmReportRelatorioCliente();
            FRC.ShowDialog();
        }

        private void fORNECEDORESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportRelatorioFornecedor FRF = new frmReportRelatorioFornecedor();
            FRF.ShowDialog();
        }

        private void pRODUTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportRelatorioProduto FRP = new frmReportRelatorioProduto();
            FRP.ShowDialog();
        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abUsuario ABU = new abUsuario();
            ABU.ShowDialog();
        }


    }
}
