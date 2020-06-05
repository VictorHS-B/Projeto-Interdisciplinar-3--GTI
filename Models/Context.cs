using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueOnline.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            InicializaBD.Initialize(this);
        }

        public DbSet<Estoque>Estoques { get; set; }
    }
}
