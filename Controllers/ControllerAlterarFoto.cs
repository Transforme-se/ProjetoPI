using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ProjetoPI.Services
{
    class ControllerAlterarFoto
    {
        public static void AtualizarPerfil(KryptonPictureBox pictureBox, int foto)
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
        public static void AtualizarPapelDeParede(Krypton.Toolkit.KryptonPanel kryptonPanel, int fundo)
        {
            kryptonPanel.BackgroundImageLayout = ImageLayout.Stretch;
            switch (fundo)
            {
                case 0:
                    kryptonPanel.StateCommon.Image = global::ProjetoPI.Properties.Resources.imgFundoPadão;
                    break;
                case 1:
                    kryptonPanel.StateCommon.Image = global::ProjetoPI.Properties.Resources.imgFundo1;
                    break;
                case 2:
                    kryptonPanel.StateCommon.Image = global::ProjetoPI.Properties.Resources.imgFundo2;
                    break;
                case 3:
                    kryptonPanel.StateCommon.Image = global::ProjetoPI.Properties.Resources.imgFundo3;
                    break;
                case 4:
                    kryptonPanel.StateCommon.Image = global::ProjetoPI.Properties.Resources.imgFundo4;
                    break;
                case 5:
                    kryptonPanel.StateCommon.Image = global::ProjetoPI.Properties.Resources.imgFundo5;
                    break;
            }
        }
    }
}
