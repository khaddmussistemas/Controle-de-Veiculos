using Controle_de_Veiculos.Controle;
using Controle_de_Veiculos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Veiculos.View
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Cliente  cliente = new Cliente();
            //
            cliente.Nome = textBox2.Text;
            //
            //
            ControllerCliente.SalvarCliente(cliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ID = int.Parse(textBox1.Text);
            ControllerCliente.ExcluirCliente(cliente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ControllerCliente.ObterClientes();
        }
    }
}
