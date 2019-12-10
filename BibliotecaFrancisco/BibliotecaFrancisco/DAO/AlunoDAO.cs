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
    class AlunoDAO
    {
        public void Insert(Aluno aluno)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Aluno( cpf, nome, cidade, dataNascimento," +
                " numero, orgaoExpeditor, rg, rua, sexo, uf) VALUE( @cpf, @nome, @cidade, @dataNascimento," +
                " @numero, @orgaoExpeditor, @rg,@rua, @sexo, @uf)";

            comando.Parameters.AddWithValue("@cpf", aluno.Cpf);
            comando.Parameters.AddWithValue("@nome", aluno.Nome);
            comando.Parameters.AddWithValue("@cidade", aluno.Cidade);
            comando.Parameters.AddWithValue("@dataNacimento", aluno.DataNascimento);
            comando.Parameters.AddWithValue("@numero", aluno.Numero);
            comando.Parameters.AddWithValue("@orgaoExperditor", aluno.OrgaoExpeditor);
            comando.Parameters.AddWithValue("@rg", aluno.Rg);
            comando.Parameters.AddWithValue("@rua", aluno.Rua);
            comando.Parameters.AddWithValue("@sexo", aluno.Sexo);
            comando.Parameters.AddWithValue("@uf", aluno.Uf);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);

        }
        public void Updade(Aluno aluno)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE livro SET " +
                "cpf=@cpf, nome=@nome, cidade=@cidade, dataNascimento=@dataNascimento, numero=@numero," +
                " orgaoExpeditor=@orgaoExpeditor, rg=@rg, rua=@rua, sexo=@sexo, uf=@uf";

            comando.Parameters.AddWithValue("@cpf", aluno.Cpf);
            comando.Parameters.AddWithValue("@nome", aluno.Nome);
            comando.Parameters.AddWithValue("@cidade", aluno.Cidade);
            comando.Parameters.AddWithValue("@dataNacimento", aluno.DataNascimento);
            comando.Parameters.AddWithValue("@numero", aluno.Numero);
            comando.Parameters.AddWithValue("@orgaoExperditor", aluno.OrgaoExpeditor);
            comando.Parameters.AddWithValue("@rg", aluno.Rg);
            comando.Parameters.AddWithValue("@rua", aluno.Rua);
            comando.Parameters.AddWithValue("@sexo", aluno.Sexo);
            comando.Parameters.AddWithValue("@uf", aluno.Uf);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);

        }
        public void Delete(Aluno aluno)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE Aluno WHERE id=@id";

            comando.Parameters.AddWithValue("@id", aluno.Id);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public Aluno SelecionarPorID(int id)
        {
            Aluno a = new Aluno();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Aluno WHERE id=@id";

            comando.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                a.Id = (int)dr["id"];
                a.Nome = (string)dr["nome"];
                a.DataNascimento = (DateTime)dr["dataNascimento"];
                a.Cpf = (string)dr["cpf"];
                a.Cidade = (string)dr["cidade"];
                a.Numero = (string)dr["numero"];
                a.Rua = (string)dr["Rua"];
                a.OrgaoExpeditor = (string)dr["orgaoExpeditor"];
                a.Sexo = (string)dr["sexo"];
                a.Uf = (string)dr["uf"];
            }
            else
            {
                a = null;
            }
            dr.Close();
            return a;
        }
        public Aluno SelecionarPorNome(string nome)
        {
            Aluno a = new Aluno();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Aluno WHERE nome like @nome";

            comando.Parameters.AddWithValue("@nome", nome);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                a.Id = (int)dr["id"];
                a.Nome = (string)dr["nome"];
                a.DataNascimento = (DateTime)dr["dataNascimento"];
                a.Cpf = (string)dr["cpf"];
                a.Cidade = (string)dr["cidade"];
                a.Numero = (string)dr["numero"];
                a.Rua = (string)dr["Rua"];
                a.OrgaoExpeditor = (string)dr["orgaoExpeditor"];
                a.Sexo = (string)dr["sexo"];
                a.Uf = (string)dr["uf"];
            }
            else
            {
                a = null;
            }
            dr.Close();
            return a;
        }
        public IList<Aluno> SelecionarTodos()
        {
            IList<Aluno> alunos = new List<Aluno>();

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM aluno";

            Conexao conexao = new Conexao();
            SqlDataReader dr = conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Aluno a = new Aluno();
                    a.Id = (int)dr["id"];
                    a.Nome = (string)dr["nome"];
                    a.DataNascimento = (DateTime)dr["dataNascimento"];
                    a.Cpf = (string)dr["cpf"];
                    a.Cidade = (string)dr["cidade"];
                    a.Numero = (string)dr["numero"];
                    a.Rua = (string)dr["Rua"];
                    a.OrgaoExpeditor = (string)dr["orgaoExpeditor"];
                    a.Sexo = (string)dr["sexo"];
                    a.Uf = (string)dr["uf"];
                    alunos.Add(a);
                }
            }
            else
            {
                alunos = null;
            }
            return alunos;
        }
    }
}
