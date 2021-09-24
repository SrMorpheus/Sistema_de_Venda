using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public  class EntradaProduto
    {

        public int CodEntrada { get; set; }

        public DateTime Data { get; set; }

        public int FkProduto { get; set; }

        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public int Fkuser { get; set; }

        public Usuario Usuario { get; set; }


        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();


        public EntradaProduto(int produto, int quantidade, double preco, int usuario)
        {


            this.FkProduto = produto;

            this.Quantidade = quantidade;

            this.Preco = preco;

            this.Fkuser = usuario;


        }

        public void Inserir()
        {

            cmd.CommandText = "insert into tbl_entrada_produto() values (default, default, @this.FkProduto, @this.Preco, @this.Quantidade, @this.Fkuser )";


            cmd.Parameters.AddWithValue("@this.FkProduto", this.FkProduto);

            cmd.Parameters.AddWithValue("@this.Preco", this.Preco);

            cmd.Parameters.AddWithValue("@this.Quantidade", this.Quantidade);

            cmd.Parameters.AddWithValue("@this.Fkuser", this.Fkuser);


            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Entrada de produto do estoque feita com sucesso!");




            }
            catch (MySqlException e)
            {
                MessageBox.Show("teste" + e);

            }





        }





    }
}
