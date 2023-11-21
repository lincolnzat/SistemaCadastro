namespace ProjetoLV2DS3
{
    partial class CadastroProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxcdProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcdSistema = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCusto = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CadastroTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(152, 42);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(128, 20);
            this.textBoxProduto.TabIndex = 1;
            this.textBoxProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço de custo: ";
            // 
            // textBoxVenda
            // 
            this.textBoxVenda.Location = new System.Drawing.Point(152, 102);
            this.textBoxVenda.Name = "textBoxVenda";
            this.textBoxVenda.Size = new System.Drawing.Size(128, 20);
            this.textBoxVenda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código do produto:";
            // 
            // textBoxcdProduto
            // 
            this.textBoxcdProduto.Location = new System.Drawing.Point(152, 142);
            this.textBoxcdProduto.Name = "textBoxcdProduto";
            this.textBoxcdProduto.Size = new System.Drawing.Size(128, 20);
            this.textBoxcdProduto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código do sistema:";
            // 
            // textBoxcdSistema
            // 
            this.textBoxcdSistema.Location = new System.Drawing.Point(152, 175);
            this.textBoxcdSistema.Name = "textBoxcdSistema";
            this.textBoxcdSistema.Size = new System.Drawing.Size(128, 20);
            this.textBoxcdSistema.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria: ";
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(152, 212);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(128, 20);
            this.textBoxCategoria.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fornecedor: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(152, 247);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(128, 20);
            this.textBoxMarca.TabIndex = 12;
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.Location = new System.Drawing.Point(150, 282);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.Size = new System.Drawing.Size(130, 20);
            this.textBoxFornecedor.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Preço de venda:";
            // 
            // textBoxCusto
            // 
            this.textBoxCusto.Location = new System.Drawing.Point(152, 71);
            this.textBoxCusto.Name = "textBoxCusto";
            this.textBoxCusto.Size = new System.Drawing.Size(128, 20);
            this.textBoxCusto.TabIndex = 15;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(124, 375);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(79, 30);
            this.btnCadastro.TabIndex = 17;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastroTextBox
            // 
            this.CadastroTextBox.Location = new System.Drawing.Point(419, 45);
            this.CadastroTextBox.Name = "CadastroTextBox";
            this.CadastroTextBox.Size = new System.Drawing.Size(369, 257);
            this.CadastroTextBox.TabIndex = 19;
            this.CadastroTextBox.Text = "";
            this.CadastroTextBox.TextChanged += new System.EventHandler(this.CadastroTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArquivoToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.aDMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirArquivoToolStripMenuItem
            // 
            this.abrirArquivoToolStripMenuItem.Name = "abrirArquivoToolStripMenuItem";
            this.abrirArquivoToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.abrirArquivoToolStripMenuItem.Text = "Abrir Arquivo";
            this.abrirArquivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArquivoToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.salvarComoToolStripMenuItem.Text = "Salvar como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // aDMToolStripMenuItem
            // 
            this.aDMToolStripMenuItem.Name = "aDMToolStripMenuItem";
            this.aDMToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.aDMToolStripMenuItem.Text = "ADM";
            this.aDMToolStripMenuItem.Click += new System.EventHandler(this.aDMToolStripMenuItem_Click);
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CadastroTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.textBoxCusto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFornecedor);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxcdSistema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxcdProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroProdutos";
            this.Text = "CadastroProdutos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxcdProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcdSistema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCusto;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox CadastroTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMToolStripMenuItem;
    }
}