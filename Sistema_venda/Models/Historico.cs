using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_venda.Models
{
    public class Historico
    {

        public int CodHistorico { get; set; }

        public string Data { get; set; }

        public Produto Produto { get; set; }

        public int FkProduto {get; set;}

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public Usuario Usuario { get; set; }

        public static List<string> ListagemMovimento { get; set; }

        public int FKUsuario { get; set; }

        public Historico()
        {

            ListagemMovimento = new List<string>();


            ListagemMovimento.Add("Produtos");
            ListagemMovimento.Add("Entrada de Produtos");
            ListagemMovimento.Add("Venda de Produtos");
            ListagemMovimento.Add("Alteração de Produtos");
            ListagemMovimento.Add("Exclusão de Produtos");
     



}


    }
}
