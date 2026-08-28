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
    public partial class FrmGabarito : Form
    {
        private int _pontosGanhos;
        private List<Pergunta> _perguntasDaPartida;
        private List<bool> _resultadosDaPartida;
        public FrmGabarito(int pontosGanhos, List<Pergunta> perguntasDaPartida, List<bool> resultadosDaPartida)
        {
            InitializeComponent();
            _pontosGanhos = pontosGanhos;
            _perguntasDaPartida = perguntasDaPartida;
            _resultadosDaPartida = resultadosDaPartida;
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FrmGabarito_Load(object sender, EventArgs e)
        {
            lblPontuacaoFinal.Text = $"Parabéns! Você ganhou {_pontosGanhos} pontos nesta partida!";

            dgvGabarito.Columns.Add("Enunciado", "Pergunta");
            dgvGabarito.Columns.Add("Correta", "Resposta Correta");
            dgvGabarito.Columns.Add("Erradas", "Outras Alternativas");

            dgvGabarito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGabarito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvGabarito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            await CarregarRespostas();
        }
        private async Task CarregarRespostas()
        {
            
            for (int i = 0; i < _perguntasDaPartida.Count; i++)
            {
                var pergunta = _perguntasDaPartida[i];
                bool acertou = _resultadosDaPartida[i];

                var alternativas = await AlternativaRepository.ObterAlternativas(pergunta.Id);

                string respostaCorreta = "";
                List<string> respostasErradas = new List<string>();

                foreach (var alt in alternativas)
                {
                    if (alt.IsCorreta)
                    {
                        respostaCorreta = alt.Texto;
                    }
                    else
                    {
                        respostasErradas.Add(alt.Texto);
                    }
                }

                string textoErradas = string.Join(" / ", respostasErradas);

                
                int indexLinha = dgvGabarito.Rows.Add(pergunta.Enunciado, respostaCorreta, textoErradas);

               
                if (acertou)
                {
                    dgvGabarito.Rows[indexLinha].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dgvGabarito.Rows[indexLinha].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }

            
            dgvGabarito.ClearSelection();
        }
    }
}
