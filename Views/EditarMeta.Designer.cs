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
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.brnExcluirMeta = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txtTituloMeta
            // 
            this.txtTituloMeta.Location = new System.Drawing.Point(72, 54);
            this.txtTituloMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTituloMeta.Name = "txtTituloMeta";
            this.txtTituloMeta.Size = new System.Drawing.Size(208, 35);
            this.txtTituloMeta.StateCommon.Border.Rounding = 20F;
            this.txtTituloMeta.TabIndex = 0;
            this.txtTituloMeta.TextChanged += new System.EventHandler(this.txtTituloMeta_TextChanged);
            // 
            // txtDescricaoMeta
            // 
            this.txtDescricaoMeta.Location = new System.Drawing.Point(72, 114);
            this.txtDescricaoMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricaoMeta.Multiline = true;
            this.txtDescricaoMeta.Name = "txtDescricaoMeta";
            this.txtDescricaoMeta.Size = new System.Drawing.Size(207, 37);
            this.txtDescricaoMeta.StateCommon.Border.Rounding = 20F;
            this.txtDescricaoMeta.TabIndex = 1;
            // 
            // txtConclusaoMeta
            // 
            this.txtConclusaoMeta.Location = new System.Drawing.Point(72, 176);
            this.txtConclusaoMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConclusaoMeta.Name = "txtConclusaoMeta";
            this.txtConclusaoMeta.Size = new System.Drawing.Size(208, 35);
            this.txtConclusaoMeta.StateCommon.Border.Rounding = 20F;
            this.txtConclusaoMeta.TabIndex = 2;
            this.txtConclusaoMeta.TextChanged += new System.EventHandler(this.ConclusaoEditarMeta_TextChanged);
            this.txtConclusaoMeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConclusaoEditarMeta_KeyPress);
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
            this.brnExcluirMeta.Location = new System.Drawing.Point(72, 261);
            this.brnExcluirMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnExcluirMeta.Name = "brnExcluirMeta";
            this.brnExcluirMeta.Size = new System.Drawing.Size(91, 32);
            this.brnExcluirMeta.StateCommon.Border.Rounding = 20F;
            this.brnExcluirMeta.TabIndex = 4;
            this.brnExcluirMeta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.brnExcluirMeta.Values.Text = "Excluir Meta";
            this.brnExcluirMeta.Click += new System.EventHandler(this.brnExcluirMeta_Click);
            // 
            // EditarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(349, 333);
            this.Controls.Add(this.brnExcluirMeta);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtConclusaoMeta);
            this.Controls.Add(this.txtDescricaoMeta);
            this.Controls.Add(this.txtTituloMeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditarMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditarMeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTituloMeta;
        private Krypton.Toolkit.KryptonTextBox txtDescricaoMeta;
        private Krypton.Toolkit.KryptonTextBox txtConclusaoMeta;
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonButton brnExcluirMeta;
    }
}