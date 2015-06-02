
namespace TurboRango
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public int? Capacidade { get; set; }
        public Categoria categoria { get; set; }
        public Contato Contato { get; set;}
        public Localizacao localizacao { get; set; }

    }
}
