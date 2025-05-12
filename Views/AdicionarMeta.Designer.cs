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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.lbAlterarSenha = new Krypton.Toolkit.KryptonLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTituloMeta
            // 
            this.txtTituloMeta.CueHint.CueHintText = "Título";
            this.txtTituloMeta.Location = new System.Drawing.Point(2, 57);
            this.txtTituloMeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtTituloMeta.Name = "txtTituloMeta";
            this.txtTituloMeta.Size = new System.Drawing.Size(287, 35);
            this.txtTituloMeta.StateCommon.Border.Rounding = 20F;
            this.txtTituloMeta.TabIndex = 1;
            // 
            // txtDescricaoMeta
            // 
            this.txtDescricaoMeta.CueHint.CueHintText = "Descrição (Opcional)";
            this.txtDescricaoMeta.Location = new System.Drawing.Point(3, 120);
            this.txtDescricaoMeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoMeta.Name = "txtDescricaoMeta";
            this.txtDescricaoMeta.Size = new System.Drawing.Size(287, 35);
            this.txtDescricaoMeta.StateCommon.Border.Rounding = 20F;
            this.txtDescricaoMeta.TabIndex = 2;
            // 
            // btnSalvarMeta
            // 
            this.btnSalvarMeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarMeta.Location = new System.Drawing.Point(170, 279);
            this.btnSalvarMeta.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarMeta.Name = "btnSalvarMeta";
            this.btnSalvarMeta.Size = new System.Drawing.Size(121, 38);
            this.btnSalvarMeta.StateCommon.Border.Rounding = 20F;
            this.btnSalvarMeta.TabIndex = 4;
            this.btnSalvarMeta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalvarMeta.Values.Text = "Salvar";
            this.btnSalvarMeta.Click += new System.EventHandler(this.btnSalvarMeta_Click);
            // 
            // txtDataConclusao
            // 
            this.txtDataConclusao.CueHint.CueHintText = "Previsão de Conclusão";
            this.txtDataConclusao.Location = new System.Drawing.Point(3, 185);
            this.txtDataConclusao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataConclusao.Name = "txtDataConclusao";
            this.txtDataConclusao.Size = new System.Drawing.Size(287, 35);
            this.txtDataConclusao.StateCommon.Border.Rounding = 20F;
            this.txtDataConclusao.TabIndex = 3;
            this.txtDataConclusao.TextChanged += new System.EventHandler(this.FormatacaoDataMeta_TextChanged);
            this.txtDataConclusao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataConclusao_KeyDown);
            this.txtDataConclusao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDataConclusao_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lbAlterarSenha);
            this.panel1.Controls.Add(this.txtTituloMeta);
            this.panel1.Controls.Add(this.btnSalvarMeta);
            this.panel1.Controls.Add(this.txtDataConclusao);
            this.panel1.Controls.Add(this.txtDescricaoMeta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(35, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 317);
            this.panel1.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(0, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 38);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Border.Rounding = 40F;
            this.btnCancelar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lbAlterarSenha
            // 
            this.lbAlterarSenha.AutoSize = false;
            this.lbAlterarSenha.Location = new System.Drawing.Point(3, 3);
            this.lbAlterarSenha.Name = "lbAlterarSenha";
            this.lbAlterarSenha.Size = new System.Drawing.Size(285, 28);
            this.lbAlterarSenha.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlterarSenha.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbAlterarSenha.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbAlterarSenha.TabIndex = 0;
            this.lbAlterarSenha.Values.Text = "Adicionar Meta";
            // 
            // AdicionarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(361, 387);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarMeta";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Meta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTituloMeta;
        private Krypton.Toolkit.KryptonTextBox txtDescricaoMeta;
        private Krypton.Toolkit.KryptonButton btnSalvarMeta;
        private Krypton.Toolkit.KryptonTextBox txtDataConclusao;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonLabel lbAlterarSenha;
        private Krypton.Toolkit.KryptonButton btnCancelar;
    }
}