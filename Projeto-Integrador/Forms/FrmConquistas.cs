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
    public partial class FrmConquistas : Form
    {
        private int? _idUsuario;

        public FrmConquistas()
        {
            InitializeComponent();
        }

        public FrmConquistas(int? idUsuario) : this()
        {
            _idUsuario = idUsuario;
        }

        private async void FrmConquistas_Load(object sender, EventArgs e)
        {
            await CarregarConquistas();
        }

        private async Task CarregarConquistas()
        {
            if (!_idUsuario.HasValue)
            {
                MessageBox.Show("Usuário não identificado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = await UsuarioRepository.ObterPorId(_idUsuario.Value);

            if (usuario == null)
            {
                MessageBox.Show("Não foi possível carregar os dados do usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            flowLayoutPanel1.Controls.Clear();

            // 1. Primeiro Quiz
            AdicionarCardConquista(
                titulo: "Primeiros Passos",
                descricao: "Conclua o seu primeiro quiz.",
                icone: ConverterParaImagem(Properties.Resources.Primeiro_quiz___conquista),
                progressoAtual: usuario.PerguntasRespondidas > 0 ? 1 : 0,
                progressoMaximo: 1
            );

            // 2. Sequência de 10 Acertos
            AdicionarCardConquista(
                titulo: "Mira Certeira",
                descricao: "Alcance uma sequência de 10 acertos seguidos.",
                icone: ConverterParaImagem(Properties.Resources._10_acertos_seguidos___conquista),
                progressoAtual: usuario.MaiorSequenciaAcertos,
                progressoMaximo: 10
            );

            // 3. Dias Seguidos
            AdicionarCardConquista(
                titulo: "Foco Inicial",
                descricao: "Acesse o sistema por 3 dias seguidos.",
                icone: ConverterParaImagem(Properties.Resources._3_dias_seguidos___conquista),
                progressoAtual: 1,
                progressoMaximo: 3
            );

            AdicionarCardConquista(
                titulo: "Dedicado",
                descricao: "Acesse o sistema por 7 dias seguidos.",
                icone: ConverterParaImagem(Properties.Resources._7_dias_seguidos___conquista),
                progressoAtual: 1,
                progressoMaximo: 7
            );

            AdicionarCardConquista(
                titulo: "Hábito Formado",
                descricao: "Acesse o sistema por 30 dias seguidos.",
                icone: ConverterParaImagem(Properties.Resources._30_dias_seguidos___conquista),
                progressoAtual: 1,
                progressoMaximo: 30
            );

            AdicionarCardConquista(
                titulo: "Persistente",
                descricao: "Acesse o sistema por 90 dias seguidos.",
                icone: ConverterParaImagem(Properties.Resources._90_dias_seguidos___conquista),
                progressoAtual: 1,
                progressoMaximo: 90
            );

            AdicionarCardConquista(
                titulo: "Lenda do Ano",
                descricao: "Acesse o sistema por 365 dias seguidos.",
                icone: ConverterParaImagem(Properties.Resources._365_dias_seguidos___conquista),
                progressoAtual: 1,
                progressoMaximo: 365
            );

            AdicionarCardConquista(
                titulo: "Mestre em Produtividade",
                descricao: "Obtenha 100 acertos no tema Produtividade.",
                icone: ConverterParaImagem(Properties.Resources.mestre_de_produtividade___conquista),
                progressoAtual: usuario.TemaDominante == "Produtividade" ? usuario.AcertosTotais : 0,
                progressoMaximo: 100
            );

            AdicionarCardConquista(
                titulo: "Mestre em Redes",
                descricao: "Obtenha 100 acertos no tema Redes.",
                icone: ConverterParaImagem(Properties.Resources.mestre_de_redes___conquista),
                progressoAtual: usuario.TemaDominante == "Redes" ? usuario.AcertosTotais : 0,
                progressoMaximo: 100
            );

            AdicionarCardConquista(
                titulo: "Mestre em Segurança",
                descricao: "Obtenha 100 acertos no tema Segurança.",
                icone: ConverterParaImagem(Properties.Resources.mestre_de_segurança___conquista),
                progressoAtual: usuario.TemaDominante == "Segurança" ? usuario.AcertosTotais : 0,
                progressoMaximo: 100
            );

            AdicionarCardConquista(
                titulo: "Mestre em Hardware",
                descricao: "Obtenha 100 acertos no tema Hardware.",
                icone: ConverterParaImagem(Properties.Resources.mestre_em_hardware),
                progressoAtual: usuario.TemaDominante == "Hardware" ? usuario.AcertosTotais : 0,
                progressoMaximo: 100
            );

            AdicionarCardConquista(
                titulo: "Mestre em Programação",
                descricao: "Obtenha 100 acertos no tema Programação.",
                icone: ConverterParaImagem(Properties.Resources.Mestre_programação___conquista),
                progressoAtual: usuario.TemaDominante == "Programação" ? usuario.AcertosTotais : 0,
                progressoMaximo: 100
            );

            AdicionarCardConquista(
                titulo: "Mestre em Sistemas",
                descricao: "Obtenha 100 acertos no tema Sistemas.",
                icone: ConverterParaImagem(Properties.Resources.Mestre_sistemas___conquista),
                progressoAtual: usuario.TemaDominante == "Sistemas" ? usuario.AcertosTotais : 0,
                progressoMaximo: 100
            );
        }

        // Método que converte byte[] em Image
        private Image ConverterParaImagem(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void AdicionarCardConquista(string titulo, string descricao, Image icone, int progressoAtual, int progressoMaximo)
        {
            int progressoTratado = Math.Min(progressoAtual, progressoMaximo);
            bool desbloqueado = progressoAtual >= progressoMaximo;

            UcConquista card = new UcConquista();
            card.ConfigurarConquista(
                titulo: titulo,
                descricao: descricao,
                icone: icone,
                progressoAtual: progressoTratado,
                progressoMaximo: progressoMaximo,
                desbloqueado: desbloqueado
            );

            flowLayoutPanel1.Controls.Add(card);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
