using Projeto_Integrador.Banco.Repositories;
using Projeto_Integrador.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador.Forms
{
    public partial class HistoricoForm : Form
    {
        private int _idUsuario;

        public HistoricoForm(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        private async void HistoricoForm_Load(object sender, EventArgs e)
        {
            await CarregarHistorico();
        }

        private async Task CarregarHistorico()
        {
            try
            {
              
                var historico = await HistoricoRepository.ObterHistoricoUsuario(_idUsuario);

                dgvHistorico.DataSource = null;
                dgvHistorico.DataSource = historico;

                if (dgvHistorico.Columns["Acertou"] != null)
                    dgvHistorico.Columns["Acertou"].Visible = false;

                if (dgvHistorico.Columns["Tema"] != null)
                    dgvHistorico.Columns["Tema"].HeaderText = "Tema da Pergunta";

                if (dgvHistorico.Columns["Resultado"] != null)
                    dgvHistorico.Columns["Resultado"].HeaderText = "Resultado";

                if (dgvHistorico.Columns["Pontos"] != null)
                    dgvHistorico.Columns["Pontos"].HeaderText = "Pontos Ganhos";

               
                dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o histórico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}