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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painelFundo = new Krypton.Toolkit.KryptonPanel();
            this.painelMetas = new Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovaMeta = new Krypton.Toolkit.KryptonButton();
            this.tabela = new Krypton.Toolkit.KryptonDataGridView();
            this.calendario = new Krypton.Toolkit.KryptonMonthCalendar();
            this.txtBusca = new Krypton.Toolkit.KryptonTextBox();
            this.lbBoasVindas = new Krypton.Toolkit.KryptonLabel();
            this.painelMenu = new Krypton.Toolkit.KryptonPanel();
            this.lbUser = new Krypton.Toolkit.KryptonLabel();
            this.btnConfig = new Krypton.Toolkit.KryptonButton();
            this.imgUser = new Krypton.Toolkit.KryptonPictureBox();
            this.btnConta = new Krypton.Toolkit.KryptonButton();
            this.btnPerfil = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn2 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn3 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn4 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn5 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewCheckBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.metasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).BeginInit();
            this.painelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.painelMetas)).BeginInit();
            this.painelMetas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelMenu)).BeginInit();
            this.painelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // painelFundo
            // 
            this.painelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelFundo.Controls.Add(this.painelMetas);
            this.painelFundo.Controls.Add(this.painelMenu);
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
            this.painelMetas.Controls.Add(this.lbBoasVindas);
            this.painelMetas.Location = new System.Drawing.Point(375, 28);
            this.painelMetas.Name = "painelMetas";
            this.painelMetas.Size = new System.Drawing.Size(970, 684);
            this.painelMetas.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.painelMetas.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNovaMeta);
            this.panel1.Controls.Add(this.tabela);
            this.panel1.Controls.Add(this.calendario);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Location = new System.Drawing.Point(60, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 500);
            this.panel1.TabIndex = 17;
            // 
            // btnNovaMeta
            // 
            this.btnNovaMeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovaMeta.Location = new System.Drawing.Point(614, 281);
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
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.AutoGenerateColumns = false;
            this.tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kryptonDataGridViewTextBoxColumn1,
            this.kryptonDataGridViewTextBoxColumn2,
            this.kryptonDataGridViewTextBoxColumn3,
            this.kryptonDataGridViewTextBoxColumn4,
            this.kryptonDataGridViewTextBoxColumn5,
            this.kryptonDataGridViewCheckBoxColumn1});
            this.tabela.DataSource = this.metasBindingSource;
            this.tabela.Location = new System.Drawing.Point(3, 23);
            this.tabela.Name = "tabela";
            this.tabela.RowHeadersVisible = false;
            this.tabela.Size = new System.Drawing.Size(520, 457);
            this.tabela.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.tabela.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.tabela.StatePressed.HeaderColumn.Border.Rounding = 10F;
            this.tabela.StatePressed.HeaderRow.Border.Rounding = 10F;
            this.tabela.StateSelected.HeaderColumn.Border.Rounding = 10F;
            this.tabela.StateSelected.HeaderRow.Border.Rounding = 10F;
            this.tabela.StateTracking.HeaderColumn.Border.Rounding = 10F;
            this.tabela.StateTracking.HeaderRow.Border.Rounding = 10F;
            this.tabela.TabIndex = 9;
            this.tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellContentClick);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(614, 91);
            this.calendario.Name = "calendario";
            this.calendario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.calendario.SelectionEnd = new System.DateTime(2025, 4, 19, 0, 0, 0, 0);
            this.calendario.SelectionStart = new System.DateTime(2025, 4, 19, 0, 0, 0, 0);
            this.calendario.ShowToday = false;
            this.calendario.ShowTodayCircle = false;
            this.calendario.Size = new System.Drawing.Size(236, 164);
            this.calendario.StateCommon.Border.Rounding = 10F;
            this.calendario.StateDisabled.Border.Rounding = 20F;
            this.calendario.TabIndex = 12;
            this.calendario.TodayDate = new System.DateTime(2025, 4, 19, 0, 0, 0, 0);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBusca.CueHint.CueHintText = "Buscar metas";
            this.txtBusca.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.txtBusca.Location = new System.Drawing.Point(614, 23);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(236, 42);
            this.txtBusca.StateActive.Border.Rounding = 40F;
            this.txtBusca.StateCommon.Border.Rounding = 20F;
            this.txtBusca.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtBusca.TabIndex = 5;
            // 
            // lbBoasVindas
            // 
            this.lbBoasVindas.Location = new System.Drawing.Point(291, 25);
            this.lbBoasVindas.Name = "lbBoasVindas";
            this.lbBoasVindas.Size = new System.Drawing.Size(389, 52);
            this.lbBoasVindas.StateCommon.ShortText.Font = new System.Drawing.Font("Corbel Light", 27.75F, System.Drawing.FontStyle.Italic);
            this.lbBoasVindas.TabIndex = 16;
            this.lbBoasVindas.Values.Text = "Olá, qual a meta de hoje ?  ";
            this.lbBoasVindas.Click += new System.EventHandler(this.lbBoasVindas_Click);
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
            this.lbUser.BackColor = System.Drawing.Color.WhiteSmoke; // Define a cor de fundo
            this.lbUser.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel; // Desativa a transparência
            this.lbUser.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbUser.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbUser.TabIndex = 0;
            this.lbUser.Values.Text = "Batman";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            this.kryptonDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kryptonDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.kryptonDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            this.kryptonDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kryptonDataGridViewTextBoxColumn1.Visible = false;
            this.kryptonDataGridViewTextBoxColumn1.Width = 27;
            // 
            // kryptonDataGridViewTextBoxColumn2
            // 
            this.kryptonDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kryptonDataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.kryptonDataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.kryptonDataGridViewTextBoxColumn2.Name = "kryptonDataGridViewTextBoxColumn2";
            this.kryptonDataGridViewTextBoxColumn2.ReadOnly = true;
            this.kryptonDataGridViewTextBoxColumn2.Width = 67;
            // 
            // kryptonDataGridViewTextBoxColumn3
            // 
            this.kryptonDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kryptonDataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.kryptonDataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.kryptonDataGridViewTextBoxColumn3.Name = "kryptonDataGridViewTextBoxColumn3";
            this.kryptonDataGridViewTextBoxColumn3.ReadOnly = true;
            this.kryptonDataGridViewTextBoxColumn3.Width = 87;
            // 
            // kryptonDataGridViewTextBoxColumn4
            // 
            this.kryptonDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kryptonDataGridViewTextBoxColumn4.DataPropertyName = "DataCriacao";
            this.kryptonDataGridViewTextBoxColumn4.HeaderText = "DataCriacao";
            this.kryptonDataGridViewTextBoxColumn4.Name = "kryptonDataGridViewTextBoxColumn4";
            this.kryptonDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // kryptonDataGridViewTextBoxColumn5
            // 
            this.kryptonDataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kryptonDataGridViewTextBoxColumn5.DataPropertyName = "DataConclusao";
            this.kryptonDataGridViewTextBoxColumn5.HeaderText = "DataConclusao";
            this.kryptonDataGridViewTextBoxColumn5.Name = "kryptonDataGridViewTextBoxColumn5";
            this.kryptonDataGridViewTextBoxColumn5.ReadOnly = true;
            this.kryptonDataGridViewTextBoxColumn5.Width = 116;
            // 
            // kryptonDataGridViewCheckBoxColumn1
            // 
            this.kryptonDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kryptonDataGridViewCheckBoxColumn1.DataPropertyName = "status";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.kryptonDataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewCheckBoxColumn1.FalseValue = null;
            this.kryptonDataGridViewCheckBoxColumn1.HeaderText = "status";
            this.kryptonDataGridViewCheckBoxColumn1.IndeterminateValue = null;
            this.kryptonDataGridViewCheckBoxColumn1.Name = "kryptonDataGridViewCheckBoxColumn1";
            this.kryptonDataGridViewCheckBoxColumn1.TrueValue = null;
            this.kryptonDataGridViewCheckBoxColumn1.Width = 48;
            // 
            // metasBindingSource
            // 
            this.metasBindingSource.DataSource = typeof(ProjetoPI.Models.Metas.Metas);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.painelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Metas - Seu software de gerenciamento de metas!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.painelFundo)).EndInit();
            this.painelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.painelMetas)).EndInit();
            this.painelMetas.ResumeLayout(false);
            this.painelMetas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelMenu)).EndInit();
            this.painelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metasBindingSource)).EndInit();
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
        private Krypton.Toolkit.KryptonLabel lbBoasVindas;
        private System.Windows.Forms.BindingSource metasBindingSource;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn2;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn4;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn5;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn kryptonDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnNovaMeta;
    }
}