using CardVault.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardVault.DAO
{
    public class TrocaDAO
    {
        public List<Troca> Listar()
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Troca";
                return con.Query<Troca>(sql).ToList();
            }
        }

        public void Inserir(Troca t)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"INSERT INTO Troca (IdColecionador1, IdColecionador2, DataTroca, Observacao) 
                               VALUES (@IdColecionador1, @IdColecionador2, @DataTroca, @Observacao)";
                con.Execute(sql, t);
            }
        }

        public void Editar(Troca t)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = @"UPDATE Troca SET IdColecionador1=@IdColecionador1, 
                               IdColecionador2=@IdColecionador2, Observacao=@Observacao 
                               WHERE Id=@Id";
                con.Execute(sql, t);
            }
        }

        public void Deletar(int id)
        {
            using (var con = Conexao.ObterConexao())
            {
                string sql = "DELETE FROM Troca WHERE Id=@Id";
                con.Execute(sql, new { Id = id });
            }
        }
    }
}
