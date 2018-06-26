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
        /*
        public void Create(Pedido pedido)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into pedido_dados (aberturaPedido) values (sysdate());";

            MySqlCommand comm = new MySqlCommand(qry); 

            dbDelivery.ExecuteSQL(comm);
        }*/
        public void CriaPedido()
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into pedido_dados (aberturaPedido, flagStatus) values (sysdate(), 1);";

            MySqlCommand comm = new MySqlCommand(qry);

            dbDelivery.ExecuteSQL(comm);
        }

        public void AbrePedidoNovo(Pedido pedido)
        {
            //return pedido.Nro_pedido;
        }
/*
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

            }

            dr.Close();
            conn.Close();

            return pedido;
        }
        
        
        private String TempoAteFechamento(int nro_pedido)//usamos apenas dentro da classe (por enquanto)
        {
            String tempoDoPedido = "";
            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select timediff(fechamentoPedido, aberturaPedido from pedido where nro_pedido = @Nro_pedido";
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.Parameters.AddWithValue("@Nro_pedido", nro_pedido);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
                tempoDoPedido = dr.GetString(0);

            dr.Close();
            conn.Close();
            return tempoDoPedido;
        }
        */

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
            //comm.Parameters.AddWithValue("@Total", pedido.Total);

            dbDelivery.ExecuteSQL(comm);
        }

        public List<Pedido> ListaPedidos()//usada para povoar datagrid da tela de pedidos
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
                                                                                    //se a fechamento - dataAbertura for null, é pq está aberto. faz AGORA-dataAbertura
            string qry = "select pd.nro, pd.situacao, pd.cliente, c.nome, c.bairro, ifnull(timediff(pd.fechamentoPedido, pd.aberturaPedido), timediff(sysdate(), pd.aberturaPedido)) from pedido_dados pd, cliente c where c.codigo = pd.cliente;"; 
    
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos colocar as inf obtidas no objeto
            while (dr.Read())
            {
                Pedido pedido = new Pedido();

                pedido.Nro_pedido = dr.GetInt32(0);
                pedido.Situacao = dr.GetString(1);
                pedido.Cliente = dr.GetInt32(2);
                pedido.NomeCliente = dr.GetString(3);
                pedido.BairroCliente = dr.GetString(4);
                pedido.Tempo = dr.GetString(5);
                /*
                if (pedido.Situacao.Equals("Aberto"))
                    pedido.Tempo = dr.GetString(5);
                else
                    pedido.Tempo = dr.GetString(6);*/

                listaPedidos.Add(pedido);
            }
            dr.Close();
            conn.Close();
            return listaPedidos;
        }

        public List<Pedido> ListaPedidosDeHoje()//mostra apenas os pedidos do dia
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            //se a fechamento - dataAbertura for null, é pq está aberto. faz AGORA-dataAbertura
            string qry = "select pd.nro, pd.situacao, pd.cliente, c.nome, c.bairro, ifnull(timediff(pd.fechamentoPedido, pd.aberturaPedido), timediff(sysdate(), pd.aberturaPedido)) from pedido_dados pd, cliente c where c.codigo = pd.cliente and timediff(sysdate(),pd.aberturaPedido)<'12:00:00';";
            
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos colocar as inf obtidas no objeto
            while (dr.Read())
            {
                Pedido pedido = new Pedido();

                pedido.Nro_pedido = dr.GetInt32(0);
                pedido.Situacao = dr.GetString(1);
                pedido.Cliente = dr.GetInt32(2);
                pedido.NomeCliente = dr.GetString(3);
                pedido.BairroCliente = dr.GetString(4);
                pedido.Tempo = dr.GetString(5);
                /*
                if (pedido.Situacao.Equals("Aberto"))
                    pedido.Tempo = dr.GetString(5);
                else
                    pedido.Tempo = dr.GetString(6);*/

                listaPedidos.Add(pedido);
            }
            dr.Close();
            conn.Close();
            return listaPedidos;
        }


        public void InsereItem(int nro_pedido, int cod_produto)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into pedido_itens (nro_pedido, cod_produto, qtde_produto) values (@Nro, @Cod, 1);";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.AddWithValue("@Nro", nro_pedido);
            comm.Parameters.AddWithValue("@Cod", cod_produto);

            dbDelivery.ExecuteSQL(comm);
        }


        public int EncontraPedidoNovo()
        {
            int nroPedido = 0;

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select nro from pedido_dados where flagStatus = 1";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
                nroPedido = dr.GetInt32(0);

            dr.Close();
            conn.Close();

            //nroPedido = 3;//tirar essa linha após testes

            return nroPedido;
        }

        public Pedido PedidoNro(int nroPedido)
        {
            Pedido pedido = null;

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();


            //vou ter q ler os dados do pedido e a lista de produtos separadamente. vamos para os dados do pedido:
            string qry = "select aberturaPedido, ifnull(cliente, 0) from pedido_dados  where nro = @Numero;";
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.Parameters.AddWithValue("@Numero", nroPedido);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                pedido = new Pedido();
                pedido.AberturaPedido = dr.GetMySqlDateTime(0);
                pedido.Cliente = dr.GetInt32(1);
            }

            dr.Close();
            conn.Close();

            return pedido;

        }



        public void AssociaClientePedido(int nroCliente, int nroPedido)
        {
            Database dbDelivery = Database.GetInstance();
            String qry = "UPDATE pedido_dados set cliente = @NumeroCliente where nro = @Nro_pedido;";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.AddWithValue("@NumeroCliente", nroCliente);
            comm.Parameters.AddWithValue("@Nro_pedido", nroPedido);

            dbDelivery.ExecuteSQL(comm);
        }

        public void AtualizaEstado(int nroPedido, int novoEstado)
        {
            Database dbDelivery = Database.GetInstance();

            String qry = "";

            if (novoEstado == 3)//3 signifca que o pedido está sendo fechado. precisa mudar a string da coluna Situacao
                qry = "UPDATE pedido_dados set flagStatus = @FlagNovoStatus, situacao = 'Fechado', fechamentoPedido=sysdate() where nro = @Nro_pedido;";
            else
                qry = "UPDATE pedido_dados set flagStatus = @FlagNovoStatus where nro = @Nro_pedido;";


            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.AddWithValue("@FlagNovoStatus", novoEstado);
            comm.Parameters.AddWithValue("@Nro_pedido", nroPedido);

            dbDelivery.ExecuteSQL(comm);
        }

        public void RemoveItemDoPedido(int codigoProduto, int nro_pedido)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "DELETE from pedido_itens where nro_pedido = @Nro_pedido and cod_produto = @Codigo";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@Nro_pedido", nro_pedido);
            comm.Parameters.AddWithValue("@Codigo", codigoProduto);

            dbDelivery.ExecuteSQL(comm);
        }
        
    }
}
