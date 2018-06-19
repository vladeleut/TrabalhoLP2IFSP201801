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

      

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
                

        }

        private void btnCancelaPedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPizza_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPizzas.pizza'. Você pode movê-la ou removê-la conforme necessário.
            this.pizzaTableAdapter.Fill(this.dataSetPizzas.pizza);

        }
    } }
