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
        float valorDoLanche = 0;
        //preciso usar esses itens nos eventos dos datagrids.

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
            dgListaPizza.Enabled = false;
            valorDoLanche += float.Parse(temp.Preco);
            //lblValorPizza.Text = "R$" + valorDoLanche.ToString();
            //lblValorPizza.Visible = true;
            temp.Tipo = "Pizza";//nessa tela só pode ser pizza
            //adiciona item no pedido temporario pedido
            pedidoTemp.Add(temp);
            //adiciona item no datagrid
            dgPedidoPizza.Rows.Add(temp.Nome, temp.Tipo, temp.Codigo);

        }

        private void dgAdicionaisPizza_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Produto temp = new Produto();
            temp.Codigo = int.Parse(dgAdicionaisPizza.Rows[e.RowIndex].Cells[2].Value.ToString());
            temp.Nome = dgAdicionaisPizza.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp.Preco = dgAdicionaisPizza.Rows[e.RowIndex].Cells[1].Value.ToString();
            valorDoLanche += float.Parse(temp.Preco);
            //lblValorPizza.Text = "R$" + valorDoLanche.ToString(); //formatar como dinheiro
            //lblValorPizza.Visible = true;

            temp.Tipo = "Adicionais - Pizza";//nesse DG só pode ser adicionais - pizza
            //adiciona item no pedido temporario pedido
            pedidoTemp.Add(temp);
            //adiciona item no datagrid
            dgPedidoPizza.Rows.Add(temp.Nome, temp.Tipo, temp.Codigo);
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
            temp.Codigo = int.Parse(dgPedidoPizza.Rows[e.RowIndex].Cells[2].Value.ToString());
            temp.Nome = dgPedidoPizza.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp.Preco = dgPedidoPizza.Rows[e.RowIndex].Cells[1].Value.ToString();
            dgListaPizza.Enabled = true;
            valorDoLanche = 0;
            //lblValorLanche.Text = "R$" + valorDoLanche.ToString();
            //lblValorLanche.Visible = true;
            temp.Tipo = "Lanche";//nessa tela só pode ser lanche
            //adiciona item no pedido temporario pedido
            pedidoTemp.Remove(temp);
            //adiciona item no datagrid
            dgPedidoPizza.Rows.Clear();
            pedidoTemp = new List<Produto>();
        }

        private void btnCancelaPedido_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
