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
    public partial class EsqueceuSenha : Form
    {

        Thread theard;
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void Resetar_Click(object sender, EventArgs e)
        {
            Loginn loginn = new Loginn();

            loginn.ValidarResetarSenha(EmailResetar.Text, CpfResetar.Text);

            if (loginn.Confirm == true)
            {
                loginn.ResetarSenha(EmailResetar.Text, CpfResetar.Text);

                MessageBox.Show("Senha resetada com sucesso para senha padrão");


                this.Close();

                theard = new Thread(NovaTela);

                theard.SetApartmentState(ApartmentState.STA);

                theard.Start();

            }else if (String.IsNullOrEmpty(EmailResetar.Text)  || String.IsNullOrEmpty(CpfResetar.Text))
            {
                MessageBox.Show("Email ou Senha não pode ser vazia ");

            }
            else
            {
                
                EmailResetar.Text = string.Empty;

                CpfResetar.Text = string.Empty;

                MessageBox.Show("Email ou CPF não existe no cadastro do sistema");



            }

           
        }

        private void NovaTela(object obj)
        {
            Application.Run(new Login());
        }

        private void VoltarEsqSenha_Click(object sender, EventArgs e)
        {
            this.Close();

            theard = new Thread(NovaTela);

            theard.SetApartmentState(ApartmentState.STA);

            theard.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CpfResetar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
