using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    public class Conexion
    {
        private static string server = @"DESKTOP-7LTT9EH\SQLEXPRESS";
        private static string db = @"Trabajo";
        private static string usuario = @"sa";
        private static string clave = @"123";

        public static string DarStrConexion()
        {
            return string.Concat(@"Data Source=", server, ";Initial Catalog=", db,
                ";Persist Security Info=False;User ID=", usuario, ";Password=", clave);
        }
    }
}
