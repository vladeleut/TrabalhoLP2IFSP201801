using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TrabalhoFinal
{
    public partial class TelaPedido : Form
    {
        public TelaPedido()
        {
            InitializeComponent();
            cbPeditoTelCliente.Select();//inicia a tela de pedido com o cursor no campo de telefone. é só digitar
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
            //este bloco (até "Bloco termina aqui") trata do carregamendo dos dados dos 
            //clientes que já estão no banco
            mtxtDDD.Text = "16";
            ClienteDAO cliDAO = new ClienteDAO();
            List<Cliente> lista = cliDAO.listaCliente();
            List<String> listaAux = new List<String>();

            foreach (Cliente c in lista)
            {
                if (!listaAux.Contains(c.Telefone))
                    listaAux.Add(c.Telefone);
            }
            foreach (String s in listaAux)
            {
                cbPeditoTelCliente.Items.Add(s);
            }
            //bloco termina aqui.

            
        }

        public void AtualizaDataGrid()
        {
            float valorTotal = 0;
            //pesquisar dados do pedido nro X, 
            //colocar itens do pedido X no datagrid.
            dgPedido.Rows.Clear();
            PedidoDAO pedidoDAO = new PedidoDAO();
            Pedido pedidoAtual = pedidoDAO.PedidoNro(pedidoDAO.EncontraPedidoNovo());
            ProdutoDAO produtos = new ProdutoDAO();
            List<Produto> listaDeItens = produtos.ListaItensDoPedidoPorNumero(pedidoDAO.EncontraPedidoNovo());
            foreach (Produto p in listaDeItens)
            {
                dgPedido.Rows.Add(p.Nome, p.Preco, p.Qtde, p.Codigo);
                valorTotal += float.Parse(p.Preco);
            }

            lblTotal.Text = valorTotal.ToString("C");


        }



        private void cbPeditoTelCliente_KeyUp(object sender, KeyEventArgs e)
        {   
            //a ideia aqui é perceber se o telefone é fixo ou móvel, ou seja, se tem 
            //8 ou 9 dígitos. 
            //RegEx?
            //como formatar?
            //ver depois

            /*
            String telefone = cbPeditoTelCliente.Text;
            String telParte1 = "";
            String telParte2 = "";
            
            if ( (cbPeditoTelCliente.Text.Length >= 0) && (cbPeditoTelCliente.Text.Length <= 4) )
            {
                telParte1 += telParte1 + e.KeyValue;
                telefone = telParte1 + "-" + telParte2;
                cbPeditoTelCliente.Text = telefone;
            }
            else if((cbPeditoTelCliente.Text.Length > 0) && (cbPeditoTelCliente.Text.Length < 8))
            {
                telParte2 += telParte2 + e.KeyValue;
                telefone = telParte1 + "-" + telParte2;
                cbPeditoTelCliente.Text = telefone;
            }
            else//só vai chegar aqui se for celular, tem o 9 na frente
            {
                telefone = "9"+telParte1 + "-" + telParte2;
                cbPeditoTelCliente.Text = telefone;
            }
                */


        }

        private void cbPeditoTelCliente_MouseClick(object sender, MouseEventArgs e)
        {
            cbPeditoTelCliente.Text = "-";
        }

        

        private void setDTO(Cliente c)
        {
            if(!(c is null))
            {
                txtComplemento.Text = c.Complemento;
                txtLogradouro.Text = c.Logradouro;
                txtNome.Text = c.Nome;
                txtBairro.Text = c.Bairro;
                txtReferencia.Text = c.Referencia;
                txtObservacao.Text = c.Observacao;
            }
            else
            {
                txtBairro.Text = "";
                txtComplemento.Text = "";
                txtLogradouro.Text = "";
                txtNome.Text = "";
                txtReferencia.Text = "";
                txtObservacao.Text = "";
            }
            
        }
        

        private void cbPeditoTelCliente_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cli = clienteDAO.Read(cbPeditoTelCliente.Text);

            setDTO(cli);

            cbPeditoTelCliente.Text = Regex.Replace(cbPeditoTelCliente.Text, "[^0-9]", "");

        }

        

        private void btnPedidoAdicionaPizza_Click(object sender, EventArgs e)
        {
            TelaPizza pizza = new TelaPizza();
            pizza.StartPosition = FormStartPosition.CenterScreen;
            pizza.ShowDialog();
        }

        private void cbPeditoTelCliente_Leave(object sender, EventArgs e)
        {
            //if((cbPeditoTelCliente.Text.Length >=8)
        }

        private void btnFinalizaPedido_Click(object sender, EventArgs e)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            ClienteDAO clienteDAO = new ClienteDAO();

            //associa pedido ao cliente. => update 
            //acharemos o nro do pedido, o nro do cliente, e atualizamos a tabela
            pedidoDAO.AssociaClientePedido(clienteDAO.EcontraNroCliente(cbPeditoTelCliente.Text), pedidoDAO.EncontraPedidoNovo());

            //mudar estado do pedido => update

            pedidoDAO.AtualizaEstado(pedidoDAO.EncontraPedidoNovo(), 2);
            //se finalizou o pedido ele deixa de ser novo para aguardar finalização.

            this.Close();
        }
        private void btnCancelaTelaPedido_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            PedidoDAO pedidoDAO = new PedidoDAO();
            pedidoDAO.AtualizaEstado(pedidoDAO.EncontraPedidoNovo(), 5);
            pedidoDAO.AssociaClientePedido(clienteDAO.EcontraNroCliente(cbPeditoTelCliente.Text), pedidoDAO.EncontraPedidoNovo());
            this.Close();
        }

        private void TelaPedido_MouseEnter(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void dgPedido_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //remover item aqui. item já está no pedido, então preciso remover do pedido where nro = nro do pedido aberto
            PedidoDAO pedidoDAO = new PedidoDAO(); 
            Pedido pedidoAtual = pedidoDAO.PedidoNro(pedidoDAO.EncontraPedidoNovo());
            
            int codProduto = int.Parse(dgPedido.Rows[e.RowIndex].Cells[3].Value.ToString());
            int nroPedido = pedidoDAO.EncontraPedidoNovo();

            pedidoDAO.RemoveItemDoPedido(codProduto, nroPedido);


            AtualizaDataGrid();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.StartPosition = FormStartPosition.CenterScreen;
            telaCliente.ShowDialog();
        }

        private void TelaPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            cbPeditoTelCliente.Text = Regex.Replace(cbPeditoTelCliente.Text, "[^0-9]", "");
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            TaxaDeEntregaDAO taxa = new TaxaDeEntregaDAO();
            float precotemp = taxa.PesquisaPreco(txtBairro.Text);

            cbTaxaDeEntrega.Text = precotemp.ToString("C");

        }
    }
}
