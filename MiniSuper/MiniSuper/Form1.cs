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
    public partial class FrmAltaUsuario : Form
    {

        Usuario usuario;
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
            long dni;
            this.usuario = new Usuario(this.txtNombre.Text, this.txtApellido.Text, (long)this.numDni.Value);
            this.Close();
        }
    }
}
