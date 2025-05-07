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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarMeta));
            this.txtTituloMeta = new Krypton.Toolkit.KryptonTextBox();
            this.txtDescricaoMeta = new Krypton.Toolkit.KryptonTextBox();
            this.btnSalvarMeta = new Krypton.Toolkit.KryptonButton();
            this.txtDataConclusao = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // txtTituloMeta
            // 
            this.txtTituloMeta.CueHint.CueHintText = "Título";
            this.txtTituloMeta.Location = new System.Drawing.Point(79, 61);
            this.txtTituloMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTituloMeta.Name = "txtTituloMeta";
            this.txtTituloMeta.Size = new System.Drawing.Size(168, 35);
            this.txtTituloMeta.StateCommon.Border.Rounding = 20F;
            this.txtTituloMeta.TabIndex = 0;
            // 
            // txtDescricaoMeta
            // 
            this.txtDescricaoMeta.CueHint.CueHintText = "Descrição (Opcional)";
            this.txtDescricaoMeta.Location = new System.Drawing.Point(79, 131);
            this.txtDescricaoMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricaoMeta.Name = "txtDescricaoMeta";
            this.txtDescricaoMeta.Size = new System.Drawing.Size(168, 35);
            this.txtDescricaoMeta.StateCommon.Border.Rounding = 20F;
            this.txtDescricaoMeta.TabIndex = 1;
            // 
            // btnSalvarMeta
            // 
            this.btnSalvarMeta.Location = new System.Drawing.Point(221, 277);
            this.btnSalvarMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvarMeta.Name = "btnSalvarMeta";
            this.btnSalvarMeta.Size = new System.Drawing.Size(89, 36);
            this.btnSalvarMeta.StateCommon.Border.Rounding = 20F;
            this.btnSalvarMeta.TabIndex = 3;
            this.btnSalvarMeta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvarMeta.Values.Text = "Salvar";
            this.btnSalvarMeta.Click += new System.EventHandler(this.btnSalvarMeta_Click);
            // 
            // txtDataConclusao
            // 
            this.txtDataConclusao.CueHint.CueHintText = "Previsão de Conclusão";
            this.txtDataConclusao.Location = new System.Drawing.Point(79, 208);
            this.txtDataConclusao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDataConclusao.Name = "txtDataConclusao";
            this.txtDataConclusao.Size = new System.Drawing.Size(168, 35);
            this.txtDataConclusao.StateCommon.Border.Rounding = 20F;
            this.txtDataConclusao.TabIndex = 4;
            this.txtDataConclusao.TextChanged += new System.EventHandler(this.FormatacaoDataMeta_TextChanged);
            // 
            // AdicionarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(358, 350);
            this.Controls.Add(this.txtDataConclusao);
            this.Controls.Add(this.btnSalvarMeta);
            this.Controls.Add(this.txtDescricaoMeta);
            this.Controls.Add(this.txtTituloMeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdicionarMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarMeta";
            this.Load += new System.EventHandler(this.AdicionarMeta_Load);
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