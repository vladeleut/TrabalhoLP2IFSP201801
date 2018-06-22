using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrabalhoFinal
{
    class ClienteDAO
    {
        public void Create(Cliente cliente)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "insert into cliente (telefone, nome, logradouro, bairro, complemento, referencia, observacao) values (@Telefone, @Nome, @Logradouro, @Bairro, @Complemento, @Referencia, @Observacao)";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@Nome", cliente.Nome);
            comm.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            comm.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
            comm.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            comm.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            comm.Parameters.AddWithValue("@Referencia", cliente.Referencia);
            comm.Parameters.AddWithValue("@Observacao", cliente.Observacao);

            dbDelivery.ExecuteSQL(comm);
        }

        public Cliente Read(string tel)
        {
            MySqlConnection conn = Database.GetInstance().GetConnection();
            Cliente cliente = null;

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select codigo, telefone, nome, logradouro, bairro, complemento, referencia, observacao from cliente where telefone like @Telefone";
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.Parameters.AddWithValue("@Telefone", tel);

            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                cliente = new Cliente();
                cliente.Codigo = dr.GetInt32(0);
                cliente.Telefone = dr.GetString(1);
                cliente.Nome = dr.GetString(2);
                cliente.Logradouro = dr.GetString(3);
                cliente.Bairro = dr.GetString(4);
                cliente.Complemento = dr.GetString(5);
                cliente.Referencia = dr.GetString(6);
                cliente.Observacao = dr.GetString(7);

            }

            dr.Close();
            conn.Close();

            return cliente;
        }

        public void Delete(int cod)
        {
            Database dbDelivery = Database.GetInstance();

            string qry = "DELETE from produto where codigo = @cod";

            MySqlCommand comm = new MySqlCommand(qry); //seta parâmetros
            comm.Parameters.AddWithValue("@cod", cod);

            dbDelivery.ExecuteSQL(comm);
        }

        public void Update(Cliente cliente)
        {
            Database dbDelivery = Database.GetInstance();
            String qry = "UPDATE produto set telefone = @Telefone, Nome = @Nome, logradouro = @Logradouro, bairro = @Bairro, complemento = @Complemento, referencia = @Referencia, observacao = @Observacao where codigo = @Codigo;";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.AddWithValue("@Nome", cliente.Nome);
            comm.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            comm.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
            comm.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            comm.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            comm.Parameters.AddWithValue("@Referencia", cliente.Referencia);
            comm.Parameters.AddWithValue("@Observacao", cliente.Observacao);
            dbDelivery.ExecuteSQL(comm);
        }

        public List<Cliente> listaCliente()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            MySqlConnection conn = Database.GetInstance().GetConnection();

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string qry = "Select codigo,telefone, nome, logradouro, bairro, complemento, referencia, observacao from cliente";
            MySqlCommand comm = new MySqlCommand(qry, conn);

            MySqlDataReader dr = comm.ExecuteReader();

            //precisamos coocar as inf obtias no objeto
            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Codigo = dr.GetInt32(0);
                cliente.Telefone = dr.GetString(1);
                cliente.Nome = dr.GetString(2);
                cliente.Logradouro = dr.GetString(3);
                cliente.Bairro = dr.GetString(4);
                cliente.Complemento = dr.GetString(5);
                cliente.Referencia = dr.GetString(6);
                cliente.Observacao = dr.GetString(7);


                listaCliente.Add(cliente);
            }
            dr.Close();
            conn.Close();
            return listaCliente;
        }
    }
}
