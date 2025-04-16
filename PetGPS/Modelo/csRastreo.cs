using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using PetGPS.Config;
using PetGPS.Controlador;

namespace PetGPS.Modelo
{
    internal class csRastreo
    {
        private readonly csConexion conexion = new csConexion();

        public bool Insertar(cllRastreo obj)
        {
            var conn = conexion.Conectar();
            try
            {
                using (var cmd = new NpgsqlCommand("sp_insertar_rastreo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("_fecha_hora", NpgsqlDbType.Timestamp).Value = obj.fecha_hora;
                    cmd.Parameters.Add("_latitud", NpgsqlDbType.Text).Value = obj.latitud;
                    cmd.Parameters.Add("_longitud", NpgsqlDbType.Text).Value = obj.longitud;
                    cmd.Parameters.Add("_ID_dispositivo", NpgsqlDbType.Integer).Value = obj.ID_dispositivo;
                    cmd.Parameters.Add("_Rango", NpgsqlDbType.Double).Value = obj.Rango;

                    return (bool)cmd.ExecuteScalar();
                }
            }
            finally
            {
                conexion.Desconectar(conn);
            }
        }

        public bool Actualizar(cllRastreo obj)
        {
            var conn = conexion.Conectar();
            try
            {
                using (var cmd = new NpgsqlCommand("sp_actualizar_rastreo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_ID_rastreo", obj.ID_rastreo);
                    cmd.Parameters.AddWithValue("_fecha_hora", obj.fecha_hora);
                    cmd.Parameters.AddWithValue("_latitud", obj.latitud);
                    cmd.Parameters.AddWithValue("_longitud", obj.longitud);
                    cmd.Parameters.AddWithValue("_ID_dispositivo", obj.ID_dispositivo);
                    cmd.Parameters.AddWithValue("_Rango", obj.Rango);
                    return (bool)cmd.ExecuteScalar();
                }
            }
            finally
            {
                conexion.Desconectar(conn);
            }
        }

        public bool Eliminar(int id)
        {
            var conn = conexion.Conectar();
            try
            {
                using (var cmd = new NpgsqlCommand("sp_eliminar_rastreo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_ID_rastreo", id);
                    return (bool)cmd.ExecuteScalar();
                }
            }
            finally
            {
                conexion.Desconectar(conn);
            }
        }

        public DataTable Listar()
        {
            var conn = conexion.Conectar();
            try
            {
                using (var cmd = new NpgsqlCommand("sp_listar_rastreo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            finally
            {
                conexion.Desconectar(conn);
            }
        }
    }
}
