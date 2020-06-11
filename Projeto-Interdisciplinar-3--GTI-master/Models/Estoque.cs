using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FerragensOnline.Models
{
    public class Estoque
    {
        [key]
        public int id { get; set; }

        [Required(ErrorMessage = "O nome precisa ser preenchido")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        public string Classe { get; set; }

        public int Preco_Custo { get; set; }

        public int Preco_Final { get; set; }

        public int Codigo_Barras { get; set; }

        public string Fornecedor { get; set; }
    }
}
