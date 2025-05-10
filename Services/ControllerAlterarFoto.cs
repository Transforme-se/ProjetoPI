using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace ProjetoPI.Services
{
    class ControllerAlterarFoto
    {
        public static void AtualizarFoto(KryptonPictureBox pictureBox, int foto)
        {
            switch (foto)
            {
                case 0:
                    pictureBox.Image = global::ProjetoPI.Properties.Resources.iconePerfil0;
                    break;
                case 1:
                    pictureBox.Image = global::ProjetoPI.Properties.Resources.iconePerfil1;
                    break;
                case 2:
                    pictureBox.Image = global::ProjetoPI.Properties.Resources.iconePerfil2;
                    break;
                case 3:
                    pictureBox.Image = global::ProjetoPI.Properties.Resources.iconePerfil3;
                    break;
                case 4:
                    pictureBox.Image = global::ProjetoPI.Properties.Resources.iconePerfil4;
                    break;
            }
        }
    }
}
