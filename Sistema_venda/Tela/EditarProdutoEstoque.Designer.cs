
namespace WinFormsApp1
{
    partial class EditarProdutoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProdutoEstoque));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Titulo = new System.Windows.Forms.Label();
            this.VoltarEditProdEstoque = new System.Windows.Forms.Button();
            this.NomeEditarProdEstoque = new System.Windows.Forms.ComboBox();
            this.EditarProdEstoque = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecoEditProdEstoque = new System.Windows.Forms.TextBox();
            this.QtdEditarProdEstoque = new System.Windows.Forms.TextBox();
            this.DesEditarProdEstoque = new System.Windows.Forms.ComboBox();
            this.CatEditarProdEstoque = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip2";
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
            this.Titulo.TabIndex = 37;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VoltarEditProdEstoque
            // 
            this.VoltarEditProdEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarEditProdEstoque.FlatAppearance.BorderSize = 0;
            this.VoltarEditProdEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarEditProdEstoque.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarEditProdEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarEditProdEstoque.Location = new System.Drawing.Point(17, 677);
            this.VoltarEditProdEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarEditProdEstoque.Name = "VoltarEditProdEstoque";
            this.VoltarEditProdEstoque.Size = new System.Drawing.Size(101, 53);
            this.VoltarEditProdEstoque.TabIndex = 46;
            this.VoltarEditProdEstoque.Text = "Voltar";
            this.VoltarEditProdEstoque.UseVisualStyleBackColor = false;
            this.VoltarEditProdEstoque.Click += new System.EventHandler(this.VoltarEditProdEstoque_Click);
            // 
            // NomeEditarProdEstoque
            // 
            this.NomeEditarProdEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NomeEditarProdEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeEditarProdEstoque.FormattingEnabled = true;
            this.NomeEditarProdEstoque.Location = new System.Drawing.Point(17, 278);
            this.NomeEditarProdEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeEditarProdEstoque.Name = "NomeEditarProdEstoque";
            this.NomeEditarProdEstoque.Size = new System.Drawing.Size(251, 33);
            this.NomeEditarProdEstoque.TabIndex = 45;
            this.NomeEditarProdEstoque.SelectedIndexChanged += new System.EventHandler(this.NomeEditarProdEstoque_SelectedIndexChanged);
            // 
            // EditarProdEstoque
            // 
            this.EditarProdEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.EditarProdEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarProdEstoque.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditarProdEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.EditarProdEstoque.Location = new System.Drawing.Point(953, 664);
            this.EditarProdEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditarProdEstoque.Name = "EditarProdEstoque";
            this.EditarProdEstoque.Size = new System.Drawing.Size(141, 66);
            this.EditarProdEstoque.TabIndex = 44;
            this.EditarProdEstoque.Text = "Editar";
            this.EditarProdEstoque.UseVisualStyleBackColor = false;
            this.EditarProdEstoque.Click += new System.EventHandler(this.EditarProdEstoque_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(316, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 33);
            this.label4.TabIndex = 43;
            this.label4.Text = "Categoria";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 42;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 49;
            this.label1.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 50;
            this.label5.Text = "Quantidade";
            // 
            // PrecoEditProdEstoque
            // 
            this.PrecoEditProdEstoque.Location = new System.Drawing.Point(253, 447);
            this.PrecoEditProdEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrecoEditProdEstoque.Name = "PrecoEditProdEstoque";
            this.PrecoEditProdEstoque.Size = new System.Drawing.Size(251, 31);
            this.PrecoEditProdEstoque.TabIndex = 51;
            // 
            // QtdEditarProdEstoque
            // 
            this.QtdEditarProdEstoque.Location = new System.Drawing.Point(17, 447);
            this.QtdEditarProdEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QtdEditarProdEstoque.Name = "QtdEditarProdEstoque";
            this.QtdEditarProdEstoque.Size = new System.Drawing.Size(225, 31);
            this.QtdEditarProdEstoque.TabIndex = 52;
            // 
            // DesEditarProdEstoque
            // 
            this.DesEditarProdEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DesEditarProdEstoque.FormattingEnabled = true;
            this.DesEditarProdEstoque.Location = new System.Drawing.Point(12, 361);
            this.DesEditarProdEstoque.Name = "DesEditarProdEstoque";
            this.DesEditarProdEstoque.Size = new System.Drawing.Size(492, 33);
            this.DesEditarProdEstoque.TabIndex = 53;
            this.DesEditarProdEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.travadesc);
            // 
            // CatEditarProdEstoque
            // 
            this.CatEditarProdEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CatEditarProdEstoque.FormattingEnabled = true;
            this.CatEditarProdEstoque.Location = new System.Drawing.Point(275, 278);
            this.CatEditarProdEstoque.Name = "CatEditarProdEstoque";
            this.CatEditarProdEstoque.Size = new System.Drawing.Size(225, 33);
            this.CatEditarProdEstoque.TabIndex = 54;
            this.CatEditarProdEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.travacat);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_venda.Properties.Resources.desenhos_animados_de_produtos_de_mercearia_de_supermercado_24640_26648;
            this.pictureBox1.Location = new System.Drawing.Point(566, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // EditarProdutoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CatEditarProdEstoque);
            this.Controls.Add(this.DesEditarProdEstoque);
            this.Controls.Add(this.QtdEditarProdEstoque);
            this.Controls.Add(this.PrecoEditProdEstoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VoltarEditProdEstoque);
            this.Controls.Add(this.NomeEditarProdEstoque);
            this.Controls.Add(this.EditarProdEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarProdutoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button VoltarEditProdEstoque;
        private System.Windows.Forms.ComboBox NomeEditarProdEstoque;
        private System.Windows.Forms.Button EditarProdEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrecoEditProdEstoque;
        private System.Windows.Forms.TextBox QtdEditarProdEstoque;
        private System.Windows.Forms.ComboBox DesEditarProdEstoque;
        private System.Windows.Forms.ComboBox CatEditarProdEstoque;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}