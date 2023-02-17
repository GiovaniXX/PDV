namespace PDV.Cadastros.Clientes
{
    partial class FrmAdicionarSaldoCliente
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.cbbOperacao = new System.Windows.Forms.ComboBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.chkImprimirComprovante = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCliente.Location = new System.Drawing.Point(10, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(429, 20);
            this.txtCliente.TabIndex = 929;
            this.txtCliente.Text = "SELECIONE O CLIENTE";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(328, 183);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(144, 35);
            this.btnConfirmar.TabIndex = 921;
            this.btnConfirmar.TabStop = false;
            this.btnConfirmar.Text = " &Confirmar [ F5 ]";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(10, 132);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(462, 45);
            this.txtObservacao.TabIndex = 920;
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(249, 81);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.PasswordChar = '•';
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(83, 20);
            this.txtSenhaFuncionario.TabIndex = 919;
            this.txtSenhaFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbOperacao
            // 
            this.cbbOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOperacao.FormattingEnabled = true;
            this.cbbOperacao.Items.AddRange(new object[] {
            "Somar",
            "Subtrair"});
            this.cbbOperacao.Location = new System.Drawing.Point(10, 80);
            this.cbbOperacao.Name = "cbbOperacao";
            this.cbbOperacao.Size = new System.Drawing.Size(127, 21);
            this.cbbOperacao.TabIndex = 918;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisaCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaCliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaCliente.Image = global::PDV.Properties.Resources.research;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(441, 22);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(31, 28);
            this.btnPesquisaCliente.TabIndex = 917;
            this.btnPesquisaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisaCliente.UseVisualStyleBackColor = false;
            // 
            // chkImprimirComprovante
            // 
            this.chkImprimirComprovante.AutoSize = true;
            this.chkImprimirComprovante.Checked = true;
            this.chkImprimirComprovante.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImprimirComprovante.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImprimirComprovante.Location = new System.Drawing.Point(168, 198);
            this.chkImprimirComprovante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkImprimirComprovante.Name = "chkImprimirComprovante";
            this.chkImprimirComprovante.Size = new System.Drawing.Size(153, 20);
            this.chkImprimirComprovante.TabIndex = 928;
            this.chkImprimirComprovante.Text = "Imprimir comprovante";
            this.chkImprimirComprovante.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 927;
            this.label3.Text = "Observação";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.Black;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(334, 81);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(138, 24);
            this.lblNomeFuncionario.TabIndex = 926;
            this.lblNomeFuncionario.Text = "nome Funcionário";
            this.lblNomeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomeFuncionario.Visible = false;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.Black;
            this.lblVendedor.Location = new System.Drawing.Point(246, 61);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(73, 16);
            this.lblVendedor.TabIndex = 925;
            this.lblVendedor.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 924;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 923;
            this.label1.Text = "Operação";
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPessoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPessoa.Location = new System.Drawing.Point(7, 8);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(46, 16);
            this.lblTipoPessoa.TabIndex = 922;
            this.lblTipoPessoa.Text = "Cliente";
            // 
            // FrmAdicionarSaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 227);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtSenhaFuncionario);
            this.Controls.Add(this.cbbOperacao);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.chkImprimirComprovante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdicionarSaldoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar saldo para cliente(s)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtSenhaFuncionario;
        private System.Windows.Forms.ComboBox cbbOperacao;
        public System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.CheckBox chkImprimirComprovante;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblVendedor;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTipoPessoa;
    }
}