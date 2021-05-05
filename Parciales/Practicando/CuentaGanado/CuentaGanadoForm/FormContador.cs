using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CuentaGanadoForm
{
    public partial class FormContador : Form
    {
        Bar bar;
        Random random = new Random();
        decimal empleados = 0;
        decimal gente = 0;

        public FormContador()
        {
            InitializeComponent();
            bar = Bar.GetBar();
            this.numericUpDownEmpleados.ReadOnly = true;
            this.numericUpDownGente.ReadOnly = true;

        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormDatos datos = new FormDatos(this.bar.ToString());
            datos.ShowDialog();

            //datos.CargarDatos = "Wachin";

            //richTxt.Text = this.bar.ToString();
        }

        private void numericUpDownEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownEmpleados.Value > empleados)
            {
                #region parte 1 
                //bool agregar = this.bar + new Empleado((short)random.Next(18, 30), "Denu");
                //if (agregar)
                //{
                //    this.empleados++;
                //    MessageBox.Show($"Se agregó al empleado");
                //}

                #endregion

                CargarDatos formCargaDatos = new CargarDatos();

                formCargaDatos.Nombre = "pepito";

                DialogResult resultado = formCargaDatos.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    string nombre = formCargaDatos.Nombre;
                    string edad = formCargaDatos.Edad;
                    string dni = formCargaDatos.Dni;

                    if (this.bar + new Empleado(short.Parse(edad), nombre, int.Parse(dni)))
                    {
                        this.dataGridView.DataSource = null;
                        this.dataGridView.DataSource = bar.Empleados;

                        this.empleados++;
                        MessageBox.Show($"Se agregó al empleado nro {empleados}");
                    }
                }
                else if (resultado == DialogResult.Cancel)
                {
                    MessageBox.Show($"Aca no paso nada");

                }

            }

            else
            {
                if (empleados > 0)
                {
                    if (this.bar.Empleados.Count > 0)
                    {
                        this.bar.Empleados.RemoveAt(bar.Empleados.Count - 1);
                        MessageBox.Show("Se borró al empleado");
                        this.empleados--;
                    }
                }
            }

        }



     

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownGente_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownGente.Value > gente)
            {
                bool agregar = this.bar + new Gente((short)random.Next(18, 30));
                if (agregar)
                {
                    this.gente++;
                    MessageBox.Show($"Se agregó gente");
                }
            }
            else
            {
                if (bar.Gente.Count > 0)
                {
                    this.bar.Gente.RemoveAt(0);
                    this.gente--;
                }
                MessageBox.Show("Se borró gente");
            }
        }

      
    }
}
