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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            Cliente cli = getDTO();
            ClienteDAO cliDAO = new ClienteDAO();
            cliDAO.Create(cli);

            /*
            //atualiza o datagrid com a nova informação inserida. precisa atualizar o combo box. 
            //limpa as informações inseridas.
            dgListaProd.Rows.Add(prod.Tipo, prod.Codigo, prod.Nome, prod.Preco);
            cbTipoProd.Text = "";
            txtNomeProd.Text = "";
            txtPrecoProd.Text = "";*/
        }


        private Cliente getDTO()
        {
            Cliente cli = new Cliente();
            cli.Telefone = cbTelCliente.Text;
            cli.Nome = txtNomeCliente.Text;
            cli.Logradouro = txtEndCliente.Text;
            cli.Bairro = txtBairroCliente.Text;
            cli.Observacao = txtObsCliente.Text;

            return cli;
        }

        private void setDTO(Cliente cli)
        {
             //cbTelCliente.Text = cli.Telefone;
             txtNomeCliente.Text = cli.Nome;
             txtEndCliente.Text = cli.Logradouro;
             txtBairroCliente.Text = cli.Bairro;
             txtObsCliente.Text = cli.Observacao;
        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO cliDAO = new ClienteDAO();
            List<Cliente> lista = cliDAO.listaCliente();
            List<String> listaAux = new List<String>();

            foreach (Cliente c in lista)
            {
                string endereco = "";
                endereco = c.Logradouro + ", " + c.Complemento + ", " + c.Bairro + ", " + c.Observacao;
                dgListaClientes.Rows.Add(c.Telefone, c.Nome, endereco , c.Codigo);

                if (!listaAux.Contains(c.Telefone))
                    listaAux.Add(c.Telefone);
            }
            foreach (String s in listaAux)
            {
                cbTelCliente.Items.Add(s);
            }

        }

        private void cbTelCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            string tel = cbTelCliente.SelectedValue.ToString();
            ClienteDAO cliDAO = new ClienteDAO();
            setDTO(cliDAO.Read(tel));
            */
        }
    }
}
