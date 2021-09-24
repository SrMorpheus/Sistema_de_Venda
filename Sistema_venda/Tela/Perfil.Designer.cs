
namespace WinFormsApp1
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PerfilPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.VendasPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.EstoquePerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.EsEstoquePerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoricoPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.text9 = new System.Windows.Forms.Label();
            this.text8 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.DataNascPerfil = new System.Windows.Forms.DateTimePicker();
            this.text7 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.text6 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.NomeEmpPerfil = new System.Windows.Forms.TextBox();
            this.EmailPerfil = new System.Windows.Forms.TextBox();
            this.CompEndPerfil = new System.Windows.Forms.TextBox();
            this.NomePerfil = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.AlterCad = new System.Windows.Forms.Button();
            this.AlterSenha = new System.Windows.Forms.Button();
            this.VoltarPerfil = new System.Windows.Forms.Button();
            this.CPFPerfil = new System.Windows.Forms.TextBox();
            this.DDD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Telefonename = new System.Windows.Forms.TextBox();
            this.NomeRuaPerfil = new System.Windows.Forms.TextBox();
            this.NomeBlocoPerfil = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PerfilPerfil,
            this.MenuPerfil,
            this.VendasPerfil,
            this.EstoquePerfil});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1143, 43);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // PerfilPerfil
            // 
            this.PerfilPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.PerfilPerfil.Name = "PerfilPerfil";
            this.PerfilPerfil.Size = new System.Drawing.Size(93, 37);
            this.PerfilPerfil.Text = "Perfil";
            // 
            // MenuPerfil
            // 
            this.MenuPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuPerfil.Name = "MenuPerfil";
            this.MenuPerfil.Size = new System.Drawing.Size(96, 37);
            this.MenuPerfil.Text = "Menu";
            // 
            // VendasPerfil
            // 
            this.VendasPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.VendasPerfil.Name = "VendasPerfil";
            this.VendasPerfil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VendasPerfil.Size = new System.Drawing.Size(111, 37);
            this.VendasPerfil.Text = "Vendas";
            this.VendasPerfil.Click += new System.EventHandler(this.VendasPerfil_Click);
            // 
            // EstoquePerfil
            // 
            this.EstoquePerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdutoPerfil,
            this.EsEstoquePerfil,
            this.HistoricoPerfil});
            this.EstoquePerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.EstoquePerfil.Name = "EstoquePerfil";
            this.EstoquePerfil.Size = new System.Drawing.Size(121, 37);
            this.EstoquePerfil.Text = "Estoque";
            // 
            // ProdutoPerfil
            // 
            this.ProdutoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.ProdutoPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdutoPerfil.Name = "ProdutoPerfil";
            this.ProdutoPerfil.Size = new System.Drawing.Size(223, 42);
            this.ProdutoPerfil.Text = "Produto";
            this.ProdutoPerfil.Click += new System.EventHandler(this.ProdutoPerfil_Click);
            // 
            // EsEstoquePerfil
            // 
            this.EsEstoquePerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.EsEstoquePerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.EsEstoquePerfil.Name = "EsEstoquePerfil";
            this.EsEstoquePerfil.Size = new System.Drawing.Size(223, 42);
            this.EsEstoquePerfil.Text = "Estoque";
            this.EsEstoquePerfil.Click += new System.EventHandler(this.EsEstoquePerfil_Click);
            // 
            // HistoricoPerfil
            // 
            this.HistoricoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.HistoricoPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.HistoricoPerfil.Name = "HistoricoPerfil";
            this.HistoricoPerfil.Size = new System.Drawing.Size(223, 42);
            this.HistoricoPerfil.Text = "Historico";
            this.HistoricoPerfil.Click += new System.EventHandler(this.HistoricoPerfil_Click);
            // 
            // text9
            // 
            this.text9.AutoSize = true;
            this.text9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text9.Location = new System.Drawing.Point(410, 272);
            this.text9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text9.Name = "text9";
            this.text9.Size = new System.Drawing.Size(66, 33);
            this.text9.TabIndex = 59;
            this.text9.Text = "CPF";
            // 
            // text8
            // 
            this.text8.AutoSize = true;
            this.text8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text8.Location = new System.Drawing.Point(722, 274);
            this.text8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text8.Name = "text8";
            this.text8.Size = new System.Drawing.Size(110, 33);
            this.text8.TabIndex = 56;
            this.text8.Text = "Telefone";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text4.Location = new System.Drawing.Point(903, 272);
            this.text4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(232, 33);
            this.text4.TabIndex = 52;
            this.text4.Text = "Data de nascimento";
            // 
            // DataNascPerfil
            // 
            this.DataNascPerfil.Enabled = false;
            this.DataNascPerfil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascPerfil.Location = new System.Drawing.Point(903, 312);
            this.DataNascPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataNascPerfil.Name = "DataNascPerfil";
            this.DataNascPerfil.Size = new System.Drawing.Size(221, 31);
            this.DataNascPerfil.TabIndex = 51;
            // 
            // text7
            // 
            this.text7.AutoSize = true;
            this.text7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text7.Location = new System.Drawing.Point(476, 522);
            this.text7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text7.Name = "text7";
            this.text7.Size = new System.Drawing.Size(281, 33);
            this.text7.TabIndex = 50;
            this.text7.Text = "Complemento Endereço";
            this.text7.Click += new System.EventHandler(this.text7_Click);
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text5.Location = new System.Drawing.Point(787, 438);
            this.text5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(156, 33);
            this.text5.TabIndex = 48;
            this.text5.Text = "Nome da rua";
            // 
            // text6
            // 
            this.text6.AutoSize = true;
            this.text6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text6.Location = new System.Drawing.Point(410, 440);
            this.text6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(150, 33);
            this.text6.TabIndex = 47;
            this.text6.Text = "Nome bloco";
            this.text6.Click += new System.EventHandler(this.text6_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(553, 355);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(89, 33);
            this.text.TabIndex = 45;
            this.text.Text = "E-mail";
            // 
            // NomeEmpPerfil
            // 
            this.NomeEmpPerfil.Enabled = false;
            this.NomeEmpPerfil.Location = new System.Drawing.Point(754, 228);
            this.NomeEmpPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeEmpPerfil.Name = "NomeEmpPerfil";
            this.NomeEmpPerfil.Size = new System.Drawing.Size(370, 31);
            this.NomeEmpPerfil.TabIndex = 44;
            // 
            // EmailPerfil
            // 
            this.EmailPerfil.Enabled = false;
            this.EmailPerfil.Location = new System.Drawing.Point(370, 395);
            this.EmailPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailPerfil.Name = "EmailPerfil";
            this.EmailPerfil.Size = new System.Drawing.Size(540, 31);
            this.EmailPerfil.TabIndex = 43;
            // 
            // CompEndPerfil
            // 
            this.CompEndPerfil.Enabled = false;
            this.CompEndPerfil.Location = new System.Drawing.Point(370, 562);
            this.CompEndPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompEndPerfil.Name = "CompEndPerfil";
            this.CompEndPerfil.Size = new System.Drawing.Size(540, 31);
            this.CompEndPerfil.TabIndex = 42;
            // 
            // NomePerfil
            // 
            this.NomePerfil.Enabled = false;
            this.NomePerfil.Location = new System.Drawing.Point(370, 228);
            this.NomePerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomePerfil.Name = "NomePerfil";
            this.NomePerfil.Size = new System.Drawing.Size(370, 31);
            this.NomePerfil.TabIndex = 41;
            this.NomePerfil.TextChanged += new System.EventHandler(this.NomePerfil_TextChanged);
            this.NomePerfil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarNome);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text2.Location = new System.Drawing.Point(836, 188);
            this.text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(211, 33);
            this.text2.TabIndex = 40;
            this.text2.Text = "Nome da empresa";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text3.Location = new System.Drawing.Point(476, 188);
            this.text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(190, 33);
            this.text3.TabIndex = 39;
            this.text3.Text = "Nome completo";
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
            this.Titulo.TabIndex = 38;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AlterCad
            // 
            this.AlterCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(56)))), ((int)(((byte)(190)))));
            this.AlterCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlterCad.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlterCad.ForeColor = System.Drawing.SystemColors.Control;
            this.AlterCad.Location = new System.Drawing.Point(640, 680);
            this.AlterCad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlterCad.Name = "AlterCad";
            this.AlterCad.Size = new System.Drawing.Size(239, 50);
            this.AlterCad.TabIndex = 60;
            this.AlterCad.Text = "Alterar Cadastro";
            this.AlterCad.UseVisualStyleBackColor = false;
            this.AlterCad.Click += new System.EventHandler(this.AlterCad_Click);
            // 
            // AlterSenha
            // 
            this.AlterSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(56)))), ((int)(((byte)(190)))));
            this.AlterSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlterSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlterSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.AlterSenha.Location = new System.Drawing.Point(887, 680);
            this.AlterSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlterSenha.Name = "AlterSenha";
            this.AlterSenha.Size = new System.Drawing.Size(239, 50);
            this.AlterSenha.TabIndex = 62;
            this.AlterSenha.Text = "Alterar Senha";
            this.AlterSenha.UseVisualStyleBackColor = false;
            this.AlterSenha.Click += new System.EventHandler(this.AlterSenha_Click);
            // 
            // VoltarPerfil
            // 
            this.VoltarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarPerfil.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarPerfil.Location = new System.Drawing.Point(17, 670);
            this.VoltarPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarPerfil.Name = "VoltarPerfil";
            this.VoltarPerfil.Size = new System.Drawing.Size(97, 60);
            this.VoltarPerfil.TabIndex = 64;
            this.VoltarPerfil.Text = "Voltar";
            this.VoltarPerfil.UseVisualStyleBackColor = false;
            this.VoltarPerfil.Click += new System.EventHandler(this.VoltarPerfil_Click);
            // 
            // CPFPerfil
            // 
            this.CPFPerfil.Enabled = false;
            this.CPFPerfil.Location = new System.Drawing.Point(370, 312);
            this.CPFPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPFPerfil.Name = "CPFPerfil";
            this.CPFPerfil.Size = new System.Drawing.Size(214, 31);
            this.CPFPerfil.TabIndex = 65;
            // 
            // DDD
            // 
            this.DDD.Enabled = false;
            this.DDD.Location = new System.Drawing.Point(594, 312);
            this.DDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DDD.Name = "DDD";
            this.DDD.Size = new System.Drawing.Size(71, 31);
            this.DDD.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(597, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 68;
            this.label1.Text = "DDD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistema_venda.Properties.Resources.WhatsApp_Image_2021_09_21_at_22_46_09;
            this.pictureBox2.Location = new System.Drawing.Point(12, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 335);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Telefonename
            // 
            this.Telefonename.Enabled = false;
            this.Telefonename.Location = new System.Drawing.Point(672, 312);
            this.Telefonename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Telefonename.Multiline = true;
            this.Telefonename.Name = "Telefonename";
            this.Telefonename.Size = new System.Drawing.Size(223, 31);
            this.Telefonename.TabIndex = 71;
            this.Telefonename.TextChanged += new System.EventHandler(this.Telefonename_TextChanged);
            // 
            // NomeRuaPerfil
            // 
            this.NomeRuaPerfil.Enabled = false;
            this.NomeRuaPerfil.Location = new System.Drawing.Point(619, 478);
            this.NomeRuaPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeRuaPerfil.Multiline = true;
            this.NomeRuaPerfil.Name = "NomeRuaPerfil";
            this.NomeRuaPerfil.Size = new System.Drawing.Size(511, 33);
            this.NomeRuaPerfil.TabIndex = 72;
            // 
            // NomeBlocoPerfil
            // 
            this.NomeBlocoPerfil.Enabled = false;
            this.NomeBlocoPerfil.Location = new System.Drawing.Point(370, 478);
            this.NomeBlocoPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeBlocoPerfil.Multiline = true;
            this.NomeBlocoPerfil.Name = "NomeBlocoPerfil";
            this.NomeBlocoPerfil.Size = new System.Drawing.Size(227, 33);
            this.NomeBlocoPerfil.TabIndex = 73;
            this.NomeBlocoPerfil.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.NomeBlocoPerfil);
            this.Controls.Add(this.NomeRuaPerfil);
            this.Controls.Add(this.Telefonename);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DDD);
            this.Controls.Add(this.CPFPerfil);
            this.Controls.Add(this.VoltarPerfil);
            this.Controls.Add(this.AlterSenha);
            this.Controls.Add(this.AlterCad);
            this.Controls.Add(this.text9);
            this.Controls.Add(this.text8);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.DataNascPerfil);
            this.Controls.Add(this.text7);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.text);
            this.Controls.Add(this.NomeEmpPerfil);
            this.Controls.Add(this.EmailPerfil);
            this.Controls.Add(this.CompEndPerfil);
            this.Controls.Add(this.NomePerfil);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PerfilPerfil;
        private System.Windows.Forms.ToolStripMenuItem MenuPerfil;
        private System.Windows.Forms.ToolStripMenuItem VendasPerfil;
        private System.Windows.Forms.ToolStripMenuItem EstoquePerfil;
        private System.Windows.Forms.ToolStripMenuItem ProdutoPerfil;
        private System.Windows.Forms.ToolStripMenuItem EsEstoquePerfil;
        private System.Windows.Forms.ToolStripMenuItem HistoricoPerfil;
        private System.Windows.Forms.Label text9;
        private System.Windows.Forms.Label text8;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.DateTimePicker DataNascPerfil;
        private System.Windows.Forms.Label text7;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox NomeEmpPerfil;
        private System.Windows.Forms.TextBox EmailPerfil;
        private System.Windows.Forms.TextBox CompEndPerfil;
        private System.Windows.Forms.TextBox NomePerfil;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button AlterCad;
        private System.Windows.Forms.Button AddTelefone;
        private System.Windows.Forms.Button AlterSenha;
        private System.Windows.Forms.Button VoltarPerfil;
        private System.Windows.Forms.TextBox CPFPerfil;
        private System.Windows.Forms.TextBox DDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Telefonename;
        private System.Windows.Forms.TextBox NomeRuaPerfil;
        private System.Windows.Forms.TextBox NomeBlocoPerfil;
    }
}