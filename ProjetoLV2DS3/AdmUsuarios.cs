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
    public partial class AdmUsuarios : Form
    {
        public AdmUsuarios()
        {
            InitializeComponent();
        }

        public string mySqlString = "server=localhost;port=3306;uid= root;database=usuarios_db";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         if (e.ColumnIndex == dataGridViewADM.Columns["excluir_usuario"].Index)
            {
                int cod_usuario = (int)dataGridViewADM.Rows[e.RowIndex].Cells["cod_usuario"].Value;
                MySqlConnection bdConn = new MySqlConnection(mySqlString);
                bdConn.Open();

                string sql = "DELETE FROM usuarios_tb WHERE cod_usuario = "+ cod_usuario + "";
                MySqlCommand inserir = new MySqlCommand(sql, bdConn);
                inserir.BeginExecuteNonQuery();
                MessageBox.Show("Exclusão realizada", "Excluir");

                AdmUsuarios adm = new AdmUsuarios();
                this.Hide();
                this.Close();
                adm.ShowDialog();
            }
            if (e.ColumnIndex == dataGridViewADM.Columns["alterar_usuario"].Index)
            {
                //Pegando o valor do cd_usuario
                int cod_usuario = (int)dataGridViewADM.Rows[e.RowIndex].Cells["cod_usuario"].Value;

                //Pegando o valor do nm_usuario
                string nome_usuario = (string)dataGridViewADM.Rows[e.RowIndex].Cells["nome_usuario"].Value;

                //Pegando o valor do senha_usuario
                string senha_usuario = (string)dataGridViewADM.Rows[e.RowIndex].Cells["senha_usuario"].Value;

                //String de conexão com o banco de dados
                MySqlConnection bdConn = new MySqlConnection(mySqlString);

                //Pegando o valor do privilegio_usuario
                string privilegio_usuario = (string)dataGridViewADM.Rows[e.RowIndex].Cells["privilegio_usuario"].Value;

                DataSet data = new DataSet();

                MySqlCommand alterar = new MySqlCommand("UPDATE usuarios_tb SET nome_usuario = @nome_usuario, " +
                "senha_usuario = @senha_usuario WHERE cod_usuario = @cod_usuario", bdConn);
                alterar.Parameters.AddWithValue("@cod_usuario", cod_usuario);
                alterar.Parameters.AddWithValue("@nome_usuario", nome_usuario);
                alterar.Parameters.AddWithValue("@senha_usuario", senha_usuario);
                bdConn.Open();
                alterar.ExecuteNonQuery();
                bdConn.Close();
                data.AcceptChanges();

                MessageBox.Show("Usuário alterado com sucesso!");
            }
        }

        private void AdmUsuarios_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mySqlString);
            string sql = "select * from usuarios_tb";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                dataGridViewADM.DataSource = data;

                //Alterar
                DataGridViewButtonColumn alterarUsuario = new DataGridViewButtonColumn();
                alterarUsuario.HeaderText = "Ação";
                alterarUsuario.Name = "alterar_usuario";
                alterarUsuario.Text = "Alterar";
                alterarUsuario.UseColumnTextForButtonValue = true;
                dataGridViewADM.Columns.Add(alterarUsuario);
                //teste
                DataGridViewButtonColumn excluirUsuario = new DataGridViewButtonColumn();
                excluirUsuario.HeaderText = "Ação";
                excluirUsuario.Name = "excluir_usuario";
                excluirUsuario.Text = "Excluir";
                excluirUsuario.UseColumnTextForButtonValue = true;
                dataGridViewADM.Columns.Add(excluirUsuario);
                //Termina aqui a inclusão do botão

               
             }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro ao carregar tabela: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            MySqlConnection conn = new MySqlConnection(mySqlString);
            string sql = "SELECT * FROM usuarios_tb WHERE nome_usuario = '" + @user + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                dataGridViewADM.DataSource = data;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro ao carregar tabela: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
