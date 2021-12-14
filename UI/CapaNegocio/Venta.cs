using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Venta
    {
        private int id;
        private Cliente cliente;
        private DateTime fecha;
        private double total;
        private List<Detalle_Venta> bo;
        private List<Detalle_Venta> dv;

        public int Id { get => id; set => id = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public double Total { get => total; set => total = value; }
        public List<Detalle_Venta> Bo { get => bo; set => bo = value; }
        public List<Detalle_Venta> Dv { get => dv; set => dv = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }


        public Venta(int id, Cliente cliente, double total, DateTime fecha)
        {
            this.id = id;
            this.cliente = cliente;
            this.total = total;
            this.fecha = fecha;
            this.dv = new List<Detalle_Venta>();
        }
        public Venta()
        {
            id = 0;
            cliente = null;
            total = 0;
            fecha = new DateTime(1990, 1, 1);
            dv = new List<Detalle_Venta>();
        }

        public static Venta BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eVenta where x.id == id select x).FirstOrDefault();
            Venta p = new Venta(f.id, Cliente.BuscarPorId((int)f.fkCliente), f.total, f.fecha);

            return p;
        }
        public override string ToString()
        {
            return " fecha: " + fecha + " Cliente : " + cliente + " Total:" + total;
        }
        public static List<Venta> Buscar(string buscado = "")
        {
            List<Venta> resultados = new List<Venta>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eVenta
                        where x.eCliente.nombre.ToLower().Contains(buscado) ||
                        x.fecha.ToString().Contains(buscado) ||
                        x.eCliente.apellido.ToLower().Contains(buscado) ||
                        x.total.ToString().Contains(buscado) ||
                        x.id.ToString().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new Venta(f.id, Cliente.BuscarPorId((int)f.fkCliente), f.total, f.fecha));
                }
            }

            return resultados;
        }
        private void CargarFilaVenta(eVenta p)
        {
            p.fkCliente = this.cliente.Id;
            p.fecha = this.fecha;
            p.total = this.total;
        }
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eVenta p = new eVenta();

            if (this.id == 0) //esto detecta que es un objeto nuevo
            {
                CargarFilaVenta(p);
                dc.eVenta.InsertOnSubmit(p);
                foreach (Detalle_Venta det in dv)
                {
                    det.Guardar(dc, p);
                }
            }
            else //este caso es para una fila que viene de la DB, id != 0
            {

                p = (from x in dc.eVenta where x.id == this.id select x).FirstOrDefault();
                CargarFilaVenta(p);
                foreach (Detalle_Venta detalleven in dv)
                {
                    detalleven.Guardar(dc, p);
                }
                if (this.bo != null && this.bo.Count > 0)
                {
                    foreach (var item in this.Bo)
                    {
                        item.Eliminar();
                    }
                    this.bo.Clear();
                }
            }

            dc.SubmitChanges();
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eVenta where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {

                var encd = (from x in dc.eDetalle_Venta where x.fkVenta == this.id select x);
                dc.eDetalle_Venta.DeleteAllOnSubmit(encd);

                dc.eVenta.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }

        public double CalcTotal()
        {
            double total = 0;
            foreach (Detalle_Venta d in dv)
            {
                total += d.Subtotal;
            }
            return total;
        }
        public void TraerDetalles()
        {
            if (this.id == 0)
            {
                return;
            }
            dv = new List<Detalle_Venta>();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eDetalle_Venta where x.id == this.id select x);
            if (enc != null)
            {
                foreach (var item in enc)
                {
                    this.dv.Add(new Detalle_Venta(item.id, item.cantidad, item.precioUni, this, Producto.BuscarPorId(item.fkProducto)));
                }
            }
        }
        public static bool BuscarPorIdCliente(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var f = (from x in dc.eVenta where x.id == id select x).FirstOrDefault();
            if (f != null)
                return true;
            return false;
        }

    }
}
