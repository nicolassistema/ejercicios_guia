using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            if (txtCotizacionDolar.Text != "1")
            {
                txtCotizacionDolar.Text = "1";
            }
        }

     
    }
}
