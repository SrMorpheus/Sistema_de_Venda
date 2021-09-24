
namespace WinFormsApp1
{
    partial class view_Estoques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_Estoques));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.BotaoEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.EstoqueEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoricoEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.Titulo = new System.Windows.Forms.Label();
            this.GridEstoque = new System.Windows.Forms.DataGridView();
            this.VoltarEstoque = new System.Windows.Forms.Button();
            this.BarPesqEstoque = new System.Windows.Forms.TextBox();
            this.PesquisarEstoque = new System.Windows.Forms.Button();
            this.ExcluirEstoque = new System.Windows.Forms.Button();
            this.EditarEstoque = new System.Windows.Forms.Button();
            this.AdicionarEstoque = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Perfil,
            this.Menu,
            this.Vendas,
            this.BotaoEstoque});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1143, 43);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip2";
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
            // BotaoEstoque
            // 
            this.BotaoEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdutoEstoque,
            this.EstoqueEstoque,
            this.HistoricoEstoque});
            this.BotaoEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoEstoque.Name = "BotaoEstoque";
            this.BotaoEstoque.Size = new System.Drawing.Size(121, 37);
            this.BotaoEstoque.Text = "Estoque";
            // 
            // ProdutoEstoque
            // 
            this.ProdutoEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.ProdutoEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdutoEstoque.Name = "ProdutoEstoque";
            this.ProdutoEstoque.Size = new System.Drawing.Size(223, 42);
            this.ProdutoEstoque.Text = "Produto";
            this.ProdutoEstoque.Click += new System.EventHandler(this.ProdutoEstoque_Click);
            // 
            // EstoqueEstoque
            // 
            this.EstoqueEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.EstoqueEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.EstoqueEstoque.Name = "EstoqueEstoque";
            this.EstoqueEstoque.Size = new System.Drawing.Size(223, 42);
            this.EstoqueEstoque.Text = "Estoque";
            // 
            // HistoricoEstoque
            // 
            this.HistoricoEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.HistoricoEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.HistoricoEstoque.Name = "HistoricoEstoque";
            this.HistoricoEstoque.Size = new System.Drawing.Size(223, 42);
            this.HistoricoEstoque.Text = "Historico";
            this.HistoricoEstoque.Click += new System.EventHandler(this.HistoricoEstoque_Click);
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
            // GridEstoque
            // 
            this.GridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEstoque.Location = new System.Drawing.Point(13, 287);
            this.GridEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridEstoque.Name = "GridEstoque";
            this.GridEstoque.RowHeadersWidth = 62;
            this.GridEstoque.RowTemplate.Height = 25;
            this.GridEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEstoque.Size = new System.Drawing.Size(1117, 360);
            this.GridEstoque.TabIndex = 38;
            this.GridEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEstoque_CellContentClick);
            this.GridEstoque.Click += new System.EventHandler(this.click);
            // 
            // VoltarEstoque
            // 
            this.VoltarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarEstoque.FlatAppearance.BorderSize = 0;
            this.VoltarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarEstoque.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarEstoque.Location = new System.Drawing.Point(13, 683);
            this.VoltarEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarEstoque.Name = "VoltarEstoque";
            this.VoltarEstoque.Size = new System.Drawing.Size(101, 53);
            this.VoltarEstoque.TabIndex = 39;
            this.VoltarEstoque.Text = "Voltar";
            this.VoltarEstoque.UseVisualStyleBackColor = false;
            this.VoltarEstoque.Click += new System.EventHandler(this.VoltarEditProduto_Click);
            // 
            // BarPesqEstoque
            // 
            this.BarPesqEstoque.Location = new System.Drawing.Point(39, 172);
            this.BarPesqEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarPesqEstoque.Name = "BarPesqEstoque";
            this.BarPesqEstoque.Size = new System.Drawing.Size(801, 31);
            this.BarPesqEstoque.TabIndex = 40;
            // 
            // PesquisarEstoque
            // 
            this.PesquisarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.PesquisarEstoque.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PesquisarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PesquisarEstoque.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesquisarEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.PesquisarEstoque.Location = new System.Drawing.Point(859, 164);
            this.PesquisarEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PesquisarEstoque.Name = "PesquisarEstoque";
            this.PesquisarEstoque.Size = new System.Drawing.Size(140, 42);
            this.PesquisarEstoque.TabIndex = 41;
            this.PesquisarEstoque.Text = "Pesquisar";
            this.PesquisarEstoque.UseVisualStyleBackColor = false;
            this.PesquisarEstoque.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExcluirEstoque
            // 
            this.ExcluirEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(67)))), ((int)(((byte)(64)))));
            this.ExcluirEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExcluirEstoque.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcluirEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.ExcluirEstoque.Location = new System.Drawing.Point(859, 235);
            this.ExcluirEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExcluirEstoque.Name = "ExcluirEstoque";
            this.ExcluirEstoque.Size = new System.Drawing.Size(140, 42);
            this.ExcluirEstoque.TabIndex = 42;
            this.ExcluirEstoque.Text = "Excluir";
            this.ExcluirEstoque.UseVisualStyleBackColor = false;
            this.ExcluirEstoque.Click += new System.EventHandler(this.ExcluirEstoque_Click);
            // 
            // EditarEstoque
            // 
            this.EditarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(95)))), ((int)(((byte)(194)))));
            this.EditarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarEstoque.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditarEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.EditarEstoque.Location = new System.Drawing.Point(670, 235);
            this.EditarEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditarEstoque.Name = "EditarEstoque";
            this.EditarEstoque.Size = new System.Drawing.Size(140, 42);
            this.EditarEstoque.TabIndex = 43;
            this.EditarEstoque.Text = "Editar";
            this.EditarEstoque.UseVisualStyleBackColor = false;
            this.EditarEstoque.Click += new System.EventHandler(this.EditarEstoque_Click);
            // 
            // AdicionarEstoque
            // 
            this.AdicionarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(230)))));
            this.AdicionarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdicionarEstoque.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdicionarEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.AdicionarEstoque.Location = new System.Drawing.Point(470, 235);
            this.AdicionarEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdicionarEstoque.Name = "AdicionarEstoque";
            this.AdicionarEstoque.Size = new System.Drawing.Size(140, 42);
            this.AdicionarEstoque.TabIndex = 44;
            this.AdicionarEstoque.Text = "Adicionar";
            this.AdicionarEstoque.UseVisualStyleBackColor = false;
            this.AdicionarEstoque.Click += new System.EventHandler(this.AdicionarEstoque_Click);
            // 
            // view_Estoques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.AdicionarEstoque);
            this.Controls.Add(this.EditarEstoque);
            this.Controls.Add(this.ExcluirEstoque);
            this.Controls.Add(this.PesquisarEstoque);
            this.Controls.Add(this.BarPesqEstoque);
            this.Controls.Add(this.VoltarEstoque);
            this.Controls.Add(this.GridEstoque);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "view_Estoques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Perfil;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Vendas;
        private System.Windows.Forms.ToolStripMenuItem BotaoEstoque;
        private System.Windows.Forms.ToolStripMenuItem ProdutoEstoque;
        private System.Windows.Forms.ToolStripMenuItem EstoqueEstoque;
        private System.Windows.Forms.ToolStripMenuItem HistoricoEstoque;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridView GridEstoque;
        private System.Windows.Forms.Button VoltarEstoque;
        private System.Windows.Forms.TextBox BarPesqEstoque;
        private System.Windows.Forms.Button PesquisarEstoque;
        private System.Windows.Forms.Button ExcluirEstoque;
        private System.Windows.Forms.Button EditarEstoque;
        private System.Windows.Forms.Button AdicionarEstoque;
    }
}