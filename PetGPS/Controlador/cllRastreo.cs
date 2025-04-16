using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetGPS.Modelo;

namespace PetGPS.Controlador
{
    internal class cllRastreo
    {
        public int ID_rastreo { get; set; }
        public DateTime fecha_hora { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public int ID_dispositivo { get; set; }
        public double Rango { get; set; }

        public bool Insertar()
        {
            csRastreo cs = new csRastreo();
            return cs.Insertar(this);
        }

        public bool Actualizar()
        {
            csRastreo cs = new csRastreo();
            return cs.Actualizar(this);
        }

        public bool Eliminar()
        {
            csRastreo cs = new csRastreo();
            return cs.Eliminar(ID_rastreo);
        }

        public DataTable Listar()
        {
            csRastreo cs = new csRastreo();
            return cs.Listar();
        }
    }
}
