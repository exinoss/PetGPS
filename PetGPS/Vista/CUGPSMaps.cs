using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Device.Location;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using PetGPS.Config;
using PetGPS.Controlador;

namespace PetGPS.Vista
{
    public partial class CUGPSMaps : UserControl
    {
        private GMapOverlay overlay;
        private GMarkerGoogle marcador;
        private GMapRoute ruta; // Para guardar la línea
        private bool primeraLecturaHome = false;
        private GMarkerGoogle marcadorHome;
        private bool gpsActivo = false;
        public CUGPSMaps()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void CalcularDistancia()
        {
            try
            {
                // Convertir coordenadas actuales
                if (double.TryParse(lbLatitud.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double lat2) &&
                    double.TryParse(lbLongitud.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double lon2))
                {
                    double lat1 = latitudRef;
                    double lon1 = longitudRef;

                    // ========================
                    // Fórmula Haversine
                    // ========================
                    double R = 6371000; // Radio de la Tierra en metros
                    double dLat = ToRadians(lat2 - lat1);
                    double dLon = ToRadians(lon2 - lon1);

                    double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                               Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                               Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
                    double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                    double distancia = R * c;

                    lbDistancia.Text = $"{Math.Round(distancia, 2)} m";

                    // ========================
                    // Comparar con rango ingresado
                    // ========================
                    if (double.TryParse(txtRango.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double rango))
                    {
                        if (distancia <= rango)
                        {
                            lbAlerta.Text = "ESTÁ EN RANGO";
                            lbAlerta.ForeColor = Color.Black;
                        }
                        else
                        {
                            lbAlerta.Text = "⚠️ ALERTA MASCOTA";
                            lbAlerta.ForeColor = Color.Red;
                        }
                    }

                    // ========================
                    // Dibujar línea de ruta
                    // ========================
                    PointLatLng punto1 = new PointLatLng(lat1, lon1);
                    PointLatLng punto2 = new PointLatLng(lat2, lon2);

                    if (ruta != null)
                        overlay.Routes.Remove(ruta);

                    List<PointLatLng> puntosRuta = new List<PointLatLng> { punto1, punto2 };
                    ruta = new GMapRoute(puntosRuta, "Ruta GPS");
                    ruta.Stroke = new Pen(Color.Blue, 2);

                    overlay.Routes.Add(ruta);
                    gmap.Refresh();
                }
                else
                {
                    lbDistancia.Text = "Coordenadas inválidas.";
                }
            }
            catch (Exception ex)
            {
                lbDistancia.Text = "Error: " + ex.Message;
            }
        }

        private double ToRadians(double grados)
        {
            return grados * Math.PI / 180;
        }

        private void CUGPSMaps_Load(object sender, EventArgs e)
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

