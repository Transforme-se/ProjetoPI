namespace ProjetoPI.Views
{
    partial class excluirConta
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
            this.lbBoasVindas = new Krypton.Toolkit.KryptonLabel();
            this.btnSim = new Krypton.Toolkit.KryptonButton();
            this.btnNao = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lbBoasVindas
            // 
            this.lbBoasVindas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBoasVindas.AutoSize = false;
            this.lbBoasVindas.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbBoasVindas.Location = new System.Drawing.Point(48, 29);
            this.lbBoasVindas.Name = "lbBoasVindas";
            this.lbBoasVindas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBoasVindas.Size = new System.Drawing.Size(396, 52);
            this.lbBoasVindas.StateCommon.Padding = new System.Windows.Forms.Padding(1);
            this.lbBoasVindas.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 27.75F, System.Drawing.FontStyle.Italic);
            this.lbBoasVindas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.TabIndex = 18;
            this.lbBoasVindas.Values.Text = "Deseja excluir sua conta ?";
            this.lbBoasVindas.Click += new System.EventHandler(this.lbBoasVindas_Click);
            // 
            // btnSim
            // 
            this.btnSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSim.Location = new System.Drawing.Point(269, 125);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(121, 38);
            this.btnSim.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSim.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSim.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnSim.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSim.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnSim.StateCommon.Border.Rounding = 40F;
            this.btnSim.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Transparent;
            this.btnSim.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnSim.StateNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnSim.StateNormal.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnSim.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSim.StateTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnSim.TabIndex = 22;
            this.btnSim.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSim.Values.Text = "Sim";
            // 
            // btnNao
            // 
            this.btnNao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNao.Location = new System.Drawing.Point(95, 125);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(121, 38);
            this.btnNao.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnNao.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnNao.StateCommon.Border.Rounding = 40F;
            this.btnNao.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNao.TabIndex = 23;
            this.btnNao.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNao.Values.Text = "Não";
            // 
            // excluirConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 217);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lbBoasVindas);
            this.Name = "excluirConta";
            this.Text = "excluirConta";
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbBoasVindas;
        private Krypton.Toolkit.KryptonButton btnSim;
        private Krypton.Toolkit.KryptonButton btnNao;
    }
}