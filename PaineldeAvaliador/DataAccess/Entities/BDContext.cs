using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.DataAccess.Entities
{
    public class BDContext
    {
        public string ConnectionString { get; set; }

        private static BDContext _context = null;

        public static BDContext Instance
        {
            get
            {
                if (_context == null)
                {
                    return new BDContext("DefaultConnection");
                }
                return _context;
            }
        }

        private BDContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
