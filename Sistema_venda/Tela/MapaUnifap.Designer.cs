
namespace WinFormsApp1
{
    partial class MapaUnifap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VoltarMapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_venda.Properties.Resources.MapaDaUnifap;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1410, 902);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // VoltarMapa
            // 
            this.VoltarMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarMapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarMapa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarMapa.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarMapa.Location = new System.Drawing.Point(77, 825);
            this.VoltarMapa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarMapa.Name = "VoltarMapa";
            this.VoltarMapa.Size = new System.Drawing.Size(97, 60);
            this.VoltarMapa.TabIndex = 10;
            this.VoltarMapa.Text = "Voltar";
            this.VoltarMapa.UseVisualStyleBackColor = false;
            this.VoltarMapa.Click += new System.EventHandler(this.VoltarMapa_Click);
            // 
            // MapaUnifap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1406, 899);
            this.Controls.Add(this.VoltarMapa);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MapaUnifap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa da unifap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VoltarMapa;
    }
}