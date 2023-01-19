using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Clinica;
using Microsoft.SqlServer.Server;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> lstHabitaciones = new List<Habitacion>();

        public static List<Habitacion> Listar()
        {
            Habitaciones();
            return lstHabitaciones;
        }

        private static void Habitaciones()
        {
            lstHabitaciones.Add(new Habitacion()
            {
                ID = 1,
                Numero = "10",
                Estado = "Disponible"
            });

            lstHabitaciones.Add(new Habitacion()
            {
                ID = 2,
                Numero = "20",
                Estado = "Disponible"
            });

            lstHabitaciones.Add(new Habitacion()
            {
                ID = 3,
                Numero = "30",
                Estado = "Disponible"
            });

            lstHabitaciones.Add(new Habitacion()
            {
                ID = 4,
                Numero = "40",
                Estado = "Disponible"
            });

            lstHabitaciones.Add(new Habitacion()
            {
                ID = 5,
                Numero = "50",
                Estado = "Disponible"
            });
        }

        public static List<Habitacion> Listar(string estado)
        {
            //TODO - Falta Implementar
            return null;
        }

        public static int Insertar(Habitacion h)
        {
            //TODO - Falta Implementar
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO - Falta Implementar
            return 0;
        }

        public static Habitacion TraerUno(int id)
        {
            //TODO - Falta Implementar
            return null;
        }
    }
}
