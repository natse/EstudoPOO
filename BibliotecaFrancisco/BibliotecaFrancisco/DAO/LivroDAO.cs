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
    class LivroDAO
    {
        public void Insert(Livro livro)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Livros( titulo, dataPublicacao, editora)VALUES( @titulo, @dataPublicacao, @editora)";

            comando.Parameters.AddWithValue("@titulo", livro.Titulo);
            comando.Parameters.AddWithValue("@dataPublicacao", livro.DataPublicacao);
            comando.Parameters.AddWithValue("@editora", livro.Editora);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public void Update(Livro livro)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Livros SET titulo=@titulo, dataPublicao=@dataPublicacao, editora=@editora ";

            comando.Parameters.AddWithValue("@titulo", livro.Titulo);
            comando.Parameters.AddWithValue("@dataPublicacao", livro.DataPublicacao);
            comando.Parameters.AddWithValue("@editora", livro.Editora);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public void Deletar(Livro livro)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE Livro WHERE id=@id";

            comando.Parameters.AddWithValue("@id", livro.Id);

            Conexao conexao = new Conexao();
            conexao.CRUD(comando);
        }
        public Livro SelecionarPorId(Livro livro)
        {
            Livro l = new Livro();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT from livro WHERE id=@id";

            Conexao conexao = new Conexao();
            conexao.Selecionar(comando);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                l.Id = (int)dr["id"];
                l.Autor = (string)dr["autor"];
                l.Titulo = (string)dr["titulo"];
                l.DataPublicacao = (DateTime)dr["dataPublicacao"];
                l.Editora = (string)dr["editora"];

            }
            else
            {
                l = null;
            }
            dr.Close();
            return l;
        }
        public Livro SelecionarPorNome(Livro livro)
        {
            Livro l = new Livro();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Livro WHERE nome like @nome";

            Conexao conexao = new Conexao();
            conexao.Selecionar(comando);

            SqlDataReader dr = conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                l.Id = (int)dr["id"];
                l.Autor = (string)dr["autor"];
                l.Titulo = (string)dr["titulo"];
                l.DataPublicacao = (DateTime)dr["dataPublicacao"];
                l.Editora = (string)dr["editora"];
            }
            else
            {
                l = null;
            }
            dr.Close();
            return l;
        }
        public IList<Livro> SelecionarTodos(Livro livro)
        {
            IList<Livro> livros = new List<Livro>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Livro";

            Conexao conexao = new Conexao();
            conexao.Selecionar(comando);

            SqlDataReader dr = conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Livro l = new Livro();
                    l.Id = (int)dr["id"];
                    l.Autor = (string)dr["autor"];
                    l.Titulo = (string)dr["titulo"];
                    l.DataPublicacao = (DateTime)dr["dataPublicacao"];
                    l.Editora = (string)dr["editora"];
                    livros.Add(l);
                }
            }
            else
            {
                livros = null;
            }
            dr.Close();
            return livros;
        }
    }
}
