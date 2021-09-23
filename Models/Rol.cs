using System;
using System.ComponentModel.DataAnnotations;
namespace proyectoFormativo.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Rol")]

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Descripción es requerido")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Estado es requerido")]
        public bool Estado { get; set; }
    }
}