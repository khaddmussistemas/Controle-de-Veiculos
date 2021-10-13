using Controle_de_Veiculos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Veiculos.Controle
{
    public static class VeiculoControler
    {
        private static readonly Contexto Contexto;

        static VeiculoControler()
        {
            Contexto = new Contexto();
        }

        public static void SalvarVeiculo(Veiculo veiculo)
        {
            if (veiculo.Placa == null)
            {
                throw new Exception("Informe a placa");
            }
            if (veiculo.Cor == null)
            {
                throw new Exception("Informe a cor");
            }
            if (veiculo.Modelo == null)
            {
                throw new Exception("Informe o endereço");
            }
            if (veiculo.Cliente == null)
            {
                throw new Exception("Informe o cliente");
            }

            Contexto.Veiculos.Add(veiculo);
            Contexto.SaveChanges();
        }
        public static void ExcluirVeiculo(Veiculo veiculo)
        {
            Contexto.Veiculos.Remove(veiculo);
            Contexto.SaveChanges();
        }
        public static List<Veiculo> ObterVericulo()
        {
            return Contexto.Veiculos.ToList();
        }
    }
}
