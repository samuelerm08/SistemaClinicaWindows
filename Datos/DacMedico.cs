using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Data;
using Microsoft.SqlServer.Server;

namespace Datos
{
    public static class DacMedico
    {
        private static readonly DbClinicaContext context = new DbClinicaContext();
        public static List<Medico> SelectAll()
        {
            return context.Medicos.ToList();
        }

        public static List<Medico> Select(string especialidad)
        {
            return context.Medicos.Where(i => i.Especialidad == especialidad).ToList();
        }

        public static Medico SelectById(int id)
        {
            return context.Medicos.Find(id);
        }

        public static int Insert(Medico m)
        {
            context.Medicos.Add(m);
            return context.SaveChanges();
        }

        public static int Update(Medico m)
        {
            Medico medicoNuevo = context.Medicos.Find(m.ID);

            medicoNuevo.Nombre = m.Nombre;
            medicoNuevo.Apellido = m.Apellido;
            medicoNuevo.Telefono = m.Telefono;
            medicoNuevo.Email = m.Email;
            medicoNuevo.Matricula = m.Matricula;
            medicoNuevo.Domicilio = m.Domicilio;
            medicoNuevo.Especialidad = m.Especialidad;

            return context.SaveChanges();
        }

        public static int Delete(Medico m)
        {
            Medico medicoBorrar = context.Medicos.Find(m.ID);

            if (medicoBorrar != null)
            {
                context.Medicos.Remove(medicoBorrar);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
