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
            caixaDAO caixa = new caixaDAO();
            caixa.AbreCaixa();
            
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
            lblAbertura.Text = Caixa.getInstance().Abertura.ToString();//pegar do banco
            lblAbertoEm.Visible = true;
            lblAbertura.Visible = true;
            btnFechaCaixa.Visible = true;
            btnAbreCaixa.Visible = false;
            

           

        }


        private void TabInicio_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnFechaCaixa_Click(object sender, EventArgs e)
        {
            //fechar atualiza o id aberto
            caixaDAO caixa = new caixaDAO();
            int idCaixa = caixa.EncontraCaixaAberto();

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
            caixa.FechaCaixa(idCaixa);
            btnFechaCaixa.Visible = false;
            btnAbreCaixa.Visible = true;
            lblAbertoEm.Visible = false;
            lblAbertura.Visible = false;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
            //preenche lista de pedidos recentes abertos e fechados
            PedidoDAO pedido = new PedidoDAO();
            List<Pedido> lista = pedido.ListaPedidosDeHoje();

            foreach (Pedido p in lista)
            {
                dgPedidos.Rows.Add(p.Nro_pedido, p.Situacao, p.NomeCliente, p.BairroCliente, p.Tempo);
            }

        }
        private void AtualizaDataGrid()
        {
            dgPedidos.Rows.Clear();
            PedidoDAO pedido = new PedidoDAO();
            List<Pedido> lista = pedido.ListaPedidosDeHoje();

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

            PedidoDAO pedido = new PedidoDAO();
            pedido.CriaPedido();

            TelaPedido telaPedido = new TelaPedido();
            telaPedido.StartPosition = FormStartPosition.CenterScreen;
            telaPedido.ShowDialog();

        }

        private void tabTelaPedido_MouseEnter(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void dgPedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PedidoDAO estePedido = new PedidoDAO();

            if (MessageBox.Show("Deseja realmente fechar este pedido?", "FECHAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int nroPedido = int.Parse(dgPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
                estePedido.AtualizaEstado(nroPedido, 3);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos trabalhando nessa funcionalidade", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos trabalhando nessa funcionalidade", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnGerenciaTaxasDeEntrega_Click(object sender, EventArgs e)
        {
            TelaTaxaEntrega tela = new TelaTaxaEntrega();
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.ShowDialog();
            
        }

        private void tabGeral_Enter(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void btnFechaTodos_Click(object sender, EventArgs e)
        {
            PedidoDAO pedido = new PedidoDAO();
            pedido.FechaTodosAbertos();
            AtualizaDataGrid();
        }
    }
}
