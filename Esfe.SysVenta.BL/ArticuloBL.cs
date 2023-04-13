using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysVenta.DAL;
using Esfe.SysVenta.EN;

namespace Esfe.SysVenta.BL
{
    public class ArticuloBL
    {
        private ArticuloDAL oArticuloDAL = new ArticuloDAL();

        //ARTICULO
        public void AgregarArticulo(Articulo pArticulo)
        {
            oArticuloDAL.AgregarArticulo(pArticulo);
        }
        public List<Articulo> ObtenerArticulo()
        {
            return oArticuloDAL.ObtenerArticulo();
        }
    }
}
