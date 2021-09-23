using System;
using System.ComponentModel.DataAnnotations;
namespace proyectoFormativo.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required(ErrorMessage = "El campo Nombre del Producto es requerido")]
        [Display(Name = "Nombre del Producto")]
        public string NombreProducto { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria CategoriaProducto  { get; set; }

        [Required(ErrorMessage = "El campo Precio es requerido")]
        public int Precio { get; set; }

        [Required(ErrorMessage = "El campo Cantidad es requerido")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Vencimiento es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Vencimiento")]
        public DateTime FechaVencimiento { get; set; }

        [MaxLength(30)]        
        [Required(ErrorMessage = "El campo Tipo de Producto es requerido")]
        [Display(Name = "Tipo de Producto")]
        public string TipoProducto { get; set; }
    }
}