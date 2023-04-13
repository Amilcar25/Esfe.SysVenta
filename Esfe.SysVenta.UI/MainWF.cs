using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysVenta.EN;
using Esfe.SysVenta.BL;
using System.Security.Cryptography.X509Certificates;

namespace Esfe.SysVenta.UI
{
    public partial class MainWf : Form
    {
        VentaBL oVentaBL = new VentaBL();
        Venta oVenta = new Venta();



        public MainWf()
        {
            InitializeComponent();
            var ventas = oVentaBL.getVenta();
            gridDatosVentas.AutoGenerateColumns = false;
            gridDatosVentas.ColumnCount = 8;

            gridDatosVentas.Columns[0].Name = "Cliente";
            gridDatosVentas.Columns[0].DataPropertyName = "Nombre";
            gridDatosVentas.Columns[0].Width = 150;

            gridDatosVentas.Columns[1].Name = "Dirección";
            gridDatosVentas.Columns[1].DataPropertyName = "Direccion";
            gridDatosVentas.Columns[1].Width = 200;

            gridDatosVentas.Columns[2].Name = "Teléfono";
            gridDatosVentas.Columns[2].DataPropertyName = "Telefono";
            gridDatosVentas.Columns[2].Width = 80;

            gridDatosVentas.Columns[3].Name = "Descripción del articulo";
            gridDatosVentas.Columns[3].DataPropertyName = "Descripcion";
            gridDatosVentas.Columns[3].Width = 200;

            gridDatosVentas.Columns[4].Name = "Catidad";
            gridDatosVentas.Columns[4].DataPropertyName = "Cantidad";
            gridDatosVentas.Columns[4].Width = 54;

            gridDatosVentas.Columns[5].Name = "Precio/u";
            gridDatosVentas.Columns[5].DataPropertyName = "PrecioUnit";
            gridDatosVentas.Columns[5].Width = 54;

            gridDatosVentas.Columns[6].Name = "Descuento";
            gridDatosVentas.Columns[6].DataPropertyName = "Descuento";
            gridDatosVentas.Columns[6].Width = 54;

            gridDatosVentas.Columns[7].Name = "Venta Total";
            gridDatosVentas.Columns[7].DataPropertyName = "VentaTotal";
            gridDatosVentas.Columns[7].Width = 54;



            gridDatosVentas.DataSource = ventas;

        }
        private void addVenta_Click(object sender, EventArgs e)
        {
            VentaWF oVentaWF = new VentaWF(this);
            oVentaWF.Show();
        }
    }
}
