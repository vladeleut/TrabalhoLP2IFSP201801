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
    public partial class TelaLanche : Form
    {
        public TelaLanche()
        {
            InitializeComponent();
        }

        //lista temporária de produtos
        List<Produto> pedidoTemp = new List<Produto>();
        float valorDoLanche = 0;
        //preciso usar esses itens nos eventos dos datagrids.

        private void FormLanche_Load(object sender, EventArgs e)
        {
            ProdutoDAO lancheDAO = new ProdutoDAO();
            List<Produto> lista = lancheDAO.ListaPorTipo("lanche");

            //povoa lista de lanches
            foreach (Produto p in lista)
                dgListaLanche.Rows.Add(p.Nome, p.Preco, p.Codigo);

            //povoa lista de adicionais
            lista = lancheDAO.ListaPorTipo("Adicionais - lanche");
            foreach (Produto adc in lista)
                dgAdicionaisLanche.Rows.Add(adc.Nome, adc.Preco, adc.Codigo);
        }

        
        private void dgListaLanche_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            //MessageBox.Show("Oi! Funciona.");
            Produto temp = new Produto();
            temp.Codigo = int.Parse(dgListaLanche.Rows[e.RowIndex].Cells[2].Value.ToString());
            temp.Nome = dgListaLanche.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp.Preco = dgListaLanche.Rows[e.RowIndex].Cells[1].Value.ToString();
            dgListaLanche.Enabled = false;
            valorDoLanche += float.Parse(temp.Preco);
            lblValorLanche.Text = "R$" + valorDoLanche.ToString();
            lblValorLanche.Visible = true;
            temp.Tipo = "Lanche";//nessa tela só pode ser lanche
            //adiciona item no pedido temporario pedido
            pedidoTemp.Add(temp);
            //adiciona item no datagrid
            dgPedidoTempLanche.Rows.Add(temp.Nome, temp.Tipo, temp.Codigo);

            //MessageBox.Show(temp.Codigo.ToString()+ temp.Nome.ToString() + temp.Preco.ToString());
            //Testando uso da lista
        }

        private void dgAdicionaisLanche_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Produto temp = new Produto();
            temp.Codigo = int.Parse(dgAdicionaisLanche.Rows[e.RowIndex].Cells[2].Value.ToString());
            temp.Nome = dgAdicionaisLanche.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp.Preco = dgAdicionaisLanche.Rows[e.RowIndex].Cells[1].Value.ToString();
            valorDoLanche += float.Parse(temp.Preco);
            lblValorLanche.Text = "R$" + valorDoLanche.ToString(); //formatar como dinheiro
            lblValorLanche.Visible = true;

            temp.Tipo = "Adicionais - Lanche";//nesse DG só pode ser adicionais - lanche
            //adiciona item no pedido temporario pedido
            pedidoTemp.Add(temp);
            //adiciona item no datagrid
            dgPedidoTempLanche.Rows.Add(temp.Nome, temp.Tipo, temp.Codigo);
        }

        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            PedidoDAO pedido = new PedidoDAO();

            foreach(Produto p in pedidoTemp)
            {
                pedido.InsereItem(pedido.EncontraPedidoNovo(), p.Codigo);
            }
            this.Close();
        }

        private void dgPedidoTempLanche_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Produto temp = new Produto();
            temp.Codigo = int.Parse(dgPedidoTempLanche.Rows[e.RowIndex].Cells[2].Value.ToString());
            temp.Nome = dgPedidoTempLanche.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp.Preco = dgPedidoTempLanche.Rows[e.RowIndex].Cells[1].Value.ToString();
            dgListaLanche.Enabled = true;
            valorDoLanche = 0;
            lblValorLanche.Text = "R$" + valorDoLanche.ToString();
            lblValorLanche.Visible = true;
            temp.Tipo = "Lanche";//nessa tela só pode ser lanche
            //adiciona item no pedido temporario pedido
            pedidoTemp.Remove(temp);
            //adiciona item no datagrid
            dgPedidoTempLanche.Rows.Clear();
            pedidoTemp = new List<Produto>();
        }

        private void btnCancelaPedido_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
