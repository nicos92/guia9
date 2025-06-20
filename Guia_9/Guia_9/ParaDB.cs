using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace VariablesDB
{
    public static class ParaDB
    {
        public static OleDbConnection ConexionConDB;
        public static string strConecion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=personasmdb.mdb;";
        public static OleDbCommand Orden;
        public static OleDbDataReader lector;
    }
}
