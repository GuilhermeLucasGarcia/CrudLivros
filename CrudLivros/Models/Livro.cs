using Microsoft.VisualBasic;

namespace CrudLivros.Models
{
    public class Livro
    {   
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public DateTime ano { get; set; }
        public string qtdPag { get; set; }
        public string sinapse { get; set; }
        public string categoria { get; set; }
        public string editora {  get; set; }
        public double altura {  get; set; }
        public double largura { get; set; }
        public double profundidade { get; set; }
        public int edicao { get; set; }
        public string isbn { get; set; }
        public string codBarras { get; set; }
        public bool inativo { get; set; }


    }
}
