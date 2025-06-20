using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using VariablesDB;

namespace FuncionesDB
{
    public static class AccesoDB
    {
        public static void ConectarDB()
        {
            ParaDB.ConexionConDB = new OleDbConnection(ParaDB.strConecion);
            ParaDB.ConexionConDB.Open();

        }

     
        public static OleDbDataReader LecturaDB(string consulta)
        {
            ParaDB.Orden = new OleDbCommand(consulta, ParaDB.ConexionConDB);
            ParaDB.lector = ParaDB.Orden.ExecuteReader();
            return ParaDB.lector;
        }

        public static int InsertarNombre(string consulta)
        {
            ParaDB.Orden = new OleDbCommand(consulta, ParaDB.ConexionConDB);
            
            return ParaDB.Orden.ExecuteNonQuery();
        }

        public static void CerrarDB()
        {
            ParaDB.ConexionConDB.Close();
        }
    }
}
