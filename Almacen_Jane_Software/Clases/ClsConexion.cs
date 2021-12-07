using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Almacen_Jane_Software
{
    class ClsConexion
    {
        static string Conexion = "datasource = 127.0.0.1; port = 3306; username = Gabriel; password = 123; database = almacen";
        public MySqlConnection Databaseconexion = new MySqlConnection(Conexion);
    }
}
