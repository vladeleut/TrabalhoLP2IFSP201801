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
    public partial class TelaPizza : Form
    {
        public TelaPizza()
        {
            InitializeComponent();
        }
        private void FormPizza_Load(object sender, EventArgs e)
        {
            ProdutoDAO pizzaDAO = new ProdutoDAO();
            List<Produto> lista = pizzaDAO.ListaPorTipo("pizza");

            foreach (Produto p in lista)
                dgListaPizza.Rows.Add(p.Nome, p.Preco, p.Codigo);


            lista = pizzaDAO.ListaPorTipo("Adicionais - pizza");
            foreach (Produto adc in lista)
                dgAdicionaisPizza.Rows.Add(adc.Nome, adc.Preco, adc.Codigo);

        }

    } }
