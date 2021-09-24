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
    public partial class EditarProdutoEstoque : Form
    {
        Thread thead;
        List<Estoque> Lista = Estoque.ListagemEstoque;
        public EditarProdutoEstoque()
        {
            InitializeComponent();
            ComboProduto();

        }

        public void ComboProduto()
        {
            Produto produtoo = new Produto(Loginn.FkUsuario);

              produtoo.ListarProduto(Estoque.ListagemEstoque[0].FkProduto);

            var ListagemProdduto = Produto.ListagemProduto;

            Produto produto = new Produto();
            produto.ListarProdutoStatic(Loginn.FkUsuario);

          

         

            NomeEditarProdEstoque.DataSource = Produto.ListagemProduto;

            NomeEditarProdEstoque.DisplayMember = "NomeProduto";

            NomeEditarProdEstoque.ValueMember = "CodProduto";



            NomeEditarProdEstoque.SelectedIndex = NomeEditarProdEstoque.FindString(ListagemProdduto[0].NomeProduto);

            QtdEditarProdEstoque.Text = Estoque.ListagemEstoque[0].QuantidadeEstoque.ToString();

            PrecoEditProdEstoque.Text = Estoque.ListagemEstoque[0].PrecoEstoque.ToString();


        }



        private void NomeEditarProdEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DESCRIÇÃO

            int id = (int)NomeEditarProdEstoque.SelectedIndex;

            DesEditarProdEstoque.DataSource = Produto.ListagemProduto;

            DesEditarProdEstoque.DisplayMember = "Descricao";

            DesEditarProdEstoque.SelectedIndex = id;

            DesEditarProdEstoque.ValueMember = "FkCategoria";




            //Categoria
            int x;

            if (NomeEditarProdEstoque.SelectedIndex == -1)
            {
                x = 0;

            }
            else
            {
                x = Int32.Parse(DesEditarProdEstoque.SelectedValue.ToString());

            }





            Categoria categoria = new Categoria();

            categoria.ListarCategoria(x);

            CatEditarProdEstoque.DataSource = Categoria.ListagemCategoria;

            CatEditarProdEstoque.DisplayMember = "NomeCategoria";

        }

        private void EditarProdEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                int qtd = Int32.Parse(QtdEditarProdEstoque.Text.ToString());

                int cod = Int32.Parse(NomeEditarProdEstoque.SelectedValue.ToString());

                double preco = Double.Parse(PrecoEditProdEstoque.Text.ToString());



             //   if (String.IsNullOrEmpty(NomeEditarProdEstoque.Text) || String.IsNullOrEmpty(QtdEditarProdEstoque.Text) || String.IsNullOrEmpty(PrecoEditProdEstoque.Text))
               // {
                 
                //}

                 if (Lista[0].FkProduto == cod && Lista[0].QuantidadeEstoque == qtd && Lista[0].PrecoEstoque == preco)
                {
                    MessageBox.Show("Não foi feita alteração em nenhum campo devido os campos ser os mesmos!", "Aviso");

                }

                else
                {




                    Estoque estoque = new Estoque(Lista[0].CodEstoque, cod, qtd, preco, Loginn.FkUsuario);



                    estoque.Editar();



                    this.Close();

                    thead = new Thread(Tela);

                    thead.SetApartmentState(ApartmentState.STA);

                    thead.Start();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Campo pode ser vazio!");
            }



        }

        private void travacat(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void travadesc(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
      
        }

        private void Tela(object obj)
        {
            Application.Run(new view_Estoques());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VoltarEditProdEstoque_Click(object sender, EventArgs e)
        {
            this.Close();

            thead = new Thread(Tela);

            thead.SetApartmentState(ApartmentState.STA);

            thead.Start();
        }
    }


}

