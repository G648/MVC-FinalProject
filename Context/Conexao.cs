using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Context
{
    public class Conexao
    {
        private static string ConnStr = "Data Source=localhost;Initial Catalog=EscolaSenai;Integrated Security=True";

        public static SqlConnection GetConnect()
        {
            var conn = new SqlConnection(ConnStr);
            return conn;
        }
    }
}
