using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public class Loginn
    {
        public int CodLogin { get; set; }

        public string CpfLogin {get; set;}

        public string LoginUser { get; set; }

        public string Senha { get; set; }

        public Usuario Usuario { get; set; }

        public static int FkUsuario { get; set; }

        public bool Confirm { get; set; }
        public int ConfirmInt { get; set; }



        Conexao conexao = new Conexao();

         

        MySqlCommand cmd = new MySqlCommand();



        public Loginn()
        {


        }

        public Loginn(string loginUser, string senha)
        {
            this.LoginUser = loginUser;


            this.Senha = senha;

        }








        public void EntrarSistema()
        {
            cmd.CommandText = "Select Fn_Valida_entrada(@this.LoginUser, @this.Senha)";

            cmd.Parameters.AddWithValue("@this.LoginUser", this.LoginUser);

            cmd.Parameters.AddWithValue("@this.Senha", this.Senha);



            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        this.Confirm = reader.GetBoolean(0);

                    }

                }

                reader.Close();
                
                conexao.Desconectar();

            }

                

            catch ( MySqlException e)
            {
                MessageBox.Show("Deu ruim no sistema irmão error foi esse aqui: " + e);


            }




        }




            public void Entrar()
        {

            cmd.CommandText = "Select fk_usuario from tbl_login where cpf_login = @this.LoginUser and  Login = @this.LoginUser";

          // cmd.Parameters.AddWithValue("@this.LoginUser", this.LoginUser);


            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows){

                    while (reader.Read())
                    {
                        FkUsuario = reader.GetInt32(0);

                    }

                }

                reader.Close();

                conexao.Desconectar();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Deu ruim no sistema irmão error foi esse aqui: " + e);

            }


        }
        

            public  void ValidarResetarSenha( string email, string cpf)
        {

            cmd.CommandText = "select fn_Valida_senha_resetar(@email, @cpf)";

            cmd.Parameters.AddWithValue("@email", email);

          cmd.Parameters.AddWithValue("@cpf", cpf);


            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                     this.Confirm = reader.GetBoolean(0);
                    }


                }

                reader.Close();

                conexao.Desconectar();



            }
            catch ( MySqlException e)
            {

                MessageBox.Show("Deu ruim no sistema irmão error foi esse aqui: " + e);
            }


        }




        public  void ResetarSenha(string email, string cpf)
        {
            cmd.CommandText = "call Procedure_Resetar(@email, @cpf)";

            //cmd.Parameters.AddWithValue("@email", email);

             //cmd.Parameters.AddWithValue("@cpf", cpf);


            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                

                conexao.Desconectar();



            }
            catch (MySqlException e)
            {

                MessageBox.Show("Deu ruim no sistema irmão error foi esse aqui: " + e);
            }


        }


        public void  ConfirmarSenha(int usuario , string senhaAtual)
        {


            cmd.CommandText = "Select fn_alterar_senha(@usuario, @senhaAtual)";

              cmd.Parameters.AddWithValue("@usuario", usuario);

            cmd.Parameters.AddWithValue("@senhaAtual", senhaAtual);

        


            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        this.Confirm = reader.GetBoolean(0);

                       

                    }

                }


                reader.Close();

                conexao.Desconectar();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Deu ruim no sistema: " + e);

            }



        }

        public void AlterarSenha(int usuario, string senhaAtual, string senhaNova)
        {


            cmd.CommandText = " call Procedure_alterar_senha(@usuario, @senhaAtual, @senhaNova)";

            //cmd.Parameters.AddWithValue("@usuario", usuario);

            //cmd.Parameters.AddWithValue("@senhaAtual", senhaAtual);

            cmd.Parameters.AddWithValue("@senhaNova", senhaNova);


            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();



                conexao.Desconectar();



            }
            catch (MySqlException e)
            {

                MessageBox.Show("Deu ruim no sistema irmão error foi esse aqui: " + e);
            }


        }



    }

    }






    

