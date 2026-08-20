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
        private int pontosTotais = 0;
        public FrmPerguntaAlternativas(int? idUsuario = null)
        {
            InitializeComponent();
            _idUsuario = idUsuario;


        }

        private async void FrmPerguntaAlternativas_Load(object sender, EventArgs e)
        {
            perguntasSorteadas = await PerguntaRepository.ObterPerguntasQuiz();
            lblNumeroPergunta.Text = $"Pergunta {indiceAtual + 1}";
            var perguntaAtual = perguntasSorteadas[indiceAtual];
            lblPontosPergunta.Text = $"{perguntaAtual.Pontuacao}";
            lblNumeroPergunta.Text = $"Pergunta {indiceAtual + 1}";
            ExibirPerguntaAtual();
           

            await ExibirAlternativas();
            usuario = await UsuarioRepository.ObterPorId(_idUsuario);
           
            lblPontosPergunta.Text = $"{perguntaAtual.Pontuacao}";


        }
        private void ExibirPerguntaAtual()
        {
            var perguntaAtual = perguntasSorteadas[indiceAtual];
            lblEnunciado.Text = perguntaAtual.Enunciado;
            lblEnunciado.Left = (this.ClientSize.Width - lblEnunciado.Width) / 2;
            lblPontosPergunta.Left = (this.ClientSize.Width - lblPontosPergunta.Width) / 2;
            lblNumeroPergunta.Left = (this.ClientSize.Width - lblNumeroPergunta.Width) / 2;

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
            btnAlternativa1.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa2.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa3.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa4.BackColor = Color.FromArgb(64, 64, 64);


            btnClicado.BackColor = Color.LightSkyBlue;


            alternativaSelecionada = btnClicado;
        }
        private async void btnProximo_Click_1(object sender, EventArgs e)
        {
            if (alternativaSelecionada == null)
            {
                MessageBox.Show("Por favor, selecione uma alternativa antes de continuar!");
                return;
            }
            bool isCorreta = (bool)alternativaSelecionada.Tag;
            var perguntaAtual = perguntasSorteadas[indiceAtual];
            int pontosGanhosNaPergunta = 0;
            if (isCorreta)
            {
                int pontosBase = perguntaAtual.Pontuacao;
                double multiplicadorBase = 1.0;
                if (usuario.AcertosConsecutivosAtuais >= 5)
                {
                    multiplicadorBase = 1.2;
                }
                else if (usuario.AcertosConsecutivosAtuais >= 3)
                {
                    multiplicadorBase = 1.10;
                }
                pontosGanhosNaPergunta = (int)Math.Round(pontosBase * multiplicadorBase);
                usuario.PontuacaoTotal += pontosGanhosNaPergunta;
                usuario.AcertosTotais++;
                usuario.AcertosConsecutivosAtuais++;
                if (usuario.AcertosConsecutivosAtuais > usuario.MaiorSequenciaAcertos)
                {
                    usuario.MaiorSequenciaAcertos = usuario.AcertosConsecutivosAtuais;
                }
            }
            else
            {
                usuario.AcertosConsecutivosAtuais = 0;

            }
            usuario.PerguntasRespondidas++;
            pontosTotais += pontosGanhosNaPergunta;
            await HistoricoRepository.RegistrarResposta(usuario.Id, perguntaAtual.Id, perguntaAtual.Tema, isCorreta, pontosGanhosNaPergunta);
            alternativaSelecionada.BackColor = Color.FromArgb(64, 64, 64);
            alternativaSelecionada = null;
            proximo();
        }

        private async void proximo()
        {

            indiceAtual++;


            if (indiceAtual < 10)
            {
                var perguntaAtual = perguntasSorteadas[indiceAtual];
                lblNumeroPergunta.Text = $"Pergunta {indiceAtual + 1}";
                
                lblPontosPergunta.Text = $"{perguntaAtual.Pontuacao}";
               
                ExibirPerguntaAtual();
                await ExibirAlternativas();
            }
            else
            {
                MessageBox.Show($"Quiz finalizado! voce obteve {pontosTotais} pontos!", "Quiz terminado!", MessageBoxButtons.OK);
                await UsuarioRepository.AtualizarUsuario(usuario.Id, usuario.Nivel, usuario.PontuacaoTotal, usuario.AcertosTotais, usuario.PerguntasRespondidas, usuario.MaiorSequenciaAcertos, usuario.AcertosConsecutivosAtuais, DateTime.Now);

                this.Close();
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

        private void lblNumeroPergunta_Click(object sender, EventArgs e)
        {

        }

        private void lblPontosPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}
