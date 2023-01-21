using Entidades;
using Entidades.Clinica;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Pacientes")]    
    public class Paciente : Persona
    {
        [Required]
        public int NroHistoriaClinica { get; set; }
        public int MedicoId { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
        public int HabitacionId { get; set; }

        [ForeignKey("HabitacionId")]
        public Habitacion Habitacion { get; set; }

        public override string ToString()
        {            
            return base.ToString() + $"Numero Historia: {NroHistoriaClinica}";
        }
    }
}
