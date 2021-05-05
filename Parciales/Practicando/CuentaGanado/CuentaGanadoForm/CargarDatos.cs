using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class CargarDatos : Form
    {

        public CargarDatos()
        {
            InitializeComponent();

        }

        public string Dni
        {
            get { return this.txtDni.Text; }
        }

        public string Nombre
        {
            get { return this.txtNombre.Text; }
            set { this.txtNombre.Text = value; }
        }

        public string Edad
        {
            get { return this.txtEdad.Text; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtNombre.Text.Trim()))
            {
                MessageBox.Show("Nombre no valido");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void CargarDatos_Load(object sender, EventArgs e)
        {

        }

    }
}
