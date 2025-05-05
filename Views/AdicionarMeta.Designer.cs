namespace ProjetoPI.Views
{
    partial class AdicionarMeta
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
            this.btnSalvarMeta = new Krypton.Toolkit.KryptonButton();
            this.txtDataConclusao = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // txtTituloMeta
            // 
            this.txtTituloMeta.Location = new System.Drawing.Point(225, 107);
            this.txtTituloMeta.Name = "txtTituloMeta";
            this.txtTituloMeta.Size = new System.Drawing.Size(224, 27);
            this.txtTituloMeta.TabIndex = 0;
            this.txtTituloMeta.Text = "Título da meta";
            // 
            // txtDescricaoMeta
            // 
            this.txtDescricaoMeta.Location = new System.Drawing.Point(225, 158);
            this.txtDescricaoMeta.Name = "txtDescricaoMeta";
            this.txtDescricaoMeta.Size = new System.Drawing.Size(224, 27);
            this.txtDescricaoMeta.TabIndex = 1;
            this.txtDescricaoMeta.Text = "Descrição (Opcional)";
            // 
            // btnSalvarMeta
            // 
            this.btnSalvarMeta.Location = new System.Drawing.Point(408, 282);
            this.btnSalvarMeta.Name = "btnSalvarMeta";
            this.btnSalvarMeta.Size = new System.Drawing.Size(119, 44);
            this.btnSalvarMeta.TabIndex = 3;
            this.btnSalvarMeta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvarMeta.Values.Text = "Salvar";
            this.btnSalvarMeta.Click += new System.EventHandler(this.btnSalvarMeta_Click);
            // 
            // txtDataConclusao
            // 
            this.txtDataConclusao.Location = new System.Drawing.Point(225, 217);
            this.txtDataConclusao.Name = "txtDataConclusao";
            this.txtDataConclusao.Size = new System.Drawing.Size(224, 27);
            this.txtDataConclusao.TabIndex = 4;
            this.txtDataConclusao.TextChanged += new System.EventHandler(this.FormatacaoDataMeta_TextChanged);
            this.txtDataConclusao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormatacaoDataMeta_KeyPress);
            // 
            // AdicionarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDataConclusao);
            this.Controls.Add(this.btnSalvarMeta);
            this.Controls.Add(this.txtDescricaoMeta);
            this.Controls.Add(this.txtTituloMeta);
            this.Name = "AdicionarMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarMeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTituloMeta;
        private Krypton.Toolkit.KryptonTextBox txtDescricaoMeta;
        private Krypton.Toolkit.KryptonButton btnSalvarMeta;
        private Krypton.Toolkit.KryptonTextBox txtDataConclusao;
    }
}