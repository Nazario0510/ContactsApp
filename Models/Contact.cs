using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContactsApp.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]
        [StringLength(20, ErrorMessage ="{0} el nombre de contacto debe tener entre {2} y {1} caracteres",MinimumLength =4)]
        [Display(Name ="Nombre")]
        public string FirstName { get; set; }

        [Display(Name ="Apellido")]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Se debe ingresar un formato de celular válido")]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [StringLength(10,ErrorMessage = "El número de celular debe contener por lo menos 10 dígitos", MinimumLength = 10)]
        [Display(Name ="Número de celular")]
        public string CellphoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Se debe ingresar un email válido")]
        [Display(Name ="Correo electrónico")]
        public string Email { get; set; }


    }
}
