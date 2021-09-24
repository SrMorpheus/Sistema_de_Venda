
namespace WinFormsApp1
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPF = new System.Windows.Forms.TextBox();
            this.VoltarEsqSenha = new System.Windows.Forms.Button();
            this.NomeBloco = new System.Windows.Forms.ComboBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.text9 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.text8 = new System.Windows.Forms.Label();
            this.text10 = new System.Windows.Forms.Label();
            this.DDD = new System.Windows.Forms.TextBox();
            this.ConfirmarCad = new System.Windows.Forms.CheckBox();
            this.text4 = new System.Windows.Forms.Label();
            this.DataNasc = new System.Windows.Forms.DateTimePicker();
            this.text7 = new System.Windows.Forms.Label();
            this.NomeRua = new System.Windows.Forms.ComboBox();
            this.text5 = new System.Windows.Forms.Label();
            this.text6 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.NomeEmpresa = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.ComplementoEnd = new System.Windows.Forms.TextBox();
            this.NomeCompleto = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CadMapa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.groupBox1.Controls.Add(this.CPF);
            this.groupBox1.Controls.Add(this.VoltarEsqSenha);
            this.groupBox1.Controls.Add(this.NomeBloco);
            this.groupBox1.Controls.Add(this.Cadastrar);
            this.groupBox1.Controls.Add(this.text9);
            this.groupBox1.Controls.Add(this.Telefone);
            this.groupBox1.Controls.Add(this.text8);
            this.groupBox1.Controls.Add(this.text10);
            this.groupBox1.Controls.Add(this.DDD);
            this.groupBox1.Controls.Add(this.ConfirmarCad);
            this.groupBox1.Controls.Add(this.text4);
            this.groupBox1.Controls.Add(this.DataNasc);
            this.groupBox1.Controls.Add(this.text7);
            this.groupBox1.Controls.Add(this.NomeRua);
            this.groupBox1.Controls.Add(this.text5);
            this.groupBox1.Controls.Add(this.text6);
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.NomeEmpresa);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.ComplementoEnd);
            this.groupBox1.Controls.Add(this.NomeCompleto);
            this.groupBox1.Controls.Add(this.text2);
            this.groupBox1.Controls.Add(this.text3);
            this.groupBox1.Controls.Add(this.Titulo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(713, 750);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(17, 318);
            this.CPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPF.MaxLength = 11;
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(141, 31);
            this.CPF.TabIndex = 25;
            this.CPF.TextChanged += new System.EventHandler(this.CPF_TextChanged);
            // 
            // VoltarEsqSenha
            // 
            this.VoltarEsqSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarEsqSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarEsqSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarEsqSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarEsqSenha.Location = new System.Drawing.Point(17, 680);
            this.VoltarEsqSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarEsqSenha.Name = "VoltarEsqSenha";
            this.VoltarEsqSenha.Size = new System.Drawing.Size(97, 60);
            this.VoltarEsqSenha.TabIndex = 9;
            this.VoltarEsqSenha.Text = "Voltar";
            this.VoltarEsqSenha.UseVisualStyleBackColor = false;
            this.VoltarEsqSenha.Click += new System.EventHandler(this.VoltarEsqSenha_Click);
            // 
            // NomeBloco
            // 
            this.NomeBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomeBloco.FormattingEnabled = true;
            this.NomeBloco.Location = new System.Drawing.Point(17, 462);
            this.NomeBloco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeBloco.Name = "NomeBloco";
            this.NomeBloco.Size = new System.Drawing.Size(403, 33);
            this.NomeBloco.TabIndex = 8;
            this.NomeBloco.SelectedIndexChanged += new System.EventHandler(this.NomeBloco_SelectedIndexChanged);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cadastrar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.Cadastrar.Location = new System.Drawing.Point(431, 680);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(127, 56);
            this.Cadastrar.TabIndex = 24;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // text9
            // 
            this.text9.AutoSize = true;
            this.text9.Location = new System.Drawing.Point(49, 288);
            this.text9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text9.Name = "text9";
            this.text9.Size = new System.Drawing.Size(42, 25);
            this.text9.TabIndex = 22;
            this.text9.Text = "CPF";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(221, 318);
            this.Telefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Telefone.Mask = "00000-9999";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(154, 31);
            this.Telefone.TabIndex = 20;
            this.Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // text8
            // 
            this.text8.AutoSize = true;
            this.text8.Location = new System.Drawing.Point(250, 288);
            this.text8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text8.Name = "text8";
            this.text8.Size = new System.Drawing.Size(77, 25);
            this.text8.TabIndex = 19;
            this.text8.Text = "Telefone";
            // 
            // text10
            // 
            this.text10.AutoSize = true;
            this.text10.Location = new System.Drawing.Point(169, 288);
            this.text10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text10.Name = "text10";
            this.text10.Size = new System.Drawing.Size(51, 25);
            this.text10.TabIndex = 17;
            this.text10.Text = "DDD";
            // 
            // DDD
            // 
            this.DDD.Location = new System.Drawing.Point(169, 318);
            this.DDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DDD.MaxLength = 2;
            this.DDD.Name = "DDD";
            this.DDD.Size = new System.Drawing.Size(43, 31);
            this.DDD.TabIndex = 16;
            this.DDD.TextChanged += new System.EventHandler(this.DDD_TextChanged);
            // 
            // ConfirmarCad
            // 
            this.ConfirmarCad.AutoSize = true;
            this.ConfirmarCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmarCad.Location = new System.Drawing.Point(431, 615);
            this.ConfirmarCad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmarCad.Name = "ConfirmarCad";
            this.ConfirmarCad.Size = new System.Drawing.Size(113, 29);
            this.ConfirmarCad.TabIndex = 15;
            this.ConfirmarCad.Text = "Confirmar";
            this.ConfirmarCad.UseVisualStyleBackColor = true;
            this.ConfirmarCad.CheckedChanged += new System.EventHandler(this.ConfirmarCad_CheckedChanged);
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Location = new System.Drawing.Point(388, 288);
            this.text4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(170, 25);
            this.text4.TabIndex = 14;
            this.text4.Text = "Data de nascimento";
            // 
            // DataNasc
            // 
            this.DataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNasc.Location = new System.Drawing.Point(386, 318);
            this.DataNasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataNasc.Name = "DataNasc";
            this.DataNasc.Size = new System.Drawing.Size(171, 31);
            this.DataNasc.TabIndex = 13;
            this.DataNasc.ValueChanged += new System.EventHandler(this.DataNasc_ValueChanged);
            // 
            // text7
            // 
            this.text7.AutoSize = true;
            this.text7.Location = new System.Drawing.Point(66, 578);
            this.text7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text7.Name = "text7";
            this.text7.Size = new System.Drawing.Size(204, 25);
            this.text7.TabIndex = 12;
            this.text7.Text = "Complemento Endereço";
            // 
            // NomeRua
            // 
            this.NomeRua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomeRua.FormattingEnabled = true;
            this.NomeRua.Location = new System.Drawing.Point(17, 535);
            this.NomeRua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeRua.Name = "NomeRua";
            this.NomeRua.Size = new System.Drawing.Size(591, 33);
            this.NomeRua.TabIndex = 11;
            this.NomeRua.SelectedIndexChanged += new System.EventHandler(this.NomeRua_SelectedIndexChanged);
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Location = new System.Drawing.Point(214, 505);
            this.text5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(116, 25);
            this.text5.TabIndex = 10;
            this.text5.Text = "Nome da rua";
            this.text5.Click += new System.EventHandler(this.label6_Click);
            // 
            // text6
            // 
            this.text6.AutoSize = true;
            this.text6.Location = new System.Drawing.Point(221, 432);
            this.text6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(111, 25);
            this.text6.TabIndex = 9;
            this.text6.Text = "Nome bloco";
            this.text6.Click += new System.EventHandler(this.text6_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(250, 358);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(61, 25);
            this.text.TabIndex = 7;
            this.text.Text = "E-mail";
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.Location = new System.Drawing.Point(269, 245);
            this.NomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(339, 31);
            this.NomeEmpresa.TabIndex = 6;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(17, 388);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(591, 31);
            this.Email.TabIndex = 5;
            // 
            // ComplementoEnd
            // 
            this.ComplementoEnd.Location = new System.Drawing.Point(17, 608);
            this.ComplementoEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComplementoEnd.Name = "ComplementoEnd";
            this.ComplementoEnd.Size = new System.Drawing.Size(358, 31);
            this.ComplementoEnd.TabIndex = 4;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Location = new System.Drawing.Point(17, 245);
            this.NomeCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeCompleto.Name = "NomeCompleto";
            this.NomeCompleto.Size = new System.Drawing.Size(241, 31);
            this.NomeCompleto.TabIndex = 3;
            this.NomeCompleto.TextChanged += new System.EventHandler(this.NomeCompleto_TextChanged);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(380, 215);
            this.text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(159, 25);
            this.text2.TabIndex = 2;
            this.text2.Text = "Nome da empresa";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Location = new System.Drawing.Point(86, 215);
            this.text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(142, 25);
            this.text3.TabIndex = 1;
            this.text3.Text = "Nome completo";
            this.text3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.Location = new System.Drawing.Point(69, 47);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(383, 128);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.groupBox2.Controls.Add(this.CadMapa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(631, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(512, 750);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // CadMapa
            // 
            this.CadMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.CadMapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadMapa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadMapa.ForeColor = System.Drawing.SystemColors.Control;
            this.CadMapa.Location = new System.Drawing.Point(145, 676);
            this.CadMapa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CadMapa.Name = "CadMapa";
            this.CadMapa.Size = new System.Drawing.Size(215, 60);
            this.CadMapa.TabIndex = 26;
            this.CadMapa.Text = "Mapa da Unifap";
            this.CadMapa.UseVisualStyleBackColor = false;
            this.CadMapa.Click += new System.EventHandler(this.CadMapa_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preencha os dados corretamente evitando erros ao cadastro-los no sistema.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox NomeEmpresa;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox ComplementoEnd;
        private System.Windows.Forms.TextBox NomeCompleto;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.Label text8;
        private System.Windows.Forms.Label text10;
        private System.Windows.Forms.TextBox DDD;
        private System.Windows.Forms.CheckBox ConfirmarCad;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.DateTimePicker DataNasc;
        private System.Windows.Forms.Label text7;
        private System.Windows.Forms.ComboBox NomeRua;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.ComboBox NomeBloco;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label text9;
        private System.Windows.Forms.Button VoltarEsqSenha;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Button CadMapa;
    }
}

