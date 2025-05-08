namespace ProjetoPI.Views
{
    partial class alterarFundo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alterarFundo));
            this.lbBoasVindas = new Krypton.Toolkit.KryptonLabel();
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.fundo2 = new Krypton.Toolkit.KryptonPictureBox();
            this.fundo3 = new Krypton.Toolkit.KryptonPictureBox();
            this.fundo4 = new Krypton.Toolkit.KryptonPictureBox();
            this.fundo1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fundo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBoasVindas
            // 
            this.lbBoasVindas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBoasVindas.AutoSize = false;
            this.lbBoasVindas.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbBoasVindas.Location = new System.Drawing.Point(57, 12);
            this.lbBoasVindas.Name = "lbBoasVindas";
            this.lbBoasVindas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBoasVindas.Size = new System.Drawing.Size(369, 52);
            this.lbBoasVindas.StateCommon.Padding = new System.Windows.Forms.Padding(1);
            this.lbBoasVindas.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 20F, System.Drawing.FontStyle.Italic);
            this.lbBoasVindas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.TabIndex = 17;
            this.lbBoasVindas.Values.Text = "Selecione um plano de fundo  ";
            this.lbBoasVindas.Click += new System.EventHandler(this.lbBoasVindas_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(352, 424);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 38);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Rounding = 40F;
            this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "Salvar";
            // 
            // fundo2
            // 
            this.fundo2.Image = ((System.Drawing.Image)(resources.GetObject("fundo2.Image")));
            this.fundo2.Location = new System.Drawing.Point(259, 85);
            this.fundo2.Name = "fundo2";
            this.fundo2.Size = new System.Drawing.Size(167, 123);
            this.fundo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundo2.TabIndex = 2;
            this.fundo2.TabStop = false;
            // 
            // fundo3
            // 
            this.fundo3.Image = ((System.Drawing.Image)(resources.GetObject("fundo3.Image")));
            this.fundo3.Location = new System.Drawing.Point(33, 264);
            this.fundo3.Name = "fundo3";
            this.fundo3.Size = new System.Drawing.Size(167, 123);
            this.fundo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundo3.TabIndex = 3;
            this.fundo3.TabStop = false;
            // 
            // fundo4
            // 
            this.fundo4.Image = ((System.Drawing.Image)(resources.GetObject("fundo4.Image")));
            this.fundo4.Location = new System.Drawing.Point(268, 264);
            this.fundo4.Name = "fundo4";
            this.fundo4.Size = new System.Drawing.Size(167, 123);
            this.fundo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundo4.TabIndex = 6;
            this.fundo4.TabStop = false;
            // 
            // fundo1
            // 
            this.fundo1.Image = ((System.Drawing.Image)(resources.GetObject("fundo1.Image")));
            this.fundo1.Location = new System.Drawing.Point(33, 85);
            this.fundo1.Name = "fundo1";
            this.fundo1.Size = new System.Drawing.Size(167, 123);
            this.fundo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundo1.TabIndex = 1;
            this.fundo1.TabStop = false;
            // 
            // alterarFundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 496);
            this.Controls.Add(this.lbBoasVindas);
            this.Controls.Add(this.fundo4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.fundo3);
            this.Controls.Add(this.fundo2);
            this.Controls.Add(this.fundo1);
            this.Name = "alterarFundo";
            this.Text = "alterarFundo";
            ((System.ComponentModel.ISupportInitialize)(this.fundo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lbBoasVindas;
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonPictureBox fundo2;
        private Krypton.Toolkit.KryptonPictureBox fundo3;
        private Krypton.Toolkit.KryptonPictureBox fundo4;
        private Krypton.Toolkit.KryptonPictureBox fundo1;
    }
}