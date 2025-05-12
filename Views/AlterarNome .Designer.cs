namespace ProjetoPI.Views
{
    partial class AlterarNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarNome));
            this.txtNovoNome = new Krypton.Toolkit.KryptonTextBox();
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.panelNome = new System.Windows.Forms.Panel();
            this.lblNomeAtual = new Krypton.Toolkit.KryptonLabel();
            this.lbAlterarNome = new Krypton.Toolkit.KryptonLabel();
            this.panelNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovoNome.CueHint.CueHintText = "Insira o novo nome";
            this.txtNovoNome.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtNovoNome.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtNovoNome.Location = new System.Drawing.Point(3, 130);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(285, 42);
            this.txtNovoNome.StateActive.Border.Rounding = 40F;
            this.txtNovoNome.StateCommon.Border.Rounding = 20F;
            this.txtNovoNome.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtNovoNome.TabIndex = 2;
            this.txtNovoNome.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(167, 260);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 38);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Rounding = 40F;
            this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(3, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 38);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Border.Rounding = 40F;
            this.btnCancelar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelNome
            // 
            this.panelNome.Controls.Add(this.lblNomeAtual);
            this.panelNome.Controls.Add(this.lbAlterarNome);
            this.panelNome.Controls.Add(this.btnCancelar);
            this.panelNome.Controls.Add(this.txtNovoNome);
            this.panelNome.Controls.Add(this.btnSalvar);
            this.panelNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNome.Location = new System.Drawing.Point(35, 35);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(291, 317);
            this.panelNome.TabIndex = 0;
            // 
            // lblNomeAtual
            // 
            this.lblNomeAtual.AutoSize = false;
            this.lblNomeAtual.Location = new System.Drawing.Point(3, 67);
            this.lblNomeAtual.Name = "lblNomeAtual";
            this.lblNomeAtual.Size = new System.Drawing.Size(285, 28);
            this.lblNomeAtual.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAtual.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblNomeAtual.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblNomeAtual.TabIndex = 6;
            this.lblNomeAtual.Values.Text = "Nome Atual";
            // 
            // lbAlterarNome
            // 
            this.lbAlterarNome.AutoSize = false;
            this.lbAlterarNome.Location = new System.Drawing.Point(3, 3);
            this.lbAlterarNome.Name = "lbAlterarNome";
            this.lbAlterarNome.Size = new System.Drawing.Size(285, 28);
            this.lbAlterarNome.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlterarNome.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbAlterarNome.TabIndex = 0;
            this.lbAlterarNome.Values.Text = "Alterar Nome";
            this.lbAlterarNome.Click += new System.EventHandler(this.lbAlterarNome_Click);
            // 
            // AlterarNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(361, 387);
            this.ControlBox = false;
            this.Controls.Add(this.panelNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarNome";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Nome";
            this.Load += new System.EventHandler(this.AlterarNome_Load);
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtNovoNome;
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.Panel panelNome;
        private Krypton.Toolkit.KryptonLabel lbAlterarNome;
        private Krypton.Toolkit.KryptonLabel lblNomeAtual;
    }
}