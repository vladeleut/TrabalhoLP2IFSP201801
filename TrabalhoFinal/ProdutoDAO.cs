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

            string qry = "insert into produto (nome, tipo, preco) values (@Nome, @Tipo, @Preco)";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@Nome", produto.Nome);
            comm.Parameters.AddWithValue("@Tipo", produto.Tipo);
            comm.Parameters.AddWithValue("@Preco", produto.Preço);

            dbDelivery.ExecuteSQL(comm);
        }

        //read
        //Delete
        //Update
        //List 

    }
}
