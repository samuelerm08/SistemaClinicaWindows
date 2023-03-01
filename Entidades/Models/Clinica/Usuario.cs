using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Clinica
{
    [Table("Usuario")]
    public class Usuario
    {        
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string UserName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
