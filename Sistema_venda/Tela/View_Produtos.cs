using MySql.Data.MySqlClient;
using sistema_venda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace sistema_venda
{
    public partial class View_Produtos : Form
    {
        Thread theard;

        int codProduto;
      

        public View_Produtos()
        {
            InitializeComponent();
            //   MessageBox.Show(Loginn.FkUsuario.ToString() + " vc entrou");

            View_Produto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Produto()
        {
            Conexao conexao = new Conexao();

            MySqlCommand cmd = new MySqlCommand();



            if (Pesquisar.Text != "")
            {


                cmd.CommandText = "select *from view_Produto where (nome_produto LIKE @Pesquisar.text or nome_categoria LIKE  @Pesquisar.text) and (ativo_produto = True) and (fk_usuario_produto = @FkUsuario ) order by nome_produto";

                cmd.Parameters.AddWithValue("@Pesquisar.text", Pesquisar.Text);
                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);


            }

            else
            {
                cmd.CommandText = "select *from view_Produto where (ativo_produto = True) and (fk_usuario_produto = @FkUsuario ) order by nome_produto ";
                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);
            }




            cmd.Connection = conexao.Conectar();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            BancoProduto.DataSource = null;

            BancoProduto.DataSource = dt;

            BancoProduto.ReadOnly = true;



            /*    foreach (DataGridViewColumn dc in BancoProduto.Columns)
                {
                    if (dc.Index.Equals(0) || dc.Index.Equals(1))
                    {
                        dc.ReadOnly = false;
                    }

                }
            */
            CriarCabecalhoGade();





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CriarCabecalhoGade()

        {




            BancoProduto.Columns["cod_produto"].Visible = false;
            
             BancoProduto.Columns["nome_produto"].HeaderText = "Produto";

            BancoProduto.Columns["nome_produto"].Width = 187;

            BancoProduto.Columns["nome_produto"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;


            BancoProduto.Columns["nome_produto"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            BancoProduto.Columns["nome_produto"].ReadOnly = false;

            BancoProduto.Columns["descricao_produto"].HeaderText = "Descrição";

            BancoProduto.Columns["descricao_produto"].Width = 300;

            BancoProduto.Columns["descricao_produto"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            BancoProduto.Columns["descricao_produto"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            BancoProduto.Columns["fk_categoria"].Visible = false;

            BancoProduto.Columns["ativo_produto"].Visible = false;

            BancoProduto.Columns["fk_usuario_produto"].Visible = false;

            BancoProduto.Columns["cod_categoria"].Visible = false;

            BancoProduto.Columns["nome_categoria"].HeaderText = "Categoria";

            BancoProduto.Columns["nome_categoria"].Width = 187;

            BancoProduto.Columns["nome_categoria"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            BancoProduto.Columns["nome_categoria"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Produto();
        }

        private void Pesquisar_TextChanged(object sender, EventArgs e)
        {
        }

        private void EditarItem(object sender, DataGridViewCellEventArgs e)
        {

         
        }

        private void BancoProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();

            theard = new Thread(NovaTelaCad);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();



        }

        private void NovaTela(object obj)
        {
            Application.Run(new EditarProduto());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                codProduto = Convert.ToInt32(BancoProduto.Rows[BancoProduto.CurrentCell.RowIndex].Cells["cod_produto"].Value);

                Produto produto = new Produto(Loginn.FkUsuario);

                produto.ListarProduto(codProduto);

                this.Close();

                theard = new Thread(NovaTela);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();

            }

            catch (Exception)
            {
                MessageBox.Show("Não pode Editar item vazio", "AVISO");


                BancoProduto.ClearSelection();

                try
                {


                    BancoProduto.Rows[BancoProduto.Rows.Count - 2].Selected = true;

                }
                catch (Exception)
                {
                    BancoProduto.Rows[BancoProduto.Rows.Count - 1].Selected = true;
                }




            }







        }

        private void NovaTelaCad(object obj)
        {

            Application.Run(new CadProduto());
        }

        private void select_tudo(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            try
            {
                var codProdutoo = Convert.ToInt32(BancoProduto.Rows[BancoProduto.CurrentCell.RowIndex].Cells["cod_produto"].Value);

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo))
                {

                    Produto pr = new Produto(Loginn.FkUsuario);

                    pr.Excluir(codProdutoo);

                    View_Produto();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode excluir item vazio", "Aviso");
            }







        }

        private void Clicktexto(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaMenu);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();

        }

        private void TelaMenu(object obj)
        {
            Application.Run(new MenuPrincipal());
        }

        private void Clic(object sender, EventArgs e)
        {
            try
            {

                codProduto = Convert.ToInt32(BancoProduto.Rows[BancoProduto.CurrentCell.RowIndex].Cells["cod_produto"].Value);


            }

            catch (Exception)
            {
                MessageBox.Show("Não pode escolher item vazio", "Aviso");
                BancoProduto.ClearSelection();
                try
                {


                    BancoProduto.Rows[BancoProduto.Rows.Count - 2].Selected = true;

                }
                catch (Exception)
                {
                    BancoProduto.Rows[BancoProduto.Rows.Count - 1].Selected = true;
                }

            }
        }

        private void EstoqueEstoque_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaEstoque);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaEstoque(object obj)
        {
            Application.Run(new view_Estoques());
        }

        private void HistoricoHistorico_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaHistorico);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaHistorico(object obj)
        {
            Application.Run(new View_Historicos());
        }

        private void Vendas_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(Telavenda);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void Telavenda(object obj)
        {
            
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaPerfil);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaPerfil(object obj)
        {
            Application.Run(new Perfil());
        }
    }
    }

