using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaFrancisco.DAO;

namespace BibliotecaFrancisco.Modelos
{
    class Emprestimo
    {
        private DateTime dataEmprestimo;
        private int id;
        private double valorTotal;
        private Funcionario objfuncionario;
        private Aluno objaluno;
        IList<ItenEmprestimo> listaIntem = new List<ItenEmprestimo>();
        public DateTime DataEmprestimo
        {
            get { return dataEmprestimo; }
            set { dataEmprestimo = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        public Funcionario Funcionario
        {
            get { return objfuncionario; }
            set { objfuncionario = value; }
        }
        public Aluno Objaluno
        {
            get { return objaluno; }
            set { objaluno = value; }
        }
        public IList<ItenEmprestimo> ListaItem
        {
            get { return listaIntem; }
            set { listaIntem = value; }
        }
        public void Salva()
        {
            EmprestimoDAO salva = new EmprestimoDAO();
            salva.Insert(this);
        }
        public void Excluir()
        {

            EmprestimoDAO Excluir = new EmprestimoDAO();
            Excluir.Delete(this);
        }
        public void alterar()
        {
            EmprestimoDAO altera = new EmprestimoDAO();
            altera.Update(this);
        }
        public void novo()
        {
            EmprestimoDAO novo = new EmprestimoDAO();
            novo.Insert(this);
        }
    }
}

