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
            Database dbBiblioteca = Database.GetInstance();
            string qry = string.Format("INSERT INTO cliente(telefone,nome,logradouro, nro, complemento, referencia, observacao) values ('{0}', '{1}','{2}','{4}', '{5}','{6}')",
                                        cliente.Telefone, cliente.Nome, cliente.Logradouro, cliente.Numero, cliente.Complemento, cliente.Referencia, cliente.Observacao);
            dbBiblioteca.ExecuteSQL(qry);
        }
        public Cliente Read(string telefone)
        {
            Cliente cliente = null;
            MySqlConnection conn = Database.GetInstance().GetConnection();

            string qry = "Select telefone,nome,logradouro, nro, complemento, referencia, observacao where telefone like '%" + telefone +"%'");
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand comm = new MySqlCommand(qry, conn);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                cliente = new Cliente();
                cliente.Telefone = dr.GetString(0);
                cliente.Nome = dr.GetString(1);
                cliente.Logradouro = dr.GetString(2);
                cliente.Numero = dr.GetInt32(3);
                cliente.Complemento = dr.GetString(4);
                cliente.Referencia = dr.GetString(5);
                cliente.Observacao = dr.GetString(6);
            }
            dr.Close();
            conn.Close();
            return cliente;
        }





        /// <summary>
        /// editado aé aqui.
        /// </summary>
        /// <param name="cliente"></param>
        public void Update(Cliente cliente)
        {
            Database dbBiblioteca = Database.GetInstance();
            string qry = string.Format("UPDATE aluno SET nome = '{0}', cpf = '{1}' dtnasc = '{2}' WHERE codigo = {3}",
                                        aluno.Nome, aluno.CPF, aluno.DataNasc.ToString("yyyy-MM-dd"), aluno.Codigo);
            dbBiblioteca.ExecuteSQL(qry);
        }
        public void Delete(int codigo)
        {
            Database dbBiblioteca = Database.GetInstance();
            string qry = "DELETE FROM aluno WHERE codigo = " + codigo;
            dbBiblioteca.ExecuteSQL(qry);
        }
        public List<Aluno> ListAll()
        {
            List<Aluno> lista = new List<Aluno>();
            Aluno aluno;

            MySqlConnection conn = Database.GetInstance().GetConnection();

            string qry = "Select codigo, nome, cpf, dtnasc from aluno";
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand comm = new MySqlCommand(qry, conn);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                aluno = new Aluno();
                aluno.Codigo = dr.GetInt32(0);
                aluno.Nome = dr.GetString(1);
                aluno.CPF = dr.GetString(2);
                aluno.DataNasc = dr.GetDateTime(3);

                lista.Add(aluno);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public List<Aluno> FindByName(string nome)
        {
            List<Aluno> lista = new List<Aluno>();
            Aluno aluno;

            MySqlConnection conn = Database.GetInstance().GetConnection();

            string qry;
            if (nome != "")//se não é vazio
            {
                qry = string.Format("SELECT codigo, nome, cpf, dtnasc FROM aluno WHERE nome LIKE '%{0}%'", nome);
            }
            else
                qry = "select codigo, nome, cpf, dtnasc FROM aluno";


            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand comm = new MySqlCommand(qry, conn);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                aluno = new Aluno();
                aluno.Codigo = dr.GetInt32(0);
                aluno.Nome = dr.GetString(1);
                aluno.CPF = dr.GetString(2);
                aluno.DataNasc = dr.GetDateTime(3);

                lista.Add(aluno);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
    }
}
