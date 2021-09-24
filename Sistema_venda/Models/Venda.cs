using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    class Venda
    {
        public int CodVenda { get; set; }

        public Usuario Usuario { get; set; }

        public int FkUsuario { get; set; }

        public Cliente Cliente { get; set; }

        public int FkCliente { get; set; }

        public string DataVenda { get; set; }

        public Produto Produto { get; set; }

        public int FkProduto { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public Pagamento Pagamento { get; set; }

        public int FkPagamento { get; set; }

        public string Observacao { get; set; }


        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();
        public Venda( int usuario , int cliente, int produto , int quantidade, double preco , int pagamento , string observacao)
        {

            this.FkUsuario = usuario;

            this.FkCliente = cliente;

            this.Quantidade = quantidade;

            this.FkProduto = produto;

            this.Preco = preco;

            this.FkPagamento = pagamento;

            this.Observacao = observacao;


        }

        public void Inserir()
        {


            cmd.CommandText = "Insert into tbl_vendas () values(default, @FkUsuario, @FkCliente, default, @FkProduto, @Quantidade, @Preco, @FkPagamento, @Observacao)";

            cmd.Parameters.AddWithValue("@FkUsuario", this.FkUsuario);

            cmd.Parameters.AddWithValue("@FkCliente", this.FkCliente);

            cmd.Parameters.AddWithValue("@FkProduto", this.FkProduto);

            cmd.Parameters.AddWithValue("@Quantidade", this.Quantidade);

            cmd.Parameters.AddWithValue("@Preco", this.Preco);

            cmd.Parameters.AddWithValue("@FkPagamento", this.FkPagamento);

            cmd.Parameters.AddWithValue("@Observacao", this.Observacao);



            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Venda  realizado com sucesso!");



            }
            catch (MySqlException e)
            {

                MessageBox.Show("Leke deu error aqui, esse foi o error: " + e);

            }




        }

        public void Editar(int x )
        {
            cmd.CommandText = "update tbl_vendas set fk_cliente_venda = @FkCliente, fk_produto_venda = @FkProduto, quantidade_venda = @Quantidade, preco_venda = @Preco, fk_pagamento =  @FkPagamento, observacao_venda = @Observacao where cod_venda = @x and fk_usuario_venda = @FkUsuario ";

            cmd.Parameters.AddWithValue("@FkUsuario", this.FkUsuario);

            cmd.Parameters.AddWithValue("@FkCliente", this.FkCliente);

            cmd.Parameters.AddWithValue("@FkProduto", this.FkProduto);

            cmd.Parameters.AddWithValue("@Quantidade", this.Quantidade);

            cmd.Parameters.AddWithValue("@Preco", this.Preco);

            cmd.Parameters.AddWithValue("@FkPagamento", this.FkPagamento);

            cmd.Parameters.AddWithValue("@Observacao", this.Observacao);

            cmd.Parameters.AddWithValue("@x", x);



            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                MessageBox.Show("Venda editada   realizado com sucesso!");



            }
            catch (MySqlException e)
            {

                MessageBox.Show("Leke deu error aqui, esse foi o error: " + e);

            }


        }

    }
}
