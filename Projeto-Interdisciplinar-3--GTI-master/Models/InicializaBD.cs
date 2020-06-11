using System.Linq;

namespace FerragensOnline.Models
{
    public class InicializaBD
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            if (context.Estoques.Any())
            {
                return;
            }

            var estoques = new Estoque[]
            {
                new Estoque{Nome ="Parafuso"},
                new Estoque{Nome ="Porca"},
                new Estoque{Nome ="Tinta"},
                new Estoque{Nome ="Chave de fenda"},

            };

            foreach (var item in estoques)
            {
                context.Estoques.Add(item);
            }

            context.SaveChanges();

        }
    }
}