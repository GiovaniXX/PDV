namespace PDV.Emails
{
    partial class FrmEnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnviarEmail));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.grpMensagem = new System.Windows.Forms.GroupBox();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.grbDePara = new System.Windows.Forms.GroupBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtEnviadoPor = new System.Windows.Forms.TextBox();
            this.txtEnviarPara = new System.Windows.Forms.TextBox();
            this.lblSubjectLine = new System.Windows.Forms.Label();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.btnAnexar = new MagicUI.MagicControl.MagicButton();
            this.magicButton1 = new MagicUI.MagicControl.MagicButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grpMensagem.SuspendLayout();
            this.grbDePara.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(258, 417);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 59);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 113;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // grpMensagem
            // 
            this.grpMensagem.Controls.Add(this.btnAnexar);
            this.grpMensagem.Controls.Add(this.txtAnexo);
            this.grpMensagem.Controls.Add(this.txtMensagem);
            this.grpMensagem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpMensagem.Location = new System.Drawing.Point(12, 151);
            this.grpMensagem.Name = "grpMensagem";
            this.grpMensagem.Size = new System.Drawing.Size(485, 260);
            this.grpMensagem.TabIndex = 112;
            this.grpMensagem.TabStop = false;
            this.grpMensagem.Text = "Mensagem";
            // 
            // txtAnexo
            // 
            this.txtAnexo.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnexo.Enabled = false;
            this.txtAnexo.Location = new System.Drawing.Point(149, 221);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(320, 20);
            this.txtAnexo.TabIndex = 7;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensagem.Location = new System.Drawing.Point(14, 20);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(455, 167);
            this.txtMensagem.TabIndex = 0;
            // 
            // grbDePara
            // 
            this.grbDePara.Controls.Add(this.txtAssunto);
            this.grbDePara.Controls.Add(this.txtEnviadoPor);
            this.grbDePara.Controls.Add(this.txtEnviarPara);
            this.grbDePara.Controls.Add(this.lblSubjectLine);
            this.grbDePara.Controls.Add(this.lblRemetente);
            this.grbDePara.Controls.Add(this.lblDestinatario);
            this.grbDePara.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDePara.Location = new System.Drawing.Point(12, 12);
            this.grbDePara.Name = "grbDePara";
            this.grbDePara.Size = new System.Drawing.Size(485, 133);
            this.grbDePara.TabIndex = 111;
            this.grbDePara.TabStop = false;
            this.grbDePara.Text = "Destinatário / Emitente";
            // 
            // txtAssunto
            // 
            this.txtAssunto.BackColor = System.Drawing.SystemColors.Window;
            this.txtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssunto.Location = new System.Drawing.Point(70, 87);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(399, 20);
            this.txtAssunto.TabIndex = 2;
            // 
            // txtEnviadoPor
            // 
            this.txtEnviadoPor.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnviadoPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnviadoPor.Location = new System.Drawing.Point(70, 60);
            this.txtEnviadoPor.Name = "txtEnviadoPor";
            this.txtEnviadoPor.Size = new System.Drawing.Size(399, 20);
            this.txtEnviadoPor.TabIndex = 1;
            // 
            // txtEnviarPara
            // 
            this.txtEnviarPara.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnviarPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnviarPara.Location = new System.Drawing.Point(70, 33);
            this.txtEnviarPara.Name = "txtEnviarPara";
            this.txtEnviarPara.Size = new System.Drawing.Size(399, 20);
            this.txtEnviarPara.TabIndex = 0;
            // 
            // lblSubjectLine
            // 
            this.lblSubjectLine.AutoSize = true;
            this.lblSubjectLine.Location = new System.Drawing.Point(11, 91);
            this.lblSubjectLine.Name = "lblSubjectLine";
            this.lblSubjectLine.Size = new System.Drawing.Size(48, 13);
            this.lblSubjectLine.TabIndex = 2;
            this.lblSubjectLine.Text = "Assunto:";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(35, 64);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(24, 13);
            this.lblRemetente.TabIndex = 1;
            this.lblRemetente.Text = "De:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(28, 37);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(32, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Para:";
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnexar.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnexar.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnAnexar.BorderRadius = 20;
            this.btnAnexar.BorderSize = 0;
            this.btnAnexar.FlatAppearance.BorderSize = 0;
            this.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnexar.Image = global::PDV.Properties.Resources.paper_clip;
            this.btnAnexar.Location = new System.Drawing.Point(14, 209);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(129, 40);
            this.btnAnexar.TabIndex = 114;
            this.btnAnexar.Text = "&Anexar [F9]";
            this.btnAnexar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnexar.TextColor = System.Drawing.SystemColors.ControlText;
            this.btnAnexar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnexar.UseVisualStyleBackColor = false;
            // 
            // magicButton1
            // 
            this.magicButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.magicButton1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.magicButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton1.BorderRadius = 18;
            this.magicButton1.BorderSize = 0;
            this.magicButton1.FlatAppearance.BorderSize = 0;
            this.magicButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.magicButton1.Image = global::PDV.Properties.Resources.email__1_;
            this.magicButton1.Location = new System.Drawing.Point(364, 431);
            this.magicButton1.Name = "magicButton1";
            this.magicButton1.Size = new System.Drawing.Size(133, 35);
            this.magicButton1.TabIndex = 114;
            this.magicButton1.Text = "&Enviar [F5]";
            this.magicButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.magicButton1.TextColor = System.Drawing.SystemColors.ControlText;
            this.magicButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.magicButton1.UseVisualStyleBackColor = false;
            // 
            // FrmEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 488);
            this.Controls.Add(this.magicButton1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.grpMensagem);
            this.Controls.Add(this.grbDePara);
            this.Name = "FrmEnviarEmail";
            this.Text = "Enviar e-mail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grpMensagem.ResumeLayout(false);
            this.grpMensagem.PerformLayout();
            this.grbDePara.ResumeLayout(false);
            this.grbDePara.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox grpMensagem;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.GroupBox grbDePara;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtEnviadoPor;
        private System.Windows.Forms.TextBox txtEnviarPara;
        private System.Windows.Forms.Label lblSubjectLine;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Label lblDestinatario;
        private MagicUI.MagicControl.MagicButton btnAnexar;
        private MagicUI.MagicControl.MagicButton magicButton1;
    }
}