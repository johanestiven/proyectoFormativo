using System;
using System.ComponentModel.DataAnnotations;

namespace proyectoFormativo.Models
{
    public class Usuario
{
        [Key]
        public int Documento { get; set; }
        [MaxLength(100)]

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }
       
        [MaxLength(120)]
        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string Apellidos { get; set; }
        
        [MaxLength(4)]        
        [Required(ErrorMessage = "El campo Tipo de documento es requerido")]
        [Display(Name = "Tipo de Documento")]
        public string TipoDocumento { get; set; }

        [MaxLength(120)]
        [Required(ErrorMessage = "El campo Contraseña es requerido")]
        public string Contraseña { get; set; }

        [MaxLength(120)]
        public string img_Usuario { get; set; }
                     
        [Required(ErrorMessage = "El campo Fecha de Nacimiento es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        
        [Required(ErrorMessage = "El campo E-mail es requerido")]
        [Display(Name = "E-mail")]        
        public string Email { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Dirección es requerido")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es requerido")]
        [Display(Name = "Teléfono")]        
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El campo Celular es requerido")]
        [Display(Name = "Teléfono")]        
        public int Telefono { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Municipio Residencia es requerido")]
        [Display(Name = "Municipio Residencia")]
        public string Direccion { get; set; }
        
        [Required(ErrorMessage = "El campo Rol es requerido")]
        public bool Rol { get; set; }
        
    }
}