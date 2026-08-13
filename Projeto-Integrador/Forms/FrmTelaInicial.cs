using Projeto_Integrador.Forms;

namespace Projeto_Integrador
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().ShowDialog();
            this.Show();
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCadastro().ShowDialog();
            this.Show();
        }
    }
}
