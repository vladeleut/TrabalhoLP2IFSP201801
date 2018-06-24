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

        public Produto Read(int codigo)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            Produto prod = null;

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select codigo, nome, preco, tipo from produto where codigo = @Codigo";
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
        }

        public void Delete(int cod)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "DELETE from produto where codigo = @cod";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@cod", cod);

            dbDelivery.ExecuteSQL(comm);
        }
        
        public void Update(Produto prod)
        {
            Database dbDelivery = Database.GetInstance();
            String qry = "UPDATE produto set nome = @Nome, tipo = @Tipo, preco = @Preco where codigo = @Codigo;";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.AddWithValue("@Nome", prod.Nome);
            comm.Parameters.AddWithValue("@Tipo", prod.Tipo);
            comm.Parameters.AddWithValue("@Preco", prod.Preco);

            dbDelivery.ExecuteSQL(comm);
        }

        public List<Produto> listaProdutos()
        {
            List<Produto> listaProd = new List<Produto>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select codigo, nome, preco, tipo from produto";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos coocar as inf obtias no objeto
            while (dr.Read())
            {
                Produto prod = new Produto();
                prod.Codigo = dr.GetInt32(0);
                prod.Nome = dr.GetString(1);
                prod.Preco = dr.GetString(2);
                prod.Tipo = dr.GetString(3);


                listaProd.Add(prod);
            }
            dr.Close();
            conn.Close();
            return listaProd;
        }

        public List<Produto> ListaPorTipo(string tipo)
        {
            List<Produto> listaPorTipo = new List<Produto>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            String qry = "";

            if (tipo.Equals("outros"))
                qry = "Select codigo, nome, preco, tipo from produto where tipo not in ('lanche','pizza','bebida')  order by tipo, nome;";
            else
                qry = "Select codigo, nome, preco, tipo from produto where tipo like @Tipo order by nome;";
            
            MySqlCommand comm = new MySqlCommand(qry, conn);

            if(!tipo.Equals("outros"))
                comm.Parameters.AddWithValue("@Tipo", tipo);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos colocar as inf obtidas no objeto
            while (dr.Read())
            {
                Produto prod = new Produto();
                prod.Codigo = dr.GetInt32(0);
                prod.Nome = dr.GetString(1);
                prod.Preco = dr.GetString(2);
                prod.Tipo = dr.GetString(3);

                listaPorTipo.Add(prod);
            }
            dr.Close();
            conn.Close();
            return listaPorTipo;
        }


    }
}
