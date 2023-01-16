using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ProjetoDOS02_2.Entities;

namespace ProjetoDOS02_2.Repositories
{
    public class VendaRepository
    {
        /// <summary>
        /// Metodo para exportar os dados da venda para arquivo JSON
        /// </summary>
        /// <param name="venda"></param>
        public void ExportaDados(Venda venda)
        {
            //Serializar os dados da venda para o formato JSON
            var json = JsonConvert.SerializeObject(venda, Formatting.Indented);

            //abrindo um arquivo modo de escrita
            var streamWriter = new StreamWriter($"c:\\teste\\teste2\\venda_{venda.IdVenda}.json");
            streamWriter.WriteLine(json); //escrevendo os dados do arquivo (json)
            streamWriter.Flush(); //salvando
            streamWriter.Close(); //fechando
        }
    }
}
