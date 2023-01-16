using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDOS02_2.Inputs
{
    /// <summary>
    /// Classe para leitura dos itens da venda
    /// </summary>
    public class ItensVendaInput
    {
        public static string LerProduto()
        {
            Console.Write("Informe o nome do produto........: ");
            return Console.ReadLine();
        }

        public static string LerPreco()
        {
            Console.Write("Informe o preço do produto.......: ");
            return Console.ReadLine();
        }
    }
}
