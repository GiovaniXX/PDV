namespace PDV
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblEsqueciMinhaSenha = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAcessar = new MagicUI.MagicControl.MagicButton();
            this.chkLembreme = new MagicUI.MagicControl.MagicRadioButton();
            this.magicButton1 = new MagicUI.MagicControl.MagicButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEsqueciMinhaSenha
            // 
            this.lblEsqueciMinhaSenha.AutoSize = true;
            this.lblEsqueciMinhaSenha.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.lblEsqueciMinhaSenha.LinkColor = System.Drawing.Color.Crimson;
            this.lblEsqueciMinhaSenha.Location = new System.Drawing.Point(458, 228);
            this.lblEsqueciMinhaSenha.Name = "lblEsqueciMinhaSenha";
            this.lblEsqueciMinhaSenha.Size = new System.Drawing.Size(111, 13);
            this.lblEsqueciMinhaSenha.TabIndex = 145;
            this.lblEsqueciMinhaSenha.TabStop = true;
            this.lblEsqueciMinhaSenha.Text = "Esqueci minha senha!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 142;
            this.label3.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Location = new System.Drawing.Point(252, 185);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(317, 33);
            this.txtSenha.TabIndex = 138;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Location = new System.Drawing.Point(252, 122);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(317, 33);
            this.txtUsuario.TabIndex = 137;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 73);
            this.panel1.TabIndex = 144;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 33);
            this.label4.TabIndex = 129;
            this.label4.Text = "Login: NN-PDV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 19);
            this.label2.TabIndex = 128;
            this.label2.Text = "Acesse com suas credenciais para acessar o sistema!";
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.btnAcessar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.btnAcessar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAcessar.BorderRadius = 20;
            this.btnAcessar.BorderSize = 0;
            this.btnAcessar.FlatAppearance.BorderSize = 0;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.Color.White;
            this.btnAcessar.Location = new System.Drawing.Point(259, 265);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(305, 40);
            this.btnAcessar.TabIndex = 146;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.TextColor = System.Drawing.Color.White;
            this.btnAcessar.UseVisualStyleBackColor = false;
            // 
            // chkLembreme
            // 
            this.chkLembreme.AutoSize = true;
            this.chkLembreme.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.chkLembreme.Location = new System.Drawing.Point(252, 224);
            this.chkLembreme.MinimumSize = new System.Drawing.Size(0, 21);
            this.chkLembreme.Name = "chkLembreme";
            this.chkLembreme.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chkLembreme.Size = new System.Drawing.Size(157, 21);
            this.chkLembreme.TabIndex = 147;
            this.chkLembreme.TabStop = true;
            this.chkLembreme.Text = "Lembrar usuário e senha?";
            this.chkLembreme.UnCheckedColor = System.Drawing.Color.Gray;
            this.chkLembreme.UseVisualStyleBackColor = true;
            // 
            // magicButton1
            // 
            this.magicButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.magicButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.magicButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton1.BorderRadius = 20;
            this.magicButton1.BorderSize = 0;
            this.magicButton1.FlatAppearance.BorderSize = 0;
            this.magicButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicButton1.ForeColor = System.Drawing.Color.White;
            this.magicButton1.Location = new System.Drawing.Point(259, 311);
            this.magicButton1.Name = "magicButton1";
            this.magicButton1.Size = new System.Drawing.Size(305, 40);
            this.magicButton1.TabIndex = 148;
            this.magicButton1.Text = "Limpar";
            this.magicButton1.TextColor = System.Drawing.Color.White;
            this.magicButton1.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 354);
            this.Controls.Add(this.magicButton1);
            this.Controls.Add(this.chkLembreme);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.lblEsqueciMinhaSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblEsqueciMinhaSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MagicUI.MagicControl.MagicButton btnAcessar;
        private MagicUI.MagicControl.MagicRadioButton chkLembreme;
        private MagicUI.MagicControl.MagicButton magicButton1;
    }
}

