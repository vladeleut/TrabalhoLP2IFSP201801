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
    public partial class TelaPedido : Form
    {
        public TelaPedido()
        {
            InitializeComponent();
            cbPeditoTelCliente.Select();//inicia a tela de pedido com o cursor no campo de telefone. é só digitar
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            //clientes.Add(new Cliente(long.Parse(txtTelefone.Text), txtNome.Text, txtLogradouro.Text, int.Parse(txtNumero.Text)));
            
            Close();
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

            //pesquisar dados do pedido nro X, 
            //colocar itens do pedido X no datagrid.
            
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
                txtReferencia.Text = c.Referencia;
                txtObservacao.Text = c.Observacao;
            }
            else
            {
                txtComplemento.Text = " ";
                txtLogradouro.Text = " ";
                txtNome.Text = " ";
                txtReferencia.Text = " ";
                txtObservacao.Text = " ";
            }
            
        }
        

        private void cbPeditoTelCliente_TextChanged(object sender, EventArgs e)
        {
            
            //int flagClienteCadastrado; //vou definir se preciso cadastrar novo cliente
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cli = clienteDAO.Read(cbPeditoTelCliente.Text);

            setDTO(cli);
            /*
            if (cli.Logradouro is null || cli.Logradouro.Length < 4) // Se o cliente for cadastrado, teremos um retorno (não nulo) no retorno de Read
                flagClienteCadastrado = 0; //não temos o cliente     //Caso contrário, podemos adicionar seus dados na tabela pois não temos.
            else
                flagClienteCadastrado = 1; //temos o cliente e não precisamos fazer nada

            return flagClienteCadastrado;*/
        }

        private void btnCancelaTelaPedido_Click(object sender, EventArgs e) => Close();

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
    }
}
