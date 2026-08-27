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
        public FrmTelaComeco(int? idUsuario = null)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPerguntaAlternativas(_idUsuario).ShowDialog();
            this.Show();
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
            HistoricoForm telaHistorico = new HistoricoForm();
            telaHistorico.ShowDialog();
            this.Show();
        }

        private void FrmTelaComeco_Load(object sender, EventArgs e)
        {



        }
    }
}

