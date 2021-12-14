using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class TipoProducto
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public TipoProducto()
        {
            id = 0;
            nombre = "";
        }

        public TipoProducto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }

        //Metodos
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eTipoProducto p = new eTipoProducto();

            if (this.id == 0)
            {
                CargarFilaPais(p);
                dc.eTipoProducto.InsertOnSubmit(p);
            }
            else
            {
                p = (from x in dc.eTipoProducto where x.id == this.id select x).FirstOrDefault();
                CargarFilaPais(p);
            }

            dc.SubmitChanges();
        }

        private void CargarFilaPais(eTipoProducto p)
        {
            p.nombre = this.nombre;

        }

        public static List<TipoProducto> Buscar(string buscado = "")
        {
            List<TipoProducto> results = new List<TipoProducto>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eTipoProducto
                        where x.nombre.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    results.Add(new TipoProducto(f.id, f.nombre));
                }
            }

            return results;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eTipoProducto where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eTipoProducto.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        public static TipoProducto BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var fila = (from x in dc.eTipoProducto where x.id == id select x).FirstOrDefault();
            return new TipoProducto(fila.id, fila.nombre);

        }
    }
}
