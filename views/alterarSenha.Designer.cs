namespace ProjetoPI.Views
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            this.txtNovaSenha = new Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmarSenha = new Krypton.Toolkit.KryptonTextBox();
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.txtSenhaAtual = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAlterarSenha = new Krypton.Toolkit.KryptonLabel();
            this.panel1.SuspendLayout();
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
            this.txtNovaSenha.Location = new System.Drawing.Point(3, 120);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(285, 42);
            this.txtNovaSenha.StateActive.Border.Rounding = 40F;
            this.txtNovaSenha.StateCommon.Border.Rounding = 20F;
            this.txtNovaSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtNovaSenha.TabIndex = 2;
            this.txtNovaSenha.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarSenha.CueHint.CueHintText = "Confirme sua senha";
            this.txtConfirmarSenha.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtConfirmarSenha.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(3, 185);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(285, 42);
            this.txtConfirmarSenha.StateActive.Border.Rounding = 40F;
            this.txtConfirmarSenha.StateCommon.Border.Rounding = 20F;
            this.txtConfirmarSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(167, 279);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 38);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSalvar.StateCommon.Border.Rounding = 40F;
            this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaAtual.CueHint.CueHintText = "Insira sua senha atual ";
            this.txtSenhaAtual.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenhaAtual.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtSenhaAtual.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSenhaAtual.Location = new System.Drawing.Point(2, 57);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(285, 42);
            this.txtSenhaAtual.StateActive.Border.Rounding = 40F;
            this.txtSenhaAtual.StateCommon.Border.Rounding = 20F;
            this.txtSenhaAtual.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtSenhaAtual.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 38);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Border.Rounding = 40F;
            this.btnCancelar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAlterarSenha);
            this.panel1.Controls.Add(this.txtSenhaAtual);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtNovaSenha);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtConfirmarSenha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(35, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 317);
            this.panel1.TabIndex = 0;
            // 
            // lbAlterarSenha
            // 
            this.lbAlterarSenha.Location = new System.Drawing.Point(79, 3);
            this.lbAlterarSenha.Name = "lbAlterarSenha";
            this.lbAlterarSenha.Size = new System.Drawing.Size(132, 26);
            this.lbAlterarSenha.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlterarSenha.TabIndex = 0;
            this.lbAlterarSenha.Values.Text = "Alterar Senha";
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(361, 387);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "AlterarSenha";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtNovaSenha;
        private Krypton.Toolkit.KryptonTextBox txtConfirmarSenha;
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonTextBox txtSenhaAtual;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonLabel lbAlterarSenha;
    }
}