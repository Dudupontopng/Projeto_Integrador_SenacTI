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
        public FrmPerguntaAlternativas(int? idUsuario = null)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }
    }
}
