using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDia1
{
    class Program
    {
         string _variavel;

        static void Main(string[] args)
        {

            dynamic oi = "ta se loco ";
            oi += 10;
            Console.WriteLine(oi);


            dynamic oi2 = new ExpandoObject();
            oi2.Saudacao = "ta se loco";


            #region arrays

            var numeros = new[] { 1, 2, 3 }.ToList();
            numeros.Add(4);

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }

            numeros.ForEach((i)=>
            {
                Console.WriteLine(i);
            });

            #endregion

            #region Extension Methods

            Console.WriteLine("Ana".toBacon());

            #endregion

            #region gedy

            var yoda = new Jedi();
            yoda.Nome = "Yoda";

            Console.WriteLine(yoda.Nome);
            yoda.grau = Grau.CAVALEIRO;

            #endregion


            Console.ReadLine();

        }
    }
}
