using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> lstPacientes = new List<Paciente>();

        public static List<Paciente> Listar()
        {
            Pacientes();

            return lstPacientes;
        }

        private static void Pacientes()
        {
            lstPacientes.Add(new Paciente()
            {
                ID = 1,
                Nombre = "Samuel",
                Apellido = "Rivera",
                Domicilio = "CABA",
                Email = "email@email.com",
                NroHistoriaClinica = 2234,
                Telefono = "11 2323-3232"
            });

            lstPacientes.Add(new Paciente()
            {
                ID = 2,
                Nombre = "Alexis",
                Apellido = "Fernandez",
                Domicilio = "CABA",
                Email = "email@email.com",
                NroHistoriaClinica = 2232,
                Telefono = "11 2323-3232"
            });

            lstPacientes.Add(new Paciente()
            {
                ID = 3,
                Nombre = "Matias",
                Apellido = "Camargo",
                Domicilio = "CABA",
                Email = "email@email.com",
                NroHistoriaClinica = 1234,
                Telefono = "11 2323-3232"
            });

            lstPacientes.Add(new Paciente()
            {
                ID = 4,
                Nombre = "John",
                Apellido = "Deere",
                Domicilio = "CABA",
                Email = "email@email.com",
                NroHistoriaClinica = 52623,
                Telefono = "11 2323-3232"
            });

            lstPacientes.Add(new Paciente()
            {
                ID = 5,
                Nombre = "Derek",
                Apellido = "Jeter",
                Domicilio = "CABA",
                Email = "email@email.com",
                NroHistoriaClinica = 5234,
                Telefono = "11 2323-3232"
            });
        }

        public static int Insertar(Paciente p)
        {
            //TODO - Falta Implementar
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO - Falta Implementar
            return 0;
        }

        public static Paciente TraerUno(int id)
        {
            //TODO - Falta Implementar
            return null;
        }
    }
}
