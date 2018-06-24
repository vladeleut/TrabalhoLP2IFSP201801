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
            //preenche lista de pedidos recentes abertos e fechados
            PedidoDAO pedido = new PedidoDAO();
            List<Pedido> lista = pedido.ListaPedidos();

            foreach (Pedido p in lista)
            {
                dgPedidos.Rows.Add(p.Nro_pedido, p.Situacao, p.NomeCliente, p.BairroCliente, p.Tempo);
            }
        }

        private void btnChamaProduto_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto TelaProd = new TelaCadastroProduto();
            TelaProd.StartPosition = FormStartPosition.CenterScreen;
            TelaProd.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            TelaCliente TelaCli = new TelaCliente();
            TelaCli.StartPosition = FormStartPosition.CenterScreen;
            TelaCli.ShowDialog();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            //tela editar pedido?
            TelaPedido telaPedido = new TelaPedido();
            telaPedido.StartPosition = FormStartPosition.CenterScreen;
            telaPedido.Show();

        }
    }
}
