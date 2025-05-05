namespace ProjetoPI.Views
{
    partial class telaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.painelFundo = new Krypton.Toolkit.KryptonPanel();
            this.painelMetas = new Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarMeta = new Krypton.Toolkit.KryptonButton();
            this.tabela = new Krypton.Toolkit.KryptonDataGridView();
            this.Id = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Titulo = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Descricao = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn4 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.PrevConclusao = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.status = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.metasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbBoasVindas = new Krypton.Toolkit.KryptonLabel();
            this.btnNovaMeta = new Krypton.Toolkit.KryptonButton();
            this.txtBusca = new Krypton.Toolkit.KryptonTextBox();
            this.calendario = new Krypton.Toolkit.KryptonMonthCalendar();
            this.painelMenu = new Krypton.Toolkit.KryptonPanel();
            this.lbUser = new Krypton.Toolkit.KryptonLabel();
            this.btnConfig = new Krypton.Toolkit.KryptonButton();
            this.imgUser = new Krypton.Toolkit.KryptonPictureBox();
            this.btnConta = new Krypton.Toolkit.KryptonButton();
            this.btnPerfil = new Krypton.Toolkit.KryptonButton();
            this.btnLimparFiltro = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).BeginInit();
            this.painelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.painelMetas)).BeginInit();
            this.painelMetas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelMenu)).BeginInit();
            this.painelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // painelFundo
            // 
            this.painelFundo.Controls.Add(this.painelMetas);
            this.painelFundo.Controls.Add(this.painelMenu);
            this.painelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelFundo.Location = new System.Drawing.Point(0, 0);
            this.painelFundo.Name = "painelFundo";
            this.painelFundo.Size = new System.Drawing.Size(1370, 749);
            this.painelFundo.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(226)))), ((int)(((byte)(193)))));
            this.painelFundo.TabIndex = 0;
            // 
            // painelMetas
            // 
            this.painelMetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelMetas.Controls.Add(this.panel1);
            this.painelMetas.Location = new System.Drawing.Point(375, 28);
            this.painelMetas.Name = "painelMetas";
            this.painelMetas.Padding = new System.Windows.Forms.Padding(50);
            this.painelMetas.Size = new System.Drawing.Size(970, 684);
            this.painelMetas.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.painelMetas.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnLimparFiltro);
            this.panel1.Controls.Add(this.btnEditarMeta);
            this.panel1.Controls.Add(this.tabela);
            this.panel1.Controls.Add(this.lbBoasVindas);
            this.panel1.Controls.Add(this.btnNovaMeta);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Controls.Add(this.calendario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 584);
            this.panel1.TabIndex = 17;
            // 
            // btnEditarMeta
            // 
            this.btnEditarMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarMeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarMeta.Location = new System.Drawing.Point(634, 423);
            this.btnEditarMeta.Name = "btnEditarMeta";
            this.btnEditarMeta.Size = new System.Drawing.Size(236, 43);
            this.btnEditarMeta.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnEditarMeta.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnEditarMeta.StateCommon.Border.Rounding = 10F;
            this.btnEditarMeta.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnEditarMeta.TabIndex = 17;
            this.btnEditarMeta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEditarMeta.Values.Text = "Editar Meta";
            this.btnEditarMeta.Click += new System.EventHandler(this.btnEditarMeta_Click);
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabela.AutoGenerateColumns = false;
            this.tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Descricao,
            this.kryptonDataGridViewTextBoxColumn4,
            this.PrevConclusao,
            this.status});
            this.tabela.DataSource = this.metasBindingSource;
            this.tabela.Location = new System.Drawing.Point(0, 88);
            this.tabela.Name = "tabela";
            this.tabela.RowHeadersVisible = false;
            this.tabela.Size = new System.Drawing.Size(605, 496);
            this.tabela.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.tabela.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.tabela.StatePressed.HeaderColumn.Border.Rounding = 10F;
            this.tabela.StatePressed.HeaderRow.Border.Rounding = 10F;
            this.tabela.StateSelected.HeaderColumn.Border.Rounding = 10F;
            this.tabela.StateSelected.HeaderRow.Border.Rounding = 10F;
            this.tabela.StateTracking.HeaderColumn.Border.Rounding = 10F;
            this.tabela.StateTracking.HeaderRow.Border.Rounding = 10F;
            this.tabela.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 46;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // kryptonDataGridViewTextBoxColumn4
            // 
            this.kryptonDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kryptonDataGridViewTextBoxColumn4.DataPropertyName = "DataCriacao";
            this.kryptonDataGridViewTextBoxColumn4.HeaderText = "Data de criação";
            this.kryptonDataGridViewTextBoxColumn4.Name = "kryptonDataGridViewTextBoxColumn4";
            this.kryptonDataGridViewTextBoxColumn4.ReadOnly = true;
            this.kryptonDataGridViewTextBoxColumn4.Visible = false;
            // 
            // PrevConclusao
            // 
            this.PrevConclusao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrevConclusao.DataPropertyName = "DataConclusao";
            this.PrevConclusao.HeaderText = "Previsão de conclusão";
            this.PrevConclusao.Name = "PrevConclusao";
            this.PrevConclusao.ReadOnly = true;
            this.PrevConclusao.Width = 200;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.status.DefaultCellStyle = dataGridViewCellStyle2;
            this.status.FalseValue = null;
            this.status.HeaderText = "status";
            this.status.IndeterminateValue = null;
            this.status.Name = "status";
            this.status.TrueValue = null;
            this.status.Width = 48;
            // 
            // metasBindingSource
            // 
            this.metasBindingSource.DataSource = typeof(ProjetoPI.Models.Metas.Metas);
            // 
            // lbBoasVindas
            // 
            this.lbBoasVindas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBoasVindas.AutoSize = false;
            this.lbBoasVindas.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbBoasVindas.Location = new System.Drawing.Point(3, 18);
            this.lbBoasVindas.Name = "lbBoasVindas";
            this.lbBoasVindas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBoasVindas.Size = new System.Drawing.Size(864, 52);
            this.lbBoasVindas.StateCommon.Padding = new System.Windows.Forms.Padding(1);
            this.lbBoasVindas.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 27.75F, System.Drawing.FontStyle.Italic);
            this.lbBoasVindas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbBoasVindas.TabIndex = 16;
            this.lbBoasVindas.Values.Text = "Olá, qual a meta de hoje ?  ";
            // 
            // btnNovaMeta
            // 
            this.btnNovaMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaMeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaMeta.Location = new System.Drawing.Point(634, 360);
            this.btnNovaMeta.Name = "btnNovaMeta";
            this.btnNovaMeta.Size = new System.Drawing.Size(236, 43);
            this.btnNovaMeta.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnNovaMeta.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnNovaMeta.StateCommon.Border.Rounding = 10F;
            this.btnNovaMeta.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovaMeta.TabIndex = 4;
            this.btnNovaMeta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNovaMeta.Values.Text = "Adicionar Nova Meta";
            this.btnNovaMeta.Click += new System.EventHandler(this.btnNovaMeta_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.CueHint.CueHintText = "Buscar metas";
            this.txtBusca.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.txtBusca.Location = new System.Drawing.Point(634, 88);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(236, 42);
            this.txtBusca.StateActive.Border.Rounding = 40F;
            this.txtBusca.StateCommon.Border.Rounding = 20F;
            this.txtBusca.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // calendario
            // 
            this.calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calendario.Location = new System.Drawing.Point(634, 150);
            this.calendario.Name = "calendario";
            this.calendario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.calendario.Size = new System.Drawing.Size(236, 190);
            this.calendario.StateCommon.Border.Rounding = 10F;
            this.calendario.StateDisabled.Border.Rounding = 20F;
            this.calendario.TabIndex = 12;
            this.calendario.TodayDate = new System.DateTime(2025, 4, 29, 19, 20, 6, 0);
            // 
            // painelMenu
            // 
            this.painelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.painelMenu.Controls.Add(this.lbUser);
            this.painelMenu.Controls.Add(this.btnConfig);
            this.painelMenu.Controls.Add(this.imgUser);
            this.painelMenu.Controls.Add(this.btnConta);
            this.painelMenu.Controls.Add(this.btnPerfil);
            this.painelMenu.Location = new System.Drawing.Point(31, 28);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(325, 684);
            this.painelMenu.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.painelMenu.TabIndex = 0;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = false;
            this.lbUser.Location = new System.Drawing.Point(3, 178);
            this.lbUser.MaximumSize = new System.Drawing.Size(319, 36);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(319, 36);
            this.lbUser.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbUser.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbUser.TabIndex = 0;
            this.lbUser.Values.Text = "Batman";
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Location = new System.Drawing.Point(95, 441);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(133, 43);
            this.btnConfig.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnConfig.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnConfig.StateCommon.Border.Rounding = 10F;
            this.btnConfig.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConfig.Values.Text = "Configurações";
            // 
            // imgUser
            // 
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(101, 52);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(121, 120);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 0;
            this.imgUser.TabStop = false;
            // 
            // btnConta
            // 
            this.btnConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConta.Location = new System.Drawing.Point(95, 363);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(133, 43);
            this.btnConta.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnConta.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnConta.StateCommon.Border.Rounding = 10F;
            this.btnConta.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnConta.TabIndex = 2;
            this.btnConta.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConta.Values.Text = "Minha Conta";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.Location = new System.Drawing.Point(95, 282);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(133, 43);
            this.btnPerfil.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnPerfil.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnPerfil.StateCommon.Border.Rounding = 10F;
            this.btnPerfil.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPerfil.Values.Text = "Meu Perfil";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltro.Location = new System.Drawing.Point(634, 541);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(236, 43);
            this.btnLimparFiltro.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnLimparFiltro.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnLimparFiltro.StateCommon.Border.Rounding = 10F;
            this.btnLimparFiltro.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimparFiltro.TabIndex = 18;
            this.btnLimparFiltro.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimparFiltro.Values.Text = "Adicionar Nova Meta";
            this.btnLimparFiltro.Visible = false;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.painelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Metas - Seu software de gerenciamento de metas!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).EndInit();
            this.painelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.painelMetas)).EndInit();
            this.painelMetas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelMenu)).EndInit();
            this.painelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel painelFundo;
        private Krypton.Toolkit.KryptonPanel painelMenu;
        private Krypton.Toolkit.KryptonPictureBox imgUser;
        private Krypton.Toolkit.KryptonPanel painelMetas;
        private Krypton.Toolkit.KryptonButton btnPerfil;
        private Krypton.Toolkit.KryptonButton btnConfig;
        private Krypton.Toolkit.KryptonButton btnConta;
        private Krypton.Toolkit.KryptonLabel lbUser;
        private Krypton.Toolkit.KryptonTextBox txtBusca;
        private Krypton.Toolkit.KryptonDataGridView tabela;
        private Krypton.Toolkit.KryptonMonthCalendar calendario;
        private System.Windows.Forms.BindingSource metasBindingSource;
        private Krypton.Toolkit.KryptonButton btnNovaMeta;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonLabel lbBoasVindas;
        private Krypton.Toolkit.KryptonButton btnEditarMeta;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Id;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Titulo;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Descricao;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn4;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PrevConclusao;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn status;
        private Krypton.Toolkit.KryptonButton btnLimparFiltro;
    }
}