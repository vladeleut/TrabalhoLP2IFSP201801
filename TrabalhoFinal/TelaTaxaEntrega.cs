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
    public partial class TelaTaxaEntrega : Form
    {
        public TelaTaxaEntrega()
        {
            InitializeComponent();
        }

        private TaxaDeEntrega getDTO()
        {
            TaxaDeEntrega taxa = new TaxaDeEntrega();
            taxa.Distancia = txtDistancia.Text;
            taxa.Bairro = txtBairro.Text;
            taxa.Preco = float.Parse(txtPrecoTaxa.Text);

            return taxa;
        }

        private void setDTO(TaxaDeEntrega taxa)
        {
            txtDistancia.Text = taxa.Distancia;
            txtBairro.Text = taxa.Bairro;
            txtPrecoTaxa.Text = taxa.Preco.ToString("C");
        }

        private TaxaDeEntregaDAO taxaDeEntregaDAO = new TaxaDeEntregaDAO();

        private void SetVisible()
        {
            lblBairro.Visible = true;
            lblNome.Visible = true;
            lblPrecoTaxa.Visible = true;
            txtBairro.Visible = true;
            txtDistancia.Visible = true;
            txtPrecoTaxa.Visible = true;
            btnInsereTaxa.Visible = true;
            btnTelaProdCancela.Visible = true;
        }

        private void SetInvisible()
        {
            lblBairro.Visible = false;
            lblNome.Visible = false;
            lblPrecoTaxa.Visible = false;
            txtBairro.Visible = false;
            txtDistancia.Visible = false;
            txtPrecoTaxa.Visible = false;
            btnInsereTaxa.Visible = false;
            btnTelaProdCancela.Visible = false;
        }



        private void btnNovaTaxa_Click(object sender, EventArgs e)
        {
            SetVisible();

        }

        private void btnTelaProdCancela_Click(object sender, EventArgs e)
        {
            SetInvisible();
        }

        private void btnInsereTaxa_Click(object sender, EventArgs e)
        {
            TaxaDeEntrega taxa = new TaxaDeEntrega();
            taxa = getDTO();
            taxaDeEntregaDAO.Insere(taxa);
            txtBairro.Text = "";
            txtDistancia.Text = "";
            txtPrecoTaxa.Text = "";
            SetInvisible();
            AtualizaDataGrid();
        }

        private void PovoaDataGrid()
        {
            List<TaxaDeEntrega> lista = taxaDeEntregaDAO.listaTudo();
            foreach (TaxaDeEntrega t in lista)
                dgEntregas.Rows.Add(t.Distancia, t.Bairro, t.Preco.ToString("C"));
        }

        private void AtualizaDataGrid()
        {
            dgEntregas.Rows.Clear();
            PovoaDataGrid();
        }


        private void TelaTaxaEntrega_Load(object sender, EventArgs e)
        {
            PovoaDataGrid();

        }

        private void txtPesqTaxa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqTaxa.Text == null | txtPesqTaxa.Text == "")
                PovoaDataGrid();

            dgEntregas.Rows.Clear();
            List<TaxaDeEntrega> pesquisa = new List<TaxaDeEntrega>();
            pesquisa = taxaDeEntregaDAO.listaTaxaPorPesquisa(txtPesqTaxa.Text);
            foreach (TaxaDeEntrega t in pesquisa)
                dgEntregas.Rows.Add(t.Distancia, t.Bairro, t.Preco.ToString("C"));
        }
    }
}
