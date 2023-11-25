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

namespace BlocoDeNotas
{
    public partial class Form1 : Form
    {
        bool alterado;
        int zoom = 100;
        public Form1()
        {
            InitializeComponent();
            this.Text = "";

            barraDeStatusToolStripMenuItem.Checked = true;
            this.atualizaPosicao();
        }
        private void atualizaPosicao()
        {
            int linha = rchTxtBxConteudo.GetLineFromCharIndex(rchTxtBxConteudo.SelectionStart);
            int coluna = rchTxtBxConteudo.SelectionStart - rchTxtBxConteudo.GetFirstCharIndexFromLine(linha);
            tlStrpSttsLblPosicionamento.Text = "Ln: " + linha.ToString() + "Col: " + coluna.ToString();

        }

        private void rchTxtBxConteudo_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaPosicao();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.abrir();
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "WordPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.abrir();
                } else
                {
                    if (this.Text != "")
                    {
                        //ja tem um arquivo aberto
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }
        private void abrir()
        {
            if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.Text = opnFlDlgAbrir.FileName;
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile()))
                {
                    rchTxtBxConteudo.Rtf = reader.ReadToEnd();
                    alterado = false;
                }
            }
        }
        private void salvar(string arquivo)
        {
            if (arquivo != "")
            {
                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(rchTxtBxConteudo.Rtf);
                buffer.Close();
                this.Text = arquivo;
                alterado = false;
            } else
            {
                MessageBox.Show("Nome de arquivo invalido", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void salvarComo()
        {
            if (svFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.salvar(svFlDlgAbrir.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                //ja tem um arquivo aberto
                this.salvar(this.Text);
            }
            else
            {
                this.salvarComo();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.Undo();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxConteudo.SelectedRtf);
                rchTxtBxConteudo.SelectedRtf = "";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedText != "")
            {
                Clipboard.SetDataObject(rchTxtBxConteudo.SelectedText);
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                rchTxtBxConteudo.SelectedText = (string)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.Undo();
        }

        private void buscarComOBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                String texto = rchTxtBxConteudo.SelectedText;
                Text.Replace(' ', '+');
                System.Diagnostics.Process.Start("microsoft-edge:https://www.bing.com/search?q=" + texto);
            } else
            {
                MessageBox.Show(" E necessario selecionar um termo para pesquisar.", "Buscar com o bing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectAll();
        }

        private void horaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void quebraAutomaticaDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraAutomaticaDeLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraAutomaticaDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rchTxtBxConteudo.WordWrap = false;
            } else
            {
                quebraAutomaticaDeLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                rchTxtBxConteudo.WordWrap = true;
            }
        }

        private void configurarPaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgStpDlgConfiguraPagina.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prntDlgImprimir.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.Text = "";
                rchTxtBxConteudo.Text = "";
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "WordPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    rchTxtBxConteudo.Text = "";
                }
                else
                {
                    if (this.Text != "")
                    {
                        //ja tem um arquivo aberto
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fntDlgFonte.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxConteudo.SelectionFont = fntDlgFonte.Font;
            }
        }
        // funcionalidades do menuStip//
        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeStatusToolStripMenuItem.Checked = !barraDeStatusToolStripMenuItem.Checked;
            sttsStrpInformacoes.Visible = !sttsStrpInformacoes.Visible;
        }
        private void atualizaZoom()
        {
            tlStrpSttsLblZoom.Text = this.zoom.ToString() + "%";
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom++;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, rchTxtBxConteudo.Font.Size + 1, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom--;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, rchTxtBxConteudo.Font.Size - 1, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom = 100;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, 12, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clrDlgCor.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxConteudo.SelectionColor = clrDlgCor.Color;
            }
        }

        private void subistituirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Substituir frm = new Substituir();
            frm.txtBxLocaliza.Text = rchTxtBxConteudo.SelectedText;
            frm.Show(this);
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizar frm = new Localizar();
            frm.txtBxLocaliza.Text = rchTxtBxConteudo.SelectedText;
            frm.Show(this);

        }

        private void mnStrpPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagem frm = new Imagem();
            frm.Show();
        }
         // botoes do toolStrip//
        private void btn_novo_Click(object sender, EventArgs e)
        {
            {
                if (!alterado)
                {
                    this.Text = "";
                    rchTxtBxConteudo.Text = "";
                }
                else
                {
                    if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "WordPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.Text = "";
                        rchTxtBxConteudo.Text = "";
                    }
                    else
                    {
                        if (this.Text != "")
                        {
                            //ja tem um arquivo aberto
                            this.salvar(this.Text);
                        }
                        else
                        {
                            this.salvarComo();
                        }
                    }
                }
            }
        }
        private void btn_abrir_Click(object sender, EventArgs e)
        {
            {
                if (!alterado)
                {
                    this.abrir();
                }
                else
                {
                    if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "WordPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.abrir();
                    }
                    else
                    {
                        if (this.Text != "")
                        {
                            //ja tem um arquivo aberto
                            this.salvar(this.Text);
                        }
                        else
                        {
                            this.salvarComo();
                        }
                    }
                }
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }
        private void btn_copiar_Click(object sender, EventArgs e)
        {
            {
                if (rchTxtBxConteudo.SelectedText != "")
                {
                    Clipboard.SetDataObject(rchTxtBxConteudo.SelectedText);
                }
            }
        }
        private void btn_colar_Click(object sender, EventArgs e)
        {
            {
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                {
                    rchTxtBxConteudo.SelectedText = (string)Clipboard.GetData(DataFormats.Text);
                }
            }
        }
        private void btn_fonte_Click(object sender, EventArgs e)
        {
            {
                if (fntDlgFonte.ShowDialog() == DialogResult.OK)
                {
                    rchTxtBxConteudo.SelectionFont = fntDlgFonte.Font;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = rchTxtBxConteudo.Font.Name;
            tamanho_da_fonte = rchTxtBxConteudo.Font.Size;
            n = rchTxtBxConteudo.SelectionFont.Bold;
            i = rchTxtBxConteudo.SelectionFont.Italic;
            s = rchTxtBxConteudo.SelectionFont.Underline;

            rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            if (n == false)
            {
                if (i == true & s == true)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);

                }
                else if (i == false & s == false)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
                else
                {
                    if (i == true & s == true)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                    }
                    else if (i == false & s == true)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                    }
                    else if (i == true & s == false)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                    }
                }

            }
        }
        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = rchTxtBxConteudo.Font.Name;
            tamanho_da_fonte = rchTxtBxConteudo.Font.Size;
            n = rchTxtBxConteudo.SelectionFont.Bold;
            i = rchTxtBxConteudo.SelectionFont.Italic;
            s = rchTxtBxConteudo.SelectionFont.Underline;

            rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            if (i == false)
            {
                if (n == true & s == true)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);

                }
                else if (n == false & s == false)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
                else
                {
                    if (n == true & s == true)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                    }
                    else if (n == false & s == true)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                    }
                    else if (n == true & s == false)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                    }
                }

            }
        }
        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = rchTxtBxConteudo.Font.Name;
            tamanho_da_fonte = rchTxtBxConteudo.Font.Size;
            n = rchTxtBxConteudo.SelectionFont.Bold;
            i = rchTxtBxConteudo.SelectionFont.Italic;
            s = rchTxtBxConteudo.SelectionFont.Underline;

            rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            if (s == false)
            {
                if (n == true & i == true)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & i == true)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & i == false)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);

                }
                else if (n == false & i == false)
                {
                    rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else
                {
                    if (n == true & i == true)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                    }
                    else if (n == false & i == true)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                    }
                    else if (n == true & i == false)
                    {
                        rchTxtBxConteudo.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                    }
                }

            }
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }
        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }
        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void alinharEsquerda()
        {
            rchTxtBxConteudo.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void alinharDireita()
        {
            rchTxtBxConteudo.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void alinharCentro()
        {
            rchTxtBxConteudo.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }
        private void btn_direita_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }
        private void btn_centro_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void tlStrpBttnZoomOut_Click(object sender, EventArgs e)
        {
            this.zoom--;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, rchTxtBxConteudo.Font.Size - 1, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void tlStrpBttnZoomIn_Click(object sender, EventArgs e)
        {
            this.zoom++;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, rchTxtBxConteudo.Font.Size + 1, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void tlStrpBttnCor_Click(object sender, EventArgs e)
        {
            {
                if (clrDlgCor.ShowDialog() == DialogResult.OK)
                {
                    rchTxtBxConteudo.SelectionColor = clrDlgCor.Color;
                }
            }
        }
    }
}
