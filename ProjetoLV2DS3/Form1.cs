using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoLV2DS3
{
    public partial class MenuInicial: Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        public MenuInicial(string user, string senhaDigitada)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCoordenadores_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        public string mySqlString = "server=localhost;port=3306;uid= root;database=usuarios_db";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "" && textBoxSenha.Text != "")
            {
                //Classe_Usuario usuario = new Classe_Usuario();
                //usuario.nome = textBoxNome.Text;
                string user = textBoxNome.Text;
                string senhaDigitada = textBoxSenha.Text;
                string senhaCadastrada = "";
                //Criando instancia
                // MySql.Data.MySqlClient.MySqlConnection conn;
                try
                {
                    MySqlConnection conn = new MySqlConnection(mySqlString);
                    string sql = "select senha_usuario from usuarios_tb where nome_usuario = @user";
                    MySqlCommand consulta = new MySqlCommand(sql, conn);
                    consulta.Parameters.AddWithValue("@user", user);
                    conn.Open();
                    MySqlDataReader registro;
                    registro = consulta.ExecuteReader();
                    registro.Read();
                    if (registro.HasRows)
                    {
                        MessageBox.Show("Sucesso na leitura do arquivo");
                        senhaCadastrada = registro["senha_usuario"].ToString();
                        if (senhaCadastrada == senhaDigitada)
                        {
                            MessageBox.Show("Entrada autorizada!");
                            lblWelcome telaPrincipal = new lblWelcome (user, senhaDigitada);
                            //this.Hide();
                            telaPrincipal.ShowDialog();
                            //this.Show();*/
                        }
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;
                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;


                    }
                }
                // conn = new MySql.Data.MySqlClient.MySqlConnection(mySqlString);
            }
                 else
                {
                MessageBox.Show("Nome ou senha de usuário inválidos");
                }
        }

                private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = textBoxNome.Text;
            string senhaDigitada = textBoxSenha.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            //string mySqlString;


            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(mySqlString);
                conn.Open();
                string sql = "INSERT INTO usuarios_tb (nome_usuario, senha_usuario, privilegio_usuario) VALUES ('"
                + user
                + "','"
                + senhaDigitada
                + "','"
                + "usuario"
                + "')";

                MySqlCommand inserir = new MySqlCommand(sql, conn);

                inserir.BeginExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
            //MySqlConnection banco = new MySqlConnection("server=localhost;port=3306;database=escolar_db;uid=root");
            //banco.Open();



            //Retorno para o usuário 
            MessageBox.Show("Usuário cadastrado com sucesso!");
            //this.Close();

        }
}

}
   

    
    
    
