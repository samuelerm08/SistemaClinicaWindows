using Entidades.Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net.Http.Headers;

namespace Datos
{
    public static class DacPaciente
    {
        private static readonly DbClinicaContext context = new DbClinicaContext();


        public static List<Paciente> SelectAll()
        {
            return context.Pacientes.ToList();
        }

        public static Paciente Select(int nroHistoriaClinica)
        {
           return context.Pacientes.FirstOrDefault(x => x.NroHistoriaClinica == nroHistoriaClinica);
        }       

        public static int Insert(Paciente p)
        {
            context.Pacientes.Add(p);
            return context.SaveChanges();
        }

        public static int Update(Paciente p)
        {
            Paciente pacienteNuevo = context.Pacientes.Find(p.ID);

            pacienteNuevo.Nombre = p.Nombre;
            pacienteNuevo.Apellido = p.Apellido;
            pacienteNuevo.Telefono = p.Telefono;
            pacienteNuevo.NroHistoriaClinica = p.NroHistoriaClinica;
            pacienteNuevo.Email = p.Email;
            pacienteNuevo.Domicilio = p.Domicilio;
            pacienteNuevo.MedicoId = p.MedicoId;
            pacienteNuevo.HabitacionId = p.HabitacionId;

            return context.SaveChanges();
        }

        public static int Delete(Paciente p)
        {
            Paciente pacienteBorrar = context.Pacientes.Find(p.ID);

            if (pacienteBorrar != null)
            {
                context.Pacientes.Remove(pacienteBorrar);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
