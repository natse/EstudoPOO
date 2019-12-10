using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaFrancisco.DAO;

namespace BibliotecaFrancisco.Modelos
{
    class Livro
    {
        private string autor;
        private DateTime datapublicacao;
        private string editora;
        private int id;
        private string titulo;
        private List<Emprestimo> emprestimo;

        public List<Emprestimo> Emprestimos { get { return emprestimo; } set {  emprestimo = value; } }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        public DateTime DataPublicacao
        {
            get { return datapublicacao; }
            set { datapublicacao = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public void Salva()
        {
            LivroDAO salva = new LivroDAO();
            salva.Insert(this);
        }
        public void Excluir()
        {

            LivroDAO Excluir = new LivroDAO();
            Excluir.Deletar(this);
        }
        public void alterar()
        {
            LivroDAO altera = new LivroDAO();
            altera.Update(this);
        }
        public void novo()
        {
            LivroDAO novo = new LivroDAO();
            novo.Insert(this);
        }
    }
}
