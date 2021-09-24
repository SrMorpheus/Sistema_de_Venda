
namespace WinFormsApp1
{
    partial class CadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProduto));
            this.CatCadProduto = new System.Windows.Forms.ComboBox();
            this.NomeCadProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CadastrarProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.VoltarCadProduto = new System.Windows.Forms.Button();
            this.DesCadProduto = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CatCadProduto
            // 
            this.CatCadProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatCadProduto.FormattingEnabled = true;
            this.CatCadProduto.Location = new System.Drawing.Point(17, 367);
            this.CatCadProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatCadProduto.Name = "CatCadProduto";
            this.CatCadProduto.Size = new System.Drawing.Size(484, 33);
            this.CatCadProduto.TabIndex = 0;
            this.CatCadProduto.SelectedIndexChanged += new System.EventHandler(this.CatCadProduto_SelectedIndexChanged);
            // 
            // NomeCadProduto
            // 
            this.NomeCadProduto.Location = new System.Drawing.Point(17, 283);
            this.NomeCadProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeCadProduto.Name = "NomeCadProduto";
            this.NomeCadProduto.Size = new System.Drawing.Size(484, 31);
            this.NomeCadProduto.TabIndex = 5;
            this.NomeCadProduto.TextChanged += new System.EventHandler(this.NomeCadProduto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(186, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categória";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição";
            // 
            // CadastrarProduto
            // 
            this.CadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.CadastrarProduto.FlatAppearance.BorderSize = 0;
            this.CadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadastrarProduto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadastrarProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.CadastrarProduto.Location = new System.Drawing.Point(917, 677);
            this.CadastrarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CadastrarProduto.Name = "CadastrarProduto";
            this.CadastrarProduto.Size = new System.Drawing.Size(209, 53);
            this.CadastrarProduto.TabIndex = 13;
            this.CadastrarProduto.Text = "Cadastrar Produto";
            this.CadastrarProduto.UseVisualStyleBackColor = false;
            this.CadastrarProduto.Click += new System.EventHandler(this.CadastrarProduto_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(17, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 128);
            this.label7.TabIndex = 16;
            this.label7.Text = "Unifood";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VoltarCadProduto
            // 
            this.VoltarCadProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarCadProduto.FlatAppearance.BorderSize = 0;
            this.VoltarCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarCadProduto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarCadProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarCadProduto.Location = new System.Drawing.Point(29, 677);
            this.VoltarCadProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarCadProduto.Name = "VoltarCadProduto";
            this.VoltarCadProduto.Size = new System.Drawing.Size(101, 53);
            this.VoltarCadProduto.TabIndex = 17;
            this.VoltarCadProduto.Text = "Voltar";
            this.VoltarCadProduto.UseVisualStyleBackColor = false;
            this.VoltarCadProduto.Click += new System.EventHandler(this.VoltarCadProduto_Click);
            // 
            // DesCadProduto
            // 
            this.DesCadProduto.Location = new System.Drawing.Point(17, 450);
            this.DesCadProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DesCadProduto.Name = "DesCadProduto";
            this.DesCadProduto.Size = new System.Drawing.Size(484, 31);
            this.DesCadProduto.TabIndex = 18;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_venda.Properties.Resources.desenhos_animados_de_produtos_de_mercearia_de_supermercado_24640_26644;
            this.pictureBox1.Location = new System.Drawing.Point(610, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.DesCadProduto);
            this.Controls.Add(this.VoltarCadProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CadastrarProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeCadProduto);
            this.Controls.Add(this.CatCadProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro produto";
            this.Load += new System.EventHandler(this.CadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CatCadProduto;
        private System.Windows.Forms.TextBox NomeCadProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CadastrarProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button VoltarCadProduto;
        private System.Windows.Forms.TextBox DesCadProduto;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}