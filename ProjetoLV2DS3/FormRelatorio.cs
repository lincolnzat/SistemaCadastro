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

namespace ProjetoLV2DS3
{
    public partial class txtConteudo : Form
    {
        public txtConteudo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblWelcome TelaPrincipal = new lblWelcome();
            this.Hide();
            TelaPrincipal.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo Texto | *.txt";
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        
                    writer.Write(textoConteudo.Text);
                    writer.Flush();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível salvar o seu arquivo, " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo Texto | *.txt";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty (ofd.FileName) == false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(ofd.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-br").TextInfo.ANSICodePage)))
                    {
                        textoConteudo.Text = reader.ReadToEnd();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo. Erro{0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textoConteudo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
