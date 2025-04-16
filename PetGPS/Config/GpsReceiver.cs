using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetGPS.Config
{
    internal class GpsReceiver
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread listenThread;
        private bool isConnected = false;

        public event Action<string, string> OnGpsDataReceived;

        public bool EstaConectado => isConnected;

        public void Conectar(string ip, int puerto = 5000)
        {
            new Thread(() =>
            {
                while (!isConnected)
                {
                    try
                    {
                        client = new TcpClient();
                        client.Connect(ip, puerto);
                        stream = client.GetStream();
                        isConnected = true;

                        listenThread = new Thread(Escuchar);
                        listenThread.IsBackground = true;
                        listenThread.Start();

                        Console.WriteLine("Conectado al ESP32 en " + ip);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Esperando conexión... " + ex.Message);
                        Thread.Sleep(3000); // Reintento cada 3 segundos
                    }
                }
            }).Start();
        }

        private void Escuchar()
        {
            try
            {
                StreamReader reader = new StreamReader(stream, Encoding.ASCII);
                string lat = "", lon = "";

                while (isConnected)
                {
                    string linea = reader.ReadLine();
                    if (linea != null)
                    {
                        if (linea.StartsWith("Lat: "))
                            lat = linea.Substring(5);
                        else if (linea.StartsWith("Lon: "))
                        {
                            lon = linea.Substring(5);
                            OnGpsDataReceived?.Invoke(lat, lon);
                        }
                    }
                }
            }
            catch
            {
                isConnected = false;
                Console.WriteLine("Desconectado del ESP32.");
            }
        }

        public void Desconectar()
        {
            isConnected = false;

            try { stream?.Close(); } catch { }
            try { client?.Close(); } catch { }

            listenThread?.Join(500); // Esperar finalización limpia
        }
    }
}
