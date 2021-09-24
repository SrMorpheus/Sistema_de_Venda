
namespace WinFormsApp1
{
    partial class EditarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProduto));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.QtdEditProd = new System.Windows.Forms.ComboBox();
            this.VoltarEditProduto = new System.Windows.Forms.Button();
            this.NomeEditarProd = new System.Windows.Forms.TextBox();
            this.DesEditarProd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(177, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(311, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 33);
            this.label4.TabIndex = 29;
            this.label4.Text = "Categória";
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editar.ForeColor = System.Drawing.SystemColors.Control;
            this.Editar.Location = new System.Drawing.Point(980, 664);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(146, 66);
            this.Editar.TabIndex = 31;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.Location = new System.Drawing.Point(19, 60);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(383, 128);
            this.Titulo.TabIndex = 34;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // QtdEditProd
            // 
            this.QtdEditProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QtdEditProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtdEditProd.FormattingEnabled = true;
            this.QtdEditProd.Location = new System.Drawing.Point(249, 275);
            this.QtdEditProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QtdEditProd.Name = "QtdEditProd";
            this.QtdEditProd.Size = new System.Drawing.Size(251, 33);
            this.QtdEditProd.TabIndex = 36;
            this.QtdEditProd.SelectedIndexChanged += new System.EventHandler(this.QtdEditProd_SelectedIndexChanged);
            // 
            // VoltarEditProduto
            // 
            this.VoltarEditProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarEditProduto.FlatAppearance.BorderSize = 0;
            this.VoltarEditProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarEditProduto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarEditProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarEditProduto.Location = new System.Drawing.Point(13, 664);
            this.VoltarEditProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarEditProduto.Name = "VoltarEditProduto";
            this.VoltarEditProduto.Size = new System.Drawing.Size(139, 66);
            this.VoltarEditProduto.TabIndex = 37;
            this.VoltarEditProduto.Text = "Voltar";
            this.VoltarEditProduto.UseVisualStyleBackColor = false;
            this.VoltarEditProduto.Click += new System.EventHandler(this.VoltarEditProduto_Click);
            // 
            // NomeEditarProd
            // 
            this.NomeEditarProd.Location = new System.Drawing.Point(13, 277);
            this.NomeEditarProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeEditarProd.Name = "NomeEditarProd";
            this.NomeEditarProd.Size = new System.Drawing.Size(225, 31);
            this.NomeEditarProd.TabIndex = 38;
            this.NomeEditarProd.TextChanged += new System.EventHandler(this.NomeEditarProd_TextChanged);
            // 
            // DesEditarProd
            // 
            this.DesEditarProd.Location = new System.Drawing.Point(13, 358);
            this.DesEditarProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DesEditarProd.Name = "DesEditarProd";
            this.DesEditarProd.Size = new System.Drawing.Size(487, 31);
            this.DesEditarProd.TabIndex = 39;
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
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_venda.Properties.Resources.desenhos_animados_de_produtos_de_mercearia_de_supermercado_24640_26652;
            this.pictureBox1.Location = new System.Drawing.Point(566, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DesEditarProd);
            this.Controls.Add(this.NomeEditarProd);
            this.Controls.Add(this.VoltarEditProduto);
            this.Controls.Add(this.QtdEditProd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            this.Load += new System.EventHandler(this.EditarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.ComboBox QtdEditProd;
        private System.Windows.Forms.Button VoltarEditProduto;
        private System.Windows.Forms.TextBox NomeEditarProd;
        private System.Windows.Forms.TextBox DesEditarProd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}