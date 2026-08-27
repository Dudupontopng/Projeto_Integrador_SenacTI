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
    public partial class FrmCadastrarPergunta : Form
    {
        public FrmCadastrarPergunta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnCadastrarPergunta_Click(object sender, EventArgs e)
        {
            string enunciado = txtBoxEnunciado.Text;
            string tipo = rbMultiplaEscolha.Checked ? "Multipla Escolha" : "Verdadeiro ou Falso";
            string nivel = rbIniciante.Checked ? "Iniciante" : rbFacil.Checked ? "Fácil" : rbIntermediario.Checked ? "Intermediario" : "Avançado";
            string tema = cbTema.Text;
            int pontuacao = int.Parse(txtBoxPontuacao.Text);
            var pergunta = new Pergunta(enunciado, tipo, nivel, tema, pontuacao);

            pergunta.Id = await PerguntaRepository.Adicionar(pergunta);
            await PerguntaRepository.Adicionar(pergunta);

            
            if(tipo == "Multipla Escolha")
            {
                new FrmCadastrarAlternativa(pergunta).ShowDialog();
            }
            else if(tipo == "Verdadeiro ou Falso")
            {
                var verdadeiro = new Alternativa("Verdadeiro", pergunta.Id, true);
                var falso = new Alternativa("Falso", pergunta.Id, false);

                await AlternativaRepository.Adicionar(verdadeiro);
                await AlternativaRepository.Adicionar(falso);
            }
            this.Close();

        }

        private void txtBoxPontuacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
    }
}
