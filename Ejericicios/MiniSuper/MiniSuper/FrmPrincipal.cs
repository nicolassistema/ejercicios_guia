using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmPrincipal : Form
    {

       
        static int cantidad = 0;


    
        public FrmPrincipal()
        {
            InitializeComponent();

            //if (FrmPrincipal.cantidad == 0)
            //{
            //    FrmPrincipal.cantidad = 1;
            //    FrmPrincipal frm = new FrmPrincipal();
            //    frm.Show();
            //}
          
        }

        private void btnNuevoCLiente_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.Show();
        }

        private void btnNuevoCLiente_MouseClick(object sender, MouseEventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.Show();
        }

        private void btnNuevoCliente_Click_1(object sender, EventArgs e)
        {

        }
    }
}
