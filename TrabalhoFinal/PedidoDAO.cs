using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrabalhoFinal
{
    class PedidoDAO
    {
        public void Create(Pedido pedido)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into pedido (aberturaPedido, fechamentoPedido, total) values (@AberturaPedido, @FechamentoPedido, @Total)";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@AberturaPedido", pedido.AberturaPedido);
            comm.Parameters.AddWithValue("@FechamentoPedido", pedido.FechamentoPedido);
            comm.Parameters.AddWithValue("@Total", pedido.Total);

            dbDelivery.ExecuteSQL(comm);
        }

        public Pedido Read(int nro_pedido)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            Pedido pedido = null;

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select nro_pedido, aberturaPedido, fechamentoPedido, total from pedido where nro_pedido = @Nro_pedido";
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.Parameters.AddWithValue("@Nro_pedido", nro_pedido);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                pedido = new Pedido();
                pedido.Nro_pedido = dr.GetInt32(0);
                pedido.AberturaPedido = dr.GetDateTime(1);
                pedido.FechamentoPedido = dr.GetDateTime(2);
                pedido.Total = dr.GetFloat(3);

            }

            dr.Close();
            conn.Close();

            return pedido;
        }

        public void Delete(int nro_pedido)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "DELETE from pedido where nro_pedido = @Nro_pedido";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@Nro_pedido", nro_pedido);

            dbDelivery.ExecuteSQL(comm);
        }

        public void Update(Pedido pedido)
        {
            Database dbDelivery = Database.GetInstance();
            String qry = "UPDATE pedido set aberturaPedido = @AberturaPedido, fechamentoPedido = @FechamentoPedido, total = @Total where nro_pedido = @Nro_pedido;";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.AddWithValue("@AberturaPedido", pedido.AberturaPedido);
            comm.Parameters.AddWithValue("@FechamentoPedido", pedido.FechamentoPedido);
            comm.Parameters.AddWithValue("@Total", pedido.Total);

            dbDelivery.ExecuteSQL(comm);
        }

        public List<Pedido> listaPedidos()
        {
            List<Pedido> listaPedido = new List<Pedido>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select cnro_pedido, aberturaPedido, fechamentoPedido, total from pedido";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos coocar as inf obtias no objeto
            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                pedido.Nro_pedido = dr.GetInt32(0);
                pedido.AberturaPedido = dr.GetDateTime(1);
                pedido.FechamentoPedido = dr.GetDateTime(2);
                pedido.Total = dr.GetFloat(3);


                listaPedido.Add(pedido);
            }
            dr.Close();
            conn.Close();
            return listaPedido;
        }

    }
}
