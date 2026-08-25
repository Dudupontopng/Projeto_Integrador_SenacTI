using Projeto_Integrador.Banco.Repositories;
using System;
using System.Collections.Generic;
using Projeto_Integrador.Modelos;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador.Forms
{
    public partial class FrmPerfil : Form
    {
        private int? _idUsuario;
        private Usuario _usuarioAtual;
        private bool _modoSomenteLeitura;
        public FrmPerfil(int? idUsuario, bool modoSomenteLeitura = false)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _modoSomenteLeitura = modoSomenteLeitura;
        }

        public FrmPerfil(int? idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        private async void FrmPerfil_Load(object sender, EventArgs e)
        {
            if (_modoSomenteLeitura)
            {
                lnkAlterarSenha.Visible = false;
            }

            await CarregarPerfil();
        }

        private async Task CarregarPerfil()
        {
            if (!_idUsuario.HasValue) return;

            _usuarioAtual = await UsuarioRepository.ObterPorId(_idUsuario.Value);
            if (_usuarioAtual == null) return;

            lblNick.Text = _usuarioAtual.Nickname.ToUpper();
            string nivelUsuario = _usuarioAtual.Nivel ?? "iniciante";
            lblNivelProgresso.Text = $"NÍVEL {nivelUsuario.ToUpper()}";
            lblPontuacaoTotal.Text = $"Pontuação total: {_usuarioAtual.PontuacaoTotal}";
            lblAcertos.Text = $"Número de acertos: {_usuarioAtual.AcertosTotais}";
            lblPerguntasRespondidas.Text = $"Número de perguntas respondidas: {_usuarioAtual.PerguntasRespondidas}";

            var temaDominante = await UsuarioRepository.ObterTemaDominante(_idUsuario.Value);
            lblTemaDominante.Text = temaDominante != null
                ? $"Tema dominante: {temaDominante.Tema} ({temaDominante.Quantidade} acertos)"
                : "Tema dominante: Nenhum jogo registrado";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkHistorico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Abrindo Histórico...", "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_usuarioAtual == null)
            {
                MessageBox.Show("Dados do usuário não foram carregados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmEsquecMinhaSenha telaAlterarSenha = new FrmEsquecMinhaSenha(_usuarioAtual);

            this.Hide();
            telaAlterarSenha.ShowDialog();
            this.Show();
        }

        private void lnkConquistas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmConquistas frmConquistas = new FrmConquistas(_idUsuario);

            frmConquistas.ShowDialog();
        }
    }
}
