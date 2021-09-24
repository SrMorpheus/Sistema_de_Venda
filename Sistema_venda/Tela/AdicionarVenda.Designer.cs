
namespace WinFormsApp1
{
    partial class AdicionarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarVenda));
            this.NomeCliente = new System.Windows.Forms.ComboBox();
            this.ProdutoVenda = new System.Windows.Forms.ComboBox();
            this.TipoPagamento = new System.Windows.Forms.ComboBox();
            this.ObservacaoVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.VoltarAddVenda = new System.Windows.Forms.Button();
            this.AddVenda = new System.Windows.Forms.Button();
            this.QuantidadeVenda = new System.Windows.Forms.TextBox();
            this.PrecoVendaa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeCliente
            // 
            this.NomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomeCliente.FormattingEnabled = true;
            this.NomeCliente.Location = new System.Drawing.Point(17, 253);
            this.NomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Size = new System.Drawing.Size(360, 33);
            this.NomeCliente.TabIndex = 0;
            this.NomeCliente.SelectedIndexChanged += new System.EventHandler(this.NomeCliente_SelectedIndexChanged);
            // 
            // ProdutoVenda
            // 
            this.ProdutoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdutoVenda.FormattingEnabled = true;
            this.ProdutoVenda.Location = new System.Drawing.Point(387, 253);
            this.ProdutoVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdutoVenda.Name = "ProdutoVenda";
            this.ProdutoVenda.Size = new System.Drawing.Size(308, 33);
            this.ProdutoVenda.TabIndex = 1;
            this.ProdutoVenda.SelectedIndexChanged += new System.EventHandler(this.ProdutoVenda_SelectedIndexChanged);
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPagamento.FormattingEnabled = true;
            this.TipoPagamento.Location = new System.Drawing.Point(320, 420);
            this.TipoPagamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.Size = new System.Drawing.Size(217, 33);
            this.TipoPagamento.TabIndex = 2;
            // 
            // ObservacaoVenda
            // 
            this.ObservacaoVenda.Location = new System.Drawing.Point(17, 337);
            this.ObservacaoVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObservacaoVenda.Name = "ObservacaoVenda";
            this.ObservacaoVenda.Size = new System.Drawing.Size(678, 31);
            this.ObservacaoVenda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(503, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(200, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(241, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observação Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(336, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Pagamento";
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
            this.Titulo.TabIndex = 39;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VoltarAddVenda
            // 
            this.VoltarAddVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarAddVenda.FlatAppearance.BorderSize = 0;
            this.VoltarAddVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarAddVenda.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarAddVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarAddVenda.Location = new System.Drawing.Point(17, 677);
            this.VoltarAddVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarAddVenda.Name = "VoltarAddVenda";
            this.VoltarAddVenda.Size = new System.Drawing.Size(101, 53);
            this.VoltarAddVenda.TabIndex = 48;
            this.VoltarAddVenda.Text = "Voltar";
            this.VoltarAddVenda.UseVisualStyleBackColor = false;
            this.VoltarAddVenda.Click += new System.EventHandler(this.VoltarAddVenda_Click);
            // 
            // AddVenda
            // 
            this.AddVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.AddVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddVenda.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.AddVenda.Location = new System.Drawing.Point(901, 677);
            this.AddVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddVenda.Name = "AddVenda";
            this.AddVenda.Size = new System.Drawing.Size(224, 53);
            this.AddVenda.TabIndex = 49;
            this.AddVenda.Text = "Adicionar venda";
            this.AddVenda.UseVisualStyleBackColor = false;
            this.AddVenda.Click += new System.EventHandler(this.AddVenda_Click);
            // 
            // QuantidadeVenda
            // 
            this.QuantidadeVenda.Location = new System.Drawing.Point(9, 422);
            this.QuantidadeVenda.Name = "QuantidadeVenda";
            this.QuantidadeVenda.Size = new System.Drawing.Size(150, 31);
            this.QuantidadeVenda.TabIndex = 53;
            // 
            // PrecoVendaa
            // 
            this.PrecoVendaa.Enabled = false;
            this.PrecoVendaa.Location = new System.Drawing.Point(165, 422);
            this.PrecoVendaa.Name = "PrecoVendaa";
            this.PrecoVendaa.Size = new System.Drawing.Size(150, 31);
            this.PrecoVendaa.TabIndex = 54;
            this.PrecoVendaa.TextChanged += new System.EventHandler(this.PrecoVendaa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_venda.Properties.Resources.stonks_meme;
            this.pictureBox1.Location = new System.Drawing.Point(702, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // AdicionarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrecoVendaa);
            this.Controls.Add(this.QuantidadeVenda);
            this.Controls.Add(this.AddVenda);
            this.Controls.Add(this.VoltarAddVenda);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObservacaoVenda);
            this.Controls.Add(this.TipoPagamento);
            this.Controls.Add(this.ProdutoVenda);
            this.Controls.Add(this.NomeCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdicionarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NomeCliente;
        private System.Windows.Forms.ComboBox ProdutoVenda;
        private System.Windows.Forms.ComboBox TipoPagamento;
        private System.Windows.Forms.TextBox ObservacaoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button VoltarAddVenda;
        private System.Windows.Forms.Button AddVenda;
        private System.Windows.Forms.TextBox QuantidadeVenda;
        private System.Windows.Forms.TextBox PrecoVendaa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}