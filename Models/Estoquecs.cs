using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueOnline.Models
{
    public class Estoque
    {
        public int id { get; set; }

        public String Nome { get; set; }

        public String Classe { get; set; }

        public int Preco_Custo { get; set; }

        public int Preco_Final { get; set; }

        public int Codigo_Barras { get; set; }

        public String Fornecedor { get; set; }
    }
}
