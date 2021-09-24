using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public class Cliente
    {
        public int CodCliente { get; set; }

        public string NomeCliente { get; set; }

        public Rua Rua { get; set; }

        public int FkEndereco { get; set; }

        public string ComplementoCliente { get; set; }

        public static List<Cliente> ListagemCliente { get; set; }

        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();



        public void ListarCliente()
        {

            cmd.CommandText = "select *from tbl_cliente";

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemCliente = new List<Cliente>();

                    while (reader.Read())
                    {

                        ListagemCliente.Add(new Cliente() { CodCliente = reader.GetInt32(0), NomeCliente = reader.GetString(1), FkEndereco = reader.GetInt32(2), ComplementoCliente = reader.GetString(3) });

                    }

                }

                reader.Close();

                conexao.Desconectar();


            }
            catch (MySqlException e)
            {
                MessageBox.Show("Agora te programa deu um bug aqui: " + e);

            }


        }







    }
}
