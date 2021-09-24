using sistema_venda;
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
    public partial class CadProduto : Form
    {
        Thread theard;
        public CadProduto()
        {
            InitializeComponent();

            ComboCategoria();
        }

        private void CadProduto_Load(object sender, EventArgs e)
        {

        }

        public void ComboCategoria()
        {
        
            Categoria.ListarCategoria();

            CatCadProduto.DataSource =  Categoria.ListagemCategoria;

            CatCadProduto.DisplayMember = "NomeCategoria";

            CatCadProduto.ValueMember = "CodCategoria";

            CatCadProduto.SelectedIndex = -1;

             
        }


        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            int x;

            if (CatCadProduto.SelectedIndex == -1){

                x = 0;
            }
            else
            {
               x = Int32.Parse(CatCadProduto.SelectedValue.ToString());
            }

          

           

            if( String.IsNullOrEmpty(NomeCadProduto.Text) || String.IsNullOrEmpty(DesCadProduto.Text) || String.IsNullOrEmpty(CatCadProduto.Text))
            {

                MessageBox.Show("Nenhum campo pode ser vazio no cadastro!");

            }else

            {
           
                Produto produto = new Produto(NomeCadProduto.Text, DesCadProduto.Text, x, Loginn.FkUsuario);

 

                produto.Inserir();

                NomeCadProduto.Text = string.Empty;

                DesCadProduto.Text = string.Empty;

                CatCadProduto.SelectedIndex = -1;



            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NomeCadProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void FotoProduto_Enter(object sender, EventArgs e)
        {

        }

        private void VoltarCadProduto_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaView);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();

        }

        private void TelaView(object obj)
        {
            Application.Run(new View_Produtos());
        }

        private void CatCadProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Produto_Click(object sender, EventArgs e)
        {

        }
    }
}
