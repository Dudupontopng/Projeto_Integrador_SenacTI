using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador.Forms
{
    public partial class UcConquista : UserControl
    {
        public UcConquista()
        {
            InitializeComponent();
        }

        public void ConfigurarConquista(string titulo, string descricao, Image icone, int progressoAtual, int progressoMaximo, bool desbloqueado)
        {
            lblTitulo.Text = titulo;
            lblProgresso.Text = $"{progressoAtual}/{progressoMaximo}";

            string textoToolTip = $"{titulo}\n\nRequisito: {descricao}\nStatus: {(desbloqueado ? "Desbloqueado!" : "Bloqueado")}";

            toolTipDescricao.SetToolTip(this, textoToolTip);
            toolTipDescricao.SetToolTip(picIcone, textoToolTip);
            toolTipDescricao.SetToolTip(lblTitulo, textoToolTip);
            toolTipDescricao.SetToolTip(lblProgresso, textoToolTip);

            if (desbloqueado)
            {
                picIcone.Image = icone;
                this.BackColor = Color.DarkSlateGray;
                lblTitulo.ForeColor = Color.White;
                lblProgresso.ForeColor = Color.LightGreen;
            }
            else
            {
                picIcone.Image = TransformarEmCinza(icone);
                this.BackColor = Color.FromArgb(40, 40, 40);
                lblTitulo.ForeColor = Color.Gray;
                lblProgresso.ForeColor = Color.Gray;
            }
        }

        private Image TransformarEmCinza(Image imagemOriginal)
        {
            if (imagemOriginal == null) return null;

            Bitmap bmp = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(imagemOriginal, new Rectangle(0, 0, bmp.Width, bmp.Height),
                        0, 0, imagemOriginal.Width, imagemOriginal.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return bmp;
        }
    }
}
