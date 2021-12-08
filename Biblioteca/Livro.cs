using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        private int n_proc;
        private string nome;
        private string autor;
        private string isbn;
        private int ano_edic;
        private int n_exemp;

        public Livro(int n_proc, string nome, string autor, string isbn, int ano_edic, int n_exemp)
        {
            this.n_proc = n_proc;
            this.nome = nome;
            this.autor = autor;
            this.isbn = isbn;
            this.ano_edic = ano_edic;
            this.n_exemp = n_exemp;
        }

        public int N_Proc
        {
            get
            {
                return n_proc;
            }
            set
            {
                n_proc = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }
        public int Ano
        {
            get
            {
                return ano_edic;
            }
            set
            {
                ano_edic = value;
            }
        }
        public int N_Exemp
        {
            get
            {
                return n_exemp;
            }
            set
            {
                n_exemp = value;
            }
        }
    }
}
