using Entidades.Clinica;
using Entidades.Models.Clinica;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbClinicaContext() : base("KeyDB") { }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
