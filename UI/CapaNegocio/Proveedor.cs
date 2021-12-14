using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private string apellido;
        private int telefono;
        private string gmail;
        private TipoDocumento doc;
        private int numDoc;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public TipoDocumento Doc { get => doc; set => doc = value; }
        public int NumDoc { get => numDoc; set => numDoc = value; }
        

        public Proveedor() 
        {
            id = 0;
            nombre = "";
            apellido = "";
            telefono = 0;
            gmail = "";
            doc = null;
            numDoc = 0;
        }
        public Proveedor(int id, string nombre, string apellido, int telefono, string gmail, TipoDocumento doc, int numDoc)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.gmail = gmail;
            this.doc = doc;
            this.numDoc = numDoc;
        }

        public override string ToString()
        {
            return string.Concat(nombre + apellido + " telefono: " + telefono + " gmail: " + gmail);
        }
        //Metodos

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eProveedor p = new eProveedor();

            if (this.id == 0)
            {
                CargarFila(p);
                dc.eProveedor.InsertOnSubmit(p);
            }
            else
            {
                p = (from x in dc.eProveedor where x.id == this.id select x).FirstOrDefault();
                CargarFila(p);
            }

            dc.SubmitChanges();
        }

        private void CargarFila(eProveedor p)
        {
            p.nombre = this.nombre;
            p.apellido = this.apellido;
            p.telefono = this.telefono;
            p.gmail = this.gmail;
            p.fkDoc = this.doc.Id;
            p.numDoc = this.numDoc;

        }

        public static IQueryable BuscarIQ(string buscado)
        {
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eProveedor
                        where x.apellido.ToLower().Contains(buscado) ||
                        x.nombre.ToLower().Contains(buscado) ||
                        x.telefono.ToString().Contains(buscado) ||
                        x.numDoc.ToString().Contains(buscado) ||
                        x.gmail.ToLower().Contains(buscado)
                        select new
                        {
                            Id = x.id,
                            Proveedor = x.nombre.ToUpper() + ", " + x.apellido.ToUpper(),
                            Telefono = x.telefono,
                            Email = x.gmail,
                            Documnto = x.eTipoDocumento.nombre.ToUpper(),
                            N_Doc = x.numDoc
                            //
                            // Pais = x.ePais.nombre.ToUpper(),
                            //  Ejemplo = x.id % 2 == 0 ? "ID PAR" : "ID IMPAR",
                            //SUMA = x.id + DateTime.Now.Minute
                            //  Edad = (DateTime.Now.AddTicks(-x.fecNac.Ticks).Year - 1).ToString()

                        };
            return filas;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eProveedor where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eProveedor.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        public static Proveedor BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eProveedor where x.id == id select x).FirstOrDefault();
            return new Proveedor(f.id, f.nombre, f.apellido, f.telefono, f.gmail, TipoDocumento.BuscarPorId(f.fkDoc), f.numDoc);
        }
    }
}
