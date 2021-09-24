using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public class Produto
    {
        public int CodProduto { get; set; }


        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public Categoria Categoria { get; set; }

        public int FkCategoria { get; set; }


        public bool Status { get; set; }


       public int  FkUsuarioProduto {get; set;}
        public static List<Produto> ListagemProduto { get; set; }
        public int FkUsuario { get; }

        // variaveis não estaticas
        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();

        //variaveis estaticas
       static Conexao conexaoStatic = new Conexao();

       static  MySqlCommand cmdStatic = new MySqlCommand();



        public Produto()
        {

        }

        public Produto(int usuario)
        {
            this.FkUsuarioProduto = usuario;
        }

        public Produto(int cod, string nome, string descricao, int fkCategoria, int usuario)
        {
            this.CodProduto = cod;

            this.NomeProduto = nome;

            this.Descricao = descricao;

            this.FkCategoria = fkCategoria;

            this.FkUsuarioProduto = usuario;




        }

        public Produto( string nome, string descricao , int fkCategoria, int usuario ) {

            this.NomeProduto = nome;

            this.Descricao = descricao;

            this.FkCategoria = fkCategoria;

            this.FkUsuarioProduto = usuario;

        
        }

        public void Editar()
        {
            cmd.CommandText = "Update tbl_produto set nome_produto = @this.NomeProduto , fk_categoria = @this.FkCategoria, descricao_produto = @this.Descricao where (cod_produto = @this.CodProduto) and (fk_usuario_produto = @FkUsuarioProduto)";
;


            cmd.Parameters.AddWithValue("@this.CodProduto", this.CodProduto);

            cmd.Parameters.AddWithValue("@this.NomeProduto", this.NomeProduto);

            cmd.Parameters.AddWithValue("@this.Descricao", this.Descricao);

            cmd.Parameters.AddWithValue("@this.FkCategoria", this.FkCategoria);

            cmd.Parameters.AddWithValue("@FkUsuarioProduto", this.FkUsuarioProduto);


            try{

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Produto Editado com sucesso!");
       



            }
            catch (MySqlException e)
            {
                MessageBox.Show("error aqui irmão:" + e);

            }



        }

        public void Inserir ()
        {
            cmd.CommandText = "Insert into tbl_produto() values (default, @this.NomeProduto, @this.Descricao, @this.FkCategoria, True, @this.FkUsuarioProduto)";

            cmd.Parameters.AddWithValue("@this.NomeProduto", this.NomeProduto);

            cmd.Parameters.AddWithValue("@this.Descricao", this.Descricao);

            cmd.Parameters.AddWithValue("@this.FkCategoria", this.FkCategoria);

            cmd.Parameters.AddWithValue("@this.FkUsuarioProduto", this.FkUsuarioProduto);


            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Produto Cadastrado com sucesso!");




            }
            catch (MySqlException e)
            {
                MessageBox.Show("olha essa merda aqui:" + e);

            }



        }

        public  void ListarProdutoStatic(int x)
        {

            cmd.CommandText = "select *from tbl_produto where (fk_usuario_produto = @x)  and ativo_produto = true order by nome_produto";

            cmd.Parameters.AddWithValue("@x", x);

            try
                {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows){

                    ListagemProduto = new List<Produto>();

                    while (reader.Read())
                    {
                        ListagemProduto.Add(new Produto () { CodProduto = reader.GetInt32(0), NomeProduto = reader.GetString(1), Descricao = reader.GetString(2) , FkCategoria = reader.GetInt32(3) });
                    }

                }

                reader.Close();

                conexao.Desconectar();


            }catch (MySqlException e)
            {
                MessageBox.Show("Deu esse maroto aqui " + e);

            }




        }

        public  void ListarProduto( int x )
        {

            cmd.CommandText = "select *from tbl_produto where (cod_produto = @x) and (fk_usuario_produto = @FkUsuarioProduto) and ativo_produto = true ";

            cmd.Parameters.AddWithValue("@x",x);
            cmd.Parameters.AddWithValue("@FkUsuarioProduto", this.FkUsuarioProduto);
;
            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemProduto = new List<Produto>();

                    while (reader.Read())
                    {
                        ListagemProduto.Add(new Produto() { CodProduto = reader.GetInt32(0), NomeProduto = reader.GetString(1), Descricao = reader.GetString(2), FkCategoria = reader.GetInt32(3) });
                    }

                }

                reader.Close();

                conexao.Desconectar();


            }
            catch (MySqlException e)
            {
                MessageBox.Show("Deu esse maroto aqui " + e);

            }




        }


        public void Excluir(int x)
        {
            cmd.CommandText = "update tbl_produto set ativo_produto = false where cod_produto = @x and (fk_usuario_produto = @FkUsuarioProduto)";
            ;


            cmd.Parameters.AddWithValue("@x", x);

            cmd.Parameters.AddWithValue("@FkUsuarioProduto", this.FkUsuarioProduto);




            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Item excluído com sucesso!");




            }
            catch (MySqlException e)
            {
                MessageBox.Show("error aqui irmão:" + e);

            }



        }





    }
}
