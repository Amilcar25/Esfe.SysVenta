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
using System.DirectoryServices.ActiveDirectory;

namespace Esfe.SysVenta.UI
{
    public partial class ArticuloWF : Form
    {

        ArticuloBL oArticuloBL = new ArticuloBL();
        Articulo oArticulo = new Articulo();
        public ArticuloWF()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombreArti.Text == "")
            {
                MessageBox.Show("Aún hay campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var articulo = new Articulo
            {
                NombreArticulo = txtNombreArti.Text,
                PrecioArticulo = Convert.ToDouble(txtPrecioUni.Value),
            };
            if (articulo != null)
            {
                oArticuloBL.AgregarArticulo(articulo);
                MessageBox.Show("Artículo guardado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreArti.Clear();
                txtPrecioUni.Value = txtPrecioUni.Minimum;
                //var articulos = oArticuloBL.ObtenerArticulo();
                //gridArticulos.DataSource = null;
                //gridArticulos.DataSource = articulos;

                //_main.gridDatosVentas.DataSource = null;
                //_main.gridDatosVentas.DataSource = ventas;
            }
            this.Close();
            //_main.Close();
        }
    }
}
