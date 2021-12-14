using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public class Detalle_Venta
    {
        #region VM
        private int id;
        private int cantidad;
        private double precioUni;
        private Venta venta;
        private Producto productos;

        #endregion

        #region Properties
        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
       
        [Browsable(false)]
        public Venta Venta { get => venta; set => venta = value; }
        public Producto Productos { get => productos; set => productos = value; }
        public double Subtotal { get => PrecioUni * cantidad; }
        public double PrecioUni { get => precioUni; set => precioUni = value; }
        #endregion

        #region Builders
        public Detalle_Venta(int id, int cantidad, double precioUni, Venta venta, Producto productos)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.PrecioUni = precioUni;
            this.venta = venta;
            this.productos = productos;
        }
        public Detalle_Venta()
        {
            id = 0;
            cantidad = 0;
            PrecioUni = 0;
            venta = null;
            this.productos = null;
        }
        #endregion

        #region Methods
        public void Guardar(DCDataContext dcOriginal, eVenta ev)
        {
            DCDataContext dc = dcOriginal;

            eDetalle_Venta p = new eDetalle_Venta();

            if (this.id == 0) //esto detecta que es un objeto nuevo
            {
                p.cantidad = this.cantidad;
                p.id = this.id;
                p.fkProducto = this.productos.Id;
                p.precioUni = this.PrecioUni;
                p.eVenta = ev;

                dc.eDetalle_Venta.InsertOnSubmit(p);
            }
            else //este caso es para una fila que viene de la DB, id != 0
            {
                p = (from x in dc.eDetalle_Venta where x.id == this.id select x).FirstOrDefault();

                p.cantidad = this.cantidad;
                p.id = this.id;
                p.fkProducto = this.productos.Id;
                p.precioUni = this.PrecioUni;
                p.fkVenta = this.venta.Id;
            }
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eDetalle_Venta where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eDetalle_Venta.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        #endregion
    }
}

