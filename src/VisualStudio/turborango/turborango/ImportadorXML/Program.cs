using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorXML
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nomeDoArquivo = "RestauranteXML";
            var restaurantesXM = new RestaurantesXML(nomeDoArquivo);

            Console.ReadLine();

        }
    }
}
