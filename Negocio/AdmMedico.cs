using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class AdmMedico
    {
        public static List<Medico> lstMedicos = new List<Medico>();
        
        public static List<Medico> Listar()
        {                        
            Medicos();
            return lstMedicos;
        }

        private static void Medicos()
        {
            lstMedicos.Add(new Medico()
            {
                ID = 1,
                Nombre = "Sebastian",
                Apellido = "Lopez",
                Domicilio = "CABA",
                Email = "email@email.com",
                Especialidad = "Clinico",
                Matricula = "2022022",
                Telefono = "11 2222-1212"
            });

            lstMedicos.Add(new Medico()
            {
                ID = 2,
                Nombre = "Nicolas",
                Apellido = "Ramos",
                Domicilio = "CABA",
                Email = "email@email.com",
                Especialidad = "Clinico",
                Matricula = "123456",
                Telefono = "11 2222-0000"
            });

            lstMedicos.Add(new Medico()
            {
                ID = 3,
                Nombre = "Ariana",
                Apellido = "Belgrado",
                Domicilio = "CABA",
                Email = "email@email.com",
                Especialidad = "Cardiologo",
                Matricula = "123455678",
                Telefono = "11 2222-7475"
            });

            lstMedicos.Add(new Medico()
            {
                ID = 4,
                Nombre = "Samuel",
                Apellido = "Tribulo",
                Domicilio = "CABA",
                Email = "email@email.com",
                Especialidad = "Nutricionista",
                Matricula = "2022022",
                Telefono = "11 2222-1212"
            });

            lstMedicos.Add(new Medico()
            {
                ID = 5,
                Nombre = "Pablo",
                Apellido = "Hernandez",
                Domicilio = "CABA",
                Email = "email@email.com",
                Especialidad = "Cardiologo",
                Matricula = "2022022",
                Telefono = "11 2222-8888"
            });
        }

        public static List<Medico> Listar(string especialidad)
        {                      
            return lstMedicos.Where(i => i.Especialidad == especialidad).ToList();
        }
        public static int Insertar(Medico m)
        {
            //TODO - Falta Implementar
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO - Falta Implementar
            return 0;
        }
        public static Medico TraerUno(int id)
        {
            //TODO - Falta Implementar
            return null;
        }
    }
}
