using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocoDeNotas
{
    public partial class Imagem : Form
    {
        public Imagem()
        {
            InitializeComponent();
        }

        private void Imagem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pctrBxAbrirImagem.Image = Properties.Resources.PrimeiraImagem;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pctrBxAbrirImagem.Image = Properties.Resources.imagem2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pctrBxAbrirImagem.Image = Properties.Resources.imagem3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pctrBxAbrirImagem.Image = Properties.Resources.imagem4;
        }

        private void pctrBxAbrirImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
