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
            this.txtTituloMeta = new Krypton.Toolkit.KryptonTextBox();
            this.txtDescricaoMeta = new Krypton.Toolkit.KryptonTextBox();
            this.txtConclusaoMeta = new Krypton.Toolkit.KryptonTextBox();
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txtTituloMeta
            // 
            this.txtTituloMeta.Location = new System.Drawing.Point(196, 86);
            this.txtTituloMeta.Name = "txtTituloMeta";
            this.txtTituloMeta.Size = new System.Drawing.Size(219, 27);
            this.txtTituloMeta.TabIndex = 0;
            this.txtTituloMeta.Text = "Titulo";
            // 
            // txtDescricaoMeta
            // 
            this.txtDescricaoMeta.Location = new System.Drawing.Point(196, 146);
            this.txtDescricaoMeta.Multiline = true;
            this.txtDescricaoMeta.Name = "txtDescricaoMeta";
            this.txtDescricaoMeta.Size = new System.Drawing.Size(219, 27);
            this.txtDescricaoMeta.TabIndex = 1;
            this.txtDescricaoMeta.Text = "Descrição";
            // 
            // txtConclusaoMeta
            // 
            this.txtConclusaoMeta.Location = new System.Drawing.Point(196, 216);
            this.txtConclusaoMeta.Name = "txtConclusaoMeta";
            this.txtConclusaoMeta.Size = new System.Drawing.Size(219, 27);
            this.txtConclusaoMeta.TabIndex = 2;
            this.txtConclusaoMeta.Text = "DataConclusao";
            this.txtConclusaoMeta.TextChanged += new System.EventHandler(this.ConclusaoEditarMeta_TextChanged);
            this.txtConclusaoMeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConclusaoEditarMeta_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(472, 304);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 25);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvar.Values.Text = "kryptonButton1";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // EditarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtConclusaoMeta);
            this.Controls.Add(this.txtDescricaoMeta);
            this.Controls.Add(this.txtTituloMeta);
            this.Name = "EditarMeta";
            this.Text = "TelaEditarMeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTituloMeta;
        private Krypton.Toolkit.KryptonTextBox txtDescricaoMeta;
        private Krypton.Toolkit.KryptonTextBox txtConclusaoMeta;
        private Krypton.Toolkit.KryptonButton btnSalvar;
    }
}