using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrabalhoFinal
{
    class TaxaDeEntregaDAO
    {

        public void Insere(TaxaDeEntrega taxa)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into taxas(nomeBairro, distancia, preco) values (@Nome, @dist, @preco)";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@Nome", taxa.Bairro);
            comm.Parameters.AddWithValue("@dist", taxa.Distancia);
            comm.Parameters.AddWithValue("@preco", taxa.Preco);

            dbDelivery.ExecuteSQL(comm);
        }

        public List<TaxaDeEntrega> listaTudo()
        {
            List<TaxaDeEntrega> lista = new List<TaxaDeEntrega>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select nomeBairro, distancia, preco from taxas order by distancia, nomeBairro";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                TaxaDeEntrega taxa = new TaxaDeEntrega();
                taxa.Bairro = dr.GetString(0);
                taxa.Distancia = dr.GetString(1);
                taxa.Preco = dr.GetFloat(2);


                lista.Add(taxa);
            }
            dr.Close();
            conn.Close();
            return lista;
        }

        public List<TaxaDeEntrega> listaTaxaPorPesquisa(String s)
        {
            List<TaxaDeEntrega> pesquisa = new List<TaxaDeEntrega>();

            s= "%" + s + "%";

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select nomeBairro, distancia, preco from taxas where nomeBairro like @S or distancia like @S order by distancia, nomeBairro";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            comm.Parameters.AddWithValue("@S", s);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos coocar as inf obtias no objeto
            while (dr.Read())
            {
                TaxaDeEntrega taxa = new TaxaDeEntrega();
                taxa.Bairro = dr.GetString(0);
                taxa.Distancia = dr.GetString(1);
                taxa.Preco = dr.GetFloat(2);


                pesquisa.Add(taxa);
            }
            dr.Close();
            conn.Close();
            return pesquisa;
        }

        public float PesquisaPreco(String bairro)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();

            bairro = "%" + bairro + "%";

            float preco = 0;

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select preco from taxas where nomeBairro like @Bairro";
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.Parameters.AddWithValue("@Bairro", bairro);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
                preco = dr.GetFloat(0);

            dr.Close();
            conn.Close();

            return preco;
        }
    }
    
}
