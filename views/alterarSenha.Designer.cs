namespace ProjetoPI.Views
{
    partial class alterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alterarSenha));
            this.txtNovaSenha = new Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmarSenha = new Krypton.Toolkit.KryptonTextBox();
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.btnSenhaAtual = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovaSenha.CueHint.CueHintText = "Insira uma nova senha";
            this.txtNovaSenha.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtNovaSenha.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtNovaSenha.Enabled = false;
            this.txtNovaSenha.Location = new System.Drawing.Point(42, 153);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(229, 42);
            this.txtNovaSenha.StateActive.Border.Rounding = 40F;
            this.txtNovaSenha.StateCommon.Border.Rounding = 20F;
            this.txtNovaSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtNovaSenha.TabIndex = 1;
            this.txtNovaSenha.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtNovaSenha.UseWaitCursor = true;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarSenha.CueHint.CueHintText = "Confirme sua senha";
            this.txtConfirmarSenha.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtConfirmarSenha.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtConfirmarSenha.Enabled = false;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(42, 234);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(229, 42);
            this.txtConfirmarSenha.StateActive.Border.Rounding = 40F;
            this.txtConfirmarSenha.StateCommon.Border.Rounding = 20F;
            this.txtConfirmarSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtConfirmarSenha.TabIndex = 2;
            this.txtConfirmarSenha.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtConfirmarSenha.UseWaitCursor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(228, 313);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 38);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Rounding = 40F;
            this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "Salvar";
            // 
            // btnSenhaAtual
            // 
            this.btnSenhaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSenhaAtual.CueHint.CueHintText = "Insira sua senha atual ";
            this.btnSenhaAtual.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSenhaAtual.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSenhaAtual.Enabled = false;
            this.btnSenhaAtual.Location = new System.Drawing.Point(42, 74);
            this.btnSenhaAtual.Name = "btnSenhaAtual";
            this.btnSenhaAtual.Size = new System.Drawing.Size(229, 42);
            this.btnSenhaAtual.StateActive.Border.Rounding = 40F;
            this.btnSenhaAtual.StateCommon.Border.Rounding = 20F;
            this.btnSenhaAtual.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.btnSenhaAtual.TabIndex = 5;
            this.btnSenhaAtual.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnSenhaAtual.UseWaitCursor = true;
            // 
            // alterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 387);
            this.Controls.Add(this.btnSenhaAtual);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Name = "alterarSenha";
            this.Text = "alterarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtNovaSenha;
        private Krypton.Toolkit.KryptonTextBox txtConfirmarSenha;
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonTextBox btnSenhaAtual;
    }
}