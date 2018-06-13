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
    public partial class FormPizza : Form
    {
        public FormPizza()
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
    } }
