namespace prjBDfelipe
{
	partial class frmFornecedor
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
			System.Windows.Forms.Label cd_fornecedorLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
			System.Windows.Forms.Label nm_fornecedorLabel;
			System.Windows.Forms.Label ds_enderecoLabel;
			System.Windows.Forms.Label nr_enderecoLabel;
			System.Windows.Forms.Label nm_bairroLabel;
			System.Windows.Forms.Label nm_cidadeLabel;
			System.Windows.Forms.Label cd_telefoneLabel;
			System.Windows.Forms.Label nm_contatoLabel;
			System.Windows.Forms.Label ds_emailLabel;
			System.Windows.Forms.Label sg_estadoLabel;
			System.Windows.Forms.Label cd_cepLabel;
			System.Windows.Forms.Label cd_cpfLabel;
			System.Windows.Forms.Label cd_rgLabel;
			System.Windows.Forms.Label cd_cnpjLabel;
			System.Windows.Forms.Label cd_ieLabel;
			System.Windows.Forms.Label lblTipo;
			this.dbProdutosDataSet = new prjBDfelipe.dbProdutosDataSet();
			this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tb_fornecedorTableAdapter = new prjBDfelipe.dbProdutosDataSetTableAdapters.tb_fornecedorTableAdapter();
			this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
			this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
			this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
			this.nr_enderecoTextBox = new System.Windows.Forms.TextBox();
			this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
			this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
			this.cd_telefoneTextBox = new System.Windows.Forms.TextBox();
			this.nm_contatoTextBox = new System.Windows.Forms.TextBox();
			this.ds_emailTextBox = new System.Windows.Forms.TextBox();
			this.btnPrevia = new System.Windows.Forms.Button();
			this.btnProximoo = new System.Windows.Forms.Button();
			this.btnNovoo = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.btnAlterarr = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPesquisa = new System.Windows.Forms.Button();
			this.btnSalvarr = new System.Windows.Forms.Button();
			this.btnImprimirr = new System.Windows.Forms.Button();
			this.btnExitt = new System.Windows.Forms.Button();
			this.tableAdapterManager = new prjBDfelipe.dbProdutosDataSetTableAdapters.TableAdapterManager();
			this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
			this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.cd_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.cd_rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.cd_cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.cd_ieMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.pdImpFornecedor = new System.Drawing.Printing.PrintDocument();
			this.ppdImpFornecedor = new System.Windows.Forms.PrintPreviewDialog();
			this.sg_tipoTextBox = new System.Windows.Forms.TextBox();
			cd_fornecedorLabel = new System.Windows.Forms.Label();
			nm_fornecedorLabel = new System.Windows.Forms.Label();
			ds_enderecoLabel = new System.Windows.Forms.Label();
			nr_enderecoLabel = new System.Windows.Forms.Label();
			nm_bairroLabel = new System.Windows.Forms.Label();
			nm_cidadeLabel = new System.Windows.Forms.Label();
			cd_telefoneLabel = new System.Windows.Forms.Label();
			nm_contatoLabel = new System.Windows.Forms.Label();
			ds_emailLabel = new System.Windows.Forms.Label();
			sg_estadoLabel = new System.Windows.Forms.Label();
			cd_cepLabel = new System.Windows.Forms.Label();
			cd_cpfLabel = new System.Windows.Forms.Label();
			cd_rgLabel = new System.Windows.Forms.Label();
			cd_cnpjLabel = new System.Windows.Forms.Label();
			cd_ieLabel = new System.Windows.Forms.Label();
			lblTipo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cd_fornecedorLabel
			// 
			cd_fornecedorLabel.AutoSize = true;
			cd_fornecedorLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cd_fornecedorLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_fornecedorLabel.Image")));
			cd_fornecedorLabel.Location = new System.Drawing.Point(101, 33);
			cd_fornecedorLabel.Name = "cd_fornecedorLabel";
			cd_fornecedorLabel.Size = new System.Drawing.Size(64, 20);
			cd_fornecedorLabel.TabIndex = 1;
			cd_fornecedorLabel.Text = "CÓDIGO:";
			// 
			// nm_fornecedorLabel
			// 
			nm_fornecedorLabel.AutoSize = true;
			nm_fornecedorLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nm_fornecedorLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_fornecedorLabel.Image")));
			nm_fornecedorLabel.Location = new System.Drawing.Point(101, 83);
			nm_fornecedorLabel.Name = "nm_fornecedorLabel";
			nm_fornecedorLabel.Size = new System.Drawing.Size(52, 20);
			nm_fornecedorLabel.TabIndex = 3;
			nm_fornecedorLabel.Text = "NOME:";
			// 
			// ds_enderecoLabel
			// 
			ds_enderecoLabel.AutoSize = true;
			ds_enderecoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			ds_enderecoLabel.Image = ((System.Drawing.Image)(resources.GetObject("ds_enderecoLabel.Image")));
			ds_enderecoLabel.Location = new System.Drawing.Point(101, 133);
			ds_enderecoLabel.Name = "ds_enderecoLabel";
			ds_enderecoLabel.Size = new System.Drawing.Size(86, 20);
			ds_enderecoLabel.TabIndex = 5;
			ds_enderecoLabel.Text = "ENDEREÇO:";
			// 
			// nr_enderecoLabel
			// 
			nr_enderecoLabel.AutoSize = true;
			nr_enderecoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nr_enderecoLabel.Image = ((System.Drawing.Image)(resources.GetObject("nr_enderecoLabel.Image")));
			nr_enderecoLabel.Location = new System.Drawing.Point(101, 183);
			nr_enderecoLabel.Name = "nr_enderecoLabel";
			nr_enderecoLabel.Size = new System.Drawing.Size(70, 20);
			nr_enderecoLabel.TabIndex = 7;
			nr_enderecoLabel.Text = "NÚMERO:";
			// 
			// nm_bairroLabel
			// 
			nm_bairroLabel.AutoSize = true;
			nm_bairroLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nm_bairroLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_bairroLabel.Image")));
			nm_bairroLabel.Location = new System.Drawing.Point(101, 233);
			nm_bairroLabel.Name = "nm_bairroLabel";
			nm_bairroLabel.Size = new System.Drawing.Size(62, 20);
			nm_bairroLabel.TabIndex = 9;
			nm_bairroLabel.Text = "BAIRRO:";
			// 
			// nm_cidadeLabel
			// 
			nm_cidadeLabel.AutoSize = true;
			nm_cidadeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nm_cidadeLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_cidadeLabel.Image")));
			nm_cidadeLabel.Location = new System.Drawing.Point(101, 283);
			nm_cidadeLabel.Name = "nm_cidadeLabel";
			nm_cidadeLabel.Size = new System.Drawing.Size(61, 20);
			nm_cidadeLabel.TabIndex = 11;
			nm_cidadeLabel.Text = "CIDADE:";
			// 
			// cd_telefoneLabel
			// 
			cd_telefoneLabel.AutoSize = true;
			cd_telefoneLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cd_telefoneLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_telefoneLabel.Image")));
			cd_telefoneLabel.Location = new System.Drawing.Point(500, 82);
			cd_telefoneLabel.Name = "cd_telefoneLabel";
			cd_telefoneLabel.Size = new System.Drawing.Size(81, 20);
			cd_telefoneLabel.TabIndex = 17;
			cd_telefoneLabel.Text = "TELEFONE:";
			// 
			// nm_contatoLabel
			// 
			nm_contatoLabel.AutoSize = true;
			nm_contatoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nm_contatoLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_contatoLabel.Image")));
			nm_contatoLabel.Location = new System.Drawing.Point(492, 133);
			nm_contatoLabel.Name = "nm_contatoLabel";
			nm_contatoLabel.Size = new System.Drawing.Size(74, 20);
			nm_contatoLabel.TabIndex = 19;
			nm_contatoLabel.Text = "CONTATO:";
			// 
			// ds_emailLabel
			// 
			ds_emailLabel.AutoSize = true;
			ds_emailLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			ds_emailLabel.Image = ((System.Drawing.Image)(resources.GetObject("ds_emailLabel.Image")));
			ds_emailLabel.Location = new System.Drawing.Point(101, 323);
			ds_emailLabel.Name = "ds_emailLabel";
			ds_emailLabel.Size = new System.Drawing.Size(52, 20);
			ds_emailLabel.TabIndex = 31;
			ds_emailLabel.Text = "EMAIL:";
			// 
			// sg_estadoLabel
			// 
			sg_estadoLabel.AutoSize = true;
			sg_estadoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			sg_estadoLabel.Image = ((System.Drawing.Image)(resources.GetObject("sg_estadoLabel.Image")));
			sg_estadoLabel.Location = new System.Drawing.Point(518, 40);
			sg_estadoLabel.Name = "sg_estadoLabel";
			sg_estadoLabel.Size = new System.Drawing.Size(30, 20);
			sg_estadoLabel.TabIndex = 42;
			sg_estadoLabel.Text = "UF:";
			// 
			// cd_cepLabel
			// 
			cd_cepLabel.AutoSize = true;
			cd_cepLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cd_cepLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_cepLabel.Image")));
			cd_cepLabel.Location = new System.Drawing.Point(371, 40);
			cd_cepLabel.Name = "cd_cepLabel";
			cd_cepLabel.Size = new System.Drawing.Size(40, 20);
			cd_cepLabel.TabIndex = 43;
			cd_cepLabel.Text = "CEP:";
			// 
			// cd_cpfLabel
			// 
			cd_cpfLabel.AutoSize = true;
			cd_cpfLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cd_cpfLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_cpfLabel.Image")));
			cd_cpfLabel.Location = new System.Drawing.Point(492, 188);
			cd_cpfLabel.Name = "cd_cpfLabel";
			cd_cpfLabel.Size = new System.Drawing.Size(39, 20);
			cd_cpfLabel.TabIndex = 44;
			cd_cpfLabel.Text = "CPF:";
			// 
			// cd_rgLabel
			// 
			cd_rgLabel.AutoSize = true;
			cd_rgLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cd_rgLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_rgLabel.Image")));
			cd_rgLabel.Location = new System.Drawing.Point(449, 236);
			cd_rgLabel.Name = "cd_rgLabel";
			cd_rgLabel.Size = new System.Drawing.Size(32, 20);
			cd_rgLabel.TabIndex = 45;
			cd_rgLabel.Text = "RG:";
			// 
			// cd_cnpjLabel
			// 
			cd_cnpjLabel.AutoSize = true;
			cd_cnpjLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cd_cnpjLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_cnpjLabel.Image")));
			cd_cnpjLabel.Location = new System.Drawing.Point(434, 282);
			cd_cnpjLabel.Name = "cd_cnpjLabel";
			cd_cnpjLabel.Size = new System.Drawing.Size(47, 20);
			cd_cnpjLabel.TabIndex = 46;
			cd_cnpjLabel.Text = "CNPJ:";
			// 
			// cd_ieLabel
			// 
			cd_ieLabel.AutoSize = true;
			cd_ieLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cd_ieLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_ieLabel.Image")));
			cd_ieLabel.Location = new System.Drawing.Point(492, 323);
			cd_ieLabel.Name = "cd_ieLabel";
			cd_ieLabel.Size = new System.Drawing.Size(25, 20);
			cd_ieLabel.TabIndex = 47;
			cd_ieLabel.Text = "IE:";
			// 
			// lblTipo
			// 
			lblTipo.AutoSize = true;
			lblTipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblTipo.Image = global::prjBDfelipe.Properties.Resources.forza_horizon_5_reveals_a_huge_car_list_and_its_not_even_com_eu9g;
			lblTipo.Location = new System.Drawing.Point(294, 183);
			lblTipo.Name = "lblTipo";
			lblTipo.Size = new System.Drawing.Size(42, 20);
			lblTipo.TabIndex = 48;
			lblTipo.Text = "TIPO:";
			// 
			// dbProdutosDataSet
			// 
			this.dbProdutosDataSet.DataSetName = "dbProdutosDataSet";
			this.dbProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tb_fornecedorBindingSource
			// 
			this.tb_fornecedorBindingSource.DataMember = "tb_fornecedor";
			this.tb_fornecedorBindingSource.DataSource = this.dbProdutosDataSet;
			// 
			// tb_fornecedorTableAdapter
			// 
			this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
			// 
			// cd_fornecedorTextBox
			// 
			this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_fornecedor", true));
			this.cd_fornecedorTextBox.Enabled = false;
			this.cd_fornecedorTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cd_fornecedorTextBox.Location = new System.Drawing.Point(171, 30);
			this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
			this.cd_fornecedorTextBox.Size = new System.Drawing.Size(60, 26);
			this.cd_fornecedorTextBox.TabIndex = 2;
			this.cd_fornecedorTextBox.TextChanged += new System.EventHandler(this.cd_fornecedorTextBox_TextChanged);
			// 
			// nm_fornecedorTextBox
			// 
			this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_fornecedor", true));
			this.nm_fornecedorTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nm_fornecedorTextBox.Location = new System.Drawing.Point(159, 79);
			this.nm_fornecedorTextBox.MaxLength = 50;
			this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
			this.nm_fornecedorTextBox.Size = new System.Drawing.Size(322, 26);
			this.nm_fornecedorTextBox.TabIndex = 4;
			// 
			// ds_enderecoTextBox
			// 
			this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_endereco", true));
			this.ds_enderecoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ds_enderecoTextBox.Location = new System.Drawing.Point(193, 128);
			this.ds_enderecoTextBox.MaxLength = 50;
			this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
			this.ds_enderecoTextBox.Size = new System.Drawing.Size(288, 26);
			this.ds_enderecoTextBox.TabIndex = 6;
			// 
			// nr_enderecoTextBox
			// 
			this.nr_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nr_endereco", true));
			this.nr_enderecoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nr_enderecoTextBox.Location = new System.Drawing.Point(171, 180);
			this.nr_enderecoTextBox.MaxLength = 10;
			this.nr_enderecoTextBox.Name = "nr_enderecoTextBox";
			this.nr_enderecoTextBox.Size = new System.Drawing.Size(83, 26);
			this.nr_enderecoTextBox.TabIndex = 8;
			// 
			// nm_bairroTextBox
			// 
			this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_bairro", true));
			this.nm_bairroTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nm_bairroTextBox.Location = new System.Drawing.Point(169, 230);
			this.nm_bairroTextBox.MaxLength = 30;
			this.nm_bairroTextBox.Name = "nm_bairroTextBox";
			this.nm_bairroTextBox.Size = new System.Drawing.Size(245, 26);
			this.nm_bairroTextBox.TabIndex = 10;
			// 
			// nm_cidadeTextBox
			// 
			this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_cidade", true));
			this.nm_cidadeTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nm_cidadeTextBox.Location = new System.Drawing.Point(168, 279);
			this.nm_cidadeTextBox.MaxLength = 30;
			this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
			this.nm_cidadeTextBox.Size = new System.Drawing.Size(204, 26);
			this.nm_cidadeTextBox.TabIndex = 12;
			// 
			// cd_telefoneTextBox
			// 
			this.cd_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_telefone", true));
			this.cd_telefoneTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cd_telefoneTextBox.Location = new System.Drawing.Point(592, 79);
			this.cd_telefoneTextBox.MaxLength = 20;
			this.cd_telefoneTextBox.Name = "cd_telefoneTextBox";
			this.cd_telefoneTextBox.Size = new System.Drawing.Size(116, 26);
			this.cd_telefoneTextBox.TabIndex = 18;
			// 
			// nm_contatoTextBox
			// 
			this.nm_contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_contato", true));
			this.nm_contatoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nm_contatoTextBox.Location = new System.Drawing.Point(572, 128);
			this.nm_contatoTextBox.MaxLength = 20;
			this.nm_contatoTextBox.Name = "nm_contatoTextBox";
			this.nm_contatoTextBox.Size = new System.Drawing.Size(136, 26);
			this.nm_contatoTextBox.TabIndex = 20;
			// 
			// ds_emailTextBox
			// 
			this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_email", true));
			this.ds_emailTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ds_emailTextBox.Location = new System.Drawing.Point(162, 320);
			this.ds_emailTextBox.MaxLength = 100;
			this.ds_emailTextBox.Name = "ds_emailTextBox";
			this.ds_emailTextBox.Size = new System.Drawing.Size(306, 26);
			this.ds_emailTextBox.TabIndex = 32;
			// 
			// btnPrevia
			// 
			this.btnPrevia.AutoSize = true;
			this.btnPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPrevia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevia.Image = global::prjBDfelipe.Properties.Resources.left_arrow;
			this.btnPrevia.Location = new System.Drawing.Point(102, 383);
			this.btnPrevia.Name = "btnPrevia";
			this.btnPrevia.Size = new System.Drawing.Size(100, 30);
			this.btnPrevia.TabIndex = 42;
			this.btnPrevia.Text = "ANTERIOR";
			this.btnPrevia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrevia.UseVisualStyleBackColor = true;
			this.btnPrevia.Click += new System.EventHandler(this.btnPrevia_Click);
			// 
			// btnProximoo
			// 
			this.btnProximoo.AutoSize = true;
			this.btnProximoo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProximoo.Image = global::prjBDfelipe.Properties.Resources.right_arrow;
			this.btnProximoo.Location = new System.Drawing.Point(237, 383);
			this.btnProximoo.Name = "btnProximoo";
			this.btnProximoo.Size = new System.Drawing.Size(95, 30);
			this.btnProximoo.TabIndex = 41;
			this.btnProximoo.Text = "PRÓXIMO";
			this.btnProximoo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnProximoo.UseVisualStyleBackColor = true;
			this.btnProximoo.Click += new System.EventHandler(this.btnProximoo_Click);
			// 
			// btnNovoo
			// 
			this.btnNovoo.AutoSize = true;
			this.btnNovoo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovoo.Image = global::prjBDfelipe.Properties.Resources.add;
			this.btnNovoo.Location = new System.Drawing.Point(379, 383);
			this.btnNovoo.Name = "btnNovoo";
			this.btnNovoo.Size = new System.Drawing.Size(75, 30);
			this.btnNovoo.TabIndex = 40;
			this.btnNovoo.Text = "NOVO";
			this.btnNovoo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovoo.UseVisualStyleBackColor = true;
			this.btnNovoo.Click += new System.EventHandler(this.btnNovoo_Click);
			// 
			// btnExclui
			// 
			this.btnExclui.AutoSize = true;
			this.btnExclui.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExclui.Image = global::prjBDfelipe.Properties.Resources.bin;
			this.btnExclui.Location = new System.Drawing.Point(653, 383);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(89, 30);
			this.btnExclui.TabIndex = 39;
			this.btnExclui.Text = "EXCLUIR";
			this.btnExclui.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
			// 
			// btnAlterarr
			// 
			this.btnAlterarr.AutoSize = true;
			this.btnAlterarr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterarr.Image = global::prjBDfelipe.Properties.Resources.exchange;
			this.btnAlterarr.Location = new System.Drawing.Point(505, 383);
			this.btnAlterarr.Name = "btnAlterarr";
			this.btnAlterarr.Size = new System.Drawing.Size(94, 30);
			this.btnAlterarr.TabIndex = 38;
			this.btnAlterarr.Text = "ALTERAR";
			this.btnAlterarr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnAlterarr.UseVisualStyleBackColor = true;
			this.btnAlterarr.Click += new System.EventHandler(this.btnAlterarr_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Image = global::prjBDfelipe.Properties.Resources.error;
			this.btnCancel.Location = new System.Drawing.Point(220, 439);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(105, 30);
			this.btnCancel.TabIndex = 37;
			this.btnCancel.Text = "CANCELAR";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnPesquisa
			// 
			this.btnPesquisa.AutoSize = true;
			this.btnPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisa.Image = global::prjBDfelipe.Properties.Resources.search;
			this.btnPesquisa.Location = new System.Drawing.Point(359, 439);
			this.btnPesquisa.Name = "btnPesquisa";
			this.btnPesquisa.Size = new System.Drawing.Size(111, 30);
			this.btnPesquisa.TabIndex = 36;
			this.btnPesquisa.Text = "PESQUISAR";
			this.btnPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnPesquisa.UseVisualStyleBackColor = true;
			this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
			// 
			// btnSalvarr
			// 
			this.btnSalvarr.AutoSize = true;
			this.btnSalvarr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvarr.Image = global::prjBDfelipe.Properties.Resources.floppy_disk;
			this.btnSalvarr.Location = new System.Drawing.Point(102, 439);
			this.btnSalvarr.Name = "btnSalvarr";
			this.btnSalvarr.Size = new System.Drawing.Size(87, 30);
			this.btnSalvarr.TabIndex = 35;
			this.btnSalvarr.Text = "SALVAR";
			this.btnSalvarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvarr.UseVisualStyleBackColor = true;
			this.btnSalvarr.Click += new System.EventHandler(this.btnSalvarr_Click);
			// 
			// btnImprimirr
			// 
			this.btnImprimirr.AutoSize = true;
			this.btnImprimirr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimirr.Image = global::prjBDfelipe.Properties.Resources.printer;
			this.btnImprimirr.Location = new System.Drawing.Point(517, 439);
			this.btnImprimirr.Name = "btnImprimirr";
			this.btnImprimirr.Size = new System.Drawing.Size(93, 30);
			this.btnImprimirr.TabIndex = 34;
			this.btnImprimirr.Text = "IMPRIMIR";
			this.btnImprimirr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnImprimirr.UseVisualStyleBackColor = true;
			this.btnImprimirr.Click += new System.EventHandler(this.btnImprimirr_Click);
			// 
			// btnExitt
			// 
			this.btnExitt.AutoSize = true;
			this.btnExitt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitt.Image = global::prjBDfelipe.Properties.Resources.logout;
			this.btnExitt.Location = new System.Drawing.Point(653, 439);
			this.btnExitt.Name = "btnExitt";
			this.btnExitt.Size = new System.Drawing.Size(75, 30);
			this.btnExitt.TabIndex = 33;
			this.btnExitt.Text = "SAIR";
			this.btnExitt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnExitt.UseVisualStyleBackColor = true;
			this.btnExitt.Click += new System.EventHandler(this.btnExitt_Click);
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.tb_clienteTableAdapter = null;
			this.tableAdapterManager.tb_fornecedorTableAdapter = this.tb_fornecedorTableAdapter;
			this.tableAdapterManager.tb_produtoTableAdapter = null;
			this.tableAdapterManager.tb_usuarioTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = prjBDfelipe.dbProdutosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sg_estadoComboBox
			// 
			this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "sg_estado", true));
			this.sg_estadoComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sg_estadoComboBox.FormattingEnabled = true;
			this.sg_estadoComboBox.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
			this.sg_estadoComboBox.Location = new System.Drawing.Point(554, 37);
			this.sg_estadoComboBox.Name = "sg_estadoComboBox";
			this.sg_estadoComboBox.Size = new System.Drawing.Size(54, 28);
			this.sg_estadoComboBox.TabIndex = 43;
			// 
			// cd_cepMaskedTextBox
			// 
			this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cep", true));
			this.cd_cepMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(420, 37);
			this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
			this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(92, 26);
			this.cd_cepMaskedTextBox.TabIndex = 44;
			// 
			// cd_cpfMaskedTextBox
			// 
			this.cd_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cpf", true));
			this.cd_cpfMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cd_cpfMaskedTextBox.Location = new System.Drawing.Point(538, 185);
			this.cd_cpfMaskedTextBox.Mask = "000,000,000-00";
			this.cd_cpfMaskedTextBox.Name = "cd_cpfMaskedTextBox";
			this.cd_cpfMaskedTextBox.Size = new System.Drawing.Size(106, 26);
			this.cd_cpfMaskedTextBox.TabIndex = 45;
			this.cd_cpfMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cd_cpfMaskedTextBox_MaskInputRejected);
			// 
			// cd_rgMaskedTextBox
			// 
			this.cd_rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_rg", true));
			this.cd_rgMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cd_rgMaskedTextBox.Location = new System.Drawing.Point(489, 233);
			this.cd_rgMaskedTextBox.Mask = "00,000,000-0";
			this.cd_rgMaskedTextBox.Name = "cd_rgMaskedTextBox";
			this.cd_rgMaskedTextBox.Size = new System.Drawing.Size(92, 26);
			this.cd_rgMaskedTextBox.TabIndex = 46;
			// 
			// cd_cnpjMaskedTextBox
			// 
			this.cd_cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cnpj", true));
			this.cd_cnpjMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cd_cnpjMaskedTextBox.Location = new System.Drawing.Point(485, 279);
			this.cd_cnpjMaskedTextBox.Name = "cd_cnpjMaskedTextBox";
			this.cd_cnpjMaskedTextBox.Size = new System.Drawing.Size(125, 26);
			this.cd_cnpjMaskedTextBox.TabIndex = 47;
			// 
			// cd_ieMaskedTextBox
			// 
			this.cd_ieMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_ie", true));
			this.cd_ieMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cd_ieMaskedTextBox.Location = new System.Drawing.Point(531, 320);
			this.cd_ieMaskedTextBox.Name = "cd_ieMaskedTextBox";
			this.cd_ieMaskedTextBox.Size = new System.Drawing.Size(100, 26);
			this.cd_ieMaskedTextBox.TabIndex = 48;
			// 
			// pdImpFornecedor
			// 
			this.pdImpFornecedor.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdImpFornecedor_PrintPage);
			// 
			// ppdImpFornecedor
			// 
			this.ppdImpFornecedor.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.ppdImpFornecedor.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.ppdImpFornecedor.ClientSize = new System.Drawing.Size(400, 300);
			this.ppdImpFornecedor.Document = this.pdImpFornecedor;
			this.ppdImpFornecedor.Enabled = true;
			this.ppdImpFornecedor.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdImpFornecedor.Icon")));
			this.ppdImpFornecedor.Name = "ppdImpFornecedor";
			this.ppdImpFornecedor.Visible = false;
			this.ppdImpFornecedor.Load += new System.EventHandler(this.ppdImpFornecedor_Load);
			// 
			// sg_tipoTextBox
			// 
			this.sg_tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "sg_tipo", true));
			this.sg_tipoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sg_tipoTextBox.Location = new System.Drawing.Point(342, 180);
			this.sg_tipoTextBox.MaxLength = 1;
			this.sg_tipoTextBox.Name = "sg_tipoTextBox";
			this.sg_tipoTextBox.Size = new System.Drawing.Size(48, 26);
			this.sg_tipoTextBox.TabIndex = 49;
			// 
			// frmFornecedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::prjBDfelipe.Properties.Resources.forza_horizon_5_reveals_a_huge_car_list_and_its_not_even_com_eu9g;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(862, 492);
			this.ControlBox = false;
			this.Controls.Add(lblTipo);
			this.Controls.Add(this.sg_tipoTextBox);
			this.Controls.Add(cd_ieLabel);
			this.Controls.Add(this.cd_ieMaskedTextBox);
			this.Controls.Add(cd_cnpjLabel);
			this.Controls.Add(this.cd_cnpjMaskedTextBox);
			this.Controls.Add(cd_rgLabel);
			this.Controls.Add(this.cd_rgMaskedTextBox);
			this.Controls.Add(cd_cpfLabel);
			this.Controls.Add(this.cd_cpfMaskedTextBox);
			this.Controls.Add(cd_cepLabel);
			this.Controls.Add(this.cd_cepMaskedTextBox);
			this.Controls.Add(sg_estadoLabel);
			this.Controls.Add(this.sg_estadoComboBox);
			this.Controls.Add(this.btnPrevia);
			this.Controls.Add(this.btnProximoo);
			this.Controls.Add(this.btnNovoo);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.btnAlterarr);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPesquisa);
			this.Controls.Add(this.btnSalvarr);
			this.Controls.Add(this.btnImprimirr);
			this.Controls.Add(this.btnExitt);
			this.Controls.Add(cd_fornecedorLabel);
			this.Controls.Add(this.cd_fornecedorTextBox);
			this.Controls.Add(nm_fornecedorLabel);
			this.Controls.Add(this.nm_fornecedorTextBox);
			this.Controls.Add(ds_enderecoLabel);
			this.Controls.Add(this.ds_enderecoTextBox);
			this.Controls.Add(nr_enderecoLabel);
			this.Controls.Add(this.nr_enderecoTextBox);
			this.Controls.Add(nm_bairroLabel);
			this.Controls.Add(this.nm_bairroTextBox);
			this.Controls.Add(nm_cidadeLabel);
			this.Controls.Add(this.nm_cidadeTextBox);
			this.Controls.Add(cd_telefoneLabel);
			this.Controls.Add(this.cd_telefoneTextBox);
			this.Controls.Add(nm_contatoLabel);
			this.Controls.Add(this.nm_contatoTextBox);
			this.Controls.Add(ds_emailLabel);
			this.Controls.Add(this.ds_emailTextBox);
			this.Name = "frmFornecedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO FORNECEDOR";
			this.Load += new System.EventHandler(this.frmFornecedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private dbProdutosDataSet dbProdutosDataSet;
		private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
		private dbProdutosDataSetTableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
		private System.Windows.Forms.TextBox cd_fornecedorTextBox;
		private System.Windows.Forms.TextBox nm_fornecedorTextBox;
		private System.Windows.Forms.TextBox ds_enderecoTextBox;
		private System.Windows.Forms.TextBox nr_enderecoTextBox;
		private System.Windows.Forms.TextBox nm_bairroTextBox;
		private System.Windows.Forms.TextBox nm_cidadeTextBox;
		private System.Windows.Forms.TextBox cd_telefoneTextBox;
		private System.Windows.Forms.TextBox nm_contatoTextBox;
		private System.Windows.Forms.TextBox ds_emailTextBox;
		private System.Windows.Forms.Button btnPrevia;
		private System.Windows.Forms.Button btnProximoo;
		private System.Windows.Forms.Button btnNovoo;
		private System.Windows.Forms.Button btnExclui;
		private System.Windows.Forms.Button btnAlterarr;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnPesquisa;
		private System.Windows.Forms.Button btnSalvarr;
		private System.Windows.Forms.Button btnImprimirr;
		private System.Windows.Forms.Button btnExitt;
		private dbProdutosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.ComboBox sg_estadoComboBox;
		private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox cd_cpfMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox cd_rgMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox cd_cnpjMaskedTextBox;
		private System.Windows.Forms.MaskedTextBox cd_ieMaskedTextBox;
        private System.Drawing.Printing.PrintDocument pdImpFornecedor;
        private System.Windows.Forms.PrintPreviewDialog ppdImpFornecedor;
        private System.Windows.Forms.TextBox sg_tipoTextBox;
    }
}