using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI.Views
{
    class PainelLogin
    {
        public async void MoverPainel(Panel painel, int targetX)
        {
            int duracaoMs = 100; // Duração da animação
            int framesPorSegundo = 200; //FPS
            int delay = 1000 / framesPorSegundo; //Calculo para manter o FPS
            int inicialX = painel.Location.X; //Posição inicial
            int distancia = targetX - inicialX; //Distancia entre inicial e final
            int framesTotais = (int)Math.Ceiling(duracaoMs / (1000.0 / framesPorSegundo)); //Quantos frames

            for (int frame = 0; frame <= framesTotais; frame++)
            {
                float progresso = (float)frame / framesTotais; //Progreção da animação
                float raizProgresso = (float)Math.Pow(progresso, 0.5); //"Suavizar" animação 
                int atualX = inicialX + (int)(distancia * raizProgresso); //Posição durante a animação

                painel.Location = new Point(atualX, painel.Location.Y); //Movimenta a imagem
                await Task.Delay(delay);
            }

            painel.Location = new Point(targetX, painel.Location.Y); //Garante que ela fique na posição final

        }
    }
}
