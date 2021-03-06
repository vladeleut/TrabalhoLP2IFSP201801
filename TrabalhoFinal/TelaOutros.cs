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
    public partial class TelaOutros : Form
    {
        public TelaOutros()
        {
            InitializeComponent();
        }

        private void TelaOutros_Load(object sender, EventArgs e)
        {
            ProdutoDAO outrosDAO = new ProdutoDAO();
            List<Produto> lista = outrosDAO.ListaPorTipo("outros");

            foreach (Produto p in lista)
                dgListaOutros.Rows.Add(p.Tipo, p.Nome, p.Preco, p.Codigo);

        }
    }
    
}
