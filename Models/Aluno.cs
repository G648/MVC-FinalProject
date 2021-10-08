using MVCRazorCRUD.Context;
using MVCRazorCRUD.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Models
{
    public class Aluno : UsuarioBase , IAluno
    {
      
        public string Escolaridade { get; set; }

        public void AtualizarAluno(Aluno aluno)
        {
            var connection = Conexao.GetConnect();
            connection.Open();
            var query = "update alunos set alunoNome = @nome, alunoEmail = @email, alunoEndereco = @end, alunoTelefone = @tel, alunoEscolaridade = @esc where alunoId = @id";
            var command = new SqlCommand(query, connection);

            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = aluno.Nome;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
            command.Parameters.Add("@end", SqlDbType.VarChar).Value = aluno.Endereco;
            command.Parameters.Add("@tel", SqlDbType.VarChar).Value = aluno.Telefone;
            command.Parameters.Add("@esc", SqlDbType.VarChar).Value = aluno.Escolaridade;
            command.Parameters.Add("@id", SqlDbType.Int).Value = aluno.Id;
            command.ExecuteNonQuery();
        }

        public List<Aluno> BuscarPorId(int id)
        {
            var connection = Conexao.GetConnect();
            connection.Open();

            var query = "select * from alunos where alunoId = @id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            var dataSet = new DataSet();
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            var rows = dataSet.Tables[0].Rows;

            List<Aluno> listaAlunos = new List<Aluno>();
            foreach(DataRow item in rows)
            {
                var Colunas = item.ItemArray;
                Aluno aluno = new Aluno();

                aluno.Id = int.Parse(Colunas[0].ToString());
                aluno.Nome = Colunas[1].ToString();
                aluno.Email = Colunas[2].ToString();
                aluno.Endereco = Colunas[3].ToString();
                aluno.Telefone = Colunas[4].ToString();
                aluno.Escolaridade = Colunas[5].ToString();
                listaAlunos.Add(aluno);
            }

            connection.Close();

            return listaAlunos;
        }

        public Aluno CadastrarAluno(Aluno aluno)
        {
            try
            {
                var connection = Conexao.GetConnect();
                connection.Open();

                var query = "Insert into alunos (alunoNome, alunoEmail, alunoEndereco, alunoTelefone, alunoEscolaridade) values (@nome, @email, @end, @tel, @esc)";

                var command = new SqlCommand(query, connection);

                command.Parameters.Add("@nome", SqlDbType.VarChar). Value = aluno.Nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
                command.Parameters.Add("@end", SqlDbType.VarChar).Value = aluno.Endereco;
                command.Parameters.Add("@tel", SqlDbType.VarChar).Value = aluno.Telefone;
                command.Parameters.Add("@esc", SqlDbType.VarChar).Value = aluno.Escolaridade;

                command.ExecuteNonQuery();

                connection.Close();
                return aluno;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Aluno> ListarAluno()
        {   try
            {

            var connection = Conexao.GetConnect();
            connection.Open();

            var query = "select * from alunos";
            var command = new SqlCommand(query, connection);
            var dataSet = new DataSet();
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            var rows = dataSet.Tables[0].Rows;

            List<Aluno> listDeAlunos = new List<Aluno>();

            foreach (DataRow item in rows)
            {
                Aluno aluno = new Aluno();
                var Colunas = item.ItemArray;
                aluno.Id = int.Parse(Colunas[0].ToString());
                aluno.Nome = Colunas[1].ToString();
                aluno.Email = Colunas[2].ToString();
                aluno.Endereco = Colunas[3].ToString();
                aluno.Telefone = Colunas[4].ToString();
                aluno.Escolaridade = Colunas[5].ToString();

                listDeAlunos.Add(aluno);
            }
            connection.Close();
            return listDeAlunos;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void RemoverAluno(int id)
        {
            var connection = Conexao.GetConnect();
            connection.Open();

            var query = "delete from alunos where alunoId = @id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();
        }
    }
}
