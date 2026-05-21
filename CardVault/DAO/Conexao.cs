using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
namespace CardVault.DAO
{
    public class Conexao
    {
        private const string StringConexao =
            "Server=localhost;Database=CardVault;Uid=root;Pwd=1234;";

        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(StringConexao);
        }
    }
}

