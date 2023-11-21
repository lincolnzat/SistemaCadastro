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
    public partial class lblWelcome : Form
    {
        public lblWelcome()
        {
            InitializeComponent();
        }

        public lblWelcome(string login, string senhaDigitada)
        {
            InitializeComponent();
            lblBemVindo.Text = "Seja bem vindo(a), " + login + "!";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usar o nosso sistema","Saída do sistema" );
            Application.Exit();
        }

        private void btnEmpregados_Click(object sender, EventArgs e)
        {
            FormEmpregados telaPrincipal = new FormEmpregados();
            this.Hide();
            telaPrincipal.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            txtConteudo telaPrincipal = new txtConteudo();
            this.Hide();
            telaPrincipal.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque telaPrincipal = new FormEstoque();
            this.Hide();
            telaPrincipal.ShowDialog();
        }

        private void empregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpregados telaPrincipal = new FormEmpregados();
            this.Hide();
            telaPrincipal.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstoque telaPrincipal = new FormEstoque();
            this.Hide();
            telaPrincipal.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConteudo telaPrincipal = new txtConteudo();
            this.Hide();
            telaPrincipal.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Load(object sender, EventArgs e)
        {

        }

        private void aDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmUsuarios Adm = new AdmUsuarios();
            Adm.ShowDialog();

        }
    }
}
