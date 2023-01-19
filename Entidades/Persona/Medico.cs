using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Matricula { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Especialidad { get; set; }

        public override string ToString()
        {
            return $"{ID}\n" +
                   $"{Nombre}\n" +
                   $"{Apellido}\n" +
                   $"{Domicilio}\n" +
                   $"{Telefono}\n" +
                   $"{Email}\n" +
                   $"{Matricula}\n" +
                   $"{Especialidad}";
        }
    }
}
