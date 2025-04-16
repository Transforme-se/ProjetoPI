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
            this.painelDivisor = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.painelDireito = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.txtSenhaLogin = new Krypton.Toolkit.KryptonTextBox();
            this.txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.btnEntrarLogin = new Krypton.Toolkit.KryptonButton();
            this.painelEsquerdo = new Krypton.Toolkit.KryptonPanel();
            this.txtConfSenha = new Krypton.Toolkit.KryptonTextBox();
            this.txtNovoUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.txtSenhaCadastro = new Krypton.Toolkit.KryptonTextBox();
            this.Concluir = new Krypton.Toolkit.KryptonButton();
            this.kryptonPictureBox3 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox4 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox5 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.btnCadastrar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).BeginInit();
            this.painelFundo.SuspendLayout();
            this.painelDivisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.painelDireito)).BeginInit();
            this.painelDireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelEsquerdo)).BeginInit();
            this.painelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // painelFundo
            // 
            this.painelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelFundo.Controls.Add(this.painelDivisor);
            this.painelFundo.Location = new System.Drawing.Point(0, 0);
            this.painelFundo.Name = "painelFundo";
            this.painelFundo.Size = new System.Drawing.Size(884, 584);
            this.painelFundo.TabIndex = 4;
            // 
            // painelDivisor
            // 
            this.painelDivisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelDivisor.ColumnCount = 2;
            this.painelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.painelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.painelDivisor.Controls.Add(this.painelDireito, 1, 0);
            this.painelDivisor.Controls.Add(this.painelEsquerdo, 0, 0);
            this.painelDivisor.Location = new System.Drawing.Point(21, 12);
            this.painelDivisor.Name = "painelDivisor";
            this.painelDivisor.RowCount = 1;
            this.painelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.painelDivisor.Size = new System.Drawing.Size(860, 560);
            this.painelDivisor.TabIndex = 0;
            // 
            // painelDireito
            // 
            this.painelDireito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelDireito.Controls.Add(this.btnCadastrar);
            this.painelDireito.Controls.Add(this.kryptonButton1);
            this.painelDireito.Controls.Add(this.kryptonPictureBox2);
            this.painelDireito.Controls.Add(this.kryptonPictureBox1);
            this.painelDireito.Controls.Add(this.txtSenhaLogin);
            this.painelDireito.Controls.Add(this.txtUsuario);
            this.painelDireito.Controls.Add(this.btnEntrarLogin);
            this.painelDireito.Location = new System.Drawing.Point(433, 3);
            this.painelDireito.Name = "painelDireito";
            this.painelDireito.Size = new System.Drawing.Size(424, 554);
            this.painelDireito.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.painelDireito.TabIndex = 1;
            this.painelDireito.Paint += new System.Windows.Forms.PaintEventHandler(this.painelDireito_Paint);
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox2.Image")));
            this.kryptonPictureBox2.Location = new System.Drawing.Point(82, 237);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(37, 33);
            this.kryptonPictureBox2.TabIndex = 6;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(82, 159);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(25, 29);
            this.kryptonPictureBox1.TabIndex = 4;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaLogin.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom2;
            this.txtSenhaLogin.Location = new System.Drawing.Point(125, 227);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '●';
            this.txtSenhaLogin.Size = new System.Drawing.Size(248, 43);
            this.txtSenhaLogin.StateActive.Border.Rounding = 30F;
            this.txtSenhaLogin.StateCommon.Border.Rounding = 20F;
            this.txtSenhaLogin.TabIndex = 5;
            this.txtSenhaLogin.UseSystemPasswordChar = true;
            this.txtSenhaLogin.TextChanged += new System.EventHandler(this.txtSenhaLogin_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(125, 152);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 42);
            this.txtUsuario.StateActive.Border.Rounding = 40F;
            this.txtUsuario.StateCommon.Border.Rounding = 20F;
            this.txtUsuario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrarLogin.Location = new System.Drawing.Point(225, 369);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(133, 43);
            this.btnEntrarLogin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnEntrarLogin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnEntrarLogin.StateCommon.Border.Rounding = 40F;
            this.btnEntrarLogin.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnEntrarLogin.TabIndex = 0;
            this.btnEntrarLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEntrarLogin.Values.Text = "Entrar";
            // 
            // painelEsquerdo
            // 
            this.painelEsquerdo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelEsquerdo.Controls.Add(this.kryptonPictureBox5);
            this.painelEsquerdo.Controls.Add(this.kryptonPictureBox4);
            this.painelEsquerdo.Controls.Add(this.kryptonPictureBox3);
            this.painelEsquerdo.Controls.Add(this.txtConfSenha);
            this.painelEsquerdo.Controls.Add(this.txtNovoUsuario);
            this.painelEsquerdo.Controls.Add(this.txtSenhaCadastro);
            this.painelEsquerdo.Controls.Add(this.Concluir);
            this.painelEsquerdo.Location = new System.Drawing.Point(3, 3);
            this.painelEsquerdo.Name = "painelEsquerdo";
            this.painelEsquerdo.Size = new System.Drawing.Size(424, 554);
            this.painelEsquerdo.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.painelEsquerdo.TabIndex = 0;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfSenha.Location = new System.Drawing.Point(119, 314);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(214, 43);
            this.txtConfSenha.StateActive.Border.Rounding = 30F;
            this.txtConfSenha.StateCommon.Border.Rounding = 20F;
            this.txtConfSenha.TabIndex = 3;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            // 
            // txtNovoUsuario
            // 
            this.txtNovoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovoUsuario.Location = new System.Drawing.Point(119, 152);
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.Size = new System.Drawing.Size(214, 43);
            this.txtNovoUsuario.StateActive.Border.Rounding = 30F;
            this.txtNovoUsuario.StateCommon.Border.Rounding = 20F;
            this.txtNovoUsuario.TabIndex = 2;
            this.txtNovoUsuario.TextChanged += new System.EventHandler(this.txtNovoUsuario_TextChanged);
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCadastro.Location = new System.Drawing.Point(119, 227);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(214, 43);
            this.txtSenhaCadastro.StateActive.Border.Rounding = 30F;
            this.txtSenhaCadastro.StateCommon.Border.Rounding = 20F;
            this.txtSenhaCadastro.TabIndex = 1;
            this.txtSenhaCadastro.TextChanged += new System.EventHandler(this.txtSenhaCadastro_TextChanged);
            // 
            // Concluir
            // 
            this.Concluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Concluir.Location = new System.Drawing.Point(198, 420);
            this.Concluir.Name = "Concluir";
            this.Concluir.Size = new System.Drawing.Size(135, 44);
            this.Concluir.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Concluir.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.Concluir.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.Concluir.StateCommon.Border.Rounding = 20F;
            this.Concluir.TabIndex = 0;
            this.Concluir.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.Concluir.Values.Text = "Concluir";
            // 
            // kryptonPictureBox3
            // 
            this.kryptonPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox3.Image")));
            this.kryptonPictureBox3.Location = new System.Drawing.Point(77, 159);
            this.kryptonPictureBox3.Name = "kryptonPictureBox3";
            this.kryptonPictureBox3.Size = new System.Drawing.Size(25, 29);
            this.kryptonPictureBox3.TabIndex = 5;
            this.kryptonPictureBox3.TabStop = false;
            // 
            // kryptonPictureBox4
            // 
            this.kryptonPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox4.Image")));
            this.kryptonPictureBox4.Location = new System.Drawing.Point(76, 227);
            this.kryptonPictureBox4.Name = "kryptonPictureBox4";
            this.kryptonPictureBox4.Size = new System.Drawing.Size(37, 33);
            this.kryptonPictureBox4.TabIndex = 7;
            this.kryptonPictureBox4.TabStop = false;
            // 
            // kryptonPictureBox5
            // 
            this.kryptonPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox5.Image")));
            this.kryptonPictureBox5.Location = new System.Drawing.Point(76, 324);
            this.kryptonPictureBox5.Name = "kryptonPictureBox5";
            this.kryptonPictureBox5.Size = new System.Drawing.Size(37, 33);
            this.kryptonPictureBox5.TabIndex = 8;
            this.kryptonPictureBox5.TabStop = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton1.Location = new System.Drawing.Point(102, 36);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(133, 43);
            this.kryptonButton1.StateCommon.Border.Rounding = 40F;
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Entrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(265, 36);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 43);
            this.btnCadastrar.StateCommon.Border.Rounding = 40F;
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCadastrar.Values.Text = "Cadastre-se";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 584);
            this.Controls.Add(this.painelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Metas - Seu software de gerenciamento de metas!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).EndInit();
            this.painelFundo.ResumeLayout(false);
            this.painelDivisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.painelDireito)).EndInit();
            this.painelDireito.ResumeLayout(false);
            this.painelDireito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelEsquerdo)).EndInit();
            this.painelEsquerdo.ResumeLayout(false);
            this.painelEsquerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel painelFundo;
        private Krypton.Toolkit.KryptonTableLayoutPanel painelDivisor;
        private Krypton.Toolkit.KryptonPanel painelDireito;
        private Krypton.Toolkit.KryptonPanel painelEsquerdo;
        private Krypton.Toolkit.KryptonButton btnEntrarLogin;
        private Krypton.Toolkit.KryptonButton Concluir;
        private Krypton.Toolkit.KryptonTextBox txtSenhaLogin;
        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private Krypton.Toolkit.KryptonTextBox txtConfSenha;
        private Krypton.Toolkit.KryptonTextBox txtNovoUsuario;
        private Krypton.Toolkit.KryptonTextBox txtSenhaCadastro;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private KryptonPictureBox kryptonPictureBox5;
        private KryptonPictureBox kryptonPictureBox4;
        private KryptonPictureBox kryptonPictureBox3;
        private KryptonButton btnCadastrar;
        private KryptonButton kryptonButton1;
    }
}