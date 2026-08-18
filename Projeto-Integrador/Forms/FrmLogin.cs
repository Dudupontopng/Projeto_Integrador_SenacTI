using Projeto_Integrador.Banco.Repositories;
using Projeto_Integrador.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string nickname = txtBoxUsuario.Text;
            string senha = txtBoxSenha.Text;
            var usuario = await UsuarioRepository.ObterPorUsuario(nickname);
            int id = usuario.Id;
            if (usuario != null && usuario.validarSenha(senha))
            {
                txtBoxSenha.Clear();
                this.Hide();
                new FrmTelaComeco(id).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha não encontrada ou invalida",
                    "Erro ao fazer login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblLinkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FrmCadastro().ShowDialog();
        }
    }
}
