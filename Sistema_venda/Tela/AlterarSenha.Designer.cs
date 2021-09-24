
namespace WinFormsApp1
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            this.Titulo = new System.Windows.Forms.Label();
            this.SenhaAtual = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.Label();
            this.VoltarAltSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NovaSenha = new System.Windows.Forms.TextBox();
            this.ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.AltSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.Location = new System.Drawing.Point(17, 15);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(383, 128);
            this.Titulo.TabIndex = 40;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SenhaAtual
            // 
            this.SenhaAtual.Location = new System.Drawing.Point(186, 228);
            this.SenhaAtual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SenhaAtual.Name = "SenhaAtual";
            this.SenhaAtual.Size = new System.Drawing.Size(370, 31);
            this.SenhaAtual.TabIndex = 43;
            this.SenhaAtual.UseSystemPasswordChar = true;
            this.SenhaAtual.TextChanged += new System.EventHandler(this.SenhaAtual_TextChanged);
            this.SenhaAtual.MouseLeave += new System.EventHandler(this.SenhaLeave);
            this.SenhaAtual.MouseHover += new System.EventHandler(this.SenhaHouve);
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text3.Location = new System.Drawing.Point(294, 188);
            this.text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(144, 33);
            this.text3.TabIndex = 42;
            this.text3.Text = "Senha atual";
            // 
            // VoltarAltSenha
            // 
            this.VoltarAltSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarAltSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarAltSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarAltSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarAltSenha.Location = new System.Drawing.Point(17, 557);
            this.VoltarAltSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarAltSenha.Name = "VoltarAltSenha";
            this.VoltarAltSenha.Size = new System.Drawing.Size(97, 60);
            this.VoltarAltSenha.TabIndex = 65;
            this.VoltarAltSenha.Text = "Voltar";
            this.VoltarAltSenha.UseVisualStyleBackColor = false;
            this.VoltarAltSenha.Click += new System.EventHandler(this.VoltarAltSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nova senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(274, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 33);
            this.label2.TabIndex = 67;
            this.label2.Text = "Confirmar senha";
            // 
            // NovaSenha
            // 
            this.NovaSenha.Location = new System.Drawing.Point(186, 312);
            this.NovaSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NovaSenha.Name = "NovaSenha";
            this.NovaSenha.Size = new System.Drawing.Size(370, 31);
            this.NovaSenha.TabIndex = 68;
            this.NovaSenha.UseSystemPasswordChar = true;
            this.NovaSenha.TextChanged += new System.EventHandler(this.NovaSenha_TextChanged);
            this.NovaSenha.MouseLeave += new System.EventHandler(this.SenhaNovaVer);
            this.NovaSenha.MouseHover += new System.EventHandler(this.SenhaNovaNaover);
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.Location = new System.Drawing.Point(186, 395);
            this.ConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.Size = new System.Drawing.Size(370, 31);
            this.ConfirmarSenha.TabIndex = 69;
            this.ConfirmarSenha.UseSystemPasswordChar = true;
            this.ConfirmarSenha.TextChanged += new System.EventHandler(this.ConfirmarSenha_TextChanged);
            this.ConfirmarSenha.MouseLeave += new System.EventHandler(this.ConfirmarSenha_MouseLeave);
            this.ConfirmarSenha.MouseHover += new System.EventHandler(this.SenhaConfirmNaoVer);
            // 
            // AltSenha
            // 
            this.AltSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.AltSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AltSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AltSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.AltSenha.Location = new System.Drawing.Point(566, 563);
            this.AltSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AltSenha.Name = "AltSenha";
            this.AltSenha.Size = new System.Drawing.Size(224, 53);
            this.AltSenha.TabIndex = 70;
            this.AltSenha.Text = "Alterar senha";
            this.AltSenha.UseVisualStyleBackColor = false;
            this.AltSenha.Click += new System.EventHandler(this.AltSenha_Click);
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(807, 637);
            this.Controls.Add(this.AltSenha);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.NovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VoltarAltSenha);
            this.Controls.Add(this.SenhaAtual);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox SenhaAtual;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Button VoltarAltSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NovaSenha;
        private System.Windows.Forms.TextBox ConfirmarSenha;
        private System.Windows.Forms.Button AltSenha;
    }
}