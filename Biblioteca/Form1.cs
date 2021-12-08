using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{

    public partial class Form1 : Form
    {
        N_Livros nlivros;
        public Form1()
        {
            nlivros = new N_Livros();
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtN_proc.TextLength != 0 && txtTitulo.TextLength != 0 && txtAutor.TextLength != 0 && txtISBN.TextLength != 0 && txtAno.TextLength != 0 && txtN_exemp.TextLength != 0)
            {
                MessageBox.Show("Regsito guardado com sucesso!", "Informação");
                nlivros.AdicionaLivro(new Livro(Convert.ToInt32(txtN_proc.Text), txtTitulo.Text, txtAutor.Text, txtISBN.Text, Convert.ToInt32(txtAno.Text), Convert.ToInt32(txtN_exemp.Text)));
                LimpaForm();
            }
        }
        private void LimpaForm()
        {
            txtN_proc.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtISBN.Text = "";
            txtAno.Text = "";
            txtN_exemp.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Form2(nlivros.livs, nlivros.NLivros).Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
