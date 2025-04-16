
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PetGPS.Vista
{
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }
        private void MostrarUbicacionDesdeTextBox()
        {

            try
            {
                decimal lat = decimal.Parse(txtLatitud.Text, CultureInfo.InvariantCulture);
                decimal lng = decimal.Parse(txtLongitud.Text, CultureInfo.InvariantCulture);

                if (lat < -90 || lat > 90 || lng < -180 || lng > 180)
                {
                    MessageBox.Show("Las coordenadas están fuera del rango válido.");
                    return;
                }

                PointLatLng punto = new PointLatLng((double)lat, (double)lng);

                // Establecer posición y zoom alto
                gmap.Position = punto;
                gmap.Zoom = 18; // Zoom cercano al punto

                // Limpiar marcadores anteriores
                gmap.Overlays.Clear();

                // Crear y agregar marcador
                GMapOverlay overlay = new GMapOverlay("marcadores");
                GMarkerGoogle marcador = new GMarkerGoogle(punto, GMarkerGoogleType.red_dot);
                overlay.Markers.Add(marcador);
                gmap.Overlays.Add(overlay);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido. Usa punto (.) como separador decimal.");
            }
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            gmap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            gmap.Position = new GMap.NET.PointLatLng(0, 0);
            gmap.MinZoom = 2;
            gmap.MaxZoom = 18;
            gmap.Zoom = 5;

            gmap.ShowCenter = false;
            gmap.DragButton = MouseButtons.Left;
            gmap.Bearing = 0;

        }

        private void btnIR_Click(object sender, EventArgs e)
        {
            MostrarUbicacionDesdeTextBox();
        }
    }
}
