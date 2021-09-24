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
    public partial class AlterarCadastro : Form
    {

        int codTelefone;

        Thread theard;





        public AlterarCadastro()
        {
            InitializeComponent();

            NomeBlococomobox();

            }



        private void NomeBlococomobox()
        {

            Usuario usuario = new Usuario();

            TelefoneUser telefone = new TelefoneUser();

            Rua rua = new Rua();

            Bloco bloco = new Bloco();



            usuario.ListarUsuario(Loginn.FkUsuario); //numero do usuario

            telefone.ListarTelefone(Loginn.FkUsuario); /////numero do usuario



            rua.ListarRuaFk(Usuario.ListagemUsuario[0].FkEndereco);

            bloco.ListarBloco(Rua.ListagemRua[0].Fk_bloco);

            var ListagemBloco = Bloco.ListagemBloco;

            NomeAlterCad.Text = Usuario.ListagemUsuario[0].NomeUsuario;

            NomeEmpAlterCad.Text = Usuario.ListagemUsuario[0].NomeEmpresa;


            CPFAlterCad.Text = Usuario.ListagemUsuario[0].CpfUsuario;

            EmailAlterCad.Text = Usuario.ListagemUsuario[0].EmailUsuariio;

            CompEndAlterCad.Text = Usuario.ListagemUsuario[0].ComplementoEndereco;

            DataNascAlterCad.Text = Usuario.ListagemUsuario[0].DataNascimento;


            DDDAlterCad.Text = TelefoneUser.ListagemTelefone[0].DDD;

            TelefoneAlterCad.Text = TelefoneUser.ListagemTelefone[0].Numero;

            codTelefone = TelefoneUser.ListagemTelefone[0].CodTelefone;

            Bloco blocoo = new Bloco();

            blocoo.ListarBloco();

            NomeBlocoAlterCad.DataSource = Bloco.ListagemBloco;

            NomeBlocoAlterCad.DisplayMember = "NomeBloco";

            NomeBlocoAlterCad.ValueMember = "CodBloco";

            NomeBlocoAlterCad.SelectedIndex = NomeBlocoAlterCad.FindString(ListagemBloco[0].NomeBloco);


        

            

           


        }
        private void VoltarEsqSenha_Click(object sender, EventArgs e)
        {

            this.Close();

            theard = new Thread(TelaPerfil);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void NomeEmpAlterCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlterarCad_Click(object sender, EventArgs e)

        {

            Usuario usuarioo = new Usuario();

            TelefoneUser telefonee = new TelefoneUser();

          

            usuarioo.ListarUsuario(Loginn.FkUsuario); //numero do usuario
               
            telefonee.ListarTelefone(Loginn.FkUsuario); /////numero do usuario

            var ListagemUser = Usuario.ListagemUsuario;
            var ListagemTel = TelefoneUser.ListagemTelefone;


            int x = Int32.Parse(NomeRuaAlterCad.SelectedValue.ToString());


            if (String.IsNullOrEmpty(NomeAlterCad.Text) || String.IsNullOrEmpty(NomeEmpAlterCad.Text) || String.IsNullOrEmpty(CompEndAlterCad.Text) || String.IsNullOrEmpty(DDDAlterCad.Text) || String.IsNullOrEmpty(TelefoneAlterCad.Text))
            {

                MessageBox.Show("Nenhum capo pode ser vazio", "aviso");
            }

            else if  (ListagemUser[0].FkEndereco == x && ListagemUser[0].NomeUsuario == NomeAlterCad.Text && ListagemUser[0].NomeEmpresa == NomeEmpAlterCad.Text && ListagemUser[0].ComplementoEndereco ==  CompEndAlterCad.Text && ListagemTel[0].DDD == DDDAlterCad.Text && ListagemTel[0].Numero == TelefoneAlterCad.Text)
            {

                MessageBox.Show("Não foi feita alteração em nenhum campo devido os campos ser os mesmos!", "Aviso");
            }


            else
            {

                Usuario usuario = new Usuario(Loginn.FkUsuario, NomeEmpAlterCad.Text, NomeAlterCad.Text, CompEndAlterCad.Text, x);

                TelefoneUser telefone = new TelefoneUser(codTelefone, DDDAlterCad.Text, TelefoneAlterCad.Text, Loginn.FkUsuario);

                telefone.Editar();
                usuario.Editar();



                this.Close();

                theard = new Thread(TelaPerfil);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();


            }




        }

        private void TelaPerfil(object obj)
        {
            Application.Run(new Perfil());
        }

        private void NomeAlterCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeRuaAlterCad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NomeBlocoAlterCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Int32.Parse(NomeBlocoAlterCad.SelectedValue.ToString());
            




            Rua rua = new Rua();

            rua.ListarRua(x);

            NomeRuaAlterCad.DataSource = Rua.ListagemRua;

            NomeRuaAlterCad.DisplayMember = "NomeRua";

            NomeRuaAlterCad.ValueMember = "CodRua";


        }
    }
}
