using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Banco
{
    public class ConexaoBanco
    {
        public IDbConnection CriarConexao()
            {
                return new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=loca_facil; Trusted_Connection=True;");
            }
        
    }
}
