using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDOS02_2.Entities
{
    public class Venda
    {
        public Guid IdVenda { get; set; }
        public string? Total { get; set; }
        public DateTime Data { get; set; }

        public List<Cliente> Clientes { get; set; }
        public List<ItensVenda> ItensVendas { get; set; }
    }
}
