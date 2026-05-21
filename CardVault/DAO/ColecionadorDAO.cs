using CardVault.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardVault.DAO
{
    public class ColecionadorDAO
    {
        public List<Colecionador> Listar()
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Colecionador";
                return con.Query<Colecionador>(sql).ToList();
            }
        }

        public void Inserir(Colecionador c)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"INSERT INTO Colecionador (Nome, Email, Telefone, DataCadastro) 
                               VALUES (@Nome, @Email, @Telefone, @DataCadastro)";
                con.Execute(sql, c);
            }
        }

        public void Editar(Colecionador c)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"UPDATE Colecionador SET Nome=@Nome, Email=@Email, 
                               Telefone=@Telefone WHERE Id=@Id";
                con.Execute(sql, c);
            }
        }

        public void Deletar(int id)
        {

            using (var con = Conexao.ObterConexao())
            {
                con.Open();

                // Deleta as trocas que envolvem o colecionador
                string sqlTrocas = @"DELETE FROM Troca WHERE IdColecionador1 = @Id OR IdColecionador2 = @Id";
                con.Execute(sqlTrocas, new { Id = id });

                // Busca os ids dos álbuns do colecionador
                string sqlBuscarAlbums = "SELECT Id FROM Album WHERE IdColecionador = @Id";
                var albumIds = con.Query<int>(sqlBuscarAlbums, new { Id = id }).ToList();

                foreach (var albumId in albumIds)
                {
                    // Deleta os cards de cada álbum
                    string sqlCards = "DELETE FROM Card WHERE IdAlbum = @IdAlbum";
                    con.Execute(sqlCards, new { IdAlbum = albumId });
                }

                // Deleta os álbuns
                string sqlAlbums = "DELETE FROM Album WHERE IdColecionador = @Id";
                con.Execute(sqlAlbums, new { Id = id });

                // Deleta o colecionador
                string sqlColecionador = "DELETE FROM Colecionador WHERE Id = @Id";
                con.Execute(sqlColecionador, new { Id = id });
            }
        }
} }



