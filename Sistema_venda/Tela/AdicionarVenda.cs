using sistema_venda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp1
{
  
    public partial class AdicionarVenda : Form
    {
        Thread theard;
        int comparaçao;
        public AdicionarVenda()
        {
            InitializeComponent();

            Leandro();
            CombooBoxCliente();
            VazioTexto();


        }

        private void NomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VazioTexto()
        {
            ObservacaoVenda.Text = string.Empty;

            QuantidadeVenda.Text = string.Empty;

            PrecoVendaa.Text = string.Empty;
        }

        private void CombooBoxCliente()
        {
            try
            {
               

                Cliente cliente = new Cliente();

                cliente.ListarCliente();

                NomeCliente.DataSource = Cliente.ListagemCliente;

                NomeCliente.DisplayMember = "NomeCliente";

                NomeCliente.ValueMember = "CodCliente";

                NomeCliente.SelectedIndex = -1;


                Pagamento pagamento = new Pagamento();

                pagamento.ListarPagamento();


                TipoPagamento.DataSource = Pagamento.ListagemPagamento;

                TipoPagamento.DisplayMember = "TipoPagamento";

                TipoPagamento.ValueMember = "CodPagamento";

                TipoPagamento.SelectedIndex = -1;


              


                ProdutoVenda.DataSource = Estoque.ListagemEstoque;


                ProdutoVenda.DisplayMember = "NomeProduto";

                ProdutoVenda.ValueMember = "FkProduto";

                ProdutoVenda.SelectedIndex = -1;


                
            }
            catch( Exception)
            {

            }
        }


        private void Leandro()
        {

            Estoque estoque = new Estoque(Loginn.FkUsuario);

            estoque.ListarEstoque();

        }

        private void ProdutoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            var index = ProdutoVenda.SelectedIndex;

            QuantidadeVenda.Text = Estoque.ListagemEstoque[index].QuantidadeEstoque.ToString();

            comparaçao = Estoque.ListagemEstoque[index].QuantidadeEstoque;

            PrecoVendaa.Text = Estoque.ListagemEstoque[index].PrecoEstoque.ToString("F2");
        }

        private void PrecoVendaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVenda_Click(object sender, EventArgs e)

        {
            
            if (String.IsNullOrEmpty(NomeCliente.Text) || String.IsNullOrEmpty(ProdutoVenda.Text) || String.IsNullOrEmpty(QuantidadeVenda.Text) || String.IsNullOrEmpty(TipoPagamento.Text))
            {
                MessageBox.Show("Nenhum campo pode ser vazio", "Aviso!");
            } else if (Int32.Parse(QuantidadeVenda.Text) > comparaçao || Int32.Parse(QuantidadeVenda.Text) < 0){

                MessageBox.Show("você colocou uma quantidade fora do limite que esta disponível", "Aviso!");

            } else if (Int32.Parse(QuantidadeVenda.Text) == 0)
            {
                MessageBox.Show("Estoque desse produto está vazio", "Aviso!");

            }
            else{
                int cliente = Int32.Parse(NomeCliente.SelectedValue.ToString());

                int pagamento = Int32.Parse(TipoPagamento.SelectedValue.ToString());

                int produto = Int32.Parse(ProdutoVenda.SelectedValue.ToString());


                Venda venda = new Venda(Loginn.FkUsuario,cliente, produto, Int32.Parse(QuantidadeVenda.Text), double.Parse(PrecoVendaa.Text), pagamento, ObservacaoVenda.Text);

                venda.Inserir();
                Leandro();

                CombooBoxCliente();

                VazioTexto();







            }
        }

        private void VoltarAddVenda_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaVenda);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaVenda(object obj)
        {
            Application.Run(new View_Vendas());
        }
    }
}
