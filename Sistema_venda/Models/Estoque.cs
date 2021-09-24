using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public class Estoque
    {
        public int CodEstoque { get; set; }

        public string DataEstoque { get; set; }


        public int FkProduto { get; set; }
        public Produto Produtos { get; set; }

        public string NomeProduto {get;set;}

      

        public int QuantidadeEstoque { get; set; }

        public double PrecoEstoque { get; set; }

        public int FkUsuario { get; set; }

        public bool AtivoEstoque { get; set; }

        public static List<Estoque> ListagemEstoque { get; set; } 

        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();

        Conexao conexaoStatic = new Conexao();

        MySqlCommand cmdStatic = new MySqlCommand();
  

        public Estoque()
        {
            
        }

        public Estoque(int cod, int produto, int quantidade , double preco, int usuario)
        {
            this.CodEstoque = cod;

            this.FkProduto = produto;

            this.QuantidadeEstoque = quantidade;

            this.PrecoEstoque = preco;

            this.FkUsuario = usuario;

            this.DataEstoque = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");

        }

      


        public Estoque(int usuario)
        {
            this.FkUsuario = usuario;
        }

       

        public void Editar()
        {
            cmd.CommandText = "Update tbl_estoque set fk_estoque_produto =  @FkProduto , quantidade_estoque = @QuantidadeEstoque , preco_estoque = @PrecoEstoque ,  data_estoque = @this.DataEstoque  where(cod_estoque = @CodEstoque) and (fk_usuario_estoque = @FkUsuario)";

            cmd.Parameters.AddWithValue("@CodEstoque", this.CodEstoque);

            cmd.Parameters.AddWithValue("@FkProduto", this.FkProduto);

            cmd.Parameters.AddWithValue("@QuantidadeEstoque", this.QuantidadeEstoque);

            cmd.Parameters.AddWithValue("@PrecoEstoque", this.PrecoEstoque);

            cmd.Parameters.AddWithValue("@FkUsuario", this.FkUsuario);
            cmd.Parameters.AddWithValue("@this.DataEstoque", this.DataEstoque); 

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Produto do estoque  editado com sucesso!");




            }
            catch (MySqlException e)
            {
                MessageBox.Show("error aqui irmão:" + e);

            }



        }






        public void Excluir(int x)
        {
            cmd.CommandText = "update tbl_estoque set ativo_estoque = false where cod_estoque = @x and (fk_usuario_estoque = @this.FkUsuario )";



            cmd.Parameters.AddWithValue("@x", x);

            cmd.Parameters.AddWithValue("@this.FkUsuario", this.FkUsuario);




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

        public void ListarEstoque(int x)
        {

            cmd.CommandText = "select * from tbl_estoque where cod_estoque = @x and fk_usuario_estoque = @this.FkUsuario and ativo_estoque = true";

            cmd.Parameters.AddWithValue("@x", x);
            cmd.Parameters.AddWithValue("@this.FkUsuario", this.FkUsuario);
            ;
            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemEstoque = new List<Estoque>();

                    while (reader.Read())
                    {
                        ListagemEstoque.Add(new Estoque() { CodEstoque = reader.GetInt32(0), FkProduto = reader.GetInt32(2), QuantidadeEstoque = reader.GetInt32(3), PrecoEstoque = reader.GetDouble(4), FkUsuario =  reader.GetInt32(5) });
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

        public void ListarEstoque()
        {

            cmd.CommandText = "select *from views_estoque  where cod_usuario = @this.FkUsuario and quantidade >= @teste";

            cmd.Parameters.AddWithValue("@teste", 0);
            cmd.Parameters.AddWithValue("@this.FkUsuario", this.FkUsuario);
            
            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemEstoque = new List<Estoque>();

                    while (reader.Read())
                    {
                        ListagemEstoque.Add( new Estoque() { CodEstoque = reader.GetInt32(1), FkProduto = reader.GetInt32(2), NomeProduto = reader.GetString(3), QuantidadeEstoque = reader.GetInt32(6), PrecoEstoque = reader.GetDouble(7), FkUsuario = reader.GetInt32(9) });
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

    }
}
