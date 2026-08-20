using Projeto_Integrador.Modelos;
using Projeto_Integrador.Banco.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador.Forms
{
    public partial class FrmEsquecMinhaSenha : Form
    {
        private Usuario _usuarioLogado;

        public FrmEsquecMinhaSenha()
        {
            InitializeComponent();
        }

        public FrmEsquecMinhaSenha(Usuario usuario) : this()
        {
            _usuarioLogado = usuario;
        }

        private async void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                // Nomes ajustados de acordo com seu Designer
                string senhaAtual = txtBoxSenhaAtual.Text;
                string novaSenha = txtBoxSenha.Text;
                string confirmarSenha = txtBoxConfirmarSenha.Text;

                if (string.IsNullOrWhiteSpace(senhaAtual) ||
                    string.IsNullOrWhiteSpace(novaSenha) ||
                    string.IsNullOrWhiteSpace(confirmarSenha))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_usuarioLogado != null && !_usuarioLogado.validarSenha(senhaAtual))
                {
                    MessageBox.Show("A 'Senha atual' informada está incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (novaSenha != confirmarSenha)
                {
                    MessageBox.Show("A 'Nova senha' e a 'Confirmação' não coincidem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _usuarioLogado.setSenhaNova(novaSenha);

                await UsuarioRepository.AlterarSenha(_usuarioLogado.Id, _usuarioLogado.Senha);

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar senha: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
