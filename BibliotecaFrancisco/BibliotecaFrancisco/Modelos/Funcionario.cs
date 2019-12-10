using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaFrancisco.DAO;

namespace BibliotecaFrancisco.Modelos
{
    class Funcionario:Pessoa
    {
        private string cargo;
        private DateTime dataAdmissao;
        private string matricula;
        private string pis;
        private double salario;
        private List<Emprestimo> emprestimo;
        public List<Emprestimo> Emprestimos { get { return emprestimo; } set {  emprestimo = value; } }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Pis
        {
            get { return pis; }
            set { pis = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public void Salva()
        {
           FuncionarioDAO salva = new FuncionarioDAO();
            salva.Insert(this);
        }
        public void Excluir()
        {

            FuncionarioDAO Excluir = new FuncionarioDAO();
            Excluir.Deletar(this);
        }
        public void alterar()
        {
            FuncionarioDAO altera = new FuncionarioDAO();
            altera.Update(this);
        }
        public void novo()
        {
            FuncionarioDAO novo = new FuncionarioDAO();
            novo.Insert(this);
        }

    }
}

