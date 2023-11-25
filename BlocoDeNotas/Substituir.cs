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
    public partial class Substituir : Form
    {
        public Substituir()
        {
            InitializeComponent();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnSubstitui_Click(object sender, EventArgs e)
        {
            String busca = txtBxLocaliza.Text;
            String nova = txtBxSubstituir.Text;
            String texto = ((Form1)this.Owner).rchTxtBxConteudo.Text;

            ((Form1)this.Owner).rchTxtBxConteudo.Text = texto.Replace(busca, nova);

            this.Close();
        }

        private void txtBxLocaliza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
