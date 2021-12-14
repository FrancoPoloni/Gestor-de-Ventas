using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private int numDoc;
        private TipoDocumento doc;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumDoc { get => numDoc; set => numDoc = value; }
        public TipoDocumento Doc { get => doc; set => doc = value; }

        public Cliente()
        {
            id = 0;
            nombre = "";
            apellido = "";
            numDoc = 0;
            doc = null;

        }

        public Cliente(int id, string nombre, string apellido, int numDoc, TipoDocumento doc)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numDoc = numDoc;
            this.doc = doc;
        }

        public override string ToString()
        {
            return string.Concat(nombre + " " + apellido);
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eCliente p = new eCliente();

            if (this.id == 0) //esto detecta que es un objeto nuevo
            {
                CargarFilaCliente(p);
                dc.eCliente.InsertOnSubmit(p);
            }
            else //este caso es para una fila que viene de la DB, id != 0
            {
                p = (from x in dc.eCliente where x.id == this.id select x).FirstOrDefault();
                CargarFilaCliente(p);
            }

            dc.SubmitChanges();
        }
        public static Cliente BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eCliente where x.id == id select x).FirstOrDefault();

            Cliente p = new Cliente(f.id, f.nombre, f.apellido, f.numdoc, TipoDocumento.BuscarPorId(f.fkDoc));

            return p;

        }
        public static List<Cliente> Buscar(string buscado = "")
        {
            List<Cliente> resultados = new List<Cliente>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eCliente
                        where x.nombre.ToLower().Contains(buscado) ||
                        x.apellido.ToLower().Contains(buscado) ||
                        x.numdoc.ToString().Contains(buscado) ||
                        x.eTipoDocumento.nombre.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    if (f.id > 0)
                    {
                        resultados.Add(new Cliente(f.id, f.nombre,f.apellido, f.numdoc, TipoDocumento.BuscarPorId((int)f.fkDoc)));
                    }
                }
            }
            return resultados;
        }
        public static IQueryable BuscarIQ(string buscado)
        {
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eCliente
                        where
                         x.id > 0 &&
                        (x.nombre.ToLower().Contains(buscado) ||
                        x.apellido.ToLower().Contains(buscado) ||
                        x.numdoc.ToString().Contains(buscado) ||
                        x.eTipoDocumento.nombre.ToLower().Contains(buscado))

                        select new
                        {
                            Nombre = x.nombre.ToUpper() + " " + x.apellido.ToUpper(),
                            TipoDeDocumento = x.eTipoDocumento.nombre,
                            NumeroDeDocumento = x.numdoc
                        };
            return filas;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eCliente where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eCliente.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        private void CargarFilaCliente(eCliente p)
        {
            p.nombre = this.nombre;
            p.apellido = this.apellido;
            p.numdoc = this.numDoc;
            p.fkDoc = this.doc.Id;

        }
        public static bool BuscarPorIdDocumento(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eTipoDocumento where x.id == id select x).FirstOrDefault();
            if (f != null)
                return true;
            return false;
        }

    }
}
