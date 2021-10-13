using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Veiculos.Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
