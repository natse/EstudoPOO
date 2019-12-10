using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFrancisco.Modelos
{
    class ItenEmprestimo
    {

        private DateTime dataDevolucao;
        private int id;
        private Livro livro;
        private Emprestimo emprestimo;
        public Emprestimo Emprestimo { get { return emprestimo; }set {   emprestimo = value; } }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataDevolucao
        {
            get { return dataDevolucao; }
            set { dataDevolucao = value; }
        }
        private Livro Livro
        {
            get { return livro; }
            set { livro = value; }
        }

    }
}

