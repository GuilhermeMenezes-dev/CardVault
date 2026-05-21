using CardVault.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardVault.DAO
{
    public class CardDAO
    {
        public List<Card> Listar()
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Card";
                return con.Query<Card>(sql).ToList();
            }
        }

        public List<Card> ListarPorAlbum(int idAlbum)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Card WHERE IdAlbum=@IdAlbum";
                return con.Query<Card>(sql, new { IdAlbum = idAlbum }).ToList();
            }
        }

        public List<Card> ListarPorRaridade(string raridade)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Card WHERE Raridade=@Raridade";
                return con.Query<Card>(sql, new { Raridade = raridade }).ToList();
            }
        }

        public void Inserir(Card c)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"INSERT INTO Card (Nome, Numero, Raridade, Descricao, IdAlbum) 
                               VALUES (@Nome, @Numero, @Raridade, @Descricao, @IdAlbum)";
                con.Execute(sql, c);
            }
        }

        public void Editar(Card c)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"UPDATE Card SET Nome=@Nome, Numero=@Numero, 
                               Raridade=@Raridade, Descricao=@Descricao 
                               WHERE Id=@Id";
                con.Execute(sql, c);
            }
        }

        public void Deletar(int id)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "DELETE FROM Card WHERE Id=@Id";
                con.Execute(sql, new { Id = id });
            }
        }
    }
}
