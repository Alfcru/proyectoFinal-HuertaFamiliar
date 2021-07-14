using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage ="El {0} debe ser almenos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, ErrorMessage ="El {0} debe ser almenos {2} y maximo {1} caracteres", MinimumLength = 3)]        
        public string Apellido { get; set; }
        public string Roles { get; set; }
        [Display(Name ="Fecha alta")]
        [DataType(DataType.Date)]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = "El Correo es obligatorio")]
        [StringLength(50, ErrorMessage ="El {0} debe ser almenos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [EmailAddress(ErrorMessage = "Ingrese un correo valido")]
        public string CorreoElectronico { get; set; }
        
    }
    
}

