using BibliotecaFrancisco.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace BibliotecaFrancisco.Modelos
{
    class Aluno:Pessoa
    {
        private string cidade;
        private DateTime dataNascimento;
        private string numero;
        private string orgaoExpeditor;
        private string rg;
        private string rua;
        private string sexo;
        private string uf;
        private List<Emprestimo> emprestimo;

       public List<Emprestimo> Emprestimos { get { return emprestimo; }set { emprestimo = value; } }

        internal Aluno FindAll()
        {
            throw new NotImplementedException();
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string OrgaoExpeditor
        {
            get { return orgaoExpeditor; }
            set { orgaoExpeditor = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        public void Salva()
        {
            AlunoDAO salva = new AlunoDAO();
            salva.Insert(this);
        }
        public  void Excluir()
        {

            AlunoDAO Excluir = new AlunoDAO();
            Excluir.Delete(this);
        }
        public  void Alterar()
        {
            AlunoDAO altera = new AlunoDAO();
            altera.Updade(this);
        }
        public void Novo()
        {
            AlunoDAO novo = new AlunoDAO();
            novo.Insert(this);
        }
       

    }
}

