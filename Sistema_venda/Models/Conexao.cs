using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_venda.Models
{
    public class Conexao
    {

        public string Mensagem { get; set; }


        MySqlConnection Connection = new MySqlConnection();


        public Conexao() {
        
        Connection.ConnectionString = @"server=127.0.0.1;Uid=root;database=SYSTVENDA20"; 

        
        }

        public MySqlConnection Conectar()
        {
            if(Connection.State == System.Data.ConnectionState.Closed)
            {

                Connection.Open();
            }

            return Connection;

        }

        public void Desconectar()
        {

            if(Connection.State == System.Data.ConnectionState.Open)
            {

                Connection.Close();
            }



        }



    }
}
