using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MapaUnifap : Form
    {
        public MapaUnifap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VoltarMapa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
