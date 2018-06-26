using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrabalhoFinal
{
    class caixaDAO
    {
        public void AbreCaixa()
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into caixa (abertura) values (sysdate());";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros

            dbDelivery.ExecuteSQL(comm);
        }

        public int EncontraCaixaAberto()
        {
            int id = 0;

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select id from caixa where estado = 'aberto'";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
                id = dr.GetInt32(0);

            dr.Close();
            conn.Close();

            return id;
        }

        public void FechaCaixa(int id)
        {
            Database dbDelivery = Database.GetInstance();
            String qry = "UPDATE caixa set fechamento = sysdate(), estado = 'Fechado' where id = @Id;";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.AddWithValue("@Id", id);

            dbDelivery.ExecuteSQL(comm);
        }
    }
}
