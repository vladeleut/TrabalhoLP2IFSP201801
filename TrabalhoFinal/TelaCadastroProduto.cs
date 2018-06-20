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
        }

        private Produto getDTO()
        {
            Produto produto = new Produto();
            produto.Tipo = cbTipo.Text;
            produto.Nome = txtNomeProd.Text;
            produto.Preço = float.Parse(txtPrecoProd.Text);

            return produto;
        }
    }
}
