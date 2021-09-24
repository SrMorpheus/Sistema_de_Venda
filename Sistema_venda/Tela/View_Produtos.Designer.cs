
namespace sistema_venda
{
    partial class View_Produtos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Produtos));
            this.BancoProduto = new System.Windows.Forms.DataGridView();
            this.Pesquisar = new System.Windows.Forms.TextBox();
            this.PesquisarBotao = new System.Windows.Forms.Button();
            this.AdicionarProduto = new System.Windows.Forms.Button();
            this.EditarProduto = new System.Windows.Forms.Button();
            this.ExcluirProduto = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.EstoqueEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoricoHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BancoProduto)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BancoProduto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BancoProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BancoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BancoProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.BancoProduto.Location = new System.Drawing.Point(134, 255);
            this.BancoProduto.Name = "BancoProduto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BancoProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BancoProduto.RowHeadersWidth = 62;
            this.BancoProduto.RowTemplate.Height = 33;
            this.BancoProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BancoProduto.Size = new System.Drawing.Size(739, 426);
            this.BancoProduto.TabIndex = 1;
            this.BancoProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.select_tudo);
            this.BancoProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BancoProduto_CellContentClick);
            this.BancoProduto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarItem);
            this.BancoProduto.Click += new System.EventHandler(this.Clic);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(134, 174);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(578, 31);
            this.Pesquisar.TabIndex = 2;
            this.Pesquisar.Click += new System.EventHandler(this.Clicktexto);
            this.Pesquisar.TextChanged += new System.EventHandler(this.Pesquisar_TextChanged);
            // 
            // PesquisarBotao
            // 
            this.PesquisarBotao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.PesquisarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PesquisarBotao.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesquisarBotao.ForeColor = System.Drawing.SystemColors.Control;
            this.PesquisarBotao.Location = new System.Drawing.Point(732, 174);
            this.PesquisarBotao.Name = "PesquisarBotao";
            this.PesquisarBotao.Size = new System.Drawing.Size(141, 50);
            this.PesquisarBotao.TabIndex = 3;
            this.PesquisarBotao.Text = "Procurar";
            this.PesquisarBotao.UseVisualStyleBackColor = false;
            this.PesquisarBotao.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdicionarProduto
            // 
            this.AdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(230)))));
            this.AdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdicionarProduto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdicionarProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.AdicionarProduto.Location = new System.Drawing.Point(935, 325);
            this.AdicionarProduto.Name = "AdicionarProduto";
            this.AdicionarProduto.Size = new System.Drawing.Size(141, 50);
            this.AdicionarProduto.TabIndex = 4;
            this.AdicionarProduto.Text = "Adicionar";
            this.AdicionarProduto.UseVisualStyleBackColor = false;
            this.AdicionarProduto.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditarProduto
            // 
            this.EditarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(95)))), ((int)(((byte)(194)))));
            this.EditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarProduto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditarProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.EditarProduto.Location = new System.Drawing.Point(935, 444);
            this.EditarProduto.Name = "EditarProduto";
            this.EditarProduto.Size = new System.Drawing.Size(141, 50);
            this.EditarProduto.TabIndex = 5;
            this.EditarProduto.Text = "Editar";
            this.EditarProduto.UseVisualStyleBackColor = false;
            this.EditarProduto.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExcluirProduto
            // 
            this.ExcluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(67)))), ((int)(((byte)(64)))));
            this.ExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExcluirProduto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcluirProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.ExcluirProduto.Location = new System.Drawing.Point(935, 558);
            this.ExcluirProduto.Name = "ExcluirProduto";
            this.ExcluirProduto.Size = new System.Drawing.Size(141, 50);
            this.ExcluirProduto.TabIndex = 6;
            this.ExcluirProduto.Text = "Excluir";
            this.ExcluirProduto.UseVisualStyleBackColor = false;
            this.ExcluirProduto.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(12, 685);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 53);
            this.button5.TabIndex = 7;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Perfil,
            this.Menu,
            this.Vendas,
            this.Estoque});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1143, 43);
            this.menuStrip2.TabIndex = 37;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Perfil
            // 
            this.Perfil.ForeColor = System.Drawing.SystemColors.Control;
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(93, 37);
            this.Perfil.Text = "Perfil";
            this.Perfil.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // Menu
            // 
            this.Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(96, 37);
            this.Menu.Text = "Menu";
            // 
            // Vendas
            // 
            this.Vendas.ForeColor = System.Drawing.SystemColors.Control;
            this.Vendas.Name = "Vendas";
            this.Vendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Vendas.Size = new System.Drawing.Size(111, 37);
            this.Vendas.Text = "Vendas";
            this.Vendas.Click += new System.EventHandler(this.Vendas_Click);
            // 
            // Estoque
            // 
            this.Estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdutoProduto,
            this.EstoqueEstoque,
            this.HistoricoHistorico});
            this.Estoque.ForeColor = System.Drawing.SystemColors.Control;
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(121, 37);
            this.Estoque.Text = "Estoque";
            // 
            // ProdutoProduto
            // 
            this.ProdutoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.ProdutoProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdutoProduto.Name = "ProdutoProduto";
            this.ProdutoProduto.Size = new System.Drawing.Size(223, 42);
            this.ProdutoProduto.Text = "Produto";
            // 
            // EstoqueEstoque
            // 
            this.EstoqueEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.EstoqueEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.EstoqueEstoque.Name = "EstoqueEstoque";
            this.EstoqueEstoque.Size = new System.Drawing.Size(223, 42);
            this.EstoqueEstoque.Text = "Estoque";
            this.EstoqueEstoque.Click += new System.EventHandler(this.EstoqueEstoque_Click);
            // 
            // HistoricoHistorico
            // 
            this.HistoricoHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.HistoricoHistorico.ForeColor = System.Drawing.SystemColors.Control;
            this.HistoricoHistorico.Name = "HistoricoHistorico";
            this.HistoricoHistorico.Size = new System.Drawing.Size(223, 42);
            this.HistoricoHistorico.Text = "Historico";
            this.HistoricoHistorico.Click += new System.EventHandler(this.HistoricoHistorico_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(13, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 128);
            this.label7.TabIndex = 38;
            this.label7.Text = "Unifood";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // View_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ExcluirProduto);
            this.Controls.Add(this.EditarProduto);
            this.Controls.Add(this.AdicionarProduto);
            this.Controls.Add(this.PesquisarBotao);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.BancoProduto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BancoProduto)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView BancoProduto;
        private System.Windows.Forms.TextBox Pesquisar;
        private System.Windows.Forms.Button PesquisarBotao;
        private System.Windows.Forms.Button AdicionarProduto;
        private System.Windows.Forms.Button EditarProduto;
        private System.Windows.Forms.Button ExcluirProduto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Perfil;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Vendas;
        private System.Windows.Forms.ToolStripMenuItem Estoque;
        private System.Windows.Forms.ToolStripMenuItem ProdutoProduto;
        private System.Windows.Forms.ToolStripMenuItem EstoqueEstoque;
        private System.Windows.Forms.ToolStripMenuItem HistoricoHistorico;
        private System.Windows.Forms.Label label7;
    }
}

