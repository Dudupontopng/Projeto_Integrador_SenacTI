using Projeto_Integrador.Banco.Repositories;
using Projeto_Integrador.Modelos;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador.Forms
{
    public partial class FrmRanking : Form
    {
        public FrmRanking()
        {
            InitializeComponent();

            this.Load += FrmRanking_Load;
            btnSair.Click += btnSair_Click;
        }

        private async void FrmRanking_Load(object sender, EventArgs e)
        {
            await CarregarRanking();
        }

        private async Task CarregarRanking()
        {
            var ranking = await UsuarioRepository.ObterRanking();

            dgvRanking.DataSource = new BindingList<Usuario>(ranking.ToList());

            string[] colunasOcultas = { "Id", "Nome", "DataNascimento", "Senha", "Nivel", "MaiorSequenciaAcertos", "AcertosConsecutivosAtuais", "UltimoAcesso" };

            foreach (string col in colunasOcultas)
            {
                if (dgvRanking.Columns[col] != null)
                    dgvRanking.Columns[col].Visible = false;
            }

            if (dgvRanking.Columns["Posicao"] != null) { dgvRanking.Columns["Posicao"].HeaderText = "Posição"; dgvRanking.Columns["Posicao"].DisplayIndex = 0; }
            if (dgvRanking.Columns["Nickname"] != null) { dgvRanking.Columns["Nickname"].HeaderText = "Jogador"; dgvRanking.Columns["Nickname"].DisplayIndex = 1; }
            if (dgvRanking.Columns["PontuacaoTotal"] != null) { dgvRanking.Columns["PontuacaoTotal"].HeaderText = "Pontuação"; dgvRanking.Columns["PontuacaoTotal"].DisplayIndex = 2; }
            if (dgvRanking.Columns["AcertosTotais"] != null) { dgvRanking.Columns["AcertosTotais"].HeaderText = "Acertos"; dgvRanking.Columns["AcertosTotais"].DisplayIndex = 3; }
            if (dgvRanking.Columns["PerguntasRespondidas"] != null) { dgvRanking.Columns["PerguntasRespondidas"].HeaderText = "Respondidas"; dgvRanking.Columns["PerguntasRespondidas"].DisplayIndex = 4; }
            if (dgvRanking.Columns["TemaDominante"] != null) { dgvRanking.Columns["TemaDominante"].HeaderText = "Tema Dominante"; dgvRanking.Columns["TemaDominante"].DisplayIndex = 5; }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (dgvRanking.CurrentRow == null)
            {
                MessageBox.Show("Selecione um jogador na tabela para ver o perfil.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioSelecionado = (Usuario)dgvRanking.CurrentRow.DataBoundItem;

            FrmPerfil telaPerfil = new FrmPerfil(usuarioSelecionado.Id, modoSomenteLeitura: true);

            this.Hide();
            telaPerfil.ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNumeroPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}