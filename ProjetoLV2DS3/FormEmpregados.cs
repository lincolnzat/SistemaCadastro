using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLV2DS3
{
    public partial class FormEmpregados : Form
    {
        public FormEmpregados()
        {
            InitializeComponent();
        }

        public FormEmpregados(string nome, string idade, string genero, string datanascimento, string telefone, string email)
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            lblWelcome TelaPrincipal = new lblWelcome();
            TelaPrincipal.ShowDialog();

        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string idade = textBoxIdade.Text;
            string genero = textBoxGenero.Text;
            string datanascimento = textBoxData.Text;
            string telefone = textBoxTel.Text;
            string email = textBoxEmail.Text;

            //Conexão com Banco de Dados
            MySqlConnection conn = new MySqlConnection("server=localhost; port=3306; database=usuarios_db; uid=root");

            conn.Open();

            string sql = "INSERT INTO empregados_tb (nm_empregado, ds_idade, ds_genero, ds_data, ds_telefone, ds_email) VALUES ('"
                + nome
                + "','"
                + idade
                + "','"
                + genero
                + "','"
                + datanascimento
                + "','"
                + telefone
                + "','"
                + email
                + "')";

            //Execução da inserção do registro no MySql
            MySqlCommand inserir = new MySqlCommand(sql, conn);

            inserir.BeginExecuteNonQuery();

            //Retorno para o usuário 
            MessageBox.Show("Empregado cadastrado com sucesso!");
            //this.Close();

            Empregados empregados = new Empregados();
            if (empregados.verificaNome(textBoxNome.Text))
            {
                MessageBox.Show("Os espaços não podem ficar em branco!");
                }
            else
            {
                string MostraNomes = "\nFuncionário: " + textBoxNome.Text +
              "\nIdade: " + textBoxIdade.Text + "\nGênero: " + textBoxGenero.Text
          + "\nData de nascimento: " + textBoxData.Text + "\nTelefone: " + textBoxTel.Text + "\nE-mail:" + textBoxEmail.Text;

                 MessageBox.Show(MostraNomes, "Cadastrado com sucesso!");
                textBoxMostrarNomes.Text += MostraNomes;
            }

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEmpregados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxIdade.Text = "";
            textBoxGenero.Text = "";
            textBoxData.Text = "";
            textBoxTel.Text = "";
            textBoxEmail.Text = "";
            textBoxMostrarNomes.Text = "";

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Arquivo de Texto | *.txt";
            savefile.ShowDialog();

            if (string.IsNullOrEmpty(savefile.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(savefile.FileName, false, Encoding.UTF8))
                    {

                        writer.Write(textBoxMostrarNomes.Text);
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
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Arquivo Texto | *.txt";
            openfile.ShowDialog();

            if (string.IsNullOrEmpty(openfile.FileName) == false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openfile.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-br").TextInfo.ANSICodePage)))
                    {
                        textBoxMostrarNomes.Text = reader.ReadToEnd();
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
            AdmEmpregados Adm = new AdmEmpregados();
            Adm.ShowDialog();
        }
    }
}
