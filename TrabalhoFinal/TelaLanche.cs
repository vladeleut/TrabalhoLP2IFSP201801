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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLanche_Load(object sender, EventArgs e)
        {
            ProdutoDAO lancheDAO = new ProdutoDAO();
            List<Produto> lista = lancheDAO.ListaPorTipo("lanche");

            foreach (Produto p in lista)
                dgListaLanche.Rows.Add(p.Nome, p.Preco, p.Codigo);

        }
    }
}
