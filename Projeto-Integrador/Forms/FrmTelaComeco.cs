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
    public partial class FrmTelaComeco : Form
    {
        private readonly int? _idUsuario;
        private readonly bool? _ehAdmin;
        int idusuario;
        public FrmTelaComeco(int? idUsuario = null, bool? ehAdmin = null)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _ehAdmin = ehAdmin;
            idusuario = _idUsuario ?? 0;
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            var usuario = await UsuarioRepository.ObterPorId(_idUsuario);
            if (usuario.UltimoAcesso.HasValue && usuario.UltimoAcesso.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Você já jogou o quiz de hoje! Volte amanhã para jogar novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                this.Hide();
                new FrmPerguntaAlternativas(_idUsuario).ShowDialog();
                this.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPerfil(_idUsuario).ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            FrmRanking telaRanking = new FrmRanking();

            this.Hide();
            telaRanking.ShowDialog();
            this.Show();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HistoricoForm(idusuario).ShowDialog();
            this.Show();
        }






        private void FrmTelaComeco_Load(object sender, EventArgs e)
        {
            if ((bool)_ehAdmin)
            {
                btnCriarPergunta.Visible = true;
                btnIniciar.Visible = false;
                btnPerfil.Visible = false;
                btnHistorico.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void btnCriarPergunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCadastrarPergunta().ShowDialog();
            this.Show();

        }

        private async void btnModoInfinito_Click(object sender, EventArgs e)
        {
            var usuario = await UsuarioRepository.ObterPorId(_idUsuario);




            this.Hide();

            new FrmPerguntaAlternativas(_idUsuario, true).ShowDialog();

            this.Show();

        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmTelaLoja(idusuario).ShowDialog();
            this.Show();
        }
    }
}

