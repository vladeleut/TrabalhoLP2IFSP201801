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
            dgListaProd.Refresh();
        }

        private Produto getDTO()
        {
            Produto produto = new Produto();
            produto.Tipo = txtTipoProd.Text;
            produto.Nome = txtNomeProd.Text;
            produto.Preco = txtPrecoProd.Text;

            return produto;
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            ProdutoDAO prodDAO = new ProdutoDAO();
            List<Produto> lista = prodDAO.listaProdutos();

            foreach (Produto p in lista)
            {
                dgListaProd.Rows.Add(p.Tipo, p.Codigo, p.Nome, p.Preco);
            }
        }
    }
}
