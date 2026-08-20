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
    public partial class FrmPerfil : Form
    {
        private int? _idUsuario;
        public FrmPerfil(int? idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }
        public class Usuario
        {
            public string Nickname { get; set; }
            public int Nivel { get; set; }
            public int ProgressoXp { get; set; }
            public int PontuacaoTotal { get; set; }
            public int NumeroAcertos { get; set; }
            public int PerguntasRespondidas { get; set; }
            public string TemaDominante { get; set; }
        }
        private async void FrmPerfil_Load(object sender, EventArgs e)
        {
            await CarregarPerfil();
        }
        private async Task CarregarPerfil()
        {
            
                var _usuarioAtual = await UsuarioRepository.ObterPorId(_idUsuario.Value);
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

        private void lnkConquistas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Abrindo Conquistas...", "Conquistas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkHistorico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Abrindo Histórico...", "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
