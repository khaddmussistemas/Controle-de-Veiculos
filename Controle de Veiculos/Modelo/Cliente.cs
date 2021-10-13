using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Veiculos.Modelo
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Endereco { get; set; }

        public string Fone { get; set; }

        public string Email { get; set; }
    }
}
