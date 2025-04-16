using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetGPS.Config
{
    internal class csConexion
    {
        private readonly string cadenaConexion = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=PetGPSBD";

        public NpgsqlConnection Conectar()
        {
            NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al conectar a PostgreSQL: " + ex.Message);
            }
            return conexion;
        }

        public void Desconectar(NpgsqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}
