namespace ProjetoPI.Views
{
    partial class MostrarMensagem
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
            this.lblMensagem = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Location = new System.Drawing.Point(173, 89);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(71, 20);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Values.Text = "Mensagem";
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // MostrarMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 234);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensagem);
            this.Name = "MostrarMensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarMensagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblMensagem;
    }
}