using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Marca
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Marca()
        {
            id = 0;
            nombre = "";
        }

        public Marca(int id, string nombre)
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
            eMarca p = new eMarca();

            if (this.id == 0) 
            {
                CargarFilaPais(p);
                dc.eMarca.InsertOnSubmit(p);
            }
            else
            {
                p = (from x in dc.eMarca where x.id == this.id select x).FirstOrDefault();
                CargarFilaPais(p);
            }

            dc.SubmitChanges();
        }

        private void CargarFilaPais(eMarca p)
        {
            p.nombre = this.nombre;

        }

        public static List<Marca> Buscar(string buscado = "")
        {
            List<Marca> results = new List<Marca>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eMarca
                        where x.nombre.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    results.Add(new Marca(f.id, f.nombre));
                }
            }

            return results;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eMarca where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eMarca.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        public static Marca BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var fila = (from x in dc.eMarca where x.id == id select x).FirstOrDefault();
            return new Marca(fila.id, fila.nombre);

        }
 
    }
}
