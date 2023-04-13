using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysVenta.EN;

namespace Esfe.SysVenta.DAL
{
    public class ArticuloDAL
    {
        public static List<Articulo> ListaArticulo = new List<Articulo>();

        public void AgregarArticulo(Articulo pArticulo)
        {
            pArticulo.IdArticulo = ListaArticulo.Select(x => x.IdArticulo).DefaultIfEmpty(0).Max() + 1;
            ListaArticulo.Add(pArticulo);
        }
        public List<Articulo> ObtenerArticulo()
        {
            return ListaArticulo;
        }

    }
}
