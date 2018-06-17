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
            this.WindowState = FormWindowState.Maximized;
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (Caixa.getInstance().IsAberto)
            {
                MessageBox.Show("Caixa já está aberto!", "Boas vendas!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Caixa.getInstance().AbreCaixa();
                MessageBox.Show("Caixa aberto com sucesso!!", "Operção concluida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            lblAbertura.Text = Caixa.getInstance().Abertura.ToString();
            
           
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
        
        private void btnFechaCaixa_Click(object sender, EventArgs e)
        {
            if (Caixa.getInstance().IsAberto)
            {
                Caixa.getInstance().FechaCaixa();
                String msg = "Caixa fechado com sucesso às" + Caixa.getInstance().Fechamento.ToString();
                MessageBox.Show(msg, "", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                
            }
            else
            {
                
                MessageBox.Show("Caixa não está aberto!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //lblFechamento.Text = Caixa.getInstance().getAbertura().ToString();
        }
    }
}
