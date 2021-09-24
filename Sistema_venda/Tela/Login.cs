using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using sistema_venda;
using sistema_venda.Models;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        Thread theard; 
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(NovaTelaResetar);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void NovaTelaResetar(object obj)
        {
            Application.Run(new EsqueceuSenha());
        }

        private void InscricaoCad_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaCad);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();


        }

        private void TelaCad(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void EntrarLogin_Click(object sender, EventArgs e)
        {
        

            Loginn login = new Loginn(NomeLogin.Text, SenhaLogin.Text);

            
            login.EntrarSistema();
            
            if (login.Confirm == true)
            {
                login.Entrar();

                this.Close();

                theard = new Thread(NovaTela);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();

            }else if (String.IsNullOrEmpty(NomeLogin.Text) ||  String.IsNullOrEmpty(SenhaLogin.Text)){
         
                
             MessageBox.Show("O Campo login ou senha  não pode ser vazio");
                

            }
            else
            {
                NomeLogin.Text = string.Empty;

                SenhaLogin.Text = string.Empty;

                MessageBox.Show("Usuário ou Senha está incorreto!");
            }



        }

        private void NovaTela(object obj)
        {
            Application.Run(new MenuPrincipal());
        }

        private void NomeLogin_TextChanged(object sender, EventArgs e)
        {
            NomeLogin.MaxLength = 11;
           
        }

        private void SenhaLogin_TextChanged(object sender, EventArgs e)
        {
   
            SenhaLogin.MaxLength = 24;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }



        private void SenhaNaover(object sender, EventArgs e)
        {
            SenhaLogin.UseSystemPasswordChar = false;
        }

        private void Senhaver(object sender, EventArgs e)
        {
            SenhaLogin.UseSystemPasswordChar = true;
        }

       
    }
}
