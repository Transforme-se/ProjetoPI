using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private async Task testeAnimacao(int targetX)
        {
            int durationMs = 200; // Duração da animação
            int framesPerSecond = 120; //FPS
            int delay = 1000 / framesPerSecond; //Calculo para manter o FPS
            int initialX = pictureBox1.Location.X; //Posição inicial
            int distance = targetX - initialX; //Distancia entre inicial e final
            int totalFrames = (int)Math.Ceiling(durationMs / (1000.0 / framesPerSecond)); //Quantos frames

            for (int frame = 0; frame <= totalFrames; frame++)
            {
                float progress = (float)frame / totalFrames; //Progreção da animação
                float easedProgress = (float)Math.Pow(progress, 0.5); //"Suavizar" animação 
                int currentX = initialX + (int)(distance * easedProgress); //Posição durante a animação

                pictureBox1.Location = new Point(currentX, pictureBox1.Location.Y); //Movimenta a imagem
                await Task.Delay(delay);
            }

            pictureBox1.Location = new Point(targetX, pictureBox1.Location.Y); //Garante que ela fique na posição final

        }

        private void button1_Click(object sender, EventArgs e)
        {
            testeAnimacao(tableLayoutPanel1.Width - pictureBox1.Width+12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testeAnimacao(12);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Height = tableLayoutPanel1.Height;
            pictureBox1.Width = tableLayoutPanel1.Width/2;
            pictureBox1.Location = new Point(12, 12);
        }
    }
}
