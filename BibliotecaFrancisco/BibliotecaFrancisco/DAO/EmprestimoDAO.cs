using BibliotecaFrancisco.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFrancisco.DAO
{
    class EmprestimoDAO
    {
        public void Insert(Emprestimo objEmprestimo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Emprestimo ( dataEmprestimo, valortotal, funcionario, aluno) VALUES (@id, @dataEmprestimo, @valortotal, @funcionario, @aluno)";

            comando.Parameters.AddWithValue("@dataEmprestimo", objEmprestimo.DataEmprestimo);
            comando.Parameters.AddWithValue("@valortotal", objEmprestimo.ValorTotal);
            comando.Parameters.AddWithValue("@funcionario", objEmprestimo.Funcionario);
            comando.Parameters.AddWithValue("@aluno", objEmprestimo.Objaluno);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public void Update(Emprestimo objEmprestimo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Emprestimo set dataEmprestimo=@dataEmprestimo, valortotal=@valortotal, funcionario=@funcionario, aluno=@aluno";

            comando.Parameters.AddWithValue("@dataEmprestimo", objEmprestimo.DataEmprestimo);
            comando.Parameters.AddWithValue("@valortotal", objEmprestimo.ValorTotal);
            comando.Parameters.AddWithValue("@funcionario", objEmprestimo.Funcionario);
            comando.Parameters.AddWithValue("@aluno", objEmprestimo.Objaluno);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public void Delete(Emprestimo objEmprestimo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE Emprestimo WHERE id=@id";

            comando.Parameters.AddWithValue("@id", objEmprestimo.Id);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public Emprestimo SelecionarPorID(int id)
        {
            Emprestimo emp = new Emprestimo();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Emprestimo WHERE id=@id";

            comando.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                emp.Id = (int)dr["id"];
                emp.DataEmprestimo = (DateTime)dr["dataemprestimo"];
                emp.ValorTotal = (double)dr["valortotal"];
                emp.Funcionario = (Funcionario)dr["funconario"];
                emp.Objaluno = (Aluno)dr["aluno"];
            }
            else
            {
                emp = null;
            }
            dr.Close();
            return emp;
        }
        public IList<Emprestimo> SelecionaTudo(int id)
        {
            IList<Emprestimo> emprestimoLista = new List<Emprestimo>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Emprestimo";

            comando.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Emprestimo e = new Emprestimo();
                    e.Id = (int)dr["id"];
                    e.DataEmprestimo = (DateTime)dr["dataEmprestimo"];
                    e.ValorTotal = (double)dr["valortotal"];
                    e.Funcionario = (Funcionario)dr["funcionario"];
                    e.Objaluno = (Aluno)dr["aluno"];
                    emprestimoLista.Add(e);
                }
            }
            else
            {
                emprestimoLista = null;
            }
            dr.Close();
            return emprestimoLista;
        }
    }
}
