
namespace WinFormsApp1
{
    partial class EsqueceuSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenha));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VoltarEsqSenha = new System.Windows.Forms.Button();
            this.Resetar = new System.Windows.Forms.Button();
            this.CpfResetar = new System.Windows.Forms.MaskedTextBox();
            this.EmailEsqSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailResetar = new System.Windows.Forms.TextBox();
            this.CPFEsqSenha = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.t.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.groupBox1.Controls.Add(this.VoltarEsqSenha);
            this.groupBox1.Controls.Add(this.Resetar);
            this.groupBox1.Controls.Add(this.CpfResetar);
            this.groupBox1.Controls.Add(this.EmailEsqSenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EmailResetar);
            this.groupBox1.Controls.Add(this.CPFEsqSenha);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(577, 750);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // VoltarEsqSenha
            // 
            this.VoltarEsqSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarEsqSenha.FlatAppearance.BorderSize = 0;
            this.VoltarEsqSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarEsqSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarEsqSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarEsqSenha.Location = new System.Drawing.Point(77, 427);
            this.VoltarEsqSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarEsqSenha.Name = "VoltarEsqSenha";
            this.VoltarEsqSenha.Size = new System.Drawing.Size(97, 60);
            this.VoltarEsqSenha.TabIndex = 8;
            this.VoltarEsqSenha.Text = "Voltar";
            this.VoltarEsqSenha.UseVisualStyleBackColor = false;
            this.VoltarEsqSenha.Click += new System.EventHandler(this.VoltarEsqSenha_Click);
            // 
            // Resetar
            // 
            this.Resetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.Resetar.FlatAppearance.BorderSize = 0;
            this.Resetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Resetar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resetar.ForeColor = System.Drawing.SystemColors.Control;
            this.Resetar.Location = new System.Drawing.Point(327, 427);
            this.Resetar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Resetar.Name = "Resetar";
            this.Resetar.Size = new System.Drawing.Size(110, 60);
            this.Resetar.TabIndex = 7;
            this.Resetar.Text = "Resetar";
            this.Resetar.UseVisualStyleBackColor = false;
            this.Resetar.Click += new System.EventHandler(this.Resetar_Click);
            // 
            // CpfResetar
            // 
            this.CpfResetar.Location = new System.Drawing.Point(143, 300);
            this.CpfResetar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CpfResetar.Name = "CpfResetar";
            this.CpfResetar.Size = new System.Drawing.Size(225, 31);
            this.CpfResetar.TabIndex = 6;
            this.CpfResetar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CpfResetar_MaskInputRejected);
            // 
            // EmailEsqSenha
            // 
            this.EmailEsqSenha.AutoSize = true;
            this.EmailEsqSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailEsqSenha.Location = new System.Drawing.Point(204, 177);
            this.EmailEsqSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailEsqSenha.Name = "EmailEsqSenha";
            this.EmailEsqSenha.Size = new System.Drawing.Size(89, 33);
            this.EmailEsqSenha.TabIndex = 5;
            this.EmailEsqSenha.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 92);
            this.label1.TabIndex = 4;
            this.label1.Text = "    Esqueceu a senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmailResetar
            // 
            this.EmailResetar.Location = new System.Drawing.Point(77, 217);
            this.EmailResetar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailResetar.Name = "EmailResetar";
            this.EmailResetar.Size = new System.Drawing.Size(358, 31);
            this.EmailResetar.TabIndex = 2;
            // 
            // CPFEsqSenha
            // 
            this.CPFEsqSenha.AutoSize = true;
            this.CPFEsqSenha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPFEsqSenha.Location = new System.Drawing.Point(213, 260);
            this.CPFEsqSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPFEsqSenha.Name = "CPFEsqSenha";
            this.CPFEsqSenha.Size = new System.Drawing.Size(66, 33);
            this.CPFEsqSenha.TabIndex = 0;
            this.CPFEsqSenha.Text = "CPF";
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.t.Controls.Add(this.label2);
            this.t.Dock = System.Windows.Forms.DockStyle.Right;
            this.t.Location = new System.Drawing.Point(570, 0);
            this.t.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t.Name = "t";
            this.t.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t.Size = new System.Drawing.Size(573, 750);
            this.t.TabIndex = 1;
            this.t.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 92);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o e-mail e CPF para resetar a senha antiga, novamente.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.t);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EsqueceuSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueceu a senha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.t.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox t;
        private System.Windows.Forms.Label CPFEsqSenha;
        private System.Windows.Forms.TextBox EmailResetar;
        private System.Windows.Forms.MaskedTextBox CpfResetar;
        private System.Windows.Forms.Label EmailEsqSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VoltarEsqSenha;
        private System.Windows.Forms.Button Resetar;
        private System.Windows.Forms.Label label2;
    }
}