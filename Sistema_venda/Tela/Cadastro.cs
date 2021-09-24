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

namespace WinFormsApp1
{
    public partial class Cadastro : Form
    {
        Thread theard;
        public Cadastro()
        {
            InitializeComponent();
            NomeBlococomobox();


        }

        private void NomeBlococomobox()
        {
            Bloco bloco = new Bloco();

            bloco.ListarBloco();

            NomeBloco.DataSource = Bloco.ListagemBloco;

            NomeBloco.DisplayMember = "NomeBloco";

            NomeBloco.ValueMember = "CodBloco";

            NomeBloco.SelectedIndex = -1;

            NomeRua.SelectedIndex = -1;
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NomeBloco_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x;

            if (NomeBloco.SelectedIndex == -1)
            {
                x = 0;
            }
            else
            {
                 x = Int32.Parse(NomeBloco.SelectedValue.ToString());
            }


         

            Rua rua = new Rua();

            rua.ListarRua(x);

            NomeRua.DataSource = Rua.ListagemRua;

            NomeRua.DisplayMember = "NomeRua";

            NomeRua.ValueMember = "CodRua";

            
        }

          
        
        private void text6_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
         
            
        {
            int x;

            if(NomeRua.SelectedIndex == -1)
            {
                x = 0;
            }
            else
            {
                x = Int32.Parse(NomeRua.SelectedValue.ToString());
            }

            string dataReal = DataNasc.Value.ToString("yyy-MM-dd");
          
  

           

            Usuario usuario = new Usuario(NomeCompleto.Text, NomeEmpresa.Text, CPF.Text, dataReal, Email.Text, x, ComplementoEnd.Text);

          

            if (ConfirmarCad.ThreeState == false)
            {
                MessageBox.Show("Confirme seu cadrastro!");

             

            }else if (ConfirmarCad.ThreeState == true)
            {


                usuario.ValidarCpfExist();

                usuario.ValidarEmailExist();


                if(usuario.ConfirmCpf == true && usuario.ConfirmEmail == false)
                {
                    MessageBox.Show("Esse CPF Já existe no sistema!");

                    CPF.Text = string.Empty;
                }
                else if  (usuario.ConfirmCpf == false && usuario.ConfirmEmail == true)
                {
                    MessageBox.Show("Esse Email Já existe no sistema!");

                    Email.Text = string.Empty;
                }
                else if (usuario.ConfirmCpf == true && usuario.ConfirmEmail == true)
                {
                    MessageBox.Show("Esse Email e CPF Já existe no sistema! ");

                    CPF.Text = string.Empty;

                    Email.Text = string.Empty;

                } else if ( String.IsNullOrEmpty(CPF.Text) || String.IsNullOrEmpty(Email.Text)  || String.IsNullOrEmpty(NomeCompleto.Text) || String.IsNullOrEmpty(NomeEmpresa.Text) ||
                            String.IsNullOrEmpty(ComplementoEnd.Text) || String.IsNullOrEmpty(NomeBloco.Text) || String.IsNullOrEmpty(NomeRua.Text))
                {
                    MessageBox.Show("Nenhum campo pode ser vazio, prenchimento obrigatório!");
                   

                }
                else
                {
                    usuario.Inserir();

                    usuario.PegarCod();

                   

                    TelefoneUser telefoneUser =  new TelefoneUser(DDD.Text, Telefone.Text, usuario.CodUsuario);

                    telefoneUser.Inserir();


                    this.Close();

                    theard = new Thread(TelaLogin);

                    theard.SetApartmentState(ApartmentState.STA);

                    theard.Start();


                }
            }

        }

        private void DataNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarCad_CheckedChanged(object sender, EventArgs e)
        {
            
            if(!ConfirmarCad.ThreeState)
            {
                ConfirmarCad.ThreeState = true;

                ConfirmarCad.CheckAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                ConfirmarCad.ThreeState = false;
                ConfirmarCad.CheckAlign = ContentAlignment.MiddleLeft;
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void VoltarEsqSenha_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaLogin);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void TelaLogin(object obj)
        {
            Application.Run(new Login());
        }

        private void NomeRua_SelectedIndexChanged(object sender, EventArgs e)
        {


       

        }

        private void NomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        

        private void DDD_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void CPF_TextChanged(object sender, EventArgs e)
        {
            CPF.MaxLength = 11;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CadMapa_Click(object sender, EventArgs e)
        {
            theard = new Thread(MapaaUnifap);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void MapaaUnifap(object obj)
        {
            Application.Run(new MapaUnifap());
        }
    }
}

