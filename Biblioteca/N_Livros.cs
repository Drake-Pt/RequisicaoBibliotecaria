using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Biblioteca
{
    class N_Livros
    {
        public static readonly int MAX_LIVROS = 100;
        public Livro[] liv;
        public int num_livros;

        public N_Livros()
        {
            this.liv = new Livro[MAX_LIVROS];
            this.num_livros = 0;
        }

        public Livro[] livs
        {
            get
            {
                return liv;
            }
            set
            {
                liv = value;
            }
        }
        public int NLivros
        {
            get
            {
                return num_livros;
            }
            set
            {
                num_livros = value;
            }
        }       
        public void AdicionaLivro(Livro e)
        {
            liv[num_livros++] = e;
        }
    }
}
