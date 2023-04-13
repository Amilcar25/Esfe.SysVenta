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

namespace Esfe.SysVenta.UI
{
    public partial class VentaWF : Form
    {
        VentaBL oVentaBL = new VentaBL();
        ArticuloBL oArticuloBL = new ArticuloBL();
        Venta oVenta = new Venta();


        MainWf _main;

        public VentaWF(MainWf main)
        {
            InitializeComponent();
            _main = main;
            var articulos = oArticuloBL.ObtenerArticulo();
            txtDescripcion.DataSource = null;
            foreach (var i in articulos)
            {
                var name = i.NombreArticulo;
                txtDescripcion.Items.Add(name);
            }
            

        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarVeta_Click(object sender, EventArgs e)
        {
            if(txtDescripcion.Items.Count > 0)
            {
                if (txtDireccion.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Aún hay campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var venta = new Venta
                {


                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text),
                    Descripcion = txtDescripcion.Text,
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    PrecioUnit = Convert.ToDouble(txtPrecio.Text),


                };
                if (venta != null)
                {
                    MessageBox.Show("Los datos se guardaron con exito","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oVentaBL.postVenta(venta);
                    var ventas = oVentaBL.getVenta();
                    _main.gridDatosVentas.DataSource = null;
                    _main.gridDatosVentas.DataSource = ventas;
                }
                _main.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay productos que vender. Por favor compre dichos productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var ArticuloView = new ArticuloWF();
                ArticuloView.Show();
                this.Close();
            }
                
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solamente permite ingresar letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros ni caracteres especiales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        //private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //solamete permite ingresar numeros 
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        MessageBox.Show("Solo se permiten numeros para establecer el precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;
        //    }
        //    //solamete permite ingresar un caracter especial " . " 

        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite ingresar numeros enteros sin caracteres especiales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("No se permite letras ni caracteres especiales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }


        }


        private void txtDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var articulos = oArticuloBL.ObtenerArticulo();
            int idx = txtDescripcion.SelectedIndex;
            txtPrecio.Value = Convert.ToDecimal(articulos[idx].PrecioArticulo);
        }

        //private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //permite ingresar numeros enteros para la cantidad
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        MessageBox.Show("Solo se permiten numeros para la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;
        //    }


        //}
    }
}
