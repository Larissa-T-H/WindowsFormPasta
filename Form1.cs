using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Pasta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string criarPasta = @"E:\"+txtCriar.Text;

            if (!Directory.Exists(criarPasta)) 
            {
                Directory.CreateDirectory(criarPasta);
                MessageBox.Show("Pasta criada com sucesso!!", "",MessageBoxButtons.OK);
               
            }
            else
            {
                MessageBox.Show("Pasta já existe", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string deletarPasta = @"E:\" + txtDeletar.Text;

            if (Directory.Exists(deletarPasta))
            {
                Directory.Delete(deletarPasta);
                MessageBox.Show("Pasta foi deletada sucesso!!", "", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Pasta não existe", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            string nomeArquivo = "texto.txt";
            string origemPasta = @"E:\" + txtOrigem.Text;
            string destinoPasta = @"E:\" + textBox4.Text;

            string  arquivoOrigem = Path.Combine(origemPasta, nomeArquivo);
            string  arquivoDestino = Path.Combine(destinoPasta, nomeArquivo);

            if (File.Exists(arquivoOrigem))
            {
                File.Move(arquivoOrigem, arquivoDestino);
                MessageBox.Show("Arquivo movido com sucesso!!", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
