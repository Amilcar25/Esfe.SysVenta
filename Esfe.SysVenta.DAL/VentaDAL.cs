using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysVenta.EN;

namespace Esfe.SysVenta.DAL
{
    public class VentaDAL


    {
        public static List<Venta> ListaVenta = new List<Venta>();

        public void postVenta(Venta venta)
        {
            venta.Id = ListaVenta.Select(x => x.Id).DefaultIfEmpty(0).Max() + 1;

            //● Si la cantidad de artículos es igual o menor a 5 artículos se le aplicará el 10 % de
            //descuento.
            //● Si la cantidad de artículos es mayo a 5 y menor o igual a 10 artículos se le aplicará
            //el 15 % de descuento.
            //● Si la cantidad de artículos es mayo a 10 artículos se le aplicará el 20 % de
            //descuento.
            //● Se deberá calcular el total a pagar y el total de descuento de la compra del cliente

            double descuento = 0;
            double totalSinDescuento;

            if (venta.Cantidad <= 5)
                descuento = .10;
            else if (venta.Cantidad > 5 && venta.Cantidad <= 10)
                descuento = .15;
            else if (venta.Cantidad > 10)
                descuento = .20;

            totalSinDescuento = (venta.Cantidad * venta.PrecioUnit);
            venta.Descuento = Math.Round(totalSinDescuento * descuento);

            venta.VentaTotal = totalSinDescuento - venta.Descuento;
            ListaVenta.Add(venta);
        }
        public void deleteVenta(int id)
        {
            var tarea = ListaVenta.FirstOrDefault(V => V.Id == id);

            if(tarea != null)
            {
                ListaVenta.Remove(tarea);
            }
        }

        public void putVenta(Venta cambios)
        {
            var venta = ListaVenta.FirstOrDefault(V => V.Id == cambios.Id);


            if (venta != null)
            {
                venta.Nombre = cambios.Nombre;
                venta.Direccion = cambios.Direccion;
                venta.Descripcion = cambios.Descripcion;
                venta.Cantidad = cambios.Cantidad;
                venta.Descuento = cambios.Descuento;
                venta.Telefono = cambios.Telefono;
                venta.VentaTotal = cambios.VentaTotal;
                venta.PrecioUnit = cambios.PrecioUnit;
            }
        }

        public List<Venta> getVentas()
        {
            return ListaVenta;
        }

    }
}
