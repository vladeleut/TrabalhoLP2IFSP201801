using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoFinal
{
    class Database
    {
        private static MySqlConnection conn;
        private static Database instance;
        private const string connString = "Server = localhost; Database = trabalhoFinal; Uid = root; Pwd = admin;";

        private Database()
        {
            try//pode dar errado
            {
                conn = new MySqlConnection(connString);//inicia a conexão
                GeraBanco();//Cria o banco de dados caso ele não exista na máquina.
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
        public MySqlConnection GetConnection()
        {
            return conn;//uma vez conectado, só precisa retornar a conexão
        }

        public void ExecuteSQL(MySqlCommand comm)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                comm.Connection = conn;
                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void GeraBanco()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand comm;//gera comandos através da conexão (?)
                StringBuilder qry = new StringBuilder();

                qry.AppendLine("create database if not exists delivery");

                comm = new MySqlCommand(qry.ToString(), conn);
                comm.ExecuteNonQuery();

                //use database
                conn.ChangeDatabase("delivery");

                qry.Clear();
                qry.AppendLine(" create table if not exists cliente(");
                qry.AppendLine("codigo int not null auto_increment,");
                qry.AppendLine("telefone varchar(14) not null,");
                qry.AppendLine("nome varchar(80),");
                qry.AppendLine("logradouro varchar(150),");
                qry.AppendLine("bairro varchar(30),");
                qry.AppendLine("complemento varchar(40),");
                qry.AppendLine("referencia varchar(100),");
                qry.AppendLine("observacao varchar(80),");
                qry.AppendLine("constraint cliente_pk primary key(codigo));");

                comm = new MySqlCommand(qry.ToString(), conn);
                comm.ExecuteNonQuery();

                qry.Clear();
                qry.AppendLine("create table if not exists produto(");
                qry.AppendLine("codigo int auto_increment,");
                qry.AppendLine("nome varchar(80),");
                qry.AppendLine("tipo varchar(20),");
                qry.AppendLine("preco float,");
                qry.AppendLine("constraint prod_pk primary key(codigo));");
                comm = new MySqlCommand(qry.ToString(), conn);
                comm.ExecuteNonQuery();

            }
            catch (Exception e )
            {
                MessageBox.Show(e.ToString());
            }
        }


        /*
        public void ExecuteSQL(string qry)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }*/
        


    }
}
