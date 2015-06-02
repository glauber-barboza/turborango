using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ImportadorXML
{
    public class RestaurantesXML
    {
        public string NomeArquivo { get; private set; }

        /// <summary>
        /// Constroi RestauranteXML apartir de um nome de arquivo
        /// </summary>
        /// <param name="nomeDoArquivo"></param>
        public RestaurantesXML(string nomeDoArquivo)
        {
            this.NomeArquivo = nomeDoArquivo;
        }

        public IList<string> ObterNomes()
        {
        //    var resultado = new List<string>();
        //    var nodos = XDocument.Load(NomeArquivo).Descendants("restaurante");
        //    foreach (var item in nodos)
	    //      {
        //         resultado.Add(item.Attribute("nome").Value);		
        //       }


            return XDocument 
                .Load(NomeArquivo)
                .Descendants("restaurante") 
                .Select(n => new Restaurante.Attribute("nome").Value)
                .OrderBy(n => n)
                .ToList();
        }

    }
}
