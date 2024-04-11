namespace CrudLivros.Models
{
    public class Livro
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string isbn { get; set; }
        public string qtdPag {  get; set;}
        public string sinapse { get; set; }
        public string codBarras { get; set; }
        public bool inativo { get; set; }


    }
}
