using CardVault.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardVault.DAO
{
    public class AlbumDAO
    {
        public List<Album> Listar()
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Album";
                return con.Query<Album>(sql).ToList();
            }
        }

        public List<Album> ListarPorColecionador(int idColecionador)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Album WHERE IdColecionador=@IdColecionador";
                return con.Query<Album>(sql, new { IdColecionador = idColecionador }).ToList();
            }
        }

        public void Inserir(Album a)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"INSERT INTO Album (Nome, Tema, AnoLancamento, TotalCards, IdColecionador) 
                               VALUES (@Nome, @Tema, @AnoLancamento, @TotalCards, @IdColecionador)";
                con.Execute(sql, a);
            }
        }

        public void Editar(Album a)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"UPDATE Album SET Nome=@Nome, Tema=@Tema, 
                               AnoLancamento=@AnoLancamento, TotalCards=@TotalCards 
                               WHERE Id=@Id";
                con.Execute(sql, a);
            }
        }
        public void Deletar(int id)
        {
            using (var con = Conexao.ObterConexao())
            {
                con.Open();

                
                string sqlCards = "DELETE FROM Card WHERE IdAlbum = @Id";
                con.Execute(sqlCards, new { Id = id });

               
                string sqlAlbum = "DELETE FROM Album WHERE Id = @Id";
                con.Execute(sqlAlbum, new { Id = id });
            }
        }

    }
}
