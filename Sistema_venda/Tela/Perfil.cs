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
    public partial class Perfil : Form
    {
        Thread theard;
        public Perfil()
        {
            InitializeComponent();
            PreechimentoPerfil();
        }

        private void text6_Click(object sender, EventArgs e)
        {

        }

        private void text7_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void ProdutoPerfil_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaProduto);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void PreechimentoPerfil()
        {
            Usuario usuario = new Usuario();

            TelefoneUser telefone = new TelefoneUser();
            
            Rua rua = new Rua();

            Bloco bloco = new Bloco();

         

            usuario.ListarUsuario(Loginn.FkUsuario); //numero do usuario

            telefone.ListarTelefone(Loginn.FkUsuario); /////numero do usuario



            rua.ListarRuaFk(Usuario.ListagemUsuario[0].FkEndereco);

            bloco.ListarBloco(Rua.ListagemRua[0].Fk_bloco);

            NomePerfil.Text = Usuario.ListagemUsuario[0].NomeUsuario;

            NomeEmpPerfil.Text = Usuario.ListagemUsuario[0].NomeEmpresa;


            CPFPerfil.Text = Usuario.ListagemUsuario[0].CpfUsuario;

            EmailPerfil.Text = Usuario.ListagemUsuario[0].EmailUsuariio;

            CompEndPerfil.Text = Usuario.ListagemUsuario[0].ComplementoEndereco;

            DataNascPerfil.Text = Usuario.ListagemUsuario[0].DataNascimento;

            NomeRuaPerfil.Text = Rua.ListagemRua[0].NomeRua;

            NomeBlocoPerfil.Text = Bloco.ListagemBloco[0].NomeBloco;

            DDD.Text = TelefoneUser.ListagemTelefone[0].DDD;

            Telefonename.Text = TelefoneUser.ListagemTelefone[0].Numero;


        }

        private void TelaProduto(object obj)
        {
            Application.Run(new View_Produtos());
        }

        private void EsEstoquePerfil_Click(object sender, EventArgs e)
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

        private void HistoricoPerfil_Click(object sender, EventArgs e)
        {
            {
                this.Close();

                theard = new Thread(TelaHistorico);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();
            }
        }

        private void TelaHistorico(object obj)
        {
            Application.Run(new View_Historicos());
        }

        private void VendasPerfil_Click(object sender, EventArgs e)
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

        private void AlterCad_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaAlterar);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        
    }

        private void TelaAlterar(object obj)
        {
            Application.Run(new AlterarCadastro());
        }

        private void TelaSenha(object obj)
        {
            Application.Run(new AlterarSenha());
        }

        private void AlterSenha_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaSenha);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefonename_TextChanged(object sender, EventArgs e)
        {

        }

        private void TravarNome(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NomePerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void VoltarPerfil_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}