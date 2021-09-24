using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public class Categoria
    {
       public int CodCategoria { get; set; }
        
        public string NomeCategoria { get; set; }


        public static List<Categoria> ListagemCategoria { get; set; }

        //variveis static use apenas uma vez
        static Conexao conexaoaStatic = new Conexao();

        static MySqlCommand  cmdStatic = new MySqlCommand();

         Conexao conexao = new Conexao();

         MySqlCommand cmd = new MySqlCommand();



        public Categoria()
        {

        }

        public static void ListarCategoria() 
        { 

            cmdStatic.CommandText = "select * from tbl_categoria order by nome_categoria" ;

            try
            {

                cmdStatic.Connection = conexaoaStatic.Conectar();

                cmdStatic.ExecuteNonQuery();

                MySqlDataReader reader = cmdStatic.ExecuteReader();

                if (reader.HasRows)
                {
                    ListagemCategoria = new List<Categoria>();

                    while (reader.Read())
                    {

                        ListagemCategoria.Add(new Categoria() { CodCategoria = reader.GetInt32(0), NomeCategoria = reader.GetString(1) });

                    }

                    reader.Close();

                    conexaoaStatic.Desconectar();

                }

            }
            catch ( MySqlException e)
            {
                MessageBox.Show("Deu error maluco "+e);

            }

        }

        public  void ListarCategoria( int x )
        {

            cmd.CommandText = "select *from tbl_categoria  where cod_categoria =  @x";

            cmd.Parameters.AddWithValue("@x", x);


            

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    ListagemCategoria = new List<Categoria>();

                    while (reader.Read())
                    {

                        ListagemCategoria.Add(new Categoria() { CodCategoria = reader.GetInt32(0), NomeCategoria = reader.GetString(1) });

                    }

                    reader.Close();

                    conexao.Desconectar();

                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Deu error maluco " + e);

            }

        }




    }
}
