using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Biblioteca
{
    public partial class Form2 : Form
    {
        Livro[] livo;
        int num_livros;
        public Form2(Livro[] l, int nl)
        {
            this.livo = l;
            this.num_livros = nl;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tabelaLivros.ColumnCount = 6;
            tabelaLivros.Columns[0].Name = "Nº Processo";
            tabelaLivros.Columns[1].Name = "Título";
            tabelaLivros.Columns[2].Name = "Autor";
            tabelaLivros.Columns[3].Name = "ISBN";
            tabelaLivros.Columns[4].Name = "Ano de edição";
            tabelaLivros.Columns[5].Name = "Nº de exmplares";

            for (int i = 0; i < num_livros; i++)
                tabelaLivros.Rows.Add(new string[] {
                    livo[i].N_Proc.ToString(),
                    livo[i].Nome,
                    livo[i].Autor,
                    livo[i].ISBN,
                    livo[i].Ano.ToString(),
                    livo[i].N_Exemp.ToString()
                });
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
