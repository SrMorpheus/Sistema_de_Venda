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
    public partial class AlterarSenha : Form
    {
        Thread theard;
        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void AltSenha_Click(object sender, EventArgs e)
        {
            Loginn login = new Loginn();

            
            login.ConfirmarSenha(Loginn.FkUsuario, SenhaAtual.Text);


            if (login.Confirm == true && !String.IsNullOrEmpty(NovaSenha.Text) && !String.IsNullOrEmpty(SenhaAtual.Text) && !String.IsNullOrEmpty(ConfirmarSenha.Text))
            {

                login.AlterarSenha(Loginn.FkUsuario, SenhaAtual.Text, ConfirmarSenha.Text);
                MessageBox.Show("Senha alterada com sucessso!", "Aviso!");

                this.Close();

                theard = new Thread(TelaPerfil);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();
            }

            else if (String.IsNullOrEmpty(NovaSenha.Text) || String.IsNullOrEmpty(SenhaAtual.Text) || String.IsNullOrEmpty(ConfirmarSenha.Text)) {

                MessageBox.Show("Nenhum campo pode ser vazio", "Aviso!");
            } else if (NovaSenha.Text != ConfirmarSenha.Text)
            {

                MessageBox.Show("As senhas estão diferentes", "Aviso!");

            }
            else
            {
                MessageBox.Show("Senha não alterada,não existe no Sistema reference ao usuario", "Aviso!");

                SenhaAtual.Text = string.Empty;

            }




        }

        private void TelaPerfil(object obj)
        {
            Application.Run(new Perfil());
        }

        private void SenhaAtual_TextChanged(object sender, EventArgs e)
        {
            SenhaAtual.MaxLength = 23;
        }

        private void VoltarAltSenha_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(TelaPerfil);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void NovaSenha_TextChanged(object sender, EventArgs e)
        {
            NovaSenha.MaxLength = 23;
        }

        private void ConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            ConfirmarSenha.MaxLength = 23;
        }

        private void SenhaHouve(object sender, EventArgs e)
        {
            SenhaAtual.UseSystemPasswordChar = false;
        }

        private void SenhaLeave(object sender, EventArgs e)
        {
            SenhaAtual.UseSystemPasswordChar = true;
        }

        private void SenhaNovaNaover(object sender, EventArgs e)
        {
            NovaSenha.UseSystemPasswordChar = false;
        }

        private void SenhaNovaVer(object sender, EventArgs e)
        {
            NovaSenha.UseSystemPasswordChar = true;
        }

        private void SenhaConfirmNaoVer(object sender, EventArgs e)
        {
            ConfirmarSenha.UseSystemPasswordChar = false;
        }

        private void ConfirmarSenha_MouseLeave(object sender, EventArgs e)
        {
            ConfirmarSenha.UseSystemPasswordChar = true;

        }
    }
    }

