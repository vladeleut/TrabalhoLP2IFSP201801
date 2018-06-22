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
            TelaCadastroProduto TelaProd = new TelaCadastroProduto();
            this.WindowState = FormWindowState.Maximized;
            
        }

       

        private void btnAbreCaixaClick(object sender, EventArgs e)
        {
            
            if (Caixa.getInstance().IsAberto)
            {
                MessageBox.Show("Caixa já está aberto!", "Boas vendas!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Caixa.getInstance().AbreCaixa();
                MessageBox.Show("Caixa aberto com sucesso!!", "Operção concluida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //btnChamaProduto.Enabled = true;
            }
            lblAbertura.Text = Caixa.getInstance().Abertura.ToString();
            

           

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            TelaPedido pedido = new TelaPedido();
            pedido.StartPosition = FormStartPosition.CenterScreen;
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
                String msg = "Caixa fechado com sucesso às " + Caixa.getInstance().Fechamento.ToString();
                MessageBox.Show(msg, "", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                
            }
            else
            {
                
                MessageBox.Show("Caixa não está aberto!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //lblFechamento.Text = Caixa.getInstance().getAbertura().ToString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'trabalhofinalDataSet2.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter2.Fill(this.trabalhofinalDataSet2.pedido);
            // TODO: esta linha de código carrega dados na tabela 'trabalhofinalDataSet1.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter1.Fill(this.trabalhofinalDataSet1.pedido);
            // TODO: esta linha de código carrega dados na tabela 'trabalhofinalDataSet.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.trabalhofinalDataSet.pedido);

        }

        private void btnChamaProduto_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto TelaProd = new TelaCadastroProduto();
            TelaProd.StartPosition = FormStartPosition.CenterScreen;
            TelaProd.ShowDialog();
        }
    }
}
