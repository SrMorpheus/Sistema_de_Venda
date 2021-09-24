using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public class Bloco
    {
        public int CodBloco {get; set;}

        public string NomeBloco { get; set; }

        public static List<Bloco> ListagemBloco { get; set; }

        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();




        public void ListarBloco()
        {

            cmd.CommandText = "Select *from tbl_bloco order by nome_bloco asc";

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemBloco = new List<Bloco>();

                    while (reader.Read())
                    {

                        ListagemBloco.Add(new Bloco() { CodBloco = reader.GetInt32(0), NomeBloco = reader.GetString(1) });

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


        public void ListarBloco(int x)
        {

            cmd.CommandText = "Select * from tbl_bloco where cod_bloco = @x";

            cmd.Parameters.AddWithValue("@x", x);
            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemBloco = new List<Bloco>();

                    while (reader.Read())
                    {

                        ListagemBloco.Add(new Bloco() { CodBloco = reader.GetInt32(0), NomeBloco = reader.GetString(1) });

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
