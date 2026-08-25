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
        private readonly bool? _ehAdmin;
        public FrmTelaComeco(int? idUsuario = null, bool? ehAdmin = null)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _ehAdmin = ehAdmin;
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

        private void FrmTelaComeco_Load(object sender, EventArgs e)
        {
            if ((bool)_ehAdmin)
            {
                btnCriarPergunta.Visible = true;
                btnIniciar.Visible = false;
                btnPerfil.Visible = false;
                btnHistorico.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void btnCriarPergunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCadastrarPergunta().ShowDialog();
            this.Show();
        }
    }
}
