namespace ProjetoPI.Views
{
    partial class alterarAvatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alterarAvatar));
            this.lbBoasVindas = new Krypton.Toolkit.KryptonLabel();
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.avatar4 = new Krypton.Toolkit.KryptonPictureBox();
            this.avatar3 = new Krypton.Toolkit.KryptonPictureBox();
            this.avatar2 = new Krypton.Toolkit.KryptonPictureBox();
            this.avatar1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
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
            this.lbBoasVindas.Size = new System.Drawing.Size(334, 52);
            this.lbBoasVindas.StateCommon.Padding = new System.Windows.Forms.Padding(1);
            this.lbBoasVindas.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 27.75F, System.Drawing.FontStyle.Italic);
            this.lbBoasVindas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.TabIndex = 17;
            this.lbBoasVindas.Values.Text = "Selecione um Avatar";
            this.lbBoasVindas.Click += new System.EventHandler(this.lbBoasVindas_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(316, 391);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 38);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Rounding = 40F;
            this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "Salvar";
            // 
            // avatar4
            // 
            this.avatar4.Image = ((System.Drawing.Image)(resources.GetObject("avatar4.Image")));
            this.avatar4.Location = new System.Drawing.Point(292, 233);
            this.avatar4.Name = "avatar4";
            this.avatar4.Size = new System.Drawing.Size(167, 123);
            this.avatar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar4.TabIndex = 22;
            this.avatar4.TabStop = false;
            // 
            // avatar3
            // 
            this.avatar3.Image = ((System.Drawing.Image)(resources.GetObject("avatar3.Image")));
            this.avatar3.Location = new System.Drawing.Point(57, 233);
            this.avatar3.Name = "avatar3";
            this.avatar3.Size = new System.Drawing.Size(167, 123);
            this.avatar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar3.TabIndex = 20;
            this.avatar3.TabStop = false;
            // 
            // avatar2
            // 
            this.avatar2.Image = ((System.Drawing.Image)(resources.GetObject("avatar2.Image")));
            this.avatar2.Location = new System.Drawing.Point(292, 70);
            this.avatar2.Name = "avatar2";
            this.avatar2.Size = new System.Drawing.Size(167, 123);
            this.avatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar2.TabIndex = 19;
            this.avatar2.TabStop = false;
            // 
            // avatar1
            // 
            this.avatar1.Image = ((System.Drawing.Image)(resources.GetObject("avatar1.Image")));
            this.avatar1.Location = new System.Drawing.Point(57, 70);
            this.avatar1.Name = "avatar1";
            this.avatar1.Size = new System.Drawing.Size(167, 123);
            this.avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar1.TabIndex = 18;
            this.avatar1.TabStop = false;
            // 
            // alterarAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.avatar4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.avatar3);
            this.Controls.Add(this.avatar2);
            this.Controls.Add(this.avatar1);
            this.Controls.Add(this.lbBoasVindas);
            this.Name = "alterarAvatar";
            this.Text = "alterarAvatar";
            ((System.ComponentModel.ISupportInitialize)(this.avatar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbBoasVindas;
        private Krypton.Toolkit.KryptonPictureBox avatar4;
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonPictureBox avatar3;
        private Krypton.Toolkit.KryptonPictureBox avatar2;
        private Krypton.Toolkit.KryptonPictureBox avatar1;
    }
}