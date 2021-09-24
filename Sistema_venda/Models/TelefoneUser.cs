using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
   public  class TelefoneUser
    {
        public int CodTelefone { get; set; }

        public string DDD { get; set; }

        public string Numero { get; set; }

        public int FkUser { get; set; }

        public Usuario Usuario { get; set; }

        public static List<TelefoneUser> ListagemTelefone { get; set; }



        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();


        public TelefoneUser()
        {

        }


        public TelefoneUser(string ddd, string numero, int fkUser )
        {

            this.DDD = ddd;

            this.Numero = numero;

            this.FkUser = fkUser;


        }

        public TelefoneUser(int cod, string ddd, string numero, int fkUser)
        {

            this.CodTelefone = cod;

            this.DDD = ddd;

            this.Numero = numero;

            this.FkUser = fkUser;

        }

            public void Inserir()
        {
            cmd.CommandText = "Insert into tbl_telefone_usuario() values (default, @this.DDD, @this.Numero, @this.FkUser)";

            cmd.Parameters.AddWithValue("@this.DDD", this.DDD);

            cmd.Parameters.AddWithValue("@this.Numero",this.Numero);

            cmd.Parameters.AddWithValue("@this.FkUser", this.FkUser);



            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

            }
            catch (MySqlException e)
            {

                MessageBox.Show("Deu ruim aqui não deveria , mas o error esse aqui: " + e);

            }

        }



        public void ListarTelefone(int x)
        {

            cmd.CommandText = "select *from tbl_telefone_usuario where fk_usuario_telefone = @x" ;


            cmd.Parameters.AddWithValue("@x", x);
            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemTelefone = new List<TelefoneUser>();

                    while (reader.Read())
                    {

                        ListagemTelefone.Add(new TelefoneUser() { CodTelefone = reader.GetInt32(0), DDD = reader.GetString(1), Numero = reader.GetString(2), FkUser = reader.GetInt32(3) });
                    

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



        public void Editar()
        {

          cmd.CommandText ="update tbl_telefone_usuario set ddd_telefone_usuario = @ddd, numero_telefone_usuario = @numero where cod_telefone_usuario = @cod and fk_usuario_telefone = @usuario";


            cmd.Parameters.AddWithValue("@ddd", this.DDD);

            cmd.Parameters.AddWithValue("@numero", this.Numero);

            cmd.Parameters.AddWithValue("@cod", this.CodTelefone);


            cmd.Parameters.AddWithValue("@usuario", this.FkUser);

            



            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

              //  MessageBox.Show("Campos editado  com sucesso!");



            }
            catch (MySqlException e)
            {

                MessageBox.Show("Leke deu error aqui, esse foi o error: " + e);

            }




        }

    }
}
