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
    class FuncionarioDAO
    {
        public void Insert(Funcionario funcionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Funcionario ( cpf, nome, cargo, dataAdmissao, matricula, pis, salario)" +
                "VALUES(@cpf, @nome, @cargo, @dataAdmissao, @matricula, @pis, @salario)";

            comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            comando.Parameters.AddWithValue("@nome", funcionario.Nome);
            comando.Parameters.AddWithValue("@cargo", funcionario.Cargo);
            comando.Parameters.AddWithValue("@dataAdmissao", funcionario.DataAdmissao);
            comando.Parameters.AddWithValue("@matricula", funcionario.Matricula);
            comando.Parameters.AddWithValue("@pis", funcionario.Pis);
            comando.Parameters.AddWithValue("@salario", funcionario.Salario);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public void Update(Funcionario funcionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDADE Funcionario SET cpf=@cpf, nome=@nome, cargo=@cargo," +
                "dataAdmissao=@dataAdmissao, matricula=@matricula, pis=@pis, salario=@salario)";

            comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            comando.Parameters.AddWithValue("@nome", funcionario.Nome);
            comando.Parameters.AddWithValue("@cargo", funcionario.Cargo);
            comando.Parameters.AddWithValue("@dataAdmissao", funcionario.DataAdmissao);
            comando.Parameters.AddWithValue("@matricula", funcionario.Matricula);
            comando.Parameters.AddWithValue("@pis", funcionario.Pis);
            comando.Parameters.AddWithValue("@salario", funcionario.Salario);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public void Deletar(Funcionario funcionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE Funcionario WHERE id=@id";

            comando.Parameters.AddWithValue("@id", funcionario.Id);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public Funcionario SelecionarPorID(int id)
        {
            Funcionario f = new Funcionario();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Funcionario WHERE id=@id";

            comando.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                f.Id = (int)dr["id"];
                f.Nome = (string)dr["nome"];
                f.Cargo = (string)dr["cargo"];
                f.DataAdmissao = (DateTime)dr["dataAdmissao"];
                f.Matricula = (string)dr["matricula"];
                f.Pis = (string)dr["pis"];
                f.Salario = (double)dr["salario"];

            }
            else
            {
                f = null;
            }
            dr.Close();
            return f;
        }
        public Funcionario SelecionarPorNome(string nome)
        {
            Funcionario f = new Funcionario();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Funcionario WHERE nome like @nome";

            comando.Parameters.AddWithValue("@nome", nome);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                f.Id = (int)dr["id"];
                f.Nome = (string)dr["nome"];
                f.Cargo = (string)dr["cargo"];
                f.DataAdmissao = (DateTime)dr["dataAdmissao"];
                f.Matricula = (string)dr["matricula"];
                f.Pis = (string)dr["pis"];
                f.Salario = (double)dr["salario"];
            }
            else
            {
                f = null;
            }
            dr.Close();
            return f;
        }
        public IList<Funcionario> BuscarTodos()
        {
            IList<Funcionario> listaF = new List<Funcionario>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Funcionario";

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Funcionario f = new Funcionario();
                    f.Id = (int)dr["id"];
                    f.Nome = (string)dr["nome"];
                    f.Cargo = (string)dr["cargo"];
                    f.DataAdmissao = (DateTime)dr["dataAdmissao"];
                    f.Matricula = (string)dr["matricula"];
                    f.Pis = (string)dr["pis"];
                    f.Salario = (double)dr["salario"];
                    listaF.Add(f);
                }
            }
            else
            {
                listaF = null;
            }
            dr.Close();
            return listaF;
        }
    }
}
