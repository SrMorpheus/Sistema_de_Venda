using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public  class Usuario
    {


            public int CodUsuario { get; set; }

            public string NomeUsuario {get; set;}

            public string NomeEmpresa { get; set; }
            
            public string CpfUsuario { get; set; }
            
            public string DataNascimento { get; set; }

            public string EmailUsuariio { get; set; }

            public int FkEndereco { get; set; }
            
            public Rua Rua { get; set;}

            public string ComplementoEndereco { get; set; }

            public static List<Usuario> ListagemUsuario { get; set; }

            public bool ConfirmEmail { get; set; }

            public bool ConfirmCpf { get; set; }


            Conexao conexao = new Conexao();

            MySqlCommand cmd = new MySqlCommand();


            public Usuario()
        {

        }

        public Usuario(int usuarioCod, string nomeEmpresa, string nomeUsuario, string Complemento, int fkEndereco)
        {

           this.CodUsuario = usuarioCod ;

            this.NomeUsuario = nomeUsuario;

            this.NomeEmpresa = nomeEmpresa;


             this.ComplementoEndereco = Complemento;

            this.FkEndereco = fkEndereco;



        }



        public Usuario( string nomeUsuario, string nomeEmpresa, string cpf, string dataNascimento, string email, int fkEndereco, string complemento)
            {


            this.NomeUsuario = nomeUsuario;

            this.NomeEmpresa = nomeEmpresa;

            this.CpfUsuario = cpf;

            this.DataNascimento = dataNascimento;

            this.EmailUsuariio = email;

            this.FkEndereco = fkEndereco;

            this.ComplementoEndereco = complemento;



             }


        public void Inserir()
        {

            cmd.CommandText = "Insert into tbl_usuario() values(default, @this.NomeUsuario, @this.NomeEmpresa, @this.CpfUsuario, @this.DataNascimento, @this.EmailUsuariio, @this.FkEndereco, @this.ComplementoEndereco, 1)";

            cmd.Parameters.AddWithValue("@this.NomeUsuario", this.NomeUsuario);

            cmd.Parameters.AddWithValue("@this.NomeEmpresa", this.NomeEmpresa);


           // cmd.Parameters.AddWithValue("@this.CpfUsuario", this.CpfUsuario);

            cmd.Parameters.AddWithValue("@this.DataNascimento", this.DataNascimento);

            cmd.Parameters.AddWithValue("@this.EmailUsuariio", this.EmailUsuariio);

            cmd.Parameters.AddWithValue("@this.FkEndereco", this.FkEndereco);

            cmd.Parameters.AddWithValue("@this.ComplementoEndereco", this.ComplementoEndereco);




            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Cadastro realizado com sucesso!");



            }
            catch (MySqlException e)
            {

                MessageBox.Show("Leke deu error aqui, esse foi o error: " + e);

            }

                     


        }


        public void Editar ()
        {

            cmd.CommandText = "update tbl_usuario set nome_usuario = @usuario, nome_empresa = @empresa, complemento_endereco = @endereco, fk_endereco = @fkendereco where cod_usuario = @idusuario";

            cmd.Parameters.AddWithValue("@idusuario", this.CodUsuario);

            cmd.Parameters.AddWithValue("@usuario", this.NomeUsuario);

            cmd.Parameters.AddWithValue("@empresa", this.NomeEmpresa);


            cmd.Parameters.AddWithValue("@endereco", this.ComplementoEndereco);

            cmd.Parameters.AddWithValue("@fkendereco", this.FkEndereco);




            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Campos editado  com sucesso!");



            }
            catch (MySqlException e)
            {

                MessageBox.Show("Leke deu error aqui, esse foi o error: " + e);

            }




        }

        public void ValidarCpfExist()
        {

            cmd.CommandText = "Select fn_cpf_validar(@this.CpfUsuario)";

           cmd.Parameters.AddWithValue("@this.CpfUsuario", this.CpfUsuario);

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        this.ConfirmCpf = reader.GetBoolean(0);
                    }

                }

                reader.Close();

                conexao.Desconectar();
            }
            catch( MySqlException e)
            {

                MessageBox.Show("Esse error não deveria acontecer meu irmão , mas está aqui o error: " + e);
            }

        }

        public void ValidarEmailExist()
        {

            cmd.CommandText = "Select fn_email_validar(@this.this.EmailUsuariio)";

            cmd.Parameters.AddWithValue("@this.this.EmailUsuariio", this.EmailUsuariio);

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        this.ConfirmEmail = reader.GetBoolean(0);
                    }

                }

                reader.Close();

                conexao.Desconectar();
            }
            catch (MySqlException e)
            {

                MessageBox.Show("Programa cheio do bug meu irmâo, mas está aqui o error: " + e);
            }

        }


        public void PegarCod()
        {

            cmd.CommandText = "Select cod_usuario from tbl_usuario where cpf_usuario = @this.CpfUsuario";

            //cmd.Parameters.AddWithValue("@this.CpfUsuario", this.CpfUsuario);


            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        CodUsuario = reader.GetInt32(0);

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

        public void ListarUsuario(int x)
        {

            cmd.CommandText = "select * from tbl_usuario where cod_usuario = @x and ativo_user = true";

            cmd.Parameters.AddWithValue("@x", x);




            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    ListagemUsuario = new List<Usuario>();

                    while (reader.Read())
                    {

                        ListagemUsuario.Add(new Usuario() { CodUsuario = reader.GetInt32(0), NomeUsuario = reader.GetString(1), NomeEmpresa = reader.GetString(2), CpfUsuario = reader.GetString(3), DataNascimento = reader.GetString(4),EmailUsuariio = reader.GetString(5),  FkEndereco = reader.GetInt32(6), ComplementoEndereco = reader.GetString(7) });

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
