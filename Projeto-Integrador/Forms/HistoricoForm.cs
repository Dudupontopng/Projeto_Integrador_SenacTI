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
    public partial class HistoricoForm : Form
    {
        public HistoricoForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoricoForm_Load(object sender, EventArgs e)
        {
            CarregarHistorico();
        }
        private void CarregarHistorico()
        {
            
            dgvHistorico.DataSource = null;
            dgvHistorico.DataSource = SessaoQuiz.Historico;

            
            if (dgvHistorico.Columns["DataHora"] != null)
                dgvHistorico.Columns["DataHora"].HeaderText = "Data e Hora";

            if (dgvHistorico.Columns["Pontuacao"] != null)
                dgvHistorico.Columns["Pontuacao"].HeaderText = "Pontos";

            if (dgvHistorico.Columns["TotalPerguntas"] != null)
                dgvHistorico.Columns["TotalPerguntas"].HeaderText = "Total de Questões";

            if (dgvHistorico.Columns["Desempenho"] != null)
                dgvHistorico.Columns["Desempenho"].HeaderText = "Aproveitamento";
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