            overlay = new GMapOverlay("marcadores");
            gmap.Overlays.Add(overlay);
            btnIniciar.Enabled = false;
            btnDetener.Enabled = false;
            btnHome.Enabled = true;
        }
        GpsReceiver receptor = new GpsReceiver();
        private void ConectarESP()
        {
            receptor.OnGpsDataReceived += (lat, lon) =>
            {
                Invoke(new Action(() =>
                {
                    lbLatitud.Text = lat;
                    lbLongitud.Text = lon;
                    MostrarUbicacionDesdeTextBox(); // Actualizar mapa automáticamente
                    CalcularDistancia();
                }));
            };

            Task.Run(() =>
            {
                receptor.Conectar("192.168.100.200", 5000);
                Invoke(new Action(() =>
                {
                    estadoConexion = receptor.EstaConectado ? true : false;
                    Console.WriteLine("Estado conexion: "+estadoConexion);
                }));
            });
        }
        bool estadoConexion;
        private void MostrarUbicacionDesdeTextBox()
        {
            try
            {
                if (decimal.TryParse(lbLatitud.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal lat) &&
                    decimal.TryParse(lbLongitud.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal lon))
                {
                    if (lat < -90 || lat > 90 || lon < -180 || lon > 180)
                    {
                        MessageBox.Show("Las coordenadas están fuera del rango válido.");
                        return;
                    }

                    PointLatLng punto = new PointLatLng((double)lat, (double)lon);
                    gmap.Position = punto;
                    gmap.Zoom = 18;

                    // Mover marcador único o crearlo si no existe
                    if (marcador == null)
                    {
                        marcador = new GMarkerGoogle(punto, GMarkerGoogleType.red_dot);
                        overlay.Markers.Add(marcador);
                    }
                    else
                    {
                        marcador.Position = punto;
                    }
                }
                else
                {
                    MessageBox.Show("Formato inválido. Usa punto (.) como separador decimal.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar ubicación: " + ex.Message);
            }
        }
        private void DesconectarESP()
        {
            gpsActivo = false;
            receptor.Desconectar();
            lbLatitud.Text = "";
            lbLongitud.Text = "";
        }
        double latitudRef,longitudRef;

        private void btnZoomP_Click(object sender, EventArgs e)
        {
            if (gmap.Zoom < gmap.MaxZoom)
            {
                gmap.Zoom += 1;
            }
        }

        private void btnZoomN_Click(object sender, EventArgs e)
        {
            if (gmap.Zoom > gmap.MinZoom)
            {
                gmap.Zoom -= 1;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!gpsActivo)
            {
                gpsActivo = true;

                receptor.OnGpsDataReceived += (lat, lon) =>
                {
                    Invoke(new Action(() =>
                    {
                        lbLatitud.Text = lat;
                        lbLongitud.Text = lon;
                        MostrarUbicacionDesdeTextBox();
                        CalcularDistancia();
                    }));
                };

                Task.Run(() =>
                {
                    receptor.Conectar("192.168.100.200", 5000);
                });
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            DesconectarESP();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRango.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double rango) || rango <= 5)
            {
                MessageBox.Show("Ingrese un valor de rango válido mayor a 5 metros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!primeraLecturaHome)
            {
                receptor.OnGpsDataReceived += GuardarHomeDesdeGPS;

                Task.Run(() =>
                {
                    receptor.Conectar("192.168.100.200", 5000);
                    Invoke(new Action(() =>
                    {
                        estadoConexion = receptor.EstaConectado;
                    }));
                });
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardarRango_Click(object sender, EventArgs e)
        {

        }

        private void GuardarHomeDesdeGPS(string lat, string lon)
        {
            if (primeraLecturaHome) return;

            Invoke(new Action(() =>
            {
                if (double.TryParse(lat, NumberStyles.Any, CultureInfo.InvariantCulture, out double latH) &&
                    double.TryParse(lon, NumberStyles.Any, CultureInfo.InvariantCulture, out double lonH) &&
                    double.TryParse(txtRango.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double rango))
                {
                    latitudRef = latH;
                    longitudRef = lonH;
                    /*
                    // Guardar en la BD
                    cllRastreo rastreo = new cllRastreo
                    {
                        fecha_hora = DateTime.Now,
                        latitud = lat,
                        longitud = lon,
                        ID_dispositivo = 1,
                        Rango = rango
                    };
                    rastreo.Insertar();
                    */
                    // Marcador azul en el mapa
                    PointLatLng punto = new PointLatLng(latitudRef, longitudRef);
                    marcadorHome = new GMarkerGoogle(punto, GMarkerGoogleType.blue_dot);
                    overlay.Markers.Add(marcadorHome);
                    gmap.Position = punto;
                    gmap.Zoom = 18;

                    primeraLecturaHome = true;
                    btnHome.Enabled = false;
                    btnIniciar.Enabled = true;
                    btnDetener.Enabled = true;

                    receptor.OnGpsDataReceived -= GuardarHomeDesdeGPS;
                    receptor.Desconectar();
                }
            }));
        }

    }
}
