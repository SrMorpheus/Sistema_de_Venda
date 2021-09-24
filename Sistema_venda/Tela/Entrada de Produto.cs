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
    public partial class EntradaProdutoTela : Form
    {
        Thread thead;
        public EntradaProdutoTela()
        {
            InitializeComponent();

            ComboProduto();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        public void ComboProduto()
        {
            Produto produto = new Produto();
            produto.ListarProdutoStatic(Loginn.FkUsuario);

            NomeEntradaProd.DataSource = Produto.ListagemProduto;

            NomeEntradaProd.DisplayMember = "NomeProduto";

            NomeEntradaProd.ValueMember = "CodProduto";

            NomeEntradaProd.SelectedIndex = -1;

            CatEntradaProd.SelectedIndex = -1;


        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QtdEntradaProd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NomeEntradaProd_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DESCRIÇÃO

            int id = (int)NomeEntradaProd.SelectedIndex;

            DesEntradaProd.DataSource = Produto.ListagemProduto;

            DesEntradaProd.DisplayMember = "Descricao" ;

            DesEntradaProd.SelectedIndex = id;

            DesEntradaProd.ValueMember = "FkCategoria";




            //Categoria
            int x ;

            if (NomeEntradaProd.SelectedIndex == -1)
            {
                x = 0;

            }else
            {
                x = Int32.Parse(DesEntradaProd.SelectedValue.ToString());

            }
               
           

            

            Categoria categoria = new Categoria();

            categoria.ListarCategoria(x);

            CatEntradaProd.DataSource = Categoria.ListagemCategoria;
            
            CatEntradaProd.DisplayMember = "NomeCategoria";



        }

        private void CatEntradaProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TravarDesc(object sender, KeyPressEventArgs e)
        {
        //usuario não vai mexer nem editar nada no campo descrição
            e.Handled = true;
        }

        private void DesEntradaProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatTravar(object sender, KeyPressEventArgs e)
        {

            //usuario não vai mexer nem editar nada no campo categoria

            e.Handled = true;
        }

        private void EntradaProd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(NomeEntradaProd.Text) || String.IsNullOrEmpty(QtdEntradaProd.Text) || String.IsNullOrEmpty(PrecoEntradaProd.Text))
            {
                MessageBox.Show("Nenhum Campo pode ser vazio!");
            }
            else
            {


                int qtd = Int32.Parse(QtdEntradaProd.Text.ToString());

                int cod = Int32.Parse(NomeEntradaProd.SelectedValue.ToString());

                double preco = Double.Parse(PrecoEntradaProd.Text.ToString());



                EntradaProduto entradaProduto = new EntradaProduto(cod, qtd, preco, Loginn.FkUsuario);

                entradaProduto.Inserir();

                NomeEntradaProd.SelectedIndex = -1;

                DesEntradaProd.Text = string.Empty;

                CatEntradaProd.Text = string.Empty;

                PrecoEntradaProd.Text = string.Empty;

                QtdEntradaProd.Text = string.Empty;
             

            }
        }

        private void TelaEstoque(object obj)
        {
            Application.Run(new view_Estoques());
        }

        private void Virgula(object sender, KeyEventArgs e)
        {



            /* try
             {



                 PrecoEntradaProd.Text = string.Format("{0,0:#, ##0}", double.Parse(PrecoEntradaProd.Text));

                 int cont = PrecoEntradaProd.TextLength;

                 PrecoEntradaProd.SelectionStart = cont;

                 PrecoEntradaProd.SelectionLength = 0;
             }
             catch ( Exception)
             {

             }  */


        }

        private void PrecoEntradaProd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void VoltarEntradaProd_Click(object sender, EventArgs e)
        {

            this.Close();

            thead = new Thread(TelaEstoque);

            thead.SetApartmentState(ApartmentState.STA);

            thead.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
