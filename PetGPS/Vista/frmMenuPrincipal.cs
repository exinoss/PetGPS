using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetGPS.Vista;

namespace PetGPS
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGPSMap_Click(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();
            CUGPSMaps controlGPS = new CUGPSMaps();
            controlGPS.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(controlGPS);
        }
    }
}
