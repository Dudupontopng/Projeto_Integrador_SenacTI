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
    public partial class FrmTelaLoja : Form
    {
        private readonly int _idUsuario;
        private Usuario _usuario;
        private List<ItemLoja> _itensLoja;
        public FrmTelaLoja(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }
        private async Task CarregarDados()
        {
            _usuario = await UsuarioRepository.ObterPorId(_idUsuario);
            lblPontos.Text = $"Meus Pontos: {_usuario.PontuacaoTotal}";

            _itensLoja = await LojaRepository.ObterItensDaLoja();
            dgvLoja.DataSource = null;
            dgvLoja.DataSource = _itensLoja;
        }
        private void ConfigurarGrid()
        {
            if (dgvLoja.Columns["Id"] != null) dgvLoja.Columns["Id"].Visible = false;
            if (dgvLoja.Columns["TipoEfeito"] != null) dgvLoja.Columns["TipoEfeito"].Visible = false;
            if (dgvLoja.Columns["ValorEfeito"] != null) dgvLoja.Columns["ValorEfeito"].Visible = false;

            if (dgvLoja.Columns["Nome"] != null) dgvLoja.Columns["Nome"].HeaderText = "Item";
            if (dgvLoja.Columns["Descricao"] != null) dgvLoja.Columns["Descricao"].HeaderText = "Efeito";
            if (dgvLoja.Columns["Preco"] != null) dgvLoja.Columns["Preco"].HeaderText = "Preço (Pontos)";

            dgvLoja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoja.MultiSelect = false;
            dgvLoja.ReadOnly = true;
        }

        private async void FrmTelaLoja_Load(object sender, EventArgs e)
        {
            await CarregarDados();
            ConfigurarGrid();
        }

        private async void btnComprar_Click(object sender, EventArgs e)
        {
            if (dgvLoja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item na lista primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var itemSelecionado = (ItemLoja)dgvLoja.SelectedRows[0].DataBoundItem;

            if (itemSelecionado.Preco > _usuario.PontuacaoTotal)
            {
                MessageBox.Show("Você não tem pontos suficientes para comprar isso!", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmacao = MessageBox.Show(
                $"Deseja comprar '{itemSelecionado.Nome}' por {itemSelecionado.Preco} pontos?",
                "Confirmar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {

                bool sucesso = await LojaRepository.ComprarItem(_idUsuario, itemSelecionado.Id, itemSelecionado.Preco);

                if (sucesso)
                {
                    MessageBox.Show("Compra realizada com sucesso! O item está no seu inventário.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarDados();
                }
                else
                {
                    MessageBox.Show("Erro ao processar a compra. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
