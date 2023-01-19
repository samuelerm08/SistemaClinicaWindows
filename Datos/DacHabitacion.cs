using Entidades.Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clinica;

namespace Datos
{
    public static class DacHabitacion
    {
        private static readonly DbClinicaContext context = new DbClinicaContext();
        public static List<Habitacion> SelectAll()
        {
            return context.Habitaciones.ToList();
        }

        public static List<Habitacion> Select(string estado)
        {
            return context.Habitaciones.Where(i => i.Estado == estado).ToList();
        }

        public static Habitacion SelectById(int id)
        {
            return context.Habitaciones.Find(id);
        }

        public static int Insert(Habitacion h)
        {
            context.Habitaciones.Add(h);
            return context.SaveChanges();
        }

        public static int Update(Habitacion h)
        {
            Habitacion nuevaHab = context.Habitaciones.Find(h.ID);

            nuevaHab.Estado = h.Estado;
            nuevaHab.Numero = h.Numero;

            return context.SaveChanges();
        }

        public static int Delete(Habitacion h)
        {
            Habitacion habitacionBorrar = context.Habitaciones.Find(h.ID);

            if (habitacionBorrar != null)
            {
                context.Habitaciones.Remove(habitacionBorrar);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
