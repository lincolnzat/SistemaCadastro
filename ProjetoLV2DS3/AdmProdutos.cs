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
    public partial class AdmProdutos : Form
    {
        public AdmProdutos()
        {
            InitializeComponent();
        }
        public string mySqlString = "server=localhost;port=3306;uid= root;database=usuarios_db";
        private void AdmProdutos_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mySqlString);
            string sql = "select * from produtos_tb";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                dataGridView1.DataSource = data;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
