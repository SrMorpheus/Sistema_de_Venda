
namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InscricaoCad = new System.Windows.Forms.Label();
            this.EsqueciSenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EntrarLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SenhaLogin = new System.Windows.Forms.TextBox();
            this.NomeLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.InscricaoCad);
            this.groupBox1.Controls.Add(this.EsqueciSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EntrarLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SenhaLogin);
            this.groupBox1.Controls.Add(this.NomeLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(186, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(774, 625);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // InscricaoCad
            // 
            this.InscricaoCad.AutoSize = true;
            this.InscricaoCad.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InscricaoCad.Location = new System.Drawing.Point(411, 503);
            this.InscricaoCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InscricaoCad.Name = "InscricaoCad";
            this.InscricaoCad.Size = new System.Drawing.Size(183, 33);
            this.InscricaoCad.TabIndex = 8;
            this.InscricaoCad.Text = "Não é inscrito?";
            this.InscricaoCad.Click += new System.EventHandler(this.InscricaoCad_Click);
            this.InscricaoCad.MouseLeave += new System.EventHandler(this.SenhaLogin_TextChanged);
            this.InscricaoCad.MouseHover += new System.EventHandler(this.SenhaLogin_TextChanged);
            // 
            // EsqueciSenha
            // 
            this.EsqueciSenha.AutoSize = true;
            this.EsqueciSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EsqueciSenha.Location = new System.Drawing.Point(170, 503);
            this.EsqueciSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EsqueciSenha.Name = "EsqueciSenha";
            this.EsqueciSenha.Size = new System.Drawing.Size(222, 33);
            this.EsqueciSenha.TabIndex = 7;
            this.EsqueciSenha.Text = "Esqueceu a senha?";
            this.EsqueciSenha.Click += new System.EventHandler(this.EsqueciSenha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(336, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // EntrarLogin
            // 
            this.EntrarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.EntrarLogin.FlatAppearance.BorderSize = 0;
            this.EntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EntrarLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntrarLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.EntrarLogin.Location = new System.Drawing.Point(231, 422);
            this.EntrarLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EntrarLogin.Name = "EntrarLogin";
            this.EntrarLogin.Size = new System.Drawing.Size(270, 57);
            this.EntrarLogin.TabIndex = 5;
            this.EntrarLogin.Text = "Entrar";
            this.EntrarLogin.UseVisualStyleBackColor = false;
            this.EntrarLogin.Click += new System.EventHandler(this.EntrarLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(336, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SenhaLogin
            // 
            this.SenhaLogin.Location = new System.Drawing.Point(231, 347);
            this.SenhaLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SenhaLogin.Name = "SenhaLogin";
            this.SenhaLogin.Size = new System.Drawing.Size(268, 31);
            this.SenhaLogin.TabIndex = 2;
            this.SenhaLogin.UseSystemPasswordChar = true;
            this.SenhaLogin.TextChanged += new System.EventHandler(this.SenhaLogin_TextChanged);
            this.SenhaLogin.MouseLeave += new System.EventHandler(this.Senhaver);
            this.SenhaLogin.MouseHover += new System.EventHandler(this.SenhaNaover);
            // 
            // NomeLogin
            // 
            this.NomeLogin.Location = new System.Drawing.Point(231, 255);
            this.NomeLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeLogin.Name = "NomeLogin";
            this.NomeLogin.Size = new System.Drawing.Size(268, 31);
            this.NomeLogin.TabIndex = 1;
            this.NomeLogin.TextChanged += new System.EventHandler(this.NomeLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(170, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 180);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unifood";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EntrarLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SenhaLogin;
        private System.Windows.Forms.TextBox NomeLogin;
        private System.Windows.Forms.Label EsqueciSenha;
        private System.Windows.Forms.Label InscricaoCad;
    }
}