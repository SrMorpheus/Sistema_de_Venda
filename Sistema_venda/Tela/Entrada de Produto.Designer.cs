
namespace WinFormsApp1
{
    partial class EntradaProdutoTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaProdutoTela));
            this.DesEntradaProd = new System.Windows.Forms.ComboBox();
            this.NomeEntradaProd = new System.Windows.Forms.ComboBox();
            this.CatEntradaProd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecoEntradaProd = new System.Windows.Forms.MaskedTextBox();
            this.QtdEntradaProd = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VoltarEntradaProd = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.EntradaProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DesEntradaProd
            // 
            this.DesEntradaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DesEntradaProd.FormattingEnabled = true;
            this.DesEntradaProd.Location = new System.Drawing.Point(17, 357);
            this.DesEntradaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DesEntradaProd.Name = "DesEntradaProd";
            this.DesEntradaProd.Size = new System.Drawing.Size(395, 33);
            this.DesEntradaProd.TabIndex = 0;
            this.DesEntradaProd.SelectedIndexChanged += new System.EventHandler(this.DesEntradaProd_SelectedIndexChanged);
            this.DesEntradaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDesc);
            // 
            // NomeEntradaProd
            // 
            this.NomeEntradaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomeEntradaProd.FormattingEnabled = true;
            this.NomeEntradaProd.Location = new System.Drawing.Point(17, 183);
            this.NomeEntradaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeEntradaProd.Name = "NomeEntradaProd";
            this.NomeEntradaProd.Size = new System.Drawing.Size(395, 33);
            this.NomeEntradaProd.TabIndex = 1;
            this.NomeEntradaProd.SelectedIndexChanged += new System.EventHandler(this.NomeEntradaProd_SelectedIndexChanged);
            // 
            // CatEntradaProd
            // 
            this.CatEntradaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CatEntradaProd.FormattingEnabled = true;
            this.CatEntradaProd.Location = new System.Drawing.Point(17, 273);
            this.CatEntradaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatEntradaProd.Name = "CatEntradaProd";
            this.CatEntradaProd.Size = new System.Drawing.Size(395, 33);
            this.CatEntradaProd.TabIndex = 2;
            this.CatEntradaProd.SelectedIndexChanged += new System.EventHandler(this.CatEntradaProd_SelectedIndexChanged);
            this.CatEntradaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CatTravar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(131, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(131, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(17, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 105);
            this.label7.TabIndex = 17;
            this.label7.Text = "Unifood";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PrecoEntradaProd
            // 
            this.PrecoEntradaProd.Location = new System.Drawing.Point(423, 357);
            this.PrecoEntradaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrecoEntradaProd.Name = "PrecoEntradaProd";
            this.PrecoEntradaProd.Size = new System.Drawing.Size(174, 31);
            this.PrecoEntradaProd.TabIndex = 19;
            this.PrecoEntradaProd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PrecoEntradaProd_MaskInputRejected);
            this.PrecoEntradaProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Virgula);
            // 
            // QtdEntradaProd
            // 
            this.QtdEntradaProd.Location = new System.Drawing.Point(423, 273);
            this.QtdEntradaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QtdEntradaProd.Name = "QtdEntradaProd";
            this.QtdEntradaProd.Size = new System.Drawing.Size(174, 31);
            this.QtdEntradaProd.TabIndex = 20;
            this.QtdEntradaProd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.QtdEntradaProd_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(470, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Preço";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(449, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantidade";
            // 
            // VoltarEntradaProd
            // 
            this.VoltarEntradaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarEntradaProd.FlatAppearance.BorderSize = 0;
            this.VoltarEntradaProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarEntradaProd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarEntradaProd.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarEntradaProd.Location = new System.Drawing.Point(40, 677);
            this.VoltarEntradaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarEntradaProd.Name = "VoltarEntradaProd";
            this.VoltarEntradaProd.Size = new System.Drawing.Size(101, 53);
            this.VoltarEntradaProd.TabIndex = 24;
            this.VoltarEntradaProd.Text = "Voltar";
            this.VoltarEntradaProd.UseVisualStyleBackColor = false;
            this.VoltarEntradaProd.Click += new System.EventHandler(this.VoltarEntradaProd_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip2.TabIndex = 36;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // EntradaProd
            // 
            this.EntradaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.EntradaProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EntradaProd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntradaProd.ForeColor = System.Drawing.SystemColors.Control;
            this.EntradaProd.Location = new System.Drawing.Point(966, 677);
            this.EntradaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EntradaProd.Name = "EntradaProd";
            this.EntradaProd.Size = new System.Drawing.Size(160, 53);
            this.EntradaProd.TabIndex = 37;
            this.EntradaProd.Text = "Entrada";
            this.EntradaProd.UseVisualStyleBackColor = false;
            this.EntradaProd.Click += new System.EventHandler(this.EntradaProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_venda.Properties.Resources.desenhos_animados_de_caixa_registradora_de_supermercado_24640_26646;
            this.pictureBox1.Location = new System.Drawing.Point(616, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EntradaProdutoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EntradaProd);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.VoltarEntradaProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QtdEntradaProd);
            this.Controls.Add(this.PrecoEntradaProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CatEntradaProd);
            this.Controls.Add(this.NomeEntradaProd);
            this.Controls.Add(this.DesEntradaProd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntradaProdutoTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DesEntradaProd;
        private System.Windows.Forms.ComboBox NomeEntradaProd;
        private System.Windows.Forms.ComboBox CatEntradaProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox PrecoEntradaProd;
        private System.Windows.Forms.MaskedTextBox QtdEntradaProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button VoltarEntradaProd;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button EntradaProd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}