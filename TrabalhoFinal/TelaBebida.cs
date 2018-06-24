﻿using System;
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
    public partial class TelaBebida : Form
    {
        public TelaBebida()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBebida_Load(object sender, EventArgs e)
        {
            ProdutoDAO bebidaDAO = new ProdutoDAO();
            List<Produto> lista = bebidaDAO.ListaPorTipo("bebida");

            foreach (Produto p in lista)
                dgListaBebidas.Rows.Add(p.Nome, p.Preco, p.Codigo);
        }
    }
}
