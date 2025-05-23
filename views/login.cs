﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using ProjetoPI.Controllers;
using ProjetoPI.Models.Usuarios;
using ProjetoPI.Services;

namespace ProjetoPI.Views
{
    public partial class Login : Form
    {
        ControllerLoginCadastro controllerLoginCadastro;

        public Login()
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            AutenticacaoService autenticacaoService = new AutenticacaoService(dataBaseService);
            UsuariosRepository usuariosRepository = new UsuariosRepository(dataBaseService);
            controllerLoginCadastro = new ControllerLoginCadastro(autenticacaoService, usuariosRepository);

        }

        private void login_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelEsquerdo, 30);
            ArredondarPainel.Arredondar(painelDireito, 30);
            ArredondarPainel.Arredondar(painel1, 30);

            try
            {
                using (var dbService = new DataBaseService())
                {
                    dbService.OpenConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var mover = new PainelLogin();
            mover.MoverPainel(painel1, 688);
            LimparCamposCadastro();
            txtNome.Focus();
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            var mover = new PainelLogin();
            mover.MoverPainel(painel1, 13);
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios user = controllerLoginCadastro.Login(txtUsuario.Text, txtSenha.Text);
                if (user != null)
                {
                    SessaoUsuario.Login(user);
                    MessageBox.Show($"Bem-vindo(a), {user.Nome}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indica que o login foi bem-sucedido
                    this.Close();
                }
                else
                {
                    LimparLogin();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao autenticar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                Console.WriteLine("Iniciando cadastro de usuário..");
                var user = controllerLoginCadastro.Cadastrar(txtNome.Text, txtUsuarioCad.Text, txtSenhaCad.Text, txtSenhaConf.Text);
                if (user)
                {
                    Console.WriteLine("Usuário cadastrado com sucesso!");
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCamposCadastro();
                    var mover = new PainelLogin();
                    mover.MoverPainel(painel1, 13);
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCamposCadastro()
        {
            txtNome.Clear();
            txtUsuarioCad.Clear();
            txtSenhaCad.Clear();
            txtSenhaConf.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void LimparLogin()
        {
            txtSenha.Clear();
        }

        private void KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == txtSenha)
                    btnEntrar_Click(sender, e);
                if (sender == txtSenhaConf)
                    btnSalvar_Click(sender, e);

                if (sender == txtUsuario)
                    txtSenha.Focus();
                if (sender == txtNome)
                    txtUsuarioCad.Focus();
                if(sender == txtUsuarioCad)
                    txtSenhaCad.Focus();
                if (sender == txtSenhaCad)
                    txtSenhaConf.Focus();
            }
        }
    }
}
