﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formulario_Jardin
{
    public partial class FrmPrincipal : Form
    {

        Jardin jardin;


        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void btnVerDatos_Click(object sender, EventArgs e)
        {

            rtbSalidaDeTest.Text = jardin.ToString();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.jardin = new Jardin(100);
            bool pudo = this.jardin + new Arbusto("Arbusto 1", 10);
            pudo = this.jardin + new Arbusto("Arbusto 2", 15);
            pudo = this.jardin + new Rosal("Rosa 1", 20, Rosal.Color.Amarilla);
            pudo = this.jardin + new Rosal("Rosa clásica", 25);
           // pudo = this.jardin + new Bananno("Banano ecuador", 30, "ECU001");
            if (!(this.jardin + new Bananno("No carga", 1, "ARG028")))
            {
                MessageBox.Show("Error!");
             //   Console.WriteLine("ERROR!");
            }

        }
    }
}
