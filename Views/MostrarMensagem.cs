﻿using System;
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
    public partial class MostrarMensagem: Form
    {
        public MostrarMensagem(string mensagem)
        {
            InitializeComponent();
            lbMensagem.Text = mensagem;
        }
    }
}
