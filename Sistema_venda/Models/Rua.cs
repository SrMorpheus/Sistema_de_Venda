using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public   class Rua
    {
       public int CodRua { get; set; }
       
       public string NomeRua { get; set; }

       public int Fk_bloco { get; set; }

        public static List<Rua> ListagemRua { get; set; }

       public Bloco Bloco { get; set; }


        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();



        public void ListarRua(int x)
        {
            cmd.CommandText = "select *from tbl_rua where fk_bloco = @x";

            cmd.Parameters.AddWithValue("@x", x);

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemRua = new List<Rua>();

                    while(reader.Read()){


                        ListagemRua.Add(new Rua() { CodRua = reader.GetInt32(0), NomeRua = reader.GetString(1) });
                    }

                }


            }
            catch (MySqlException e )
            {

                MessageBox.Show("Esse error meu chefe : " + e);

            }



        }

        public void ListarRuaFk(int x)
        {
            cmd.CommandText = "Select *from tbl_rua where cod_rua = @x ";



            cmd.Parameters.AddWithValue("@x", x);

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemRua = new List<Rua>();

                    while (reader.Read())
                    {


                        ListagemRua.Add(new Rua() { CodRua = reader.GetInt32(0), NomeRua = reader.GetString(1), Fk_bloco = reader.GetInt32(2) });
                    }

                }


            }
            catch (MySqlException e)
            {

                MessageBox.Show("Esse error meu chefe : " + e);

            }



        }



    }
}
