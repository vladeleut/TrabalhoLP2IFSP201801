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
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            Produto prod = getDTO();
            ProdutoDAO prodDAO = new ProdutoDAO();
            prodDAO.Create(prod);
            
            //atualiza o datagrid com a nova informação inserida. precisa atualizar o combo box. 
            //limpa as informações inseridas.
            dgListaProd.Rows.Add(prod.Tipo, prod.Codigo, prod.Nome, prod.Preco);
            cbTipoProd.Text = "";
            txtNomeProd.Text = "";
            txtPrecoProd.Text = "";
        }


        private Produto getDTO()
        {
            Produto produto = new Produto();
            produto.Tipo = cbTipoProd.Text;
            produto.Nome = txtNomeProd.Text;
            produto.Preco = txtPrecoProd.Text;

            return produto;
        }

        private void setDTO(Produto prod)
        {
            cbTipoProd.Text = prod.Tipo;
            txtNomeProd.Text = prod.Nome;
            txtPrecoProd.Text = prod.Preco;
            txtCodigoProd.Text = prod.Codigo.ToString();
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            ProdutoDAO prodDAO = new ProdutoDAO();
            List<Produto> lista = prodDAO.listaProdutos();
            List<String> listaAux = new List<String>();

            foreach (Produto p in lista)
            {
                dgListaProd.Rows.Add(p.Tipo, p.Codigo, p.Nome, p.Preco);

                if (!listaAux.Contains(p.Tipo.ToUpper()))
                    listaAux.Add(p.Tipo.ToUpper());
            }
            foreach (String s in listaAux)
            {
                cbTipoProd.Items.Add(s);
            }
           
        }

        private void btnTelaProdCancela_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgListaProd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            btnEditarProd.Enabled = true;
            string aux = dgListaProd[e.RowIndex, 2].Value.ToString() ;
            int codigo = int.Parse(aux);            
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto prod = produtoDAO.Read(codigo);
            

            setDTO(prod);*/
        }

        private void dgListaProd_MouseClick(object sender, DataGridViewCellEventArgs e)
        {/*
            btnEditarProd.Enabled = true;
            string aux = dgListaProd[e.RowIndex, dgProdColCodigo.Index].Value.ToString();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            int codigo = int.Parse(aux);
            Produto prod = produtoDAO.Read(codigo);

            setDTO(prod);*/
        }

        

        private void txtPrecoProd_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPrecoProd_TextChanged(object sender, EventArgs e)
        {
            if(!(txtPrecoProd.Text == null))
            {
                //float preco = float.Parse(txtPrecoProd.Text);
                //txtPrecoProd.Text.Replace(txtPrecoProd.Text, preco.ToString("C"));
                //txtPrecoProd.Text = preco.ToString("C");
            }
        }
    }
}
