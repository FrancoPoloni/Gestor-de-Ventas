using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class ConexionNeg
    {
        public static string StrConexion()
        {
            return CapaDatos.Conexion.DarStrConexion();
        }
    }
}
