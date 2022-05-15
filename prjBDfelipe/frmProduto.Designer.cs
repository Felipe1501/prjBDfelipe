namespace prjBDfelipe
{
	partial class frmProduto
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
            System.Windows.Forms.Label cd_produtoLabel;
            System.Windows.Forms.Label nm_produtoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            System.Windows.Forms.Label nm_categoriaLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            System.Windows.Forms.Label vl_custoLabel;
            System.Windows.Forms.Label vl_vendaLabel;
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbProdutosDataSet = new prjBDfelipe.dbProdutosDataSet();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.qt_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.vl_custoTextBox = new System.Windows.Forms.TextBox();
            this.vl_vendaTextBox = new System.Windows.Forms.TextBox();
            this.btnPreviaa = new System.Windows.Forms.Button();
            this.btnProximooo = new System.Windows.Forms.Button();
            this.btnNovooo = new System.Windows.Forms.Button();
            this.btnExcluii = new System.Windows.Forms.Button();
            this.btnAlterarrr = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnPesquisaa = new System.Windows.Forms.Button();
            this.btnSalvarrr = new System.Windows.Forms.Button();
            this.btnImprimirrr = new System.Windows.Forms.Button();
            this.btnExittt = new System.Windows.Forms.Button();
            this.tb_produtoTableAdapter = new prjBDfelipe.dbProdutosDataSetTableAdapters.tb_produtoTableAdapter();
            this.pdImpProduto = new System.Drawing.Printing.PrintDocument();
            this.ppdImpProduto = new System.Windows.Forms.PrintPreviewDialog();
            cd_produtoLabel = new System.Windows.Forms.Label();
            nm_produtoLabel = new System.Windows.Forms.Label();
            nm_categoriaLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            vl_custoLabel = new System.Windows.Forms.Label();
            vl_vendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_produtoLabel
            // 
            cd_produtoLabel.AutoSize = true;
            cd_produtoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_produtoLabel.Image = global::prjBDfelipe.Properties.Resources.apps_18763_14422652290628995_37694ae8_eb71_4ba2_86c6_2ae02b79e3fe;
            cd_produtoLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            cd_produtoLabel.Location = new System.Drawing.Point(56, 39);
            cd_produtoLabel.Name = "cd_produtoLabel";
            cd_produtoLabel.Size = new System.Drawing.Size(64, 20);
            cd_produtoLabel.TabIndex = 1;
            cd_produtoLabel.Text = "CÓDIGO:";
            // 
            // nm_produtoLabel
            // 
            nm_produtoLabel.AutoSize = true;
            nm_produtoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_produtoLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_produtoLabel.Image")));
            nm_produtoLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            nm_produtoLabel.Location = new System.Drawing.Point(56, 80);
            nm_produtoLabel.Name = "nm_produtoLabel";
            nm_produtoLabel.Size = new System.Drawing.Size(52, 20);
            nm_produtoLabel.TabIndex = 3;
            nm_produtoLabel.Text = "NOME:";
            // 
            // nm_categoriaLabel
            // 
            nm_categoriaLabel.AutoSize = true;
            nm_categoriaLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_categoriaLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_categoriaLabel.Image")));
            nm_categoriaLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            nm_categoriaLabel.Location = new System.Drawing.Point(56, 121);
            nm_categoriaLabel.Name = "nm_categoriaLabel";
            nm_categoriaLabel.Size = new System.Drawing.Size(88, 20);
            nm_categoriaLabel.TabIndex = 5;
            nm_categoriaLabel.Text = "CATEGORIA:";
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qt_estoqueLabel.Image = ((System.Drawing.Image)(resources.GetObject("qt_estoqueLabel.Image")));
            qt_estoqueLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            qt_estoqueLabel.Location = new System.Drawing.Point(56, 162);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(76, 20);
            qt_estoqueLabel.TabIndex = 7;
            qt_estoqueLabel.Text = "ESTOQUE:";
            // 
            // vl_custoLabel
            // 
            vl_custoLabel.AutoSize = true;
            vl_custoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_custoLabel.Image = ((System.Drawing.Image)(resources.GetObject("vl_custoLabel.Image")));
            vl_custoLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            vl_custoLabel.Location = new System.Drawing.Point(56, 203);
            vl_custoLabel.Name = "vl_custoLabel";
            vl_custoLabel.Size = new System.Drawing.Size(105, 20);
            vl_custoLabel.TabIndex = 9;
            vl_custoLabel.Text = "VALOR CUSTO:";
            // 
            // vl_vendaLabel
            // 
            vl_vendaLabel.AutoSize = true;
            vl_vendaLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_vendaLabel.Image = ((System.Drawing.Image)(resources.GetObject("vl_vendaLabel.Image")));
            vl_vendaLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            vl_vendaLabel.Location = new System.Drawing.Point(56, 244);
            vl_vendaLabel.Name = "vl_vendaLabel";
            vl_vendaLabel.Size = new System.Drawing.Size(106, 20);
            vl_vendaLabel.TabIndex = 11;
            vl_vendaLabel.Text = "VALOR VENDA:";
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "cd_produto", true));
            this.cd_produtoTextBox.Enabled = false;
            this.cd_produtoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_produtoTextBox.Location = new System.Drawing.Point(126, 36);
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(68, 26);
            this.cd_produtoTextBox.TabIndex = 2;
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataMember = "tb_produto";
            this.tb_produtoBindingSource.DataSource = this.dbProdutosDataSet;
            // 
            // dbProdutosDataSet
            // 
            this.dbProdutosDataSet.DataSetName = "dbProdutosDataSet";
            this.dbProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "nm_produto", true));
            this.nm_produtoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_produtoTextBox.Location = new System.Drawing.Point(114, 77);
            this.nm_produtoTextBox.MaxLength = 50;
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(353, 26);
            this.nm_produtoTextBox.TabIndex = 4;
            // 
            // nm_categoriaTextBox
            // 
            this.nm_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "nm_categoria", true));
            this.nm_categoriaTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_categoriaTextBox.Location = new System.Drawing.Point(152, 118);
            this.nm_categoriaTextBox.MaxLength = 30;
            this.nm_categoriaTextBox.Name = "nm_categoriaTextBox";
            this.nm_categoriaTextBox.Size = new System.Drawing.Size(197, 26);
            this.nm_categoriaTextBox.TabIndex = 6;
            // 
            // qt_estoqueTextBox
            // 
            this.qt_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "qt_estoque", true));
            this.qt_estoqueTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt_estoqueTextBox.Location = new System.Drawing.Point(139, 159);
            this.qt_estoqueTextBox.MaxLength = 1;
            this.qt_estoqueTextBox.Name = "qt_estoqueTextBox";
            this.qt_estoqueTextBox.Size = new System.Drawing.Size(55, 26);
            this.qt_estoqueTextBox.TabIndex = 8;
            // 
            // vl_custoTextBox
            // 
            this.vl_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "vl_custo", true));
            this.vl_custoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_custoTextBox.Location = new System.Drawing.Point(168, 200);
            this.vl_custoTextBox.MaxLength = 10;
            this.vl_custoTextBox.Name = "vl_custoTextBox";
            this.vl_custoTextBox.Size = new System.Drawing.Size(105, 26);
            this.vl_custoTextBox.TabIndex = 10;
            // 
            // vl_vendaTextBox
            // 
            this.vl_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "vl_venda", true));
            this.vl_vendaTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_vendaTextBox.Location = new System.Drawing.Point(168, 241);
            this.vl_vendaTextBox.MaxLength = 10;
            this.vl_vendaTextBox.Name = "vl_vendaTextBox";
            this.vl_vendaTextBox.Size = new System.Drawing.Size(105, 26);
            this.vl_vendaTextBox.TabIndex = 12;
            // 
            // btnPreviaa
            // 
            this.btnPreviaa.AutoSize = true;
            this.btnPreviaa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviaa.Image = global::prjBDfelipe.Properties.Resources.left_arrow;
            this.btnPreviaa.Location = new System.Drawing.Point(77, 309);
            this.btnPreviaa.Name = "btnPreviaa";
            this.btnPreviaa.Size = new System.Drawing.Size(100, 30);
            this.btnPreviaa.TabIndex = 52;
            this.btnPreviaa.Text = "ANTERIOR";
            this.btnPreviaa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviaa.UseVisualStyleBackColor = true;
            this.btnPreviaa.Click += new System.EventHandler(this.btnPreviaa_Click);
            // 
            // btnProximooo
            // 
            this.btnProximooo.AutoSize = true;
            this.btnProximooo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximooo.Image = global::prjBDfelipe.Properties.Resources.right_arrow;
            this.btnProximooo.Location = new System.Drawing.Point(194, 309);
            this.btnProximooo.Name = "btnProximooo";
            this.btnProximooo.Size = new System.Drawing.Size(95, 30);
            this.btnProximooo.TabIndex = 51;
            this.btnProximooo.Text = "PRÓXIMO";
            this.btnProximooo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProximooo.UseVisualStyleBackColor = true;
            this.btnProximooo.Click += new System.EventHandler(this.btnProximooo_Click);
            // 
            // btnNovooo
            // 
            this.btnNovooo.AutoSize = true;
            this.btnNovooo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovooo.Image = global::prjBDfelipe.Properties.Resources.add;
            this.btnNovooo.Location = new System.Drawing.Point(353, 309);
            this.btnNovooo.Name = "btnNovooo";
            this.btnNovooo.Size = new System.Drawing.Size(75, 30);
            this.btnNovooo.TabIndex = 50;
            this.btnNovooo.Text = "NOVO";
            this.btnNovooo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovooo.UseVisualStyleBackColor = true;
            this.btnNovooo.Click += new System.EventHandler(this.btnNovooo_Click);
            // 
            // btnExcluii
            // 
            this.btnExcluii.AutoSize = true;
            this.btnExcluii.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluii.Image = global::prjBDfelipe.Properties.Resources.bin;
            this.btnExcluii.Location = new System.Drawing.Point(627, 309);
            this.btnExcluii.Name = "btnExcluii";
            this.btnExcluii.Size = new System.Drawing.Size(89, 30);
            this.btnExcluii.TabIndex = 49;
            this.btnExcluii.Text = "EXCLUIR";
            this.btnExcluii.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluii.UseVisualStyleBackColor = true;
            this.btnExcluii.Click += new System.EventHandler(this.btnExcluii_Click);
            // 
            // btnAlterarrr
            // 
            this.btnAlterarrr.AutoSize = true;
            this.btnAlterarrr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarrr.Image = global::prjBDfelipe.Properties.Resources.exchange;
            this.btnAlterarrr.Location = new System.Drawing.Point(479, 309);
            this.btnAlterarrr.Name = "btnAlterarrr";
            this.btnAlterarrr.Size = new System.Drawing.Size(94, 30);
            this.btnAlterarrr.TabIndex = 48;
            this.btnAlterarrr.Text = "ALTERAR";
            this.btnAlterarrr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterarrr.UseVisualStyleBackColor = true;
            this.btnAlterarrr.Click += new System.EventHandler(this.btnAlterarrr_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.AutoSize = true;
            this.btnCancell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.Image = global::prjBDfelipe.Properties.Resources.error;
            this.btnCancell.Location = new System.Drawing.Point(194, 365);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(105, 30);
            this.btnCancell.TabIndex = 47;
            this.btnCancell.Text = "CANCELAR";
            this.btnCancell.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnPesquisaa
            // 
            this.btnPesquisaa.AutoSize = true;
            this.btnPesquisaa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaa.Image = global::prjBDfelipe.Properties.Resources.search;
            this.btnPesquisaa.Location = new System.Drawing.Point(353, 365);
            this.btnPesquisaa.Name = "btnPesquisaa";
            this.btnPesquisaa.Size = new System.Drawing.Size(111, 30);
            this.btnPesquisaa.TabIndex = 46;
            this.btnPesquisaa.Text = "PESQUISAR";
            this.btnPesquisaa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisaa.UseVisualStyleBackColor = true;
            this.btnPesquisaa.Click += new System.EventHandler(this.btnPesquisaa_Click);
            // 
            // btnSalvarrr
            // 
            this.btnSalvarrr.AutoSize = true;
            this.btnSalvarrr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarrr.Image = global::prjBDfelipe.Properties.Resources.floppy_disk;
            this.btnSalvarrr.Location = new System.Drawing.Point(76, 365);
            this.btnSalvarrr.Name = "btnSalvarrr";
            this.btnSalvarrr.Size = new System.Drawing.Size(87, 30);
            this.btnSalvarrr.TabIndex = 45;
            this.btnSalvarrr.Text = "SALVAR";
            this.btnSalvarrr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarrr.UseVisualStyleBackColor = true;
            this.btnSalvarrr.Click += new System.EventHandler(this.btnSalvarrr_Click);
            // 
            // btnImprimirrr
            // 
            this.btnImprimirrr.AutoSize = true;
            this.btnImprimirrr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirrr.Image = global::prjBDfelipe.Properties.Resources.printer;
            this.btnImprimirrr.Location = new System.Drawing.Point(491, 365);
            this.btnImprimirrr.Name = "btnImprimirrr";
            this.btnImprimirrr.Size = new System.Drawing.Size(93, 30);
            this.btnImprimirrr.TabIndex = 44;
            this.btnImprimirrr.Text = "IMPRIMIR";
            this.btnImprimirrr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimirrr.UseVisualStyleBackColor = true;
            this.btnImprimirrr.Click += new System.EventHandler(this.btnImprimirrr_Click);
            // 
            // btnExittt
            // 
            this.btnExittt.AutoSize = true;
            this.btnExittt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExittt.Image = global::prjBDfelipe.Properties.Resources.logout;
            this.btnExittt.Location = new System.Drawing.Point(627, 365);
            this.btnExittt.Name = "btnExittt";
            this.btnExittt.Size = new System.Drawing.Size(75, 30);
            this.btnExittt.TabIndex = 43;
            this.btnExittt.Text = "SAIR";
            this.btnExittt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExittt.UseVisualStyleBackColor = true;
            this.btnExittt.Click += new System.EventHandler(this.btnExittt_Click);
            // 
            // tb_produtoTableAdapter
            // 
            this.tb_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // pdImpProduto
            // 
            this.pdImpProduto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdImpProduto_PrintPage);
            // 
            // ppdImpProduto
            // 
            this.ppdImpProduto.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdImpProduto.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdImpProduto.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdImpProduto.Document = this.pdImpProduto;
            this.ppdImpProduto.Enabled = true;
            this.ppdImpProduto.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdImpProduto.Icon")));
            this.ppdImpProduto.Name = "ppdImpProduto";
            this.ppdImpProduto.Visible = false;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjBDfelipe.Properties.Resources.apps_18763_14422652290628995_37694ae8_eb71_4ba2_86c6_2ae02b79e3fe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnPreviaa);
            this.Controls.Add(this.btnProximooo);
            this.Controls.Add(this.btnNovooo);
            this.Controls.Add(this.btnExcluii);
            this.Controls.Add(this.btnAlterarrr);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnPesquisaa);
            this.Controls.Add(this.btnSalvarrr);
            this.Controls.Add(this.btnImprimirrr);
            this.Controls.Add(this.btnExittt);
            this.Controls.Add(cd_produtoLabel);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(nm_produtoLabel);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(nm_categoriaLabel);
            this.Controls.Add(this.nm_categoriaTextBox);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.qt_estoqueTextBox);
            this.Controls.Add(vl_custoLabel);
            this.Controls.Add(this.vl_custoTextBox);
            this.Controls.Add(vl_vendaLabel);
            this.Controls.Add(this.vl_vendaTextBox);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO PRODUTOS";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private dbProdutosDataSet dbProdutosDataSet;
		private System.Windows.Forms.BindingSource tb_produtoBindingSource;
		private dbProdutosDataSetTableAdapters.tb_produtoTableAdapter tb_produtoTableAdapter;
		private System.Windows.Forms.TextBox cd_produtoTextBox;
		private System.Windows.Forms.TextBox nm_produtoTextBox;
		private System.Windows.Forms.TextBox nm_categoriaTextBox;
		private System.Windows.Forms.TextBox qt_estoqueTextBox;
		private System.Windows.Forms.TextBox vl_custoTextBox;
		private System.Windows.Forms.TextBox vl_vendaTextBox;
		private System.Windows.Forms.Button btnPreviaa;
		private System.Windows.Forms.Button btnProximooo;
		private System.Windows.Forms.Button btnNovooo;
		private System.Windows.Forms.Button btnExcluii;
		private System.Windows.Forms.Button btnAlterarrr;
		private System.Windows.Forms.Button btnCancell;
		private System.Windows.Forms.Button btnPesquisaa;
		private System.Windows.Forms.Button btnSalvarrr;
		private System.Windows.Forms.Button btnImprimirrr;
		private System.Windows.Forms.Button btnExittt;
        private System.Drawing.Printing.PrintDocument pdImpProduto;
        private System.Windows.Forms.PrintPreviewDialog ppdImpProduto;
    }
}