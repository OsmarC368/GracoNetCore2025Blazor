using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data.Models
{
    public class UserDTO
    {
        
        [Required(ErrorMessage = "El Usuario es Requerido!")]
        [StringLength(225, ErrorMessage = "El Nombre de Usuario es Demasiado Corto", MinimumLength =4)]
        public string UserName {get; set;} = string.Empty;

        [Required(ErrorMessage = "La Contraseña es Requerido!")]
        [StringLength(225, ErrorMessage = "La Contraseña de Usuario es Demasiado Corta", MinimumLength=4)]
        public string Password {get; set;} = string.Empty;


    }
}