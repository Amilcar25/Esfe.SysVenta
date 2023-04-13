using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysVenta.DAL;
using Esfe.SysVenta.EN;


namespace Esfe.SysVenta.BL
{
    public class VentaBL
    {
        public VentaDAL oVentaDAL = new VentaDAL();

        public void postVenta(Venta venta)
        {
            
            oVentaDAL.postVenta(venta);
        }

        public void deleteVenta(int id)
        {
            oVentaDAL.deleteVenta(id);  
        }
        public void putVenta(Venta cambios)
        {
            oVentaDAL.putVenta(cambios);
        }
        public List<Venta> getVenta()
        {
            return oVentaDAL.getVentas();
        }
        
    }
}
