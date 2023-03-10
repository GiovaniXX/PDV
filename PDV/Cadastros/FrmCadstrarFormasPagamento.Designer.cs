namespace PDV.Cadastros
{
    partial class FrmCadstrarFormasPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridFormasPagamento = new System.Windows.Forms.DataGridView();
            this.FormaPagamentoId_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPercentualTaxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaIntervaloEmDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPrimeiroVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FluxoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numPrimeiroVencimento = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gridParcelas = new System.Windows.Forms.DataGridView();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCoeficiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numIntervaloEmDias = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numQuantidadeParcelas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormasPagamento)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrimeiroVencimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervaloEmDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeParcelas)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridFormasPagamento
            // 
            this.gridFormasPagamento.AllowUserToAddRows = false;
            this.gridFormasPagamento.AllowUserToDeleteRows = false;
            this.gridFormasPagamento.AllowUserToOrderColumns = true;
            this.gridFormasPagamento.AllowUserToResizeColumns = false;
            this.gridFormasPagamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            this.gridFormasPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridFormasPagamento.ColumnHeadersHeight = 24;
            this.gridFormasPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridFormasPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormaPagamentoId_,
            this.StatusId,
            this.Ativo,
            this.DescricaoStatus,
            this.Tipo,
            this.Descricao,
            this.Forma1,
            this.Forma2,
            this.Forma3,
            this.Forma4,
            this.Forma5,
            this.Forma6,
            this.FormaCartao,
            this.FormaPercentualTaxa,
            this.FormaIntervaloEmDias,
            this.FormaParcelas,
            this.FormaPrimeiroVencimento,
            this.FluxoCaixa});
            this.gridFormasPagamento.Location = new System.Drawing.Point(6, 258);
            this.gridFormasPagamento.Name = "gridFormasPagamento";
            this.gridFormasPagamento.ReadOnly = true;
            this.gridFormasPagamento.RowHeadersWidth = 20;
            this.gridFormasPagamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFormasPagamento.RowTemplate.Height = 18;
            this.gridFormasPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFormasPagamento.Size = new System.Drawing.Size(545, 144);
            this.gridFormasPagamento.TabIndex = 201;
            // 
            // FormaPagamentoId_
            // 
            this.FormaPagamentoId_.DataPropertyName = "FormaPagamentoId";
            this.FormaPagamentoId_.HeaderText = "FormaPagamentoId";
            this.FormaPagamentoId_.Name = "FormaPagamentoId_";
            this.FormaPagamentoId_.ReadOnly = true;
            this.FormaPagamentoId_.Visible = false;
            // 
            // StatusId
            // 
            this.StatusId.DataPropertyName = "StatusId";
            this.StatusId.HeaderText = "StatusId";
            this.StatusId.Name = "StatusId";
            this.StatusId.ReadOnly = true;
            this.StatusId.Visible = false;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Visible = false;
            // 
            // DescricaoStatus
            // 
            this.DescricaoStatus.DataPropertyName = "DescricaoStatus";
            this.DescricaoStatus.HeaderText = "DescricaoStatus";
            this.DescricaoStatus.Name = "DescricaoStatus";
            this.DescricaoStatus.ReadOnly = true;
            this.DescricaoStatus.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Forma1
            // 
            this.Forma1.DataPropertyName = "Forma1";
            this.Forma1.HeaderText = "Forma1";
            this.Forma1.Name = "Forma1";
            this.Forma1.ReadOnly = true;
            this.Forma1.Visible = false;
            // 
            // Forma2
            // 
            this.Forma2.DataPropertyName = "Forma2";
            this.Forma2.HeaderText = "Forma2";
            this.Forma2.Name = "Forma2";
            this.Forma2.ReadOnly = true;
            this.Forma2.Visible = false;
            // 
            // Forma3
            // 
            this.Forma3.DataPropertyName = "Forma3";
            this.Forma3.HeaderText = "Forma3";
            this.Forma3.Name = "Forma3";
            this.Forma3.ReadOnly = true;
            this.Forma3.Visible = false;
            // 
            // Forma4
            // 
            this.Forma4.DataPropertyName = "Forma4";
            this.Forma4.HeaderText = "Forma4";
            this.Forma4.Name = "Forma4";
            this.Forma4.ReadOnly = true;
            this.Forma4.Visible = false;
            // 
            // Forma5
            // 
            this.Forma5.DataPropertyName = "Forma5";
            this.Forma5.HeaderText = "Forma5";
            this.Forma5.Name = "Forma5";
            this.Forma5.ReadOnly = true;
            this.Forma5.Visible = false;
            // 
            // Forma6
            // 
            this.Forma6.DataPropertyName = "Forma6";
            this.Forma6.HeaderText = "Forma6";
            this.Forma6.Name = "Forma6";
            this.Forma6.ReadOnly = true;
            this.Forma6.Visible = false;
            // 
            // FormaCartao
            // 
            this.FormaCartao.DataPropertyName = "FormaCartao";
            this.FormaCartao.HeaderText = "FormaCartao";
            this.FormaCartao.Name = "FormaCartao";
            this.FormaCartao.ReadOnly = true;
            this.FormaCartao.Visible = false;
            // 
            // FormaPercentualTaxa
            // 
            this.FormaPercentualTaxa.DataPropertyName = "FormaPercentualTaxa";
            this.FormaPercentualTaxa.HeaderText = "FormaPercentualTaxa";
            this.FormaPercentualTaxa.Name = "FormaPercentualTaxa";
            this.FormaPercentualTaxa.ReadOnly = true;
            this.FormaPercentualTaxa.Visible = false;
            // 
            // FormaIntervaloEmDias
            // 
            this.FormaIntervaloEmDias.DataPropertyName = "FormaIntervaloEmDias";
            this.FormaIntervaloEmDias.HeaderText = "FormaIntervaloEmDias";
            this.FormaIntervaloEmDias.Name = "FormaIntervaloEmDias";
            this.FormaIntervaloEmDias.ReadOnly = true;
            this.FormaIntervaloEmDias.Visible = false;
            // 
            // FormaParcelas
            // 
            this.FormaParcelas.DataPropertyName = "FormaParcelas";
            this.FormaParcelas.HeaderText = "FormaParcelas";
            this.FormaParcelas.Name = "FormaParcelas";
            this.FormaParcelas.ReadOnly = true;
            this.FormaParcelas.Visible = false;
            // 
            // FormaPrimeiroVencimento
            // 
            this.FormaPrimeiroVencimento.DataPropertyName = "FormaPrimeiroVencimento";
            this.FormaPrimeiroVencimento.HeaderText = "FormaPrimeiroVencimento";
            this.FormaPrimeiroVencimento.Name = "FormaPrimeiroVencimento";
            this.FormaPrimeiroVencimento.ReadOnly = true;
            this.FormaPrimeiroVencimento.Visible = false;
            // 
            // FluxoCaixa
            // 
            this.FluxoCaixa.DataPropertyName = "FluxoCaixa";
            this.FluxoCaixa.HeaderText = "FluxoCaixa";
            this.FluxoCaixa.Name = "FluxoCaixa";
            this.FluxoCaixa.ReadOnly = true;
            this.FluxoCaixa.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.chkDebito);
            this.groupBox.Controls.Add(this.label19);
            this.groupBox.Controls.Add(this.chkCredito);
            this.groupBox.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox.Location = new System.Drawing.Point(6, 188);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(373, 64);
            this.groupBox.TabIndex = 200;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Operadoras de cartões";
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Enabled = false;
            this.chkDebito.ForeColor = System.Drawing.Color.Black;
            this.chkDebito.Location = new System.Drawing.Point(6, 28);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(57, 17);
            this.chkDebito.TabIndex = 182;
            this.chkDebito.Text = "Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(149, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 181;
            this.label19.Text = "Percentual (%)";
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Enabled = false;
            this.chkCredito.ForeColor = System.Drawing.Color.Black;
            this.chkCredito.Location = new System.Drawing.Point(75, 28);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(59, 17);
            this.chkCredito.TabIndex = 183;
            this.chkCredito.Text = "Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(6, 85);
            this.txtDescricao.MaxLength = 40;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(306, 23);
            this.txtDescricao.TabIndex = 189;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(318, 88);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(56, 17);
            this.chkAtivo.TabIndex = 199;
            this.chkAtivo.Text = "Ativo?";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Firebrick;
            this.label16.Location = new System.Drawing.Point(3, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(263, 16);
            this.label16.TabIndex = 198;
            this.label16.Text = "Obs.: A vista informe zero no 1° Vencimento";
            // 
            // numPrimeiroVencimento
            // 
            this.numPrimeiroVencimento.Enabled = false;
            this.numPrimeiroVencimento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrimeiroVencimento.Location = new System.Drawing.Point(6, 154);
            this.numPrimeiroVencimento.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numPrimeiroVencimento.Name = "numPrimeiroVencimento";
            this.numPrimeiroVencimento.Size = new System.Drawing.Size(98, 23);
            this.numPrimeiroVencimento.TabIndex = 190;
            this.numPrimeiroVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 197;
            this.label2.Text = "1° Vencimento";
            // 
            // gridParcelas
            // 
            this.gridParcelas.AllowUserToAddRows = false;
            this.gridParcelas.AllowUserToDeleteRows = false;
            this.gridParcelas.AllowUserToResizeColumns = false;
            this.gridParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue;
            this.gridParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridParcelas.ColumnHeadersHeight = 24;
            this.gridParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.Valor,
            this.ValorCoeficiente});
            this.gridParcelas.Location = new System.Drawing.Point(385, 85);
            this.gridParcelas.Name = "gridParcelas";
            this.gridParcelas.RowHeadersVisible = false;
            this.gridParcelas.RowHeadersWidth = 50;
            this.gridParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridParcelas.RowTemplate.Height = 20;
            this.gridParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParcelas.Size = new System.Drawing.Size(166, 167);
            this.gridParcelas.TabIndex = 193;
            // 
            // Parcela
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Parcela.DefaultCellStyle = dataGridViewCellStyle8;
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.ReadOnly = true;
            this.Parcela.Width = 80;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle9;
            this.Valor.HeaderText = "Prazo";
            this.Valor.Name = "Valor";
            // 
            // ValorCoeficiente
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ValorCoeficiente.DefaultCellStyle = dataGridViewCellStyle10;
            this.ValorCoeficiente.HeaderText = "Coeficiente (%)";
            this.ValorCoeficiente.Name = "ValorCoeficiente";
            this.ValorCoeficiente.ReadOnly = true;
            this.ValorCoeficiente.Visible = false;
            this.ValorCoeficiente.Width = 130;
            // 
            // numIntervaloEmDias
            // 
            this.numIntervaloEmDias.Enabled = false;
            this.numIntervaloEmDias.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIntervaloEmDias.Location = new System.Drawing.Point(110, 154);
            this.numIntervaloEmDias.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numIntervaloEmDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIntervaloEmDias.Name = "numIntervaloEmDias";
            this.numIntervaloEmDias.Size = new System.Drawing.Size(98, 23);
            this.numIntervaloEmDias.TabIndex = 191;
            this.numIntervaloEmDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIntervaloEmDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(107, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 196;
            this.label22.Text = "Intervalor em dias";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(211, 138);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 195;
            this.label21.Text = "Qtde parcelas";
            // 
            // numQuantidadeParcelas
            // 
            this.numQuantidadeParcelas.Enabled = false;
            this.numQuantidadeParcelas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeParcelas.Location = new System.Drawing.Point(214, 154);
            this.numQuantidadeParcelas.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numQuantidadeParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidadeParcelas.Name = "numQuantidadeParcelas";
            this.numQuantidadeParcelas.Size = new System.Drawing.Size(98, 23);
            this.numQuantidadeParcelas.TabIndex = 192;
            this.numQuantidadeParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidadeParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 194;
            this.label1.Text = "Descrição";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnPesquisar);
            this.menuPanel.Controls.Add(this.btnNovo);
            this.menuPanel.Controls.Add(this.btnExcluir);
            this.menuPanel.Controls.Add(this.btnSalvar);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(557, 50);
            this.menuPanel.TabIndex = 188;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::PDV.Properties.Resources.research;
            this.btnPesquisar.Location = new System.Drawing.Point(414, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 35);
            this.btnPesquisar.TabIndex = 108;
            this.btnPesquisar.Text = " &Pesquisar [ F9 ]";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::PDV.Properties.Resources.novo25;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(6, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 35);
            this.btnNovo.TabIndex = 107;
            this.btnNovo.Text = " &Novo [ F2 ]";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::PDV.Properties.Resources.trash__1_;
            this.btnExcluir.Location = new System.Drawing.Point(278, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 35);
            this.btnExcluir.TabIndex = 106;
            this.btnExcluir.Text = " &Excluir [ F8 ]";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::PDV.Properties.Resources.salvar25;
            this.btnSalvar.Location = new System.Drawing.Point(142, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 35);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = " &Salvar [ F5 ]";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FrmCadstrarFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 405);
            this.Controls.Add(this.gridFormasPagamento);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numPrimeiroVencimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridParcelas);
            this.Controls.Add(this.numIntervaloEmDias);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.numQuantidadeParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadstrarFormasPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Formas Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.gridFormasPagamento)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrimeiroVencimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervaloEmDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeParcelas)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFormasPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamentoId_;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaCartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPercentualTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaIntervaloEmDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPrimeiroVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FluxoCaixa;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numPrimeiroVencimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCoeficiente;
        private System.Windows.Forms.NumericUpDown numIntervaloEmDias;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numQuantidadeParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}