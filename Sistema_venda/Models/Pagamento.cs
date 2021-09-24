using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sistema_venda.Models
{
    public  class Pagamento
    {
        public int CodPagamento { get; set; }

        public string TipoPagamento { get; set; }






        public static List<Pagamento> ListagemPagamento { get; set; }

        public static List <string> ListagemPagamentoPesquisar { get; set; }

        Conexao conexao = new Conexao();

        MySqlCommand cmd = new MySqlCommand();


        public Pagamento()
        {


            {

                ListagemPagamentoPesquisar = new List<string>();


                ListagemPagamentoPesquisar.Add("Geral");
                ListagemPagamentoPesquisar.Add("Dinheiro");
                ListagemPagamentoPesquisar.Add("Cartão");
                ListagemPagamentoPesquisar.Add("Transferência");
                ListagemPagamentoPesquisar.Add("Pix");




            }



        }



        public void ListarPagamento()
        {

            cmd.CommandText = "select *from tbl_pagamento";

            try
            {

                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    ListagemPagamento = new List<Pagamento>();

                    while (reader.Read())
                    {

                        ListagemPagamento.Add(new Pagamento() { CodPagamento = reader.GetInt32(0), TipoPagamento = reader.GetString(1) });

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
