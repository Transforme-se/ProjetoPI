using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI.Views
{
    public partial class perfil : Form
    {
        public perfil()
        {
            InitializeComponent();
        }

        private void painelFundo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void perfil_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelFundo, 30);
            ArredondarPainel.Arredondar(painelPerfil, 30);
        }
            
    }
}
