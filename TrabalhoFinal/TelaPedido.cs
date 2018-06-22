using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class TelaPedido : Form
    {
        public TelaPedido()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaPizza pizza = new TelaPizza();
            pizza.StartPosition = FormStartPosition.CenterScreen;
            pizza.ShowDialog();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            //clientes.Add(new Cliente(long.Parse(txtTelefone.Text), txtNome.Text, txtLogradouro.Text, int.Parse(txtNumero.Text)));
            
            Close();
        }

        

        private void bttAdcLanche_Click(object sender, EventArgs e)
        {
            TelaLanche lanche = new TelaLanche();
            lanche.StartPosition = FormStartPosition.CenterScreen;
            lanche.ShowDialog();
        }

        private void bttAdcBebida_Click(object sender, EventArgs e)
        {
            TelaBebida bebida = new TelaBebida();
            bebida.StartPosition = FormStartPosition.CenterScreen;
            bebida.ShowDialog();
        }

        private void bttAdcOutro_Click(object sender, EventArgs e)
        {
            TelaOutros outro = new TelaOutros();
            outro.StartPosition = FormStartPosition.CenterScreen;
            outro.ShowDialog();
        }

        private void TelaPedido_Load(object sender, EventArgs e)
        {
            mtxtDDD.Text = "16";
            //carregar lista para o tel
        }

        
    }
}
