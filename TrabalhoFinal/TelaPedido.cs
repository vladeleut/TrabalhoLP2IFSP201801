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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaPizza pizza = new TelaPizza();
            pizza.StartPosition = FormStartPosition.CenterScreen;
            pizza.ShowDialog();
            
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

        private void cbPeditoTelCliente_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cli = clienteDAO.Read(cbPeditoTelCliente.Text);

            setDTO(cli);

        }

        private void setDTO(Cliente c)
        {
            txtComplemento.Text = c.Complemento;
            txtLogradouro.Text = c.Logradouro;
            txtNome.Text = c.Nome;
            txtReferencia.Text = c.Referencia;
            txtObservacao.Text = c.Observacao;
        }
    }
}
