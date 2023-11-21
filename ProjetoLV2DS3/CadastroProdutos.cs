using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoLV2DS3
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        public CadastroProdutos (string nome, string precocusto, string precovenda, string codigodoproduto, string codigodosistema, string categoria, string marca, string fornecedor)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxProduto.Text;
            string precocusto = textBoxCusto.Text;
            string precovenda = textBoxVenda.Text;
            string codigodoproduto = textBoxcdProduto.Text;
            string codigodosistema = textBoxcdSistema.Text;
            string categoria = textBoxCategoria.Text;
            string marca = textBoxMarca.Text;
            string fornecedor = textBoxFornecedor.Text;

            //Conexão com Banco de Dados
            MySqlConnection conn = new MySqlConnection("server=localhost; port=3306; database=usuarios_db; uid=root");

            conn.Open();

            string sql = "INSERT INTO produtos_tb (nm_produto, vl_preco_custo, vl_preco_venda, cd_codigo_produto, cd_sistema, nm_categoria, nm_marca, nm_fornecedor) VALUES ('"
                + nome
                + "','"
                + precocusto
                + "','"
                + precovenda
                + "','"
                + codigodoproduto
                + "','"
                + codigodosistema
                + "','"
                + categoria
                + "','"
                + marca
                + "','"
                + fornecedor
                + "')";

            //Execução da inserção do registro no MySql
            MySqlCommand inserir = new MySqlCommand(sql, conn);

            inserir.BeginExecuteNonQuery();

            //Retorno para o usuário 
            MessageBox.Show("Produto cadastrado com sucesso!");
            //this.Close();


            if ((textBoxProduto.Text == ""))
            {
                MessageBox.Show("Os espaços não podem ficar em branco!");
            }
            else
            {

                string MostraCadastro = "\nProduto: " + textBoxProduto.Text +
      "\nCusto: " + textBoxCusto.Text + "\nVenda: " + textBoxVenda.Text
      + "\nCódigo do produto: " + textBoxcdProduto.Text + "\nCódigo do sistema: " + textBoxcdSistema.Text +
      "\nCategoria: " + textBoxCategoria.Text + "\nMarca: " + textBoxMarca.Text + "\nFornecedor: " + textBoxFornecedor.Text;

                MessageBox.Show(MostraCadastro, "Cadastrado com sucesso!");
                CadastroTextBox.Text += MostraCadastro;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEstoque TelaPrincipal = new FormEstoque();
            TelaPrincipal.ShowDialog();

        }

        private void CadastroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvararquivo = new SaveFileDialog();
            salvararquivo.Filter = "Arquivo Texto | *.txt";
            salvararquivo.ShowDialog();

            if (string.IsNullOrEmpty(salvararquivo.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(salvararquivo.FileName, false, Encoding.UTF8))
                    {

                        writer.Write(CadastroTextBox.Text);
                        writer.Flush();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível salvar o seu arquivo, " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirarquivo = new OpenFileDialog();
            abrirarquivo.Filter = "Arquivo Texto | *.txt";
            abrirarquivo.ShowDialog();

            if (string.IsNullOrEmpty(abrirarquivo.FileName) == false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(abrirarquivo.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-br").TextInfo.ANSICodePage)))
                    {
                        CadastroTextBox.Text = reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo. Erro{0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void aDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmProdutos Adm = new AdmProdutos();
            Adm.ShowDialog();
        }
    }
    }

