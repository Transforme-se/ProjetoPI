namespace ProjetoPI.Views
{
    partial class perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfil));
            this.painelFundo = new Krypton.Toolkit.KryptonPanel();
            this.painelPerfil = new Krypton.Toolkit.KryptonPanel();
            this.lbUser = new Krypton.Toolkit.KryptonLabel();
            this.btnConfig = new Krypton.Toolkit.KryptonButton();
            this.imgUser = new Krypton.Toolkit.KryptonPictureBox();
            this.btnConta = new Krypton.Toolkit.KryptonButton();
            this.btnPerfil = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).BeginInit();
            this.painelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.painelPerfil)).BeginInit();
            this.painelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // painelFundo
            // 
            this.painelFundo.Controls.Add(this.painelPerfil);
            this.painelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelFundo.Location = new System.Drawing.Point(0, 0);
            this.painelFundo.Name = "painelFundo";
            this.painelFundo.Size = new System.Drawing.Size(339, 464);
            this.painelFundo.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(226)))), ((int)(((byte)(193)))));
            this.painelFundo.TabIndex = 0;
            this.painelFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.painelFundo_Paint);
            // 
            // painelPerfil
            // 
            this.painelPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.painelPerfil.Controls.Add(this.lbUser);
            this.painelPerfil.Controls.Add(this.btnConfig);
            this.painelPerfil.Controls.Add(this.imgUser);
            this.painelPerfil.Controls.Add(this.btnConta);
            this.painelPerfil.Controls.Add(this.btnPerfil);
            this.painelPerfil.Location = new System.Drawing.Point(20, 29);
            this.painelPerfil.Name = "painelPerfil";
            this.painelPerfil.Size = new System.Drawing.Size(292, 398);
            this.painelPerfil.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.painelPerfil.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(111, 113);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(52, 20);
            this.lbUser.TabIndex = 0;
            this.lbUser.Values.Text = "Batman";
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.Location = new System.Drawing.Point(72, 298);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(133, 43);
            this.btnConfig.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnConfig.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnConfig.StateCommon.Border.Rounding = 10F;
            this.btnConfig.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConfig.Values.Text = "Configurações";
            // 
            // imgUser
            // 
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(92, 3);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(97, 109);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 0;
            this.imgUser.TabStop = false;
            // 
            // btnConta
            // 
            this.btnConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConta.Location = new System.Drawing.Point(72, 220);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(133, 43);
            this.btnConta.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnConta.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnConta.StateCommon.Border.Rounding = 10F;
            this.btnConta.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnConta.TabIndex = 2;
            this.btnConta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConta.Values.Text = "Minha Conta";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerfil.Location = new System.Drawing.Point(72, 139);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(133, 43);
            this.btnPerfil.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnPerfil.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnPerfil.StateCommon.Border.Rounding = 10F;
            this.btnPerfil.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPerfil.Values.Text = "Meu Perfil";
            // 
            // perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 464);
            this.Controls.Add(this.painelFundo);
            this.Name = "perfil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "perfil";
            this.Load += new System.EventHandler(this.perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).EndInit();
            this.painelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.painelPerfil)).EndInit();
            this.painelPerfil.ResumeLayout(false);
            this.painelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel painelFundo;
        private Krypton.Toolkit.KryptonPanel painelPerfil;
        private Krypton.Toolkit.KryptonLabel lbUser;
        private Krypton.Toolkit.KryptonButton btnConfig;
        private Krypton.Toolkit.KryptonPictureBox imgUser;
        private Krypton.Toolkit.KryptonButton btnConta;
        private Krypton.Toolkit.KryptonButton btnPerfil;
    }
}