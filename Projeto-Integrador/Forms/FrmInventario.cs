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
    public partial class FrmInventario : Form
    {
        private readonly int _idUsuario;
        private Usuario _usuario;
        private List<ItemInventario> _itensInventario;
        public FrmInventario(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        private async void FrmInventario_Load(object sender, EventArgs e)
        {
            await CarregarDados();
            ConfigurarGrid();

        }
        private async Task CarregarDados()
        {
            _usuario = await UsuarioRepository.ObterPorId(_idUsuario);


            _itensInventario = await LojaRepository.ObterInventarioDoUsuario(_usuario.Id);
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = _itensInventario;
        }
        private void ConfigurarGrid()
        {
            if (dgvInventario.Columns["UsuarioId"] != null) dgvInventario.Columns["UsuarioId"].Visible = false;
            if (dgvInventario.Columns["ItemId"] != null) dgvInventario.Columns["ItemId"].Visible = false;
            if (dgvInventario.Columns["TipoEfeito"] != null) dgvInventario.Columns["TipoEfeito"].Visible = false;
            if (dgvInventario.Columns["ValorEfeito"] != null) dgvInventario.Columns["ValorEfeito"].Visible = false;

            if (dgvInventario.Columns["NomeItem"] != null) dgvInventario.Columns["NomeItem"].HeaderText = "Item Equipado";
            if (dgvInventario.Columns["Quantidade"] != null) dgvInventario.Columns["Quantidade"].HeaderText = "Quantidade na Mochila";

            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;
            dgvInventario.ReadOnly = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
