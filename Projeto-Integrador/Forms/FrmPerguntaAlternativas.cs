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
            ExibirAlternativas();
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
            btnAlternativa2.Text = alterativas[1].Texto;
            btnAlternativa3.Text = alterativas[2].Texto;
            btnAlternativa4.Text = alterativas[3].Texto;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            indiceAtual++;
            if(indiceAtual < 10)
            {
                ExibirPerguntaAtual();
            }
            else
            {
               MessageBox.Show("Quiz finalizado! Vamos calcular seus pontos!", "Quiz finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
