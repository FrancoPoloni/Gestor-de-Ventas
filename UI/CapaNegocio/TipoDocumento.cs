using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class TipoDocumento
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public TipoDocumento()
        {
            id = 0;
            nombre = "";
        }

        public TipoDocumento(int id, string nombre)
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
            eTipoDocumento p = new eTipoDocumento();

            if (this.id == 0)
            {
                CargarFilaPais(p);
                dc.eTipoDocumento.InsertOnSubmit(p);
            }
            else
            {
                p = (from x in dc.eTipoDocumento where x.id == this.id select x).FirstOrDefault();
                CargarFilaPais(p);
            }

            dc.SubmitChanges();
        }

        private void CargarFilaPais(eTipoDocumento p)
        {
            p.nombre = this.nombre;

        }

        public static List<TipoDocumento> Buscar(string buscado = "")
        {
            List<TipoDocumento> results = new List<TipoDocumento>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eTipoDocumento
                        where x.nombre.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    results.Add(new TipoDocumento(f.id, f.nombre));
                }
            }

            return results;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eTipoDocumento where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eTipoDocumento.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        public static TipoDocumento BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var fila = (from x in dc.eTipoDocumento where x.id == id select x).FirstOrDefault();
            return new TipoDocumento(fila.id, fila.nombre);

        }

    }
}
