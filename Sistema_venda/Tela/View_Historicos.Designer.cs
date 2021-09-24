
namespace WinFormsApp1
{
    partial class View_Historicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Historicos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.BotaoEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.EstoqueEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoricoEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.PesquisarHistorico = new System.Windows.Forms.Button();
            this.BarPesqEstoque = new System.Windows.Forms.TextBox();
            this.VoltarHistorico = new System.Windows.Forms.Button();
            this.HistoricoGrid = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.FiltroHistorico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGrid)).BeginInit();
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
            this.menuStrip1.TabIndex = 37;
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
            this.EstoqueEstoque.Click += new System.EventHandler(this.EstoqueEstoque_Click);
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
            // PesquisarHistorico
            // 
            this.PesquisarHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.PesquisarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PesquisarHistorico.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesquisarHistorico.ForeColor = System.Drawing.SystemColors.Control;
            this.PesquisarHistorico.Location = new System.Drawing.Point(887, 192);
            this.PesquisarHistorico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PesquisarHistorico.Name = "PesquisarHistorico";
            this.PesquisarHistorico.Size = new System.Drawing.Size(140, 43);
            this.PesquisarHistorico.TabIndex = 49;
            this.PesquisarHistorico.Text = "Pesquisar";
            this.PesquisarHistorico.UseVisualStyleBackColor = false;
            this.PesquisarHistorico.Click += new System.EventHandler(this.PesquisarHistorico_Click);
            // 
            // BarPesqEstoque
            // 
            this.BarPesqEstoque.Location = new System.Drawing.Point(39, 197);
            this.BarPesqEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarPesqEstoque.Name = "BarPesqEstoque";
            this.BarPesqEstoque.Size = new System.Drawing.Size(558, 31);
            this.BarPesqEstoque.TabIndex = 48;
            // 
            // VoltarHistorico
            // 
            this.VoltarHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarHistorico.FlatAppearance.BorderSize = 0;
            this.VoltarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarHistorico.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarHistorico.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarHistorico.Location = new System.Drawing.Point(39, 677);
            this.VoltarHistorico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarHistorico.Name = "VoltarHistorico";
            this.VoltarHistorico.Size = new System.Drawing.Size(101, 53);
            this.VoltarHistorico.TabIndex = 47;
            this.VoltarHistorico.Text = "Voltar";
            this.VoltarHistorico.UseVisualStyleBackColor = false;
            this.VoltarHistorico.Click += new System.EventHandler(this.VoltarHistorico_Click);
            // 
            // HistoricoGrid
            // 
            this.HistoricoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoricoGrid.Location = new System.Drawing.Point(39, 245);
            this.HistoricoGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HistoricoGrid.Name = "HistoricoGrid";
            this.HistoricoGrid.RowHeadersWidth = 62;
            this.HistoricoGrid.RowTemplate.Height = 25;
            this.HistoricoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoricoGrid.Size = new System.Drawing.Size(1048, 422);
            this.HistoricoGrid.TabIndex = 46;
            this.HistoricoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoricoGrid_CellContentClick);
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
            this.Titulo.TabIndex = 45;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FiltroHistorico
            // 
            this.FiltroHistorico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroHistorico.FormattingEnabled = true;
            this.FiltroHistorico.Location = new System.Drawing.Point(606, 197);
            this.FiltroHistorico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FiltroHistorico.Name = "FiltroHistorico";
            this.FiltroHistorico.Size = new System.Drawing.Size(254, 33);
            this.FiltroHistorico.TabIndex = 54;
            this.FiltroHistorico.SelectedIndexChanged += new System.EventHandler(this.FiltroHistorico_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(694, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 55;
            this.label1.Text = "Filtro";
            // 
            // View_Historicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroHistorico);
            this.Controls.Add(this.PesquisarHistorico);
            this.Controls.Add(this.BarPesqEstoque);
            this.Controls.Add(this.VoltarHistorico);
            this.Controls.Add(this.HistoricoGrid);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Historicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGrid)).EndInit();
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
        private System.Windows.Forms.Button PesquisarHistorico;
        private System.Windows.Forms.TextBox BarPesqEstoque;
        private System.Windows.Forms.Button VoltarHistorico;
        private System.Windows.Forms.DataGridView HistoricoGrid;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.ComboBox FiltroHistorico;
        private System.Windows.Forms.Label label1;
    }
}