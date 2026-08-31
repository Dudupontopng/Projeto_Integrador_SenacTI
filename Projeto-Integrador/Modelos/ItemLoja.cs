using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.Modelos
{
    public class ItemLoja
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        public string TipoEfeito { get; set; }
        public decimal ValorEfeito { get; set; }
    }
}
