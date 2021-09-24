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
    public partial class View_Historicos : Form
    {
        Thread theard;
        public View_Historicos()
        {
            InitializeComponent();
            Filtrocomobox();
        }

        private void EditarHistorico_Click(object sender, EventArgs e)
        {

        }

        private void Filtrocomobox()
        {
            Historico historico = new Historico();



            FiltroHistorico.DataSource = Historico.ListagemMovimento;

        



        }


   

        private void View_Historico()
        {
            Conexao conexao = new Conexao();

            MySqlCommand cmd = new MySqlCommand();

            var filtro = "%" + FiltroHistorico.SelectedValue.ToString();


            if (BarPesqEstoque.Text != "")
            {


                cmd.CommandText = "select *from views_historico  where tipo like @filtro and produto = @pesquisa and cod_usuario = @FkUsuario";


                cmd.Parameters.AddWithValue("@filtro", filtro);

                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);

                cmd.Parameters.AddWithValue("@pesquisa", BarPesqEstoque.Text);
              
            }

            else
            {
                cmd.CommandText = "select *from views_historico  where tipo like @filtro and cod_usuario = @FkUsuario";
               
                cmd.Parameters.AddWithValue("@filtro", filtro);
                
                cmd.Parameters.AddWithValue("@FkUsuario",Loginn.FkUsuario);
            }




            cmd.Connection = conexao.Conectar();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            HistoricoGrid.DataSource = null;

            HistoricoGrid.DataSource = dt;

            HistoricoGrid.ReadOnly = true;



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
    

        private void CriarCabecalhoGade()
        {

            HistoricoGrid.Columns["cod_usuario"].Visible = false;

            HistoricoGrid.Columns["usuario"].Visible = false;



            HistoricoGrid.Columns["data_historico"].HeaderText = "Data";

            HistoricoGrid.Columns["data_historico"].Width = 185;

            HistoricoGrid.Columns["data_historico"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["data_historico"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["tipo"].HeaderText = "Movimentação";

            HistoricoGrid.Columns["tipo"].Width = 274;

            HistoricoGrid.Columns["tipo"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["tipo"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["produto"].HeaderText = "Produto";

            HistoricoGrid.Columns["produto"].Width = 150;

            HistoricoGrid.Columns["produto"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["produto"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["quantidade"].HeaderText = "Quantidade";

            HistoricoGrid.Columns["quantidade"].Width = 109;

            HistoricoGrid.Columns["quantidade"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["quantidade"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["preco"].HeaderText = "Preço";

            HistoricoGrid.Columns["preco"].Width = 110;

            HistoricoGrid.Columns["preco"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["preco"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;


            HistoricoGrid.Columns["Total"].HeaderText = "Total";

            HistoricoGrid.Columns["Total"].Width = 130;

            HistoricoGrid.Columns["Total"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            HistoricoGrid.Columns["Total"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;






        }






        private void PesquisarHistorico_Click(object sender, EventArgs e)
        {
            View_Historico();

        }

        private void AdicionarHistorico_Click(object sender, EventArgs e)
        {

        }

        private void HistoricoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FiltroHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            View_Historico();
        }

        private void VoltarHistorico_Click(object sender, EventArgs e)
        {

            this.Close();

            theard = new Thread(NovaTelaMenu);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void NovaTelaMenu(object obj)
        {
            Application.Run(new MenuPrincipal());
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

        private void HistoricoEstoque_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

