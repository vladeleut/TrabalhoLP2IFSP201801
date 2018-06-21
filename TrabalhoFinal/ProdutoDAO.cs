using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrabalhoFinal
{
    class ProdutoDAO
    {
        public void Create(Produto produto)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into produto (tipo, nome, preco) values (@Tipo, @Nome, @Preco)";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@Nome", produto.Nome);
            comm.Parameters.AddWithValue("@Tipo", produto.Tipo);
            comm.Parameters.AddWithValue("@Preco", produto.Preco);

            dbDelivery.ExecuteSQL(comm);
        }

        /*public Produto Read(int codigo)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            Produto prod = null;

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select * from produto where codigo = @Codigo";
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.Parameters.AddWithValue("@Codigo", codigo);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                prod = new Produto();
                prod.Codigo = dr.GetInt32(0);
                prod.Nome = dr.GetString(1);
                prod.Preco = dr.GetString(2);
                prod.Tipo = dr.GetString(3);

            }

            dr.Close();
            conn.Close();

            return prod;
        }*/

        //Delete
        //Update

        public List<Produto> listaProdutos()
        {
            List<Produto> listaProd = new List<Produto>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select * from produto";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos coocar as inf obtias no objeto
            while (dr.Read())
            {
                Produto prod = new Produto();
                prod.Codigo = dr.GetInt32(0);
                prod.Nome = dr.GetString(1);
                prod.Preco = dr.GetString(2);   //dr.GetFloat(2);
                prod.Tipo = dr.GetString(3);


                listaProd.Add(prod);
            }
            dr.Close();
            conn.Close();
            return listaProd;
        }

    }
}
