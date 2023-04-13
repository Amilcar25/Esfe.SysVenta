using Esfe.SysVenta.EN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysVenta.BL;

namespace Esfe.SysVenta.UI
{
    public partial class PrincipalWF : Form
    {
        public PrincipalWF()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWf pMainWF = new MainWf();
            pMainWF.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloWF pArticulo = new ArticuloWF();
            pArticulo.ShowDialog();

        }
    }
}
