using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Modelos
{
    public class ItemInventario
    {
        public int UsuarioId { get; set; }
        public int ItemId { get; set; }
        public int Quantidade { get; set; }

       
        public string NomeItem { get; set; }
        public string TipoEfeito { get; set; }
        public decimal ValorEfeito { get; set; }
    }
}
