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
    public partial class TelaPizza : Form
    {
        public TelaPizza()
        {
            InitializeComponent();
        }

        //lista temporária de pedidos
        List<Produto> pedidoTemp = new List<Produto>();
        float valorPizza = 0;
        //preciso usar esses itens nos eventos dos datagrids.
        int contadorPartesPizza = 0;

        private void FormPizza_Load(object sender, EventArgs e)
        {
            ProdutoDAO pizzaDAO = new ProdutoDAO();
            List<Produto> lista = pizzaDAO.ListaPorTipo("pizza");

            foreach (Produto p in lista)
                dgListaPizza.Rows.Add(p.Nome, p.Preco, p.Codigo);


            lista = pizzaDAO.ListaPorTipo("Adicionais - pizza");
            foreach (Produto adc in lista)
                dgAdicionaisPizza.Rows.Add(adc.Nome, adc.Preco, adc.Codigo);
        }
        private void dgListaPizza_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Produto temp = new Produto();
            temp.Codigo = int.Parse(dgListaPizza.Rows[e.RowIndex].Cells[2].Value.ToString());
            temp.Nome = dgListaPizza.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp.Preco = dgListaPizza.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            lblTelaValorPizza.Visible = true;
            temp.Tipo = "Pizza";//nessa tela só pode ser pizza
            //adiciona item no pedido temporario pedido
            pedidoTemp.Add(temp);
            //adiciona item no datagrid
            dgPedidoPizza.Rows.Add(temp.Nome, temp.Codigo);

            //determina preço da maior pizza
            if(float.Parse(temp.Preco) > valorPizza)
            {
                valorPizza = float.Parse(temp.Preco);
            }
            lblTelaValorPizza.Text = valorPizza.ToString("C");
            contadorPartesPizza += 1;
            lblContadorDePartes.Text = contadorPartesPizza.ToString();
            if(contadorPartesPizza == 3)
            {
                dgListaPizza.Enabled = false;
                lblAvisoAvisoPizza1.Visible = true;
                lblAvisoPizza2.Visible = true;
                lblContadorDePartes.Text = "Máximo de 3 Sabores";
            }

        }

        private void dgAdicionaisPizza_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Produto temp = new Produto();
            temp.Codigo = int.Parse(dgAdicionaisPizza.Rows[e.RowIndex].Cells[2].Value.ToString());
            temp.Nome = dgAdicionaisPizza.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp.Preco = dgAdicionaisPizza.Rows[e.RowIndex].Cells[1].Value.ToString();
            valorPizza += float.Parse(temp.Preco);
            lblTelaValorPizza.Text = valorPizza.ToString("C");
            lblTelaValorPizza.Visible = true;

            temp.Tipo = "Adicionais - Pizza";//nesse DG só pode ser adicionais - pizza
            //adiciona item no pedido temporario pedido
            pedidoTemp.Add(temp);
            //adiciona item no datagrid
            dgPedidoPizza.Rows.Add(temp.Nome, temp.Preco, temp.Codigo);
        }

        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            PedidoDAO pedido = new PedidoDAO();
            
            foreach (Produto p in pedidoTemp)
            {
                pedido.InsereItem(pedido.EncontraPedidoNovo(), p.Codigo);
            }
            this.Close();
        }

        private void dgPedidoPizza_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //implementar um contador
            Produto temp = new Produto();
            
            temp.Codigo = int.Parse(dgPedidoPizza.Rows[e.RowIndex].Cells[1].Value.ToString());
            temp.Nome = dgPedidoPizza.Rows[e.RowIndex].Cells[0].Value.ToString();
            //temp.Preco = dgPedidoPizza.Rows[e.RowIndex].Cells[1].Value.ToString();
            dgListaPizza.Enabled = true;
            lblAvisoAvisoPizza1.Visible = false;
            lblAvisoPizza2.Visible = false;
            valorPizza = 0;
            lblTelaValorPizza.Text = valorPizza.ToString("C");
            lblTelaValorPizza.Visible = true;
            temp.Tipo = "Lanche";//nessa tela só pode ser lanche
            //adiciona item no pedido temporario pedido
            pedidoTemp.Remove(temp);
            //adiciona item no datagrid
            dgPedidoPizza.Rows.Clear();
            pedidoTemp = new List<Produto>();
            //dgPedidoPizza.Rows.RemoveAt(e.RowIndex);
            contadorPartesPizza =0;
            lblContadorDePartes.Text = contadorPartesPizza.ToString();
        }

        private void btnCancelaPedido_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
