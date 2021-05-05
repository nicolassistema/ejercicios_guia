﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bilbioteca;

namespace FormCampo
{
    public partial class FrmPrincipal : Form
    {
        Campo campo;
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            rtbSalidaDeTest.Text = campo.ToString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.campo = new Campo(1500);
            campo.TipoServicio = Campo.Tipo.Pastoreo;
            bool pudo = this.campo + new Cerdo("Pegy", 300);
            pudo = this.campo + new Cerdo("Babe", 250);
            pudo = this.campo + new Vaca("Rosalinda", 450, Vaca.Clasificacion.Lechera);
            pudo = this.campo + new Vaca("Lola", 325);
            pudo = this.campo + new Caballo("Secretariat", 175, true);
            if (!(this.campo + new Caballo("BoJack", 1, false)))
            {
                Console.WriteLine("ERROR!");
            }

        }


    }
}
