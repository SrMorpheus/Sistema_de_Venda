
namespace WinFormsApp1
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.Produtoopcao = new System.Windows.Forms.ToolStripMenuItem();
            this.Estoque2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Historico = new System.Windows.Forms.ToolStripMenuItem();
            this.SairMenu = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Perfil,
            this.Menu,
            this.Vendas,
            this.Estoque});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1143, 43);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Perfil
            // 
            this.Perfil.ForeColor = System.Drawing.SystemColors.Control;
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(93, 37);
            this.Perfil.Text = "Perfil";
            this.Perfil.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // Menu
            // 
            this.Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(96, 37);
            this.Menu.Text = "Menu";
            // 
            // Vendas
            // 
            this.Vendas.ForeColor = System.Drawing.SystemColors.Control;
            this.Vendas.Name = "Vendas";
            this.Vendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Vendas.Size = new System.Drawing.Size(111, 37);
            this.Vendas.Text = "Vendas";
            this.Vendas.Click += new System.EventHandler(this.Vendas_Click);
            // 
            // Estoque
            // 
            this.Estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Produtoopcao,
            this.Estoque2,
            this.Historico});
            this.Estoque.ForeColor = System.Drawing.SystemColors.Control;
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(121, 37);
            this.Estoque.Text = "Estoque";
            // 
            // Produtoopcao
            // 
            this.Produtoopcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.Produtoopcao.ForeColor = System.Drawing.SystemColors.Control;
            this.Produtoopcao.Name = "Produtoopcao";
            this.Produtoopcao.Size = new System.Drawing.Size(223, 42);
            this.Produtoopcao.Text = "Produto";
            this.Produtoopcao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Produtoopcao.Click += new System.EventHandler(this.Produtoopcao_Click);
            // 
            // Estoque2
            // 
            this.Estoque2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.Estoque2.ForeColor = System.Drawing.SystemColors.Control;
            this.Estoque2.Name = "Estoque2";
            this.Estoque2.Size = new System.Drawing.Size(223, 42);
            this.Estoque2.Text = "Estoque";
            this.Estoque2.Click += new System.EventHandler(this.Estoque2_Click);
            // 
            // Historico
            // 
            this.Historico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.Historico.ForeColor = System.Drawing.SystemColors.Control;
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(223, 42);
            this.Historico.Text = "Historico";
            this.Historico.Click += new System.EventHandler(this.Historico_Click);
            // 
            // SairMenu
            // 
            this.SairMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.SairMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SairMenu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SairMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.SairMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SairMenu.Location = new System.Drawing.Point(17, 678);
            this.SairMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SairMenu.Name = "SairMenu";
            this.SairMenu.Size = new System.Drawing.Size(101, 53);
            this.SairMenu.TabIndex = 18;
            this.SairMenu.Text = "Sair";
            this.SairMenu.UseVisualStyleBackColor = false;
            this.SairMenu.Click += new System.EventHandler(this.SairMenu_Click);
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.Location = new System.Drawing.Point(17, 48);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(383, 128);
            this.Titulo.TabIndex = 35;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_venda.Properties.Resources.ea104a53_3400_473d_ac3d_e45b4efa1a6f;
            this.pictureBox1.Location = new System.Drawing.Point(12, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistema_venda.Properties.Resources.cantina_central_crédito_Divulgação;
            this.pictureBox2.Location = new System.Drawing.Point(691, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sistema_venda.Properties.Resources.lanchonete_pesquisa_preco_780x450;
            this.pictureBox3.Location = new System.Drawing.Point(691, 392);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(430, 304);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.SairMenu);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Perfil;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Vendas;
        private System.Windows.Forms.ToolStripMenuItem Estoque;
        private System.Windows.Forms.ToolStripMenuItem Produtoopcao;
        private System.Windows.Forms.ToolStripMenuItem Estoque2;
        private System.Windows.Forms.ToolStripMenuItem Historico;
        private System.Windows.Forms.Button SairMenu;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}