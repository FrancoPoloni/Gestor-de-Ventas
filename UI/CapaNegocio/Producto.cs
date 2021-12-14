using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.ComponentModel;

namespace CapaNegocio
{
    public class Producto
    {
        private int id;
        private string nombre;
        private double precio;
        private Marca marca;
        private TipoProducto tipo;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public Marca Marca { get => marca; set => marca = value; }
        public TipoProducto Tipo { get => tipo; set => tipo = value; }
        

        public Producto()
        {
            id = 0;
            nombre = "";
            precio = 0;
            marca = null;
            tipo = null;
        }
        public Producto(int id, string nombre, double precio, Marca marca, TipoProducto tipo)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.tipo = tipo;
        }
        public override string ToString()
        {
            return string.Concat(nombre + " marca " + marca);
        }
        //metodos
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eProducto p = new eProducto();

            if (this.id == 0)
            {
                CargarFila(p);
                dc.eProducto.InsertOnSubmit(p);
            }
            else
            {
                p = (from x in dc.eProducto where x.id == this.id select x).FirstOrDefault();
                CargarFila(p);
            }

            dc.SubmitChanges();
        }

        private void CargarFila(eProducto p)
        {
            p.nombre = this.nombre;
            p.precio = this.precio;
            p.fkmarca = this.marca.Id;
            p.fkTipo = this.tipo.Id;

        }

        public static List<Producto> Buscar(string buscado = "")
        {
            List<Producto> results = new List<Producto>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eProducto
                        where x.nombre.ToLower().Contains(buscado) ||
                        x.precio.ToString().Contains(buscado) ||
                        x.eMarca.nombre.ToLower().Contains(buscado) ||
                        x.eTipoProducto.nombre.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    results.Add(new Producto(f.id, f.nombre, f.precio, Marca.BuscarPorId(f.fkmarca), TipoProducto.BuscarPorId(f.fkTipo)));
                }
            }

            return results;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eProducto where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eProducto.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        public static Producto BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eProducto where x.id == id select x).FirstOrDefault();
            return new Producto(f.id, f.nombre, f.precio, Marca.BuscarPorId(f.fkmarca), TipoProducto.BuscarPorId(f.fkTipo));
        }
        public static bool BuscarPorIdMarca(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eMarca where x.id == id select x).FirstOrDefault();
            if (f != null)
                return true;
            return false;
        }
        public static bool BuscarPorIdTipo(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eTipoProducto where x.id == id select x).FirstOrDefault();
            if (f != null)
                return true;
            return false;
        }

    }
}
