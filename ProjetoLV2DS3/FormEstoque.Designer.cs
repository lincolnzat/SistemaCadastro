namespace ProjetoLV2DS3
{
    partial class FormEstoque
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
            this.button1 = new System.Windows.Forms.Button();
            this.CadastrarProdutos = new System.Windows.Forms.RadioButton();
            this.ConsultarProdutos = new System.Windows.Forms.RadioButton();
            this.AlterarProdutos = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastrarProdutos
            // 
            this.CadastrarProdutos.AutoSize = true;
            this.CadastrarProdutos.Location = new System.Drawing.Point(70, 75);
            this.CadastrarProdutos.Name = "CadastrarProdutos";
            this.CadastrarProdutos.Size = new System.Drawing.Size(110, 17);
            this.CadastrarProdutos.TabIndex = 1;
            this.CadastrarProdutos.TabStop = true;
            this.CadastrarProdutos.Text = "Cadastrar Produto";
            this.CadastrarProdutos.UseVisualStyleBackColor = true;
            this.CadastrarProdutos.CheckedChanged += new System.EventHandler(this.CadastrarProdutos_CheckedChanged);
            // 
            // ConsultarProdutos
            // 
            this.ConsultarProdutos.AutoSize = true;
            this.ConsultarProdutos.Location = new System.Drawing.Point(346, 75);
            this.ConsultarProdutos.Name = "ConsultarProdutos";
            this.ConsultarProdutos.Size = new System.Drawing.Size(109, 17);
            this.ConsultarProdutos.TabIndex = 2;
            this.ConsultarProdutos.TabStop = true;
            this.ConsultarProdutos.Text = "Consultar Produto";
            this.ConsultarProdutos.UseVisualStyleBackColor = true;
            // 
            // AlterarProdutos
            // 
            this.AlterarProdutos.AutoSize = true;
            this.AlterarProdutos.Location = new System.Drawing.Point(609, 75);
            this.AlterarProdutos.Name = "AlterarProdutos";
            this.AlterarProdutos.Size = new System.Drawing.Size(95, 17);
            this.AlterarProdutos.TabIndex = 3;
            this.AlterarProdutos.TabStop = true;
            this.AlterarProdutos.Text = "Alterar Produto";
            this.AlterarProdutos.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(102, 283);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(96, 40);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.AlterarProdutos);
            this.Controls.Add(this.ConsultarProdutos);
            this.Controls.Add(this.CadastrarProdutos);
            this.Controls.Add(this.button1);
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton CadastrarProdutos;
        private System.Windows.Forms.RadioButton ConsultarProdutos;
        private System.Windows.Forms.RadioButton AlterarProdutos;
        private System.Windows.Forms.Button btnEnviar;
    }
}