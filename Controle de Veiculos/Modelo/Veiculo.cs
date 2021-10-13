using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Veiculos.Modelo
{
    public class Veiculo
    {
        public int ID { get; set; }

        public string Placa { get; set; }
        public string Modelo { get; set; }

        public string Ano { get; set; }

        public string Fabricante { get; set; }

        public string Cor { get; set; }

        public Cliente Cliente { get; set; }

        public int ClienteID { get; set; }

    }
}
