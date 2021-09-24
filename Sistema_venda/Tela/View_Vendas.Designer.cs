
namespace WinFormsApp1
{
    partial class View_Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Vendas));
            this.VendaHistorico = new System.Windows.Forms.DataGridView();
            this.PesquisaVenda = new System.Windows.Forms.TextBox();
            this.PesquisarVendas = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.VoltarHistoricoVenda = new System.Windows.Forms.Button();
            this.FiltroVenda = new System.Windows.Forms.ComboBox();
            this.AdicionarVenda = new System.Windows.Forms.Button();
            this.Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.EstoqueHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoricoHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.VendaHistorico)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VendaHistorico
            // 
            this.VendaHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendaHistorico.Location = new System.Drawing.Point(17, 248);
            this.VendaHistorico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VendaHistorico.Name = "VendaHistorico";
            this.VendaHistorico.RowHeadersWidth = 62;
            this.VendaHistorico.RowTemplate.Height = 25;
            this.VendaHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VendaHistorico.Size = new System.Drawing.Size(1109, 402);
            this.VendaHistorico.TabIndex = 18;
            this.VendaHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendaHistorico_CellContentClick);
            this.VendaHistorico.Click += new System.EventHandler(this.Venda_click);
            // 
            // PesquisaVenda
            // 
            this.PesquisaVenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesquisaVenda.Location = new System.Drawing.Point(17, 202);
            this.PesquisaVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PesquisaVenda.Name = "PesquisaVenda";
            this.PesquisaVenda.Size = new System.Drawing.Size(637, 31);
            this.PesquisaVenda.TabIndex = 19;
            this.PesquisaVenda.TextChanged += new System.EventHandler(this.PesquisaVenda_TextChanged);
            // 
            // PesquisarVendas
            // 
            this.PesquisarVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.PesquisarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PesquisarVendas.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesquisarVendas.ForeColor = System.Drawing.SystemColors.Control;
            this.PesquisarVendas.Location = new System.Drawing.Point(993, 192);
            this.PesquisarVendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PesquisarVendas.Name = "PesquisarVendas";
            this.PesquisarVendas.Size = new System.Drawing.Size(133, 48);
            this.PesquisarVendas.TabIndex = 20;
            this.PesquisarVendas.Text = "Pesquisar";
            this.PesquisarVendas.UseVisualStyleBackColor = false;
            this.PesquisarVendas.Click += new System.EventHandler(this.PesquisarVendas_Click);
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
            this.Titulo.TabIndex = 36;
            this.Titulo.Text = "Unifood";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VoltarHistoricoVenda
            // 
            this.VoltarHistoricoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.VoltarHistoricoVenda.FlatAppearance.BorderSize = 0;
            this.VoltarHistoricoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarHistoricoVenda.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoltarHistoricoVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.VoltarHistoricoVenda.Location = new System.Drawing.Point(17, 677);
            this.VoltarHistoricoVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltarHistoricoVenda.Name = "VoltarHistoricoVenda";
            this.VoltarHistoricoVenda.Size = new System.Drawing.Size(101, 53);
            this.VoltarHistoricoVenda.TabIndex = 47;
            this.VoltarHistoricoVenda.Text = "Voltar";
            this.VoltarHistoricoVenda.UseVisualStyleBackColor = false;
            this.VoltarHistoricoVenda.Click += new System.EventHandler(this.VoltarHistoricoVenda_Click);
            // 
            // FiltroVenda
            // 
            this.FiltroVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroVenda.FormattingEnabled = true;
            this.FiltroVenda.Location = new System.Drawing.Point(664, 202);
            this.FiltroVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FiltroVenda.Name = "FiltroVenda";
            this.FiltroVenda.Size = new System.Drawing.Size(318, 33);
            this.FiltroVenda.TabIndex = 48;
            this.FiltroVenda.SelectedIndexChanged += new System.EventHandler(this.FiltroVenda_SelectedIndexChanged);
            // 
            // AdicionarVenda
            // 
            this.AdicionarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.AdicionarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdicionarVenda.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdicionarVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.AdicionarVenda.Location = new System.Drawing.Point(916, 677);
            this.AdicionarVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdicionarVenda.Name = "AdicionarVenda";
            this.AdicionarVenda.Size = new System.Drawing.Size(210, 53);
            this.AdicionarVenda.TabIndex = 49;
            this.AdicionarVenda.Text = "Adicionar venda";
            this.AdicionarVenda.UseVisualStyleBackColor = false;
            this.AdicionarVenda.Click += new System.EventHandler(this.AdicionarVenda_Click);
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
            // 
            // Estoque
            // 
            this.Estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdHistoricoVenda,
            this.EstoqueHistoricoVenda,
            this.HistoricoHistoricoVenda});
            this.Estoque.ForeColor = System.Drawing.SystemColors.Control;
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(121, 37);
            this.Estoque.Text = "Estoque";
            // 
            // ProdHistoricoVenda
            // 
            this.ProdHistoricoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.ProdHistoricoVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.ProdHistoricoVenda.Name = "ProdHistoricoVenda";
            this.ProdHistoricoVenda.Size = new System.Drawing.Size(223, 42);
            this.ProdHistoricoVenda.Text = "Produto";
            this.ProdHistoricoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProdHistoricoVenda.Click += new System.EventHandler(this.ProdHistoricoVenda_Click);
            // 
            // EstoqueHistoricoVenda
            // 
            this.EstoqueHistoricoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.EstoqueHistoricoVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.EstoqueHistoricoVenda.Name = "EstoqueHistoricoVenda";
            this.EstoqueHistoricoVenda.Size = new System.Drawing.Size(223, 42);
            this.EstoqueHistoricoVenda.Text = "Estoque";
            this.EstoqueHistoricoVenda.Click += new System.EventHandler(this.EstoqueHistoricoVenda_Click);
            // 
            // HistoricoHistoricoVenda
            // 
            this.HistoricoHistoricoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(117)))));
            this.HistoricoHistoricoVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.HistoricoHistoricoVenda.Name = "HistoricoHistoricoVenda";
            this.HistoricoHistoricoVenda.Size = new System.Drawing.Size(223, 42);
            this.HistoricoHistoricoVenda.Text = "Historico";
            this.HistoricoHistoricoVenda.Click += new System.EventHandler(this.HistoricoHistoricoVenda_Click);
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
            this.Estoque});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1143, 43);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // View_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.AdicionarVenda);
            this.Controls.Add(this.FiltroVenda);
            this.Controls.Add(this.VoltarHistoricoVenda);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.PesquisarVendas);
            this.Controls.Add(this.PesquisaVenda);
            this.Controls.Add(this.VendaHistorico);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.VendaHistorico)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView VendaHistorico;
        private System.Windows.Forms.TextBox PesquisaVenda;
        private System.Windows.Forms.Button PesquisarVendas;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button VoltarHistoricoVenda;
        private System.Windows.Forms.ComboBox FiltroVenda;
        private System.Windows.Forms.Button AdicionarVenda;
        private System.Windows.Forms.ToolStripMenuItem Perfil;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Vendas;
        private System.Windows.Forms.ToolStripMenuItem Estoque;
        private System.Windows.Forms.ToolStripMenuItem ProdHistoricoVenda;
        private System.Windows.Forms.ToolStripMenuItem EstoqueHistoricoVenda;
        private System.Windows.Forms.ToolStripMenuItem HistoricoHistoricoVenda;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}