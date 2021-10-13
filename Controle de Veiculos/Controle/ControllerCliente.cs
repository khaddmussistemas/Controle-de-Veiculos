using Controle_de_Veiculos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Veiculos.Controle
{
   

    public static class ControllerCliente
    {
        private static readonly  Contexto Contexto;

        static ControllerCliente()
        {
            Contexto = new Contexto();
        }

        public static void  SalvarCliente(Cliente cliente)
        {
            if(cliente.Nome == null)
            {
                throw new Exception("Informe o nome");
            }
            if (cliente.Cpf == null)
            {
                throw new Exception("Informe o cpf");
            }
            if (cliente.Endereco == null)
            {
                throw new Exception("Informe o endereço");
            }
            if (cliente.Fone == null)
            {
                throw new Exception("Informe o fone");
            }
            Contexto.Clientes.Add(cliente);
            Contexto.SaveChanges();
        }
        public static void ExcluirCliente(Cliente cliente)
        {
            Contexto.Clientes.Remove(cliente);
            Contexto.SaveChanges();
        }
        public static List<Cliente> ObterClientes()
        {
            return Contexto.Clientes.ToList();
        }

    }
}
