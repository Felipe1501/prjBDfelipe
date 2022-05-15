namespace prjBDfelipe
{
	partial class frmCliente
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
            System.Windows.Forms.Label cd_clienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nr_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label cd_telefoneLabel;
            System.Windows.Forms.Label ds_emailLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_rgLabel;
            this.dbProdutosDataSet = new prjBDfelipe.dbProdutosDataSet();
            this.tb_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new prjBDfelipe.dbProdutosDataSetTableAdapters.tb_clienteTableAdapter();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nr_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.cd_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAlte = new System.Windows.Forms.Button();
            this.btnExcl = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.tableAdapterManager = new prjBDfelipe.dbProdutosDataSetTableAdapters.TableAdapterManager();
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cd_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pdImp = new System.Drawing.Printing.PrintDocument();
            this.ppdImp = new System.Windows.Forms.PrintPreviewDialog();
            cd_clienteLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nr_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            cd_telefoneLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_clienteLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_clienteLabel.Image")));
            cd_clienteLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cd_clienteLabel.Location = new System.Drawing.Point(29, 44);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(80, 20);
            cd_clienteLabel.TabIndex = 1;
            cd_clienteLabel.Text = "ㅤCÓDIGO:";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_clienteLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_clienteLabel.Image")));
            nm_clienteLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            nm_clienteLabel.Location = new System.Drawing.Point(29, 81);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(68, 20);
            nm_clienteLabel.TabIndex = 3;
            nm_clienteLabel.Text = "ㅤNOME:";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_enderecoLabel.Image = ((System.Drawing.Image)(resources.GetObject("ds_enderecoLabel.Image")));
            ds_enderecoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ds_enderecoLabel.Location = new System.Drawing.Point(29, 118);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(102, 20);
            ds_enderecoLabel.TabIndex = 5;
            ds_enderecoLabel.Text = "ㅤENDEREÇO:";
            // 
            // nr_enderecoLabel
            // 
            nr_enderecoLabel.AutoSize = true;
            nr_enderecoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_enderecoLabel.Image = ((System.Drawing.Image)(resources.GetObject("nr_enderecoLabel.Image")));
            nr_enderecoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            nr_enderecoLabel.Location = new System.Drawing.Point(29, 155);
            nr_enderecoLabel.Name = "nr_enderecoLabel";
            nr_enderecoLabel.Size = new System.Drawing.Size(86, 20);
            nr_enderecoLabel.TabIndex = 7;
            nr_enderecoLabel.Text = "ㅤNÚMERO:";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_bairroLabel.Image")));
            nm_bairroLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            nm_bairroLabel.Location = new System.Drawing.Point(29, 192);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(78, 20);
            nm_bairroLabel.TabIndex = 9;
            nm_bairroLabel.Text = "ㅤBAIRRO:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Image = ((System.Drawing.Image)(resources.GetObject("nm_cidadeLabel.Image")));
            nm_cidadeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            nm_cidadeLabel.Location = new System.Drawing.Point(29, 229);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(77, 20);
            nm_cidadeLabel.TabIndex = 11;
            nm_cidadeLabel.Text = "ㅤCIDADE:";
            // 
            // cd_telefoneLabel
            // 
            cd_telefoneLabel.AutoSize = true;
            cd_telefoneLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_telefoneLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_telefoneLabel.Image")));
            cd_telefoneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cd_telefoneLabel.Location = new System.Drawing.Point(474, 118);
            cd_telefoneLabel.Name = "cd_telefoneLabel";
            cd_telefoneLabel.Size = new System.Drawing.Size(97, 20);
            cd_telefoneLabel.TabIndex = 17;
            cd_telefoneLabel.Text = "ㅤTELEFONE:";
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_emailLabel.Image = ((System.Drawing.Image)(resources.GetObject("ds_emailLabel.Image")));
            ds_emailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ds_emailLabel.Location = new System.Drawing.Point(364, 229);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(68, 20);
            ds_emailLabel.TabIndex = 23;
            ds_emailLabel.Text = "ㅤEMAIL:";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Image = ((System.Drawing.Image)(resources.GetObject("sg_estadoLabel.Image")));
            sg_estadoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sg_estadoLabel.Location = new System.Drawing.Point(486, 49);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(46, 20);
            sg_estadoLabel.TabIndex = 34;
            sg_estadoLabel.Text = "ㅤUF:";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cpfLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_cpfLabel.Image")));
            cd_cpfLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cd_cpfLabel.Location = new System.Drawing.Point(477, 158);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(55, 20);
            cd_cpfLabel.TabIndex = 35;
            cd_cpfLabel.Text = "ㅤCPF:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_cepLabel.Image")));
            cd_cepLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cd_cepLabel.Location = new System.Drawing.Point(489, 81);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(56, 20);
            cd_cepLabel.TabIndex = 36;
            cd_cepLabel.Text = "ㅤCEP:";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_rgLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_rgLabel.Image")));
            cd_rgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cd_rgLabel.Location = new System.Drawing.Point(475, 197);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(48, 20);
            cd_rgLabel.TabIndex = 37;
            cd_rgLabel.Text = "ㅤRG:";
            // 
            // dbProdutosDataSet
            // 
            this.dbProdutosDataSet.DataSetName = "dbProdutosDataSet";
            this.dbProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteBindingSource
            // 
            this.tb_clienteBindingSource.DataMember = "tb_cliente";
            this.tb_clienteBindingSource.DataSource = this.dbProdutosDataSet;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Enabled = false;
            this.cd_clienteTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_clienteTextBox.Location = new System.Drawing.Point(115, 41);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(58, 26);
            this.cd_clienteTextBox.TabIndex = 2;
            this.cd_clienteTextBox.TextChanged += new System.EventHandler(this.cd_clienteTextBox_TextChanged);
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_cliente", true));
            this.nm_clienteTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_clienteTextBox.Location = new System.Drawing.Point(103, 78);
            this.nm_clienteTextBox.MaxLength = 50;
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(361, 26);
            this.nm_clienteTextBox.TabIndex = 4;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(137, 115);
            this.ds_enderecoTextBox.MaxLength = 50;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(327, 26);
            this.ds_enderecoTextBox.TabIndex = 6;
            // 
            // nr_enderecoTextBox
            // 
            this.nr_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nr_endereco", true));
            this.nr_enderecoTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_enderecoTextBox.Location = new System.Drawing.Point(121, 152);
            this.nr_enderecoTextBox.MaxLength = 10;
            this.nr_enderecoTextBox.Name = "nr_enderecoTextBox";
            this.nr_enderecoTextBox.Size = new System.Drawing.Size(85, 26);
            this.nr_enderecoTextBox.TabIndex = 8;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(113, 189);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(256, 26);
            this.nm_bairroTextBox.TabIndex = 10;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(112, 226);
            this.nm_cidadeTextBox.MaxLength = 30;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(210, 26);
            this.nm_cidadeTextBox.TabIndex = 12;
            // 
            // cd_telefoneTextBox
            // 
            this.cd_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_telefone", true));
            this.cd_telefoneTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_telefoneTextBox.Location = new System.Drawing.Point(580, 115);
            this.cd_telefoneTextBox.MaxLength = 20;
            this.cd_telefoneTextBox.Name = "cd_telefoneTextBox";
            this.cd_telefoneTextBox.Size = new System.Drawing.Size(128, 26);
            this.cd_telefoneTextBox.TabIndex = 18;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "ds_email", true));
            this.ds_emailTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_emailTextBox.Location = new System.Drawing.Point(438, 226);
            this.ds_emailTextBox.MaxLength = 100;
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(350, 26);
            this.ds_emailTextBox.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::prjBDfelipe.Properties.Resources.logout;
            this.btnExit.Location = new System.Drawing.Point(630, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "SAIR";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.AutoSize = true;
            this.btnAnt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnt.Image = global::prjBDfelipe.Properties.Resources.left_arrow;
            this.btnAnt.Location = new System.Drawing.Point(54, 322);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(100, 30);
            this.btnAnt.TabIndex = 26;
            this.btnAnt.Text = "ANTERIOR";
            this.btnAnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnProx
            // 
            this.btnProx.AutoSize = true;
            this.btnProx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProx.Image = global::prjBDfelipe.Properties.Resources.right_arrow;
            this.btnProx.Location = new System.Drawing.Point(200, 322);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(95, 30);
            this.btnProx.TabIndex = 27;
            this.btnProx.Text = "PRÓXIMO";
            this.btnProx.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::prjBDfelipe.Properties.Resources.add;
            this.btnNew.Location = new System.Drawing.Point(341, 322);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "NOVO";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAlte
            // 
            this.btnAlte.AutoSize = true;
            this.btnAlte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlte.Image = global::prjBDfelipe.Properties.Resources.exchange;
            this.btnAlte.Location = new System.Drawing.Point(478, 322);
            this.btnAlte.Name = "btnAlte";
            this.btnAlte.Size = new System.Drawing.Size(94, 30);
            this.btnAlte.TabIndex = 29;
            this.btnAlte.Text = "ALTERAR";
            this.btnAlte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlte.UseVisualStyleBackColor = true;
            this.btnAlte.Click += new System.EventHandler(this.btnAlte_Click);
            // 
            // btnExcl
            // 
            this.btnExcl.AutoSize = true;
            this.btnExcl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcl.Image = global::prjBDfelipe.Properties.Resources.bin;
            this.btnExcl.Location = new System.Drawing.Point(629, 322);
            this.btnExcl.Name = "btnExcl";
            this.btnExcl.Size = new System.Drawing.Size(89, 30);
            this.btnExcl.TabIndex = 30;
            this.btnExcl.Text = "EXCLUIR";
            this.btnExcl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcl.UseVisualStyleBackColor = true;
            this.btnExcl.Click += new System.EventHandler(this.btnExcl_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::prjBDfelipe.Properties.Resources.floppy_disk;
            this.btnSave.Location = new System.Drawing.Point(54, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "SALVAR";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.AutoSize = true;
            this.btnCanc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.Image = global::prjBDfelipe.Properties.Resources.error;
            this.btnCanc.Location = new System.Drawing.Point(189, 379);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(105, 30);
            this.btnCanc.TabIndex = 32;
            this.btnCanc.Text = "CANCELAR";
            this.btnCanc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::prjBDfelipe.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(338, 379);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 30);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "PESQUISAR";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnImp
            // 
            this.btnImp.AutoSize = true;
            this.btnImp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.Image = global::prjBDfelipe.Properties.Resources.printer;
            this.btnImp.Location = new System.Drawing.Point(493, 379);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(93, 30);
            this.btnImp.TabIndex = 34;
            this.btnImp.Text = "IMPRIMIR";
            this.btnImp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = this.tb_clienteTableAdapter;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_produtoTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjBDfelipe.dbProdutosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "sg_estado", true));
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
            this.sg_estadoComboBox.Location = new System.Drawing.Point(538, 51);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(59, 21);
            this.sg_estadoComboBox.TabIndex = 35;
            // 
            // cd_cpfMaskedTextBox
            // 
            this.cd_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cpf", true));
            this.cd_cpfMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cpfMaskedTextBox.Location = new System.Drawing.Point(538, 155);
            this.cd_cpfMaskedTextBox.Mask = "000,000,000-00";
            this.cd_cpfMaskedTextBox.Name = "cd_cpfMaskedTextBox";
            this.cd_cpfMaskedTextBox.Size = new System.Drawing.Size(105, 26);
            this.cd_cpfMaskedTextBox.TabIndex = 36;
            this.cd_cpfMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cd_cpfMaskedTextBox_MaskInputRejected);
            this.cd_cpfMaskedTextBox.Leave += new System.EventHandler(this.cd_cpfMaskedTextBox_Leave);
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(554, 78);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(68, 26);
            this.cd_cepMaskedTextBox.TabIndex = 37;
            // 
            // cd_rgMaskedTextBox
            // 
            this.cd_rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_rg", true));
            this.cd_rgMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_rgMaskedTextBox.Location = new System.Drawing.Point(529, 194);
            this.cd_rgMaskedTextBox.Mask = "00,000,000-0";
            this.cd_rgMaskedTextBox.Name = "cd_rgMaskedTextBox";
            this.cd_rgMaskedTextBox.Size = new System.Drawing.Size(89, 26);
            this.cd_rgMaskedTextBox.TabIndex = 38;
            // 
            // pdImp
            // 
            this.pdImp.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdImp_PrintPage);
            // 
            // ppdImp
            // 
            this.ppdImp.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdImp.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdImp.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdImp.Document = this.pdImp;
            this.ppdImp.Enabled = true;
            this.ppdImp.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdImp.Icon")));
            this.ppdImp.Name = "ppdImp";
            this.ppdImp.Visible = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjBDfelipe.Properties.Resources.monitor1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.ControlBox = false;
            this.Controls.Add(cd_rgLabel);
            this.Controls.Add(this.cd_rgMaskedTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(this.cd_cpfMaskedTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoComboBox);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExcl);
            this.Controls.Add(this.btnAlte);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.nm_clienteTextBox);
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
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(this.ds_emailTextBox);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTROS CLIENTES";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProdutosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private dbProdutosDataSet dbProdutosDataSet;
		private System.Windows.Forms.BindingSource tb_clienteBindingSource;
		private dbProdutosDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
		private System.Windows.Forms.TextBox cd_clienteTextBox;
		private System.Windows.Forms.TextBox nm_clienteTextBox;
		private System.Windows.Forms.TextBox ds_enderecoTextBox;
		private System.Windows.Forms.TextBox nr_enderecoTextBox;
		private System.Windows.Forms.TextBox nm_bairroTextBox;
		private System.Windows.Forms.TextBox nm_cidadeTextBox;
		private System.Windows.Forms.TextBox cd_telefoneTextBox;
		private System.Windows.Forms.TextBox ds_emailTextBox;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAnt;
		private System.Windows.Forms.Button btnProx;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnAlte;
		private System.Windows.Forms.Button btnExcl;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCanc;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnImp;
        private dbProdutosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
        private System.Windows.Forms.MaskedTextBox cd_cpfMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_rgMaskedTextBox;
        private System.Drawing.Printing.PrintDocument pdImp;
        private System.Windows.Forms.PrintPreviewDialog ppdImp;
    }
}