using Entidades.Data;
using Entidades.Models.Clinica;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacUsuario
    {
        private static readonly DbClinicaContext context = new DbClinicaContext();

        public static List<Usuario> SelectAll()
        {
            return context.Usuarios.ToList();
        }       

        public static Usuario Validate(string user, string password)
        {
            return context.Usuarios.Where(i => i.UserName == user && i.Password == password).SingleOrDefault();
        }
        public static int Insert(Usuario u)
        {
            context.Usuarios.Add(u);
            return context.SaveChanges();
        }
    }
}
