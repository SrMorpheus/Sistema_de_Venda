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
    public partial class EditarProduto : Form
    {
        Thread theard;

        List<Produto> lista = Produto.ListagemProduto;
        public EditarProduto()
        {
            InitializeComponent();
            ComboCategoria();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        public void ComboCategoria()
        {

            Categoria categoria = new Categoria();

           

            NomeEditarProd.Text = lista[0].NomeProduto;

            DesEditarProd.Text = lista[0].Descricao;

            categoria.ListarCategoria(lista[0].FkCategoria);

            var listaCategoria = Categoria.ListagemCategoria;

         

            Categoria.ListarCategoria();


            QtdEditProd.DataSource = Categoria.ListagemCategoria;

            QtdEditProd.DisplayMember = "NomeCategoria";

            QtdEditProd.ValueMember = "CodCategoria";

            QtdEditProd.SelectedIndex = QtdEditProd.FindStringExact(listaCategoria[0].NomeCategoria);


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {

           
            }

            private void QtdEditProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int x;

            if (QtdEditProd.SelectedIndex == -1)
            {

                x = 0;
            }
            else
            {
                x = Int32.Parse(QtdEditProd.SelectedValue.ToString());
            }





            if (String.IsNullOrEmpty(NomeEditarProd.Text) || String.IsNullOrEmpty(DesEditarProd.Text) || String.IsNullOrEmpty(QtdEditProd.Text))
            {

                MessageBox.Show("Nenhum campo pode ser vazio no cadastro!");

            }
            else if (lista[0].NomeProduto == NomeEditarProd.Text && lista[0].Descricao == DesEditarProd.Text && x == lista[0].FkCategoria )
            {

                MessageBox.Show("Não foi feita alteração em nenhum campo devido os campos ser os mesmos!", "Aviso");
            }
            else

            {
                Produto produto = new Produto(lista[0].CodProduto, NomeEditarProd.Text, DesEditarProd.Text, x,Loginn.FkUsuario);

                produto.Editar();

                this.Close();
              

                theard = new Thread(NovaTelaCad);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();

                //  NomeCadProduto.Text = string.Empty;

                //DesCadProduto.Text = string.Empty;

                //CatCadProduto.SelectedIndex = -1;


            }
        }

        private void NovaTelaCad(object obj)
        {
            Application.Run(new View_Produtos());
        }

        private void NomeEditarProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void VoltarEditProduto_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(NovaTelaCad);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();

        }
    }
}
