using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDOS02_2.Inputs
{
    /// <summary>
    /// Classe para leitura de dados da Venda
    /// </summary>
    public class VendaInput
    {
        public static string LerTotal()
        {
            Console.Write("Informe Total da Venda.....: ");
            return Console.ReadLine();
        }

        public static string LerData()
        {
            Console.Write("Informe data da Venda......: ");
            return Console.ReadLine();
        }

    }
}
