using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDOS02_2.Inputs
{
    /// <summary>
    /// Classe para leitura dos dados de endereço do cliente
    /// </summary>
    public class EnderecoInput
    {
        public static string LerLogradouro()
        {
            Console.Write("Informe o logradouro..........: ");
            return Console.ReadLine();
        }

        public static string LerBairro()
        {
            Console.Write("Informe o bairro..............: ");
            return Console.ReadLine();
        }

        public static string LerCidade()
        {
            Console.Write("Informe a cidade..............: ");
            return Console.ReadLine();
        }

        public static string LerEstado()
        {
            Console.Write("Informe o estado.............: ");
            return Console.ReadLine();
        }

        public static string LerCep()
        {
            Console.Write("Informe o CEP...............: ");
            return Console.ReadLine();
        }
    }
}
