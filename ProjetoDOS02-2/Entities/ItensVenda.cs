using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDOS02_2.Entities
{
    public class ItensVenda
    {
        public Guid IdItensVenda { get; set; }
        public string? Produto { get; set; }
        public string? Preco { get; set; }

        public List<Categoria> Categorias { get; set; }
    }
}
