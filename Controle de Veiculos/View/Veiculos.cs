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
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculos = new Veiculo();
            //
            veiculos.Placa = textBox2.Text;
            //
            //
            VeiculoControler.SalvarVeiculo(veiculos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeiculoControler.ObterVericulo();
        }

        private void Veiculos_Load(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.ID = int.Parse(textBox1.Text);
            VeiculoControler.ExcluirVeiculo(veiculo);
        }
    }
}
