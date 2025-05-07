namespace ProjetoPI.Views
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.CueHint.CueHintText = "Digite o nome da Metas";
            this.txtUsuario.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtUsuario.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtUsuario.Location = new System.Drawing.Point(42, 69);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 42);
            this.txtUsuario.StateActive.Border.Rounding = 40F;
            this.txtUsuario.StateCommon.Border.Rounding = 20F;
            this.txtUsuario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonTextBox1.CueHint.CueHintText = "Descrição";
            this.kryptonTextBox1.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonTextBox1.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonTextBox1.Location = new System.Drawing.Point(42, 140);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(250, 42);
            this.kryptonTextBox1.StateActive.Border.Rounding = 40F;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.kryptonTextBox1.TabIndex = 6;
            this.kryptonTextBox1.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.kryptonTextBox1.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonTextBox2.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonTextBox2.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonTextBox2.Location = new System.Drawing.Point(42, 260);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(250, 42);
            this.kryptonTextBox2.StateActive.Border.Rounding = 40F;
            this.kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            this.kryptonTextBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.kryptonTextBox2.TabIndex = 7;
            this.kryptonTextBox2.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.kryptonTextBox2.TextChanged += new System.EventHandler(this.kryptonTextBox2_TextChanged);
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonTextBox3.CueHint.CueHintText = "Insira seu usuário";
            this.kryptonTextBox3.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonTextBox3.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonTextBox3.Location = new System.Drawing.Point(355, 302);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(132, 42);
            this.kryptonTextBox3.StateActive.Border.Rounding = 40F;
            this.kryptonTextBox3.StateCommon.Border.Rounding = 20F;
            this.kryptonTextBox3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(40, -1, -1, -1);
            this.kryptonTextBox3.TabIndex = 8;
            this.kryptonTextBox3.Text = "SALVAR";
            this.kryptonTextBox3.ToolTipValues.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.kryptonTextBox3.TextChanged += new System.EventHandler(this.kryptonTextBox3_TextChanged);
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(433, 80);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(75, 21);
            this.kryptonDateTimePicker1.TabIndex = 9;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 411);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.kryptonTextBox3);
            this.Controls.Add(this.kryptonTextBox2);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
    }
}