using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    [NotMapped]
    public class Director : Medico
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]        
        public string PostGrado { get; set; }
    }
}
