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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Caixa caixaAberto = new Caixa();
            MessageBox.Show("Caixa aberto com sucesso!!", "Operção concluida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           
            //TabInicio.SelectedTab = tabPage2;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            TelaPedido pedido = new TelaPedido();
            pedido.Show();
        }

        private void TabInicio_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
