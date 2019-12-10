using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFrancisco.DAO
{
    class Conexao
    {
        public void CRUD(SqlCommand comando)
        {
            SqlConnection conexao = Conectar();
            comando.Connection = conexao;
            int Id = Convert.ToInt32(comando.ExecuteScalar());

        }
        public static SqlConnection Conectar()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["Biblioteca"].ConnectionString;
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
        public SqlDataReader Selecionar(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public int manterCRUDComRetorno(SqlCommand comando)
        {
            SqlTransaction transaction = null;
            SqlConnection conexao = Conectar();
            try
            {

                bool inserir = false;
                int retorno = 0;

                if (comando.CommandText.Contains("INSERT INTO"))
                {
                    inserir = true;
                }
                comando.Connection = conexao;
                if (inserir)
                {
                    transaction = conexao.BeginTransaction(IsolationLevel.ReadCommitted);
                    comando.Transaction = transaction;
                    comando.CommandText = comando.CommandText + ";SELECT CAST(scope_identity() AS int);";
                    retorno = Convert.ToInt32(comando.ExecuteScalar());
                    transaction.Commit();
                }
                else
                {
                    retorno = comando.ExecuteNonQuery();
                }
                conexao.Close();
                return retorno;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                }
                catch
                {

                }
                throw new ArgumentException(e.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }

        }
    }
}
