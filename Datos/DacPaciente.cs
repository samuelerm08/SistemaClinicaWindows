﻿using Entidades.Data;
using Entidades;
using Entidades.Clinica;
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

        //Metodos operaciones
        public static List<Paciente> SelectAll()
        {
            var query = (from p in context.Pacientes
                         join m in context.Medicos on p.MedicoId equals m.ID
                         join h in context.Habitaciones on p.HabitacionId equals h.ID
                         select new { p, m, h });

            var list = new List<Paciente>();

            foreach (var item in query)
            {
                list.Add(new Paciente()
                {
                    ID = item.p.ID,
                    Nombre = item.p.Nombre,
                    Apellido = item.p.Apellido,
                    Domicilio = item.p.Domicilio,
                    Telefono = item.p.Telefono,
                    Email = item.p.Email,
                    NroHistoriaClinica = item.p.NroHistoriaClinica,
                    MedicoId = item.m.ID,
                    Medico = new Medico() { Nombre = item.m.Nombre },
                    HabitacionId = item.h.ID,
                    Habitacion = new Habitacion() { Numero = item.h.Numero }
                });
            }

            return list;
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
