using MySql.Data.MySqlClient;
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
    public partial class view_Estoques : Form
    {
        Thread theard;

        int codestoque;

        public object NovaTelaCad { get; private set; }

        public view_Estoques()
        {
            InitializeComponent();
            View_Estoque();
        }

        private void View_Estoque()
        {
            Conexao conexao = new Conexao();

            MySqlCommand cmd = new MySqlCommand();
           

            if (!String.IsNullOrEmpty(BarPesqEstoque.Text))

            {
                cmd.CommandText = "select *from views_estoque where (nome_produto LIKE @BarPesqEstoque.text or Categoria LIKE  @BarPesqEstoque.text) and (cod_usuario = @FkUsuario) order by nome_produto";

                cmd.Parameters.AddWithValue("@BarPesqEstoque.text", BarPesqEstoque.Text);
                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);

            }
            else
            {
                cmd.CommandText = "select *from views_estoque  where cod_usuario = @FkUsuario  order by nome_produto";
                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);


            }

            cmd.Connection = conexao.Conectar();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            GridEstoque.DataSource = null;

            GridEstoque.DataSource = dt;

            GridEstoque.ReadOnly = true;

            CriarCabecalhoGade();

        }

        private void CriarCabecalhoGade()

        {
            GridEstoque.Columns["cod_estoque"].Visible = false;

            GridEstoque.Columns["cod_produto"].Visible = false;


            GridEstoque.Columns["cod_usuario"].Visible = false;


            GridEstoque.Columns["data_estoque"].HeaderText = "Data";

            GridEstoque.Columns["data_estoque"].Width = 180;

            GridEstoque.Columns["data_estoque"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["data_estoque"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            GridEstoque.Columns["nome_produto"].HeaderText = "Produto";

            GridEstoque.Columns["nome_produto"].Width = 180;

            GridEstoque.Columns["nome_produto"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["nome_produto"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;



            GridEstoque.Columns["descricao"].HeaderText = "Descrição";

            GridEstoque.Columns["descricao"].Width = 180;

            GridEstoque.Columns["descricao"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["descricao"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["Categoria"].HeaderText = "Categoria";

            GridEstoque.Columns["Categoria"].Width = 180;

            GridEstoque.Columns["Categoria"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["Categoria"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;




            GridEstoque.Columns["quantidade"].HeaderText = "Quantidade";

            GridEstoque.Columns["quantidade"].Width = 110;

            GridEstoque.Columns["quantidade"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["quantidade"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            GridEstoque.Columns["estoque"].HeaderText = "Preço";

            GridEstoque.Columns["estoque"].Width = 111;

            GridEstoque.Columns["estoque"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["estoque"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["Total"].HeaderText = "Total";

            GridEstoque.Columns["Total"].Width = 111;

            GridEstoque.Columns["Total"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            GridEstoque.Columns["Total"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;








        }

        private void VoltarEditProduto_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(MenuNovo);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Estoque();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdicionarEstoque_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(NovaTelaCaad);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }


        private void NovaTelaCaad(object obj)
        {

            Application.Run(new EntradaProdutoTela());
        }

        private void MenuNovo(object obj)
        {

            Application.Run(new MenuPrincipal());
        }


        private void click(object sender, EventArgs e)
        {
            try
            {

                codestoque = Convert.ToInt32(GridEstoque.Rows[GridEstoque.CurrentCell.RowIndex].Cells["cod_estoque"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode escolher item vazio", "Aviso");

                GridEstoque.ClearSelection();

                try
                {


                    GridEstoque.Rows[GridEstoque.Rows.Count - 2].Selected = true;

                }
                catch (Exception)
                {
                    GridEstoque.Rows[GridEstoque.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void ExcluirEstoque_Click(object sender, EventArgs e)
        {

            try
            {
                var codestoquee = Convert.ToInt32(GridEstoque.Rows[GridEstoque.CurrentCell.RowIndex].Cells["cod_estoque"].Value);

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o item selecionado?", "Confirmação", MessageBoxButtons.YesNo))
                {

                    Estoque estoquee = new Estoque(Loginn.FkUsuario);

                    estoquee.Excluir(codestoquee);

                    View_Estoque();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode excluir item vazio", "Aviso");
            }
        }

        private void EditarEstoque_Click(object sender, EventArgs e)
        {
            try
            {

                codestoque = Convert.ToInt32(GridEstoque.Rows[GridEstoque.CurrentCell.RowIndex].Cells["cod_estoque"].Value);

                Estoque estoque = new Estoque(Loginn.FkUsuario);

                estoque.ListarEstoque(codestoque);

                this.Close();

                theard = new Thread(NovaEdit);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();

            }

            catch (Exception)
            {
                MessageBox.Show("Não pode Editar item vazio", "AVISO");


                GridEstoque.ClearSelection();

            }

        }

        private void NovaEdit(object obj)
        {
            Application.Run(new EditarProdutoEstoque());
        }

        private void ProdutoEstoque_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaProduto);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaProduto(object obj)
        {
            Application.Run(new View_Produtos());
        }

        private void HistoricoEstoque_Click(object sender, EventArgs e)
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

            theard = new Thread(TelaVenda);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaVenda(object obj)
        {
            Application.Run(new View_Vendas());
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
