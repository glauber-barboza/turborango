using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboRango.Dominio
{
    public class Produtos : Entidade
    {
        public string nome {get;set;}
        public double preco {get;set;}
        public string descricao { get; set;}
        public string imgPrato {get;set;}
    }
}
