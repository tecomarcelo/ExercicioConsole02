using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDOS02_2.Inputs
{
    /// <summary>
    /// Classe para leitura de dados do Cliente
    /// </summary>
    public class ClienteInput
    {
        public static string LerNome()
        {
            Console.Write("Informe o nome do cliente.......: ");
            return Console.ReadLine();
        }

        public static string LerCpf()
        {
            Console.Write("Informe o CPF do cliente.......: ");
            return Console.ReadLine();
        }
    }
}
