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
    public partial class frmUsuario : Form
    {

        private void Habilita()
        {
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAnterior.Enabled = false;
            btnSair.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;

        }

        private void Desabilita()
        {
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAnterior.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
        }

        public frmUsuario()
        {
            InitializeComponent();
            Desabilita();
        }


        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProdutosDataSet.tb_usuario' table. You can move, or remove it, as needed.
            this.tb_usuarioTableAdapter.Fill(this.dbProdutosDataSet.tb_usuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.RemoveCurrent();
            tb_usuarioTableAdapter.Update(dbProdutosDataSet.tb_usuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(dbProdutosDataSet.tb_usuario);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaUsuario FPU = new frmPesquisaUsuario();
            FPU.ShowDialog();
            cod = FPU.getCodigo();
            if(cod > 0)
            {
                reg = tb_usuarioBindingSource.Find("cd_usuario", cod);
                tb_usuarioBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUÁRIO\n\n";
            strDados += "CÓDIGO: " + cd_usuarioTextBox.Text + "\n\n";
            strDados += "NOME: " + nm_usuarioTextBox.Text + "\n\n";
            strDados += "NÍVEL: " + sg_nivelTextBox.Text + "\n\n";
            strDados += "LOGIN: " + nm_loginTextBox.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
