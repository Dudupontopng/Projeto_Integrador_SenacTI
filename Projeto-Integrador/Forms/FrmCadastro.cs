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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private async void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtBoxNome.Text;
            string nickname = txtBoxUsuario.Text;
            string senha = txtBoxSenha.Text;
            string confirmarSenha = txtBoxConfirmarSenha.Text;
            DateTime dataNascimento = datePickerNascimento.Value;
            var usuario = new Usuario(nome, nickname, senha, dataNascimento);
            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();
            var contexto = new ValidationContext(usuario);
            if (senha == confirmarSenha)
            {
                Validator.TryValidateObject(usuario, contexto, listaDeErros, true);
                if (listaDeErros.Count > 0)
                {
                    foreach (var erro in listaDeErros)
                    {
                        stringBuilder.Append(erro.ErrorMessage + "\n");
                    }
                    lblErrors.Text = stringBuilder.ToString();
                }
                else
                {
                    await UsuarioRepository.Adicionar(usuario);

                    this.Close();
                }
            }
            else
            {
                lblErrors.Text = "As senhas não se coincidem";
            }
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
