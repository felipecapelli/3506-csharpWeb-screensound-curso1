using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL //DAL = Data Access Layer
    {
        public IEnumerable<Artista> Listar()
        {
            using var context = new ScreenSoundContext();

            return context.Artistas.ToList();
        }

        //public void Adicionar(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);

        //    int retorno = command.ExecuteNonQuery();
        //    Console.WriteLine($"Linhas afetadas Adicionar {retorno}");
        //}

        //public Artista Buscar(string nomeArtistaParaBuscar) 
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = $"SELECT * FROM [ScreenSound].[dbo].[Artistas] where Nome = @nome";
        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", nomeArtistaParaBuscar);

        //    using SqlDataReader dataReader = command.ExecuteReader();

        //    dataReader.Read();
        //    string nomeArtista = Convert.ToString(dataReader["Nome"]);
        //    string bioArtista = Convert.ToString(dataReader["Bio"]);
        //    int idArtista = Convert.ToInt32(dataReader["Id"]);
        //    Artista artista = new(nomeArtista, bioArtista) { Id = idArtista };

        //    return artista;
        //}

        //public void Atualizar(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";
        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);
        //    command.Parameters.AddWithValue("@id", artista.Id);

        //    int retorno = command.ExecuteNonQuery();
        //    Console.WriteLine($"Linhas afetadas Atualizar {retorno}");
        //}

        //public void Excluir(Artista artista) {
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = $"DELETE FROM Artistas WHERE Id = @id";
        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@id", artista.Id);

        //    int retorno = command.ExecuteNonQuery();
        //    Console.WriteLine($"Linhas afetadas Excluir {retorno}");
        //}
    }
}
