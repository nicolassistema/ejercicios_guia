using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Conversor
{
    public partial class frmPrincipal : Form
    {
    
        private bool locked;

        public frmPrincipal()
        {
            InitializeComponent();
            locked = false;
        

        }
      


        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
          //  if (!(String.IsNullOrWhiteSpace(txtCotizacionEuro.Text)) && !(String.IsNullOrWhiteSpace(txtCotizacionPeso.Text)) && !(String.IsNullOrWhiteSpace(txtCotizacionDolar.Text)) && !locked)
                if (!locked)

                {
                if (!locked)
                {
                    btnLockCotizacion.ImageIndex = 1;
                    txtCotizacionEuro.Enabled = false;
                    txtCotizacionPeso.Enabled = false;
                    txtCotizacionDolar.Enabled = false;
                }
                else
                {
                    btnLockCotizacion.ImageIndex = 0;
                    txtCotizacionEuro.Enabled = true;
                    txtCotizacionPeso.Enabled = true;
                    txtCotizacionDolar.Enabled = true;
                }
                locked = !locked;
            }
            else
            {
                MessageBox.Show("Debe completar los 3 campos para poder bloquearlos", "Error", MessageBoxButtons.OK);
            }
          
        }

        private void btnCovertEuro_Click(object sender, EventArgs e)
        {

            if (Double.TryParse(txtEuro.Text, out double montoEntrada))
            {
                Euro euro = new Euro(montoEntrada);
                Euro.SetCotizacion(double.Parse(txtCotizacionEuro.Text));
                ((Pesos)euro).GetCantidad();//Esto esta de mas pero sino lo pongo, al primer click aparece en 0, en el segundo click aparece el resultado correcto
                txtEuroAPeso.Text = ((Pesos)euro).GetCantidad().ToString();
                txtEuroAEuro.Text = euro.GetCantidad().ToString();
                txtEuroADolar.Text =((Dolar)euro).GetCantidad().ToString();
            }
        }

        private void btnCovertDolar_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtDolar.Text, out double equivalenteEuro))
            {
                Dolar.SetCotizacion(equivalenteEuro);
                Dolar dolar = new Dolar(equivalenteEuro);
                ((Euro)dolar).GetCantidad();
                txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
                txtDolarAPeso.Text = ((Pesos)dolar).GetCantidad().ToString();
                txtDolarADolar.Text = dolar.GetCantidad().ToString();

            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtPeso.Text, out double equivalenteEuro))
            {
                //Pesos.SetCotizacion(equivalenteEuro);
                Pesos peso = new Pesos(equivalenteEuro);
                ((Euro)peso).GetCantidad();
                txtPesoAEuro.Text = ((Euro)peso).GetCantidad().ToString();
                txtPesoADolar.Text = ((Dolar)peso).GetCantidad().ToString();
                txtPesoAPeso.Text = peso.GetCantidad().ToString();

            }
        }

        
        static bool ValidaNum(string strInt)
        {
            string str = strInt;
            char[] arr = str.ToCharArray();
            int contador = 0;
            //valido que no tena mas de punto, un punto y una coma, una coma y un punto
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '.' || arr[i] == ',')
                {
                    contador++;
                    if (contador > 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        static  string PuntoToComa(string strInt)
        {
            string str = strInt;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '.')
                {
                    arr[i] = ',';
                    break;
                }
            }
            strInt = new string(arr);

            return strInt;
        }




        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {

            if (ValidaNum(txtCotizacionEuro.Text))
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtCotizacionEuro.Focus();
            }

            if (Double.TryParse(txtCotizacionEuro.Text, out double equivalenteEuro))
            {
               txtCotizacionEuro.Text = PuntoToComa(txtCotizacionEuro.Text);
            }
            else
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            if (ValidaNum(txtCotizacionDolar.Text))
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtCotizacionEuro.Focus();
            }

            if (Double.TryParse(txtCotizacionDolar.Text, out double equivalenteEuro))
            {
                txtCotizacionDolar.Text = PuntoToComa(txtCotizacionDolar.Text);
            }
            else
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtCotizacionDolar.Focus();
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            if (ValidaNum(txtCotizacionPeso.Text))
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtCotizacionPeso.Focus();
            }

            if (Double.TryParse(txtCotizacionPeso.Text, out double equivalenteEuro))
            {
                txtCotizacionPeso.Text = PuntoToComa(txtCotizacionPeso.Text);
            }
            else
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtCotizacionPeso.Focus();
            }
        }

        private void txtEuro_Leave(object sender, EventArgs e)
        {

            if (ValidaNum(txtEuro.Text))
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtEuro.Focus();
            }

            if (Double.TryParse(txtEuro.Text, out double equivalenteEuro))
            {
                txtEuro.Text = PuntoToComa(txtEuro.Text);
            }
            else
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtEuro.Focus();
            }
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            if (ValidaNum(txtDolar.Text))
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtDolar.Focus();
            }

            if (Double.TryParse(txtDolar.Text, out double equivalenteEuro))
            {
                txtDolar.Text = PuntoToComa(txtDolar.Text);
            }
            else
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtDolar.Focus();
            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (ValidaNum(txtPeso.Text))
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtPeso.Focus();
            }

            if (Double.TryParse(txtPeso.Text, out double equivalenteEuro))
            {
                txtPeso.Text = PuntoToComa(txtPeso.Text);
            }
            else
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK);
                txtPeso.Focus();
            }
        }
    }
}
