namespace PDV.Cadastros.Clientes
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNaturalidade = new System.Windows.Forms.TextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExportarImgProduto = new System.Windows.Forms.Button();
            this.btnRemoverImgProduto = new System.Windows.Forms.Button();
            this.btnPesquisarImgProduto = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.cbbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cbbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRgIE = new System.Windows.Forms.TextBox();
            this.lblDescTipoPessoa = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.dtpNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabClientesCadastrados = new System.Windows.Forms.TabPage();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblQuantidadeClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ClientesId_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApelidoFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pcImagemCliente = new System.Windows.Forms.PictureBox();
            this.btnPesquisarCidade = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabClientesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagemCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCadastrar);
            this.tabControl.Controls.Add(this.tabClientesCadastrados);
            this.tabControl.Location = new System.Drawing.Point(0, 53);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(858, 395);
            this.tabControl.TabIndex = 109;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.tabCadastrar.Controls.Add(this.txtNome);
            this.tabCadastrar.Controls.Add(this.label11);
            this.tabCadastrar.Controls.Add(this.txtNaturalidade);
            this.tabCadastrar.Controls.Add(this.txtNacionalidade);
            this.tabCadastrar.Controls.Add(this.label10);
            this.tabCadastrar.Controls.Add(this.btnExportarImgProduto);
            this.tabCadastrar.Controls.Add(this.btnRemoverImgProduto);
            this.tabCadastrar.Controls.Add(this.btnPesquisarImgProduto);
            this.tabCadastrar.Controls.Add(this.pcImagemCliente);
            this.tabCadastrar.Controls.Add(this.txtObservacao);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.cbbSexo);
            this.tabCadastrar.Controls.Add(this.label13);
            this.tabCadastrar.Controls.Add(this.txtTelefone);
            this.tabCadastrar.Controls.Add(this.txtApelido);
            this.tabCadastrar.Controls.Add(this.cbbEstadoCivil);
            this.tabCadastrar.Controls.Add(this.lblEstadoCivil);
            this.tabCadastrar.Controls.Add(this.cbbTipoPessoa);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.label15);
            this.tabCadastrar.Controls.Add(this.txtRgIE);
            this.tabCadastrar.Controls.Add(this.lblDescTipoPessoa);
            this.tabCadastrar.Controls.Add(this.txtCpfCnpj);
            this.tabCadastrar.Controls.Add(this.btnPesquisarCidade);
            this.tabCadastrar.Controls.Add(this.txtCidade);
            this.tabCadastrar.Controls.Add(this.label6);
            this.tabCadastrar.Controls.Add(this.txtCep);
            this.tabCadastrar.Controls.Add(this.label12);
            this.tabCadastrar.Controls.Add(this.label8);
            this.tabCadastrar.Controls.Add(this.txtComplemento);
            this.tabCadastrar.Controls.Add(this.label7);
            this.tabCadastrar.Controls.Add(this.txtNumero);
            this.tabCadastrar.Controls.Add(this.label5);
            this.tabCadastrar.Controls.Add(this.txtBairro);
            this.tabCadastrar.Controls.Add(this.label19);
            this.tabCadastrar.Controls.Add(this.txtEndereco);
            this.tabCadastrar.Controls.Add(this.chkAtivo);
            this.tabCadastrar.Controls.Add(this.label18);
            this.tabCadastrar.Controls.Add(this.dtpDataCadastro);
            this.tabCadastrar.Controls.Add(this.dtpNascimento);
            this.tabCadastrar.Controls.Add(this.label21);
            this.tabCadastrar.Controls.Add(this.txtEmail);
            this.tabCadastrar.Controls.Add(this.label16);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.txtCelular);
            this.tabCadastrar.Controls.Add(this.lblTelefone2);
            this.tabCadastrar.Controls.Add(this.lblTelefone);
            this.tabCadastrar.Controls.Add(this.label20);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(850, 369);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar   ";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(8, 27);
            this.txtNome.MaxLength = 75;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(494, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 872;
            this.label11.Text = "Naturalidade";
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaturalidade.Enabled = false;
            this.txtNaturalidade.Location = new System.Drawing.Point(497, 78);
            this.txtNaturalidade.MaxLength = 40;
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.Size = new System.Drawing.Size(133, 20);
            this.txtNaturalidade.TabIndex = 5;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidade.Enabled = false;
            this.txtNacionalidade.Location = new System.Drawing.Point(347, 78);
            this.txtNacionalidade.MaxLength = 20;
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(144, 20);
            this.txtNacionalidade.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 869;
            this.label10.Text = "Nacionalidade";
            // 
            // btnExportarImgProduto
            // 
            this.btnExportarImgProduto.BackColor = System.Drawing.Color.White;
            this.btnExportarImgProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarImgProduto.Image = global::PDV.Properties.Resources.export;
            this.btnExportarImgProduto.Location = new System.Drawing.Point(636, 267);
            this.btnExportarImgProduto.Name = "btnExportarImgProduto";
            this.btnExportarImgProduto.Size = new System.Drawing.Size(206, 37);
            this.btnExportarImgProduto.TabIndex = 24;
            this.btnExportarImgProduto.TabStop = false;
            this.btnExportarImgProduto.Text = " Exportar";
            this.btnExportarImgProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarImgProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarImgProduto.UseVisualStyleBackColor = false;
            // 
            // btnRemoverImgProduto
            // 
            this.btnRemoverImgProduto.BackColor = System.Drawing.Color.White;
            this.btnRemoverImgProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverImgProduto.Image = global::PDV.Properties.Resources.trash__1_;
            this.btnRemoverImgProduto.Location = new System.Drawing.Point(636, 224);
            this.btnRemoverImgProduto.Name = "btnRemoverImgProduto";
            this.btnRemoverImgProduto.Size = new System.Drawing.Size(206, 37);
            this.btnRemoverImgProduto.TabIndex = 23;
            this.btnRemoverImgProduto.TabStop = false;
            this.btnRemoverImgProduto.Text = " Excluir";
            this.btnRemoverImgProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverImgProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoverImgProduto.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarImgProduto
            // 
            this.btnPesquisarImgProduto.BackColor = System.Drawing.Color.White;
            this.btnPesquisarImgProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarImgProduto.Image = global::PDV.Properties.Resources.research;
            this.btnPesquisarImgProduto.Location = new System.Drawing.Point(636, 181);
            this.btnPesquisarImgProduto.Name = "btnPesquisarImgProduto";
            this.btnPesquisarImgProduto.Size = new System.Drawing.Size(206, 37);
            this.btnPesquisarImgProduto.TabIndex = 22;
            this.btnPesquisarImgProduto.TabStop = false;
            this.btnPesquisarImgProduto.Text = " Procurar";
            this.btnPesquisarImgProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarImgProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarImgProduto.UseVisualStyleBackColor = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(124, 313);
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(610, 42);
            this.txtObservacao.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 861;
            this.label3.Text = "Limite de crédito";
            // 
            // cbbSexo
            // 
            this.cbbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSexo.Enabled = false;
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbbSexo.Location = new System.Drawing.Point(410, 26);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(100, 21);
            this.cbbSexo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 860;
            this.label13.Text = "Sexo";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(8, 281);
            this.txtTelefone.Mask = "99999999999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(110, 20);
            this.txtTelefone.TabIndex = 16;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApelido
            // 
            this.txtApelido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApelido.Enabled = false;
            this.txtApelido.Location = new System.Drawing.Point(8, 78);
            this.txtApelido.MaxLength = 75;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(333, 20);
            this.txtApelido.TabIndex = 3;
            // 
            // cbbEstadoCivil
            // 
            this.cbbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstadoCivil.Enabled = false;
            this.cbbEstadoCivil.FormattingEnabled = true;
            this.cbbEstadoCivil.Location = new System.Drawing.Point(516, 26);
            this.cbbEstadoCivil.Name = "cbbEstadoCivil";
            this.cbbEstadoCivil.Size = new System.Drawing.Size(114, 21);
            this.cbbEstadoCivil.TabIndex = 2;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(513, 8);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil.TabIndex = 826;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // cbbTipoPessoa
            // 
            this.cbbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoPessoa.Enabled = false;
            this.cbbTipoPessoa.FormattingEnabled = true;
            this.cbbTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbbTipoPessoa.Location = new System.Drawing.Point(8, 129);
            this.cbbTipoPessoa.Name = "cbbTipoPessoa";
            this.cbbTipoPessoa.Size = new System.Drawing.Size(91, 21);
            this.cbbTipoPessoa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 823;
            this.label4.Text = "Tipo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 822;
            this.label15.Text = "RG / IE";
            // 
            // txtRgIE
            // 
            this.txtRgIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRgIE.Enabled = false;
            this.txtRgIE.Location = new System.Drawing.Point(248, 130);
            this.txtRgIE.MaxLength = 18;
            this.txtRgIE.Name = "txtRgIE";
            this.txtRgIE.Size = new System.Drawing.Size(120, 20);
            this.txtRgIE.TabIndex = 8;
            // 
            // lblDescTipoPessoa
            // 
            this.lblDescTipoPessoa.AutoSize = true;
            this.lblDescTipoPessoa.Location = new System.Drawing.Point(102, 111);
            this.lblDescTipoPessoa.Name = "lblDescTipoPessoa";
            this.lblDescTipoPessoa.Size = new System.Drawing.Size(27, 13);
            this.lblDescTipoPessoa.TabIndex = 821;
            this.lblDescTipoPessoa.Text = "CPF";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCnpj.Enabled = false;
            this.txtCpfCnpj.Location = new System.Drawing.Point(105, 130);
            this.txtCpfCnpj.MaxLength = 18;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(137, 20);
            this.txtCpfCnpj.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.DimGray;
            this.txtCidade.Location = new System.Drawing.Point(8, 232);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(336, 21);
            this.txtCidade.TabIndex = 816;
            this.txtCidade.Text = "SELECIONE A CIDADE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 817;
            this.label6.Text = "Cidade";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(8, 181);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(77, 20);
            this.txtCep.TabIndex = 10;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 174;
            this.label12.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 173;
            this.label8.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(485, 181);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(145, 20);
            this.txtComplemento.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 172;
            this.label7.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(427, 181);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 171;
            this.label5.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(387, 230);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(243, 20);
            this.txtBairro.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(88, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 170;
            this.label19.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(91, 181);
            this.txtEndereco.MaxLength = 75;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(330, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.Location = new System.Drawing.Point(347, 30);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(59, 17);
            this.chkAtivo.TabIndex = 7;
            this.chkAtivo.Text = "Ativo ?";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(737, 313);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 163;
            this.label18.Text = "Data de Cadastro";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(740, 332);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(102, 20);
            this.dtpDataCadastro.TabIndex = 21;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpNascimento.Enabled = false;
            this.dtpNascimento.Location = new System.Drawing.Point(374, 130);
            this.dtpNascimento.Mask = "00/00/0000";
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(101, 20);
            this.dtpNascimento.TabIndex = 9;
            this.dtpNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(237, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 161;
            this.label21.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(240, 281);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 160;
            this.label16.Text = "Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 157;
            this.label2.Text = "Apelido / Nome Fantasia";
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(124, 281);
            this.txtCelular.Mask = "99999999999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(110, 20);
            this.txtCelular.TabIndex = 17;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Location = new System.Drawing.Point(121, 262);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(39, 13);
            this.lblTelefone2.TabIndex = 155;
            this.lblTelefone2.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(5, 262);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 153;
            this.lblTelefone.Text = "Telefone";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 103;
            this.label20.Text = "Nome Completo";
            // 
            // tabClientesCadastrados
            // 
            this.tabClientesCadastrados.BackColor = System.Drawing.SystemColors.Control;
            this.tabClientesCadastrados.Controls.Add(this.lblQuantidade);
            this.tabClientesCadastrados.Controls.Add(this.lblQuantidadeClientes);
            this.tabClientesCadastrados.Controls.Add(this.label1);
            this.tabClientesCadastrados.Controls.Add(this.txtPesquisar);
            this.tabClientesCadastrados.Controls.Add(this.grid);
            this.tabClientesCadastrados.Location = new System.Drawing.Point(4, 22);
            this.tabClientesCadastrados.Name = "tabClientesCadastrados";
            this.tabClientesCadastrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientesCadastrados.Size = new System.Drawing.Size(850, 369);
            this.tabClientesCadastrados.TabIndex = 1;
            this.tabClientesCadastrados.Text = "Clientes cadastrados   ";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(6, 338);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(838, 21);
            this.lblQuantidade.TabIndex = 177;
            this.lblQuantidade.Text = "Resultados encontrados";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantidadeClientes
            // 
            this.lblQuantidadeClientes.BackColor = System.Drawing.Color.LightBlue;
            this.lblQuantidadeClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantidadeClientes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeClientes.Location = new System.Drawing.Point(6, 462);
            this.lblQuantidadeClientes.Name = "lblQuantidadeClientes";
            this.lblQuantidadeClientes.Size = new System.Drawing.Size(764, 22);
            this.lblQuantidadeClientes.TabIndex = 176;
            this.lblQuantidadeClientes.Text = "RESULTADOS ENCONTRADOS";
            this.lblQuantidadeClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPesquisar.Location = new System.Drawing.Point(78, 10);
            this.txtPesquisar.MaxLength = 75;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(766, 20);
            this.txtPesquisar.TabIndex = 105;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 24;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientesId_,
            this.Nome,
            this.ApelidoFantasia,
            this.CpfCnpj,
            this.Telefone,
            this.Celular,
            this.Cidade});
            this.grid.Location = new System.Drawing.Point(6, 39);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 20;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 18;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(838, 300);
            this.grid.TabIndex = 104;
            // 
            // ClientesId_
            // 
            this.ClientesId_.DataPropertyName = "ClientesId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClientesId_.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClientesId_.HeaderText = "Código";
            this.ClientesId_.Name = "ClientesId_";
            this.ClientesId_.ReadOnly = true;
            this.ClientesId_.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 325;
            // 
            // ApelidoFantasia
            // 
            this.ApelidoFantasia.DataPropertyName = "ApelidoFantasia";
            this.ApelidoFantasia.HeaderText = "Apelido / Fantasia";
            this.ApelidoFantasia.Name = "ApelidoFantasia";
            this.ApelidoFantasia.ReadOnly = true;
            this.ApelidoFantasia.Width = 300;
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.DataPropertyName = "CpfCnpj";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CpfCnpj.DefaultCellStyle = dataGridViewCellStyle3;
            this.CpfCnpj.HeaderText = "CPF / CNPJ";
            this.CpfCnpj.Name = "CpfCnpj";
            this.CpfCnpj.ReadOnly = true;
            this.CpfCnpj.Width = 130;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle4.NullValue = null;
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle4;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Visible = false;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Visible = false;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 250;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.White;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Image = global::PDV.Properties.Resources.email__1_;
            this.btnEmail.Location = new System.Drawing.Point(557, 4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(130, 35);
            this.btnEmail.TabIndex = 111;
            this.btnEmail.Text = " &E-mail [ F12 ]";
            this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmail.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::PDV.Properties.Resources.salvar25;
            this.btnSalvar.Location = new System.Drawing.Point(142, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 35);
            this.btnSalvar.TabIndex = 106;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = " &Salvar [ F5 ]";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::PDV.Properties.Resources.trash__1_;
            this.btnExcluir.Location = new System.Drawing.Point(278, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 35);
            this.btnExcluir.TabIndex = 108;
            this.btnExcluir.Text = " &Excluir [ F8 ]";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::PDV.Properties.Resources.research;
            this.btnPesquisar.Location = new System.Drawing.Point(414, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 35);
            this.btnPesquisar.TabIndex = 107;
            this.btnPesquisar.Text = " &Pesquisar [ F9 ]";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // pcImagemCliente
            // 
            this.pcImagemCliente.BackColor = System.Drawing.Color.White;
            this.pcImagemCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcImagemCliente.Enabled = false;
            this.pcImagemCliente.Location = new System.Drawing.Point(636, 8);
            this.pcImagemCliente.Name = "pcImagemCliente";
            this.pcImagemCliente.Size = new System.Drawing.Size(206, 169);
            this.pcImagemCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImagemCliente.TabIndex = 865;
            this.pcImagemCliente.TabStop = false;
            // 
            // btnPesquisarCidade
            // 
            this.btnPesquisarCidade.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisarCidade.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarCidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarCidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarCidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCidade.Image = global::PDV.Properties.Resources.research;
            this.btnPesquisarCidade.Location = new System.Drawing.Point(347, 223);
            this.btnPesquisarCidade.Name = "btnPesquisarCidade";
            this.btnPesquisarCidade.Size = new System.Drawing.Size(31, 30);
            this.btnPesquisarCidade.TabIndex = 14;
            this.btnPesquisarCidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisarCidade.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::PDV.Properties.Resources.novo25;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(6, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 35);
            this.btnNovo.TabIndex = 110;
            this.btnNovo.Text = " &Novo [ F2 ]";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 452);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            this.tabControl.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabClientesCadastrados.ResumeLayout(false);
            this.tabClientesCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagemCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNaturalidade;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExportarImgProduto;
        private System.Windows.Forms.Button btnRemoverImgProduto;
        private System.Windows.Forms.Button btnPesquisarImgProduto;
        private System.Windows.Forms.PictureBox pcImagemCliente;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.ComboBox cbbEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cbbTipoPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRgIE;
        private System.Windows.Forms.Label lblDescTipoPessoa;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        public System.Windows.Forms.Button btnPesquisarCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.MaskedTextBox dtpNascimento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabClientesCadastrados;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblQuantidadeClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientesId_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApelidoFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
    }
}