using Krypton.Toolkit;

namespace ProjetoPI.Views
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.painelFundo = new Krypton.Toolkit.KryptonPanel();
            this.painel1 = new System.Windows.Forms.Panel();
            this.painelDivisor = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.painelEsquerdo = new Krypton.Toolkit.KryptonPanel();
            this.btnVoltarLogin = new Krypton.Toolkit.KryptonButton();
            this.txtSenhaConf = new Krypton.Toolkit.KryptonTextBox();
            this.txtSenhaCad = new Krypton.Toolkit.KryptonTextBox();
            this.txtUsuarioCad = new Krypton.Toolkit.KryptonTextBox();
            this.txtNome = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPictureBox5 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox3 = new Krypton.Toolkit.KryptonPictureBox();
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.painelDireito = new Krypton.Toolkit.KryptonPanel();
            this.btnCadastro = new Krypton.Toolkit.KryptonButton();
            this.txtSenha = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.btnEntrar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).BeginInit();
            this.painelFundo.SuspendLayout();
            this.painelDivisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.painelEsquerdo)).BeginInit();
            this.painelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelDireito)).BeginInit();
            this.painelDireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // painelFundo
            // 
            this.painelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelFundo.Controls.Add(this.painel1);
            this.painelFundo.Controls.Add(this.painelDivisor);
            this.painelFundo.Location = new System.Drawing.Point(0, 0);
            this.painelFundo.Name = "painelFundo";
            this.painelFundo.Size = new System.Drawing.Size(1370, 749);
            this.painelFundo.StateCommon.Color1 = System.Drawing.Color.White;
            this.painelFundo.TabIndex = 4;
            // 
            // painel1
            // 
            this.painel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painel1.BackgroundImage")));
            this.painel1.Location = new System.Drawing.Point(688, 13);
            this.painel1.Name = "painel1";
            this.painel1.Size = new System.Drawing.Size(667, 719);
            this.painel1.TabIndex = 5;
            // 
            // painelDivisor
            // 
            this.painelDivisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelDivisor.ColumnCount = 2;
            this.painelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.painelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.painelDivisor.Controls.Add(this.painelEsquerdo, 0, 0);
            this.painelDivisor.Controls.Add(this.painelDireito, 1, 0);
            this.painelDivisor.Location = new System.Drawing.Point(12, 12);
            this.painelDivisor.Name = "painelDivisor";
            this.painelDivisor.RowCount = 1;
            this.painelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.painelDivisor.Size = new System.Drawing.Size(1346, 725);
            this.painelDivisor.StateCommon.Color1 = System.Drawing.Color.White;
            this.painelDivisor.TabIndex = 0;
            // 
            // painelEsquerdo
            // 
            this.painelEsquerdo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelEsquerdo.Controls.Add(this.btnVoltarLogin);
            this.painelEsquerdo.Controls.Add(this.txtSenhaConf);
            this.painelEsquerdo.Controls.Add(this.txtSenhaCad);
            this.painelEsquerdo.Controls.Add(this.txtUsuarioCad);
            this.painelEsquerdo.Controls.Add(this.txtNome);
            this.painelEsquerdo.Controls.Add(this.kryptonPictureBox5);
            this.painelEsquerdo.Controls.Add(this.kryptonPictureBox3);
            this.painelEsquerdo.Controls.Add(this.btnSalvar);
            this.painelEsquerdo.Location = new System.Drawing.Point(3, 3);
            this.painelEsquerdo.Name = "painelEsquerdo";
            this.painelEsquerdo.Size = new System.Drawing.Size(667, 719);
            this.painelEsquerdo.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(226)))), ((int)(((byte)(193)))));
            this.painelEsquerdo.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.painelEsquerdo.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.painelEsquerdo.TabIndex = 0;
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltarLogin.Location = new System.Drawing.Point(351, 62);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(135, 43);
            this.btnVoltarLogin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnVoltarLogin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnVoltarLogin.StateCommon.Border.Rounding = 40F;
            this.btnVoltarLogin.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnVoltarLogin.TabIndex = 14;
            this.btnVoltarLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVoltarLogin.Values.Text = "Login";
            this.btnVoltarLogin.Click += new System.EventHandler(this.btnVoltarLogin_Click);
            // 
            // txtSenhaConf
            // 
            this.txtSenhaConf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaConf.CueHint.CueHintText = "Confirme sua senha";
            this.txtSenhaConf.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenhaConf.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenhaConf.Location = new System.Drawing.Point(239, 376);
            this.txtSenhaConf.Name = "txtSenhaConf";
            this.txtSenhaConf.PasswordChar = '*';
            this.txtSenhaConf.Size = new System.Drawing.Size(250, 42);
            this.txtSenhaConf.StateActive.Border.Rounding = 40F;
            this.txtSenhaConf.StateCommon.Border.Rounding = 20F;
            this.txtSenhaConf.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtSenhaConf.TabIndex = 13;
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCad.CueHint.CueHintText = "Criei uma senha";
            this.txtSenhaCad.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenhaCad.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenhaCad.Location = new System.Drawing.Point(236, 303);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.PasswordChar = '*';
            this.txtSenhaCad.Size = new System.Drawing.Size(250, 42);
            this.txtSenhaCad.StateActive.Border.Rounding = 40F;
            this.txtSenhaCad.StateCommon.Border.Rounding = 20F;
            this.txtSenhaCad.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtSenhaCad.TabIndex = 12;
            // 
            // txtUsuarioCad
            // 
            this.txtUsuarioCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuarioCad.CueHint.CueHintText = "Crie um usuário";
            this.txtUsuarioCad.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtUsuarioCad.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtUsuarioCad.Location = new System.Drawing.Point(239, 228);
            this.txtUsuarioCad.Name = "txtUsuarioCad";
            this.txtUsuarioCad.Size = new System.Drawing.Size(250, 42);
            this.txtUsuarioCad.StateActive.Border.Rounding = 40F;
            this.txtUsuarioCad.StateCommon.Border.Rounding = 20F;
            this.txtUsuarioCad.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtUsuarioCad.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.CueHint.CueHintText = "Digite seu nome";
            this.txtNome.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtNome.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtNome.Location = new System.Drawing.Point(236, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 42);
            this.txtNome.StateActive.Border.Rounding = 40F;
            this.txtNome.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtNome.StateCommon.Border.Rounding = 20F;
            this.txtNome.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtNome.TabIndex = 10;
            // 
            // kryptonPictureBox5
            // 
            this.kryptonPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox5.Image")));
            this.kryptonPictureBox5.Location = new System.Drawing.Point(193, 303);
            this.kryptonPictureBox5.Name = "kryptonPictureBox5";
            this.kryptonPictureBox5.Size = new System.Drawing.Size(37, 35);
            this.kryptonPictureBox5.TabIndex = 8;
            this.kryptonPictureBox5.TabStop = false;
            // 
            // kryptonPictureBox3
            // 
            this.kryptonPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox3.Image")));
            this.kryptonPictureBox3.Location = new System.Drawing.Point(193, 161);
            this.kryptonPictureBox3.Name = "kryptonPictureBox3";
            this.kryptonPictureBox3.Size = new System.Drawing.Size(25, 29);
            this.kryptonPictureBox3.TabIndex = 5;
            this.kryptonPictureBox3.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Location = new System.Drawing.Point(351, 442);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(135, 44);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Rounding = 20F;
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // painelDireito
            // 
            this.painelDireito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelDireito.Controls.Add(this.btnCadastro);
            this.painelDireito.Controls.Add(this.txtSenha);
            this.painelDireito.Controls.Add(this.kryptonPictureBox2);
            this.painelDireito.Controls.Add(this.kryptonPictureBox1);
            this.painelDireito.Controls.Add(this.txtUsuario);
            this.painelDireito.Controls.Add(this.btnEntrar);
            this.painelDireito.Location = new System.Drawing.Point(676, 3);
            this.painelDireito.Name = "painelDireito";
            this.painelDireito.Size = new System.Drawing.Size(667, 719);
            this.painelDireito.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(226)))), ((int)(((byte)(193)))));
            this.painelDireito.TabIndex = 1;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastro.Location = new System.Drawing.Point(363, 62);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(133, 43);
            this.btnCadastro.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCadastro.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCadastro.StateCommon.Border.Rounding = 40F;
            this.btnCadastro.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCadastro.Values.Text = "Cadastre-se";
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.CueHint.CueHintText = "Insira seu usuário";
            this.txtSenha.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenha.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenha.Location = new System.Drawing.Point(246, 303);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(250, 42);
            this.txtSenha.StateActive.Border.Rounding = 40F;
            this.txtSenha.StateCommon.Border.Rounding = 20F;
            this.txtSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtSenha.TabIndex = 9;
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox2.Image")));
            this.kryptonPictureBox2.Location = new System.Drawing.Point(209, 303);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(31, 35);
            this.kryptonPictureBox2.TabIndex = 6;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(215, 228);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(25, 29);
            this.kryptonPictureBox1.TabIndex = 4;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.CueHint.CueHintText = "Insira seu usuário";
            this.txtUsuario.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtUsuario.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtUsuario.Location = new System.Drawing.Point(246, 228);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 42);
            this.txtUsuario.StateActive.Border.Rounding = 40F;
            this.txtUsuario.StateCommon.Border.Rounding = 20F;
            this.txtUsuario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.Location = new System.Drawing.Point(363, 376);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(133, 43);
            this.btnEntrar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnEntrar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnEntrar.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnEntrar.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnEntrar.StateCommon.Border.Rounding = 40F;
            this.btnEntrar.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnEntrar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEntrar.Values.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.painelFundo);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Metas - Seu software de gerenciamento de metas!";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).EndInit();
            this.painelFundo.ResumeLayout(false);
            this.painelDivisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.painelEsquerdo)).EndInit();
            this.painelEsquerdo.ResumeLayout(false);
            this.painelEsquerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelDireito)).EndInit();
            this.painelDireito.ResumeLayout(false);
            this.painelDireito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel painelFundo;
        private Krypton.Toolkit.KryptonTableLayoutPanel painelDivisor;
        private Krypton.Toolkit.KryptonPanel painelDireito;
        private Krypton.Toolkit.KryptonPanel painelEsquerdo;
        private Krypton.Toolkit.KryptonButton btnEntrar;
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private KryptonPictureBox kryptonPictureBox5;
        private KryptonPictureBox kryptonPictureBox3;
        private KryptonTextBox txtSenha;
        private KryptonTextBox txtSenhaConf;
        private KryptonTextBox txtSenhaCad;
        private KryptonTextBox txtUsuarioCad;
        private KryptonButton btnCadastro;
        private KryptonTextBox txtNome;
        private System.Windows.Forms.Panel painel1;
        private KryptonButton btnVoltarLogin;
    }
}