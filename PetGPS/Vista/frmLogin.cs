using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGPS.Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "juan" && txtContrasenia.Text == "root123")
            {
                frmMenuPrincipal menu = new frmMenuPrincipal();
                menu.Show();
                this.Hide(); // Oculta el formulario de login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
