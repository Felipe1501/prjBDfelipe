namespace prjBDfelipe
{
    partial class frmReportRelatorioProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbProdutosDataSet = new prjBDfelipe.dbProdutosDataSet();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_produtoTableAdapter = new prjBDfelipe.dbProdutosDataSetTableAdapters.tb_produtoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_produtoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjBDfelipe.RelatorioProduto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(853, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbProdutosDataSet
            // 
            this.dbProdutosDataSet.DataSetName = "dbProdutosDataSet";
            this.dbProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataMember = "tb_produto";
            this.tb_produtoBindingSource.DataSource = this.dbProdutosDataSet;
            // 
            // tb_produtoTableAdapter
            // 
            this.tb_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportRelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 412);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportRelatorioProduto";
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.frmReportRelatorioProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_produtoBindingSource;
        private dbProdutosDataSet dbProdutosDataSet;
        private dbProdutosDataSetTableAdapters.tb_produtoTableAdapter tb_produtoTableAdapter;
    }
}