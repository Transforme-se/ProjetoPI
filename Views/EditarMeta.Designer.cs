namespace ProjetoPI.Views
{
    partial class EditarMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMeta));
            this.txtTituloMeta = new Krypton.Toolkit.KryptonTextBox();
            this.txtDescricaoMeta = new Krypton.Toolkit.KryptonTextBox();
            this.txtConclusaoMeta = new Krypton.Toolkit.KryptonTextBox();
            this.brnExcluirMeta = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAlterarSenha = new Krypton.Toolkit.KryptonLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTituloMeta
            // 
            this.txtTituloMeta.Location = new System.Drawing.Point(2, 57);
            this.txtTituloMeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtTituloMeta.Name = "txtTituloMeta";
            this.txtTituloMeta.Size = new System.Drawing.Size(287, 35);
            this.txtTituloMeta.StateCommon.Border.Rounding = 20F;
            this.txtTituloMeta.TabIndex = 1;
            this.txtTituloMeta.TextChanged += new System.EventHandler(this.txtTituloMeta_TextChanged);
            // 
            // txtDescricaoMeta
            // 
            this.txtDescricaoMeta.Location = new System.Drawing.Point(3, 120);
            this.txtDescricaoMeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoMeta.Multiline = true;
            this.txtDescricaoMeta.Name = "txtDescricaoMeta";
            this.txtDescricaoMeta.Size = new System.Drawing.Size(287, 37);
            this.txtDescricaoMeta.StateCommon.Border.Rounding = 20F;
            this.txtDescricaoMeta.TabIndex = 2;
            // 
            // txtConclusaoMeta
            // 
            this.txtConclusaoMeta.Location = new System.Drawing.Point(3, 185);
            this.txtConclusaoMeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtConclusaoMeta.Name = "txtConclusaoMeta";
            this.txtConclusaoMeta.Size = new System.Drawing.Size(287, 35);
            this.txtConclusaoMeta.StateCommon.Border.Rounding = 20F;
            this.txtConclusaoMeta.TabIndex = 3;
            this.txtConclusaoMeta.TextChanged += new System.EventHandler(this.ConclusaoEditarMeta_TextChanged);
            this.txtConclusaoMeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConclusaoMeta_KeyDown);
            this.txtConclusaoMeta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConclusaoMeta_KeyUp);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(186, 261);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 32);
            this.btnSalvar.StateCommon.Border.Rounding = 20F;
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // brnExcluirMeta
            // 
            this.brnExcluirMeta.Location = new System.Drawing.Point(2, 279);
            this.brnExcluirMeta.Margin = new System.Windows.Forms.Padding(2);
            this.brnExcluirMeta.Name = "brnExcluirMeta";
            this.brnExcluirMeta.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.brnExcluirMeta.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(12)))));
            this.brnExcluirMeta.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.brnExcluirMeta.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.brnExcluirMeta.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.brnExcluirMeta.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.brnExcluirMeta.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnExcluirMeta.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.brnExcluirMeta.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.brnExcluirMeta.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.brnExcluirMeta.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.brnExcluirMeta.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.brnExcluirMeta.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.brnExcluirMeta.Size = new System.Drawing.Size(121, 38);
            this.brnExcluirMeta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.brnExcluirMeta.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(11)))), ((int)(((byte)(12)))));
            this.brnExcluirMeta.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.brnExcluirMeta.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.brnExcluirMeta.StateCommon.Border.Rounding = 20F;
            this.brnExcluirMeta.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.brnExcluirMeta.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.brnExcluirMeta.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnExcluirMeta.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.brnExcluirMeta.TabIndex = 5;
            this.brnExcluirMeta.TabStop = false;
            this.brnExcluirMeta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.brnExcluirMeta.Values.Text = "Excluir Meta";
            this.brnExcluirMeta.Click += new System.EventHandler(this.brnExcluirMeta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAlterarSenha);
            this.panel1.Controls.Add(this.txtTituloMeta);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.brnExcluirMeta);
            this.panel1.Controls.Add(this.txtDescricaoMeta);
            this.panel1.Controls.Add(this.txtConclusaoMeta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(35, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 317);
            this.panel1.TabIndex = 5;
            // 
            // lbAlterarSenha
            // 
            this.lbAlterarSenha.Location = new System.Drawing.Point(89, 3);
            this.lbAlterarSenha.Name = "lbAlterarSenha";
            this.lbAlterarSenha.Size = new System.Drawing.Size(113, 26);
            this.lbAlterarSenha.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlterarSenha.TabIndex = 5;
            this.lbAlterarSenha.Values.Text = "Editar Meta";
            // 
            // EditarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(361, 387);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarMeta";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditarMeta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTituloMeta;
        private Krypton.Toolkit.KryptonTextBox txtDescricaoMeta;
        private Krypton.Toolkit.KryptonTextBox txtConclusaoMeta;
        private Krypton.Toolkit.KryptonButton brnExcluirMeta;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonLabel lbAlterarSenha;
        private Krypton.Toolkit.KryptonButton btnSalvar;
    }
}