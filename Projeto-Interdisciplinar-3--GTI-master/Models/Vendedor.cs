﻿namespace FerragensOnline.Models
{
    public class Vendedor
    {
        [key]
        public int id { get; set; }

        public string Nome { get; set; }

        public string Usuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}




