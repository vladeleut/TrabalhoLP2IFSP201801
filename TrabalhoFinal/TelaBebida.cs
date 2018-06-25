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
    public partial class TelaBebida : Form
    {
        public TelaBebida()
        {
            InitializeComponent();
        }

        //lista temporária de rrodutos
        //List<Produto> pedidoTemp = new List<Produto>();
        //preciso usar esses itens nos eventos dos datagrids.
        
        private void FormBebida_Load(object sender, EventArgs e)
        {
            ProdutoDAO bebidaDAO = new ProdutoDAO();
            List<Produto> lista = bebidaDAO.ListaPorTipo("bebida");

            //povoa lista de bebidas
            foreach (Produto p in lista)
                dgListaBebidas.Rows.Add(p.Nome, p.Preco, p.Codigo);
        }

        private void dgListaBebidas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PedidoDAO pedido = new PedidoDAO();

            //Produto temp = new Produto();
            int codigoProduto = int.Parse(dgListaBebidas.Rows[e.RowIndex].Cells[2].Value.ToString());
            //temp.Nome = dgListaBebidas.Rows[e.RowIndex].Cells[0].Value.ToString();
            //temp.Preco = dgListaBebidas.Rows[e.RowIndex].Cells[1].Value.ToString();
            //temp.Tipo = "Bebida";//nessa tela só pode ser bebida

            pedido.InsereItem(pedido.EncontraPedidoNovo(), codigoProduto);

            this.Close();
        }
        

        private void btnCancelaPedido_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
