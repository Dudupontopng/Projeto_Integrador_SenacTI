using Projeto_Integrador.Banco.Configuracao;
using Projeto_Integrador.Banco.Repositories;
using Projeto_Integrador.Modelos;
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
    public partial class FrmPerguntaAlternativas : Form
    {
        private readonly int? _idUsuario;
        private readonly int? _idPergunta;
        private List<Pergunta> perguntasSorteadas;
        private int indiceAtual = 0;
        private Usuario usuario;
        private Button alternativaSelecionada = null;
        public FrmPerguntaAlternativas(int? idUsuario = null)
        {
            InitializeComponent();
            _idUsuario = idUsuario;


        }

        private async void FrmPerguntaAlternativas_Load(object sender, EventArgs e)
        {
            perguntasSorteadas = await PerguntaRepository.ObterPerguntasQuiz();
            ExibirPerguntaAtual();
            lblNumeroPergunta.Text = $"Pergunta {indiceAtual + 1}";
            await ExibirAlternativas();
            usuario = await UsuarioRepository.ObterPorId(_idUsuario);
            

        }
        private void ExibirPerguntaAtual()
        {
            var perguntaAtual = perguntasSorteadas[indiceAtual];
            lblEnunciado.Text = perguntaAtual.Enunciado;

        }
        private async Task ExibirAlternativas()
        {
            var perguntaAtual = perguntasSorteadas[indiceAtual];
            int idPergunta = perguntaAtual.Id;
            var alterativas = await AlternativaRepository.ObterAlternativas(idPergunta);
            btnAlternativa1.Text = alterativas[0].Texto;
            btnAlternativa1.Tag = alterativas[0].IsCorreta;
            btnAlternativa2.Text = alterativas[1].Texto;
            btnAlternativa2.Tag = alterativas[1].IsCorreta;
            if (alterativas.Count == 4)
            {
                btnAlternativa3.Visible = true;
                btnAlternativa4.Visible = true;
                btnAlternativa3.Text = alterativas[2].Texto;
                btnAlternativa3.Tag = alterativas[2].IsCorreta;
                btnAlternativa4.Text = alterativas[3].Texto;
                btnAlternativa4.Tag = alterativas[3].IsCorreta;
            }
            else
            {
                btnAlternativa3.Visible = false;
                btnAlternativa4.Visible = false;
            }

        }


        private void MarcarAlternativa(Button btnClicado)
        {
            btnAlternativa1.BackColor = Color.FromArgb(64, 64, 64) ;
            btnAlternativa2.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa3.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa4.BackColor = Color.FromArgb(64, 64, 64);


            btnClicado.BackColor = Color.LightSkyBlue;


            alternativaSelecionada = btnClicado;
        }
        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            if(alternativaSelecionada == null)
            {
                MessageBox.Show("Por favor, selecione uma alternativa antes de continuar!");
                return;
            }
            bool isCorreta = (bool)alternativaSelecionada.Tag;
            if (isCorreta)
            {

            }
            else
            {

            }
            alternativaSelecionada.BackColor = Color.FromArgb(64, 64, 64);
            alternativaSelecionada = null;
            proximo();
        }
        private async void proximo()
        {
            indiceAtual++;
            if (indiceAtual < 10)
            {
                lblNumeroPergunta.Text = $"Pergunta {indiceAtual + 1}";
                ExibirPerguntaAtual();
                await ExibirAlternativas();
            }
            else
            {
                MessageBox.Show("Quiz finalizado! Vamos calcular seus pontos.", "Quiz terminado!", MessageBoxButtons.OK);
            }
        }
        private void btnAlternativa1_Click(object sender, EventArgs e)
        {
            MarcarAlternativa(btnAlternativa1);
        }

        private void btnAlternativa2_Click(object sender, EventArgs e)
        {
            MarcarAlternativa(btnAlternativa2);
        }

        private void btnAlternativa3_Click(object sender, EventArgs e)
        {
            MarcarAlternativa(btnAlternativa3);
        }

        private void btnAlternativa4_Click(object sender, EventArgs e)
        {
            MarcarAlternativa(btnAlternativa4);
        }
    }
}
