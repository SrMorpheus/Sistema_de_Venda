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
    public partial class View_Vendas : Form
    {
        int CodVenda;
        Thread theard;



        public View_Vendas()
        {
            InitializeComponent();
            Filtrocomobox();


        }

        private void VendaHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Venda()
        {
            Conexao conexao = new Conexao();

            MySqlCommand cmd = new MySqlCommand();

            var filtro = "%" + FiltroVenda.SelectedValue.ToString();


            if (PesquisaVenda.Text != "" && filtro == "%Geral")
            {


                cmd.CommandText = "select *from view_vendas where  cod_usuario = @FkUsuario and (produto LIKE @pesquisa or cliente LIKE @pesquisa)  ";


                // cmd.Parameters.AddWithValue("@filtro", filtro);

                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);

                cmd.Parameters.AddWithValue("@pesquisa", PesquisaVenda.Text);

            }

            else if (String.IsNullOrEmpty(PesquisaVenda.Text) && filtro == "%Geral")
            {
                cmd.CommandText = "select *from view_vendas where  cod_usuario = @FkUsuario";

                // cmd.Parameters.AddWithValue("@filtro", filtro);

                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);

            }
            else if (PesquisaVenda.Text != "" && filtro != "%Geral")
            {

                cmd.CommandText = "select *from view_vendas where  cod_usuario = @FkUsuario and (produto LIKE @pesquisa or cliente LIKE @pesquisa) and tipo_pagamento LIKE @filtro ";

                cmd.Parameters.AddWithValue("@filtro", filtro);

                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);

                cmd.Parameters.AddWithValue("@pesquisa", PesquisaVenda.Text);

            }
            else
            {
                cmd.CommandText = "select *from view_vendas where  cod_usuario = @FkUsuario and tipo_pagamento LIKE @filtro";

                cmd.Parameters.AddWithValue("@filtro", filtro);

                cmd.Parameters.AddWithValue("@FkUsuario", Loginn.FkUsuario);

            }




            cmd.Connection = conexao.Conectar();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            VendaHistorico.DataSource = null;

            VendaHistorico.DataSource = dt;

            VendaHistorico.ReadOnly = true;



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
            VendaHistorico.Columns["cod_vendas"].Visible = false;
            VendaHistorico.Columns["cod_usuario"].Visible = false;

            VendaHistorico.Columns["usuario_venda"].Visible = false;


            VendaHistorico.Columns["data_venda"].HeaderText = "Data";

            VendaHistorico.Columns["data_venda"].Width = 200;

            VendaHistorico.Columns["data_venda"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["data_venda"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["produto"].HeaderText = "Produto";

            VendaHistorico.Columns["produto"].Width = 150;

            VendaHistorico.Columns["produto"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["produto"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;


            VendaHistorico.Columns["quantidade"].HeaderText = "Quantidade";

            VendaHistorico.Columns["quantidade"].Width = 120;

            VendaHistorico.Columns["quantidade"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["quantidade"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["preco"].HeaderText = "Preço";

            VendaHistorico.Columns["preco"].Width = 120;

            VendaHistorico.Columns["preco"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["preco"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["Total"].HeaderText = "Total";

            VendaHistorico.Columns["Total"].Width = 120;

            VendaHistorico.Columns["Total"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["Total"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["obeservacao"].HeaderText = "Observação";

            VendaHistorico.Columns["obeservacao"].Width = 250;

            VendaHistorico.Columns["obeservacao"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["obeservacao"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["cliente"].HeaderText = "Cliente";

            VendaHistorico.Columns["cliente"].Width = 300;

            VendaHistorico.Columns["cliente"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["cliente"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["tipo_pagamento"].HeaderText = "Pagamento";

            VendaHistorico.Columns["tipo_pagamento"].Width = 200;
            VendaHistorico.Columns["tipo_pagamento"].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;

            VendaHistorico.Columns["tipo_pagamento"].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;









        }

        private void Filtrocomobox()
        {
            Historico historico = new Historico();

            Pagamento pagamento = new Pagamento();

            FiltroVenda.DataSource = Pagamento.ListagemPagamentoPesquisar;





        }


        private void PesquisarVendas_Click(object sender, EventArgs e)
        {
            View_Venda();
        }

        private void FiltroVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            View_Venda();
        }

        private void PesquisaVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void Venda_click(object sender, EventArgs e)
        {
            try
            {
                CodVenda = Convert.ToInt32(VendaHistorico.Rows[VendaHistorico.CurrentCell.RowIndex].Cells["cod_vendas"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode escolher item vazio", "Aviso");

                VendaHistorico.ClearSelection();
                try
                {
                    VendaHistorico.Rows[VendaHistorico.Rows.Count - 2].Selected = true;
                }
                catch (Exception)
                {
                    VendaHistorico.Rows[VendaHistorico.Rows.Count - 1].Selected = true;
                }

            }





        }

        private void AdicionarVenda_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaVenda);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaVenda(object obj)
        {
            Application.Run(new AdicionarVenda());
        }

        private void VoltarHistoricoVenda_Click(object sender, EventArgs e)
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

        private void ProdHistoricoVenda_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaProduo);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaProduo(object obj)
        {
            Application.Run(new View_Produtos());
        }

        private void EstoqueHistoricoVenda_Click(object sender, EventArgs e)
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

        private void HistoricoHistoricoVenda_Click(object sender, EventArgs e)
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