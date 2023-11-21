using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLV2DS3
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblWelcome TelaPrincipal = new lblWelcome();
            this.Hide();
            TelaPrincipal.ShowDialog();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           if (CadastrarProdutos.Checked)
            {
                MessageBox.Show("Cadastro selecionado.");
                CadastroProdutos TelaPrincipal = new CadastroProdutos();
                this.Hide();
                TelaPrincipal.ShowDialog();
            }

            if (ConsultarProdutos.Checked)
            {
                MessageBox.Show("Consulta selecionada.");
            }

            if (AlterarProdutos.Checked)
            {
                MessageBox.Show("Alteração selecionada.");
            }
        }

        private void CadastrarProdutos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {

        }
    }
}
