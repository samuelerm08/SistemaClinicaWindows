using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Domicilio { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Telefono { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Email { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\n" +    
                   $"Nombre: {Nombre}\n" +
                   $"Apellido: {Apellido}\n" +
                   $"Domicilio: {Domicilio}\n" +
                   $"Telefono: {Telefono}\n" +
                   $"Email: {Email}\n";
        }
    }
}
