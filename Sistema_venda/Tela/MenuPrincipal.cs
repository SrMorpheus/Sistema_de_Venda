using sistema_venda;
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
    public partial class MenuPrincipal : Form
    {
        Thread theard;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Produtoopcao_Click(object sender, EventArgs e)
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

        private void SairMenu_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja Sair do Sistema?", "Confirmação", MessageBoxButtons.YesNo))
            {
                this.Close();

                theard = new Thread(TelaLogin);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();
            }

            
        }

        private void TelaLogin(object obj)
        {
            Application.Run(new Login());
        }

        private void Estoque2_Click(object sender, EventArgs e)
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

        private void Historico_Click(object sender, EventArgs e)
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
