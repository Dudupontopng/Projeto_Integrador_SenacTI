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
    public partial class FrmCadastrarAlternativa : Form
    {
        Pergunta _pergunta = null;
        public FrmCadastrarAlternativa(Pergunta pergunta)
        {
            InitializeComponent();
            _pergunta = pergunta;
        }

        private async void btnCadastrarAlternativas_Click(object sender, EventArgs e)
        {
            string textoAlternativa1 = txtBoxAlternativa1.Text;
            string textoAlternativa2 = txtBoxAlternativa2.Text;
            string textoAlternativa3 = txtBoxAlternativa3.Text;
            string textoAlternativa4 = txtBoxAlternativa4.Text;
            int perguntaId = _pergunta.Id;
            string textoCorreta = comboBox1.Text;
            bool isCorreta1 = (textoCorreta == "Alternativa 1");
            bool isCorreta2 = (textoCorreta == "Alternativa 2");
            bool isCorreta3 = (textoCorreta == "Alternativa 3");
            bool isCorreta4 = (textoCorreta == "Alternativa 4");


            var alternativa1 = new Alternativa(textoAlternativa1, perguntaId, isCorreta1);
            var alternativa2 = new Alternativa(textoAlternativa2, perguntaId, isCorreta2);
            var alternativa3 = new Alternativa(textoAlternativa3, perguntaId, isCorreta3);
            var alternativa4 = new Alternativa(textoAlternativa4, perguntaId, isCorreta4);

            await AlternativaRepository.Adicionar(alternativa1);
            await AlternativaRepository.Adicionar(alternativa2);
            await AlternativaRepository.Adicionar(alternativa3);
            await AlternativaRepository.Adicionar(alternativa4);

            MessageBox.Show("Alternativas salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
