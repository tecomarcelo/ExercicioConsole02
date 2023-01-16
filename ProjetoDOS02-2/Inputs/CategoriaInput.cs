using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDOS02_2.Inputs
{
    /// <summary>
    /// Classe para leitura dos dados de Categoria
    /// </summary>
    public class CategoriaInput
    {
        /// <summary>
        /// Metodo para ler o valor 
        /// </summary>
        /// <returns></returns>
        public static string LerDescricao()
        {
            Console.Write("Informe a categoria do produto....: ");
            return Console.ReadLine();
        }
    }
}
