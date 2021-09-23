using System;
using System.ComponentModel.DataAnnotations;
namespace proyectoFormativo.Models
{
    public class Compra
    {
     [key]  
     public int Id { get; set; }

    [MaxLength(50)]
    [Required(ErrorMessage = "El campo Nombre es requerido")]
    [Display(Name = "Nombre del Producto ")]
    public string NombreProducto { get; set; }

    [MaxLength(50)]        
    [Required(ErrorMessage = "El campo Tipo de producto es requerido")]
    [Display(Name = "Tipo de Prodcuto")]
    public string TipoProducto { get; set; }

    [Required(ErrorMessage = "El campo Cantidad es requerido")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "El campo Precio es requerido")]
    public int Precio { get; set; }

    [Required(ErrorMessage = "El campo Fecha de Compra es requerido")]
    [DataType(DataType.Date)]
    [Display(Name = "Fecha de Compra")]
    public DateTime FechaCompra { get; set; }
    }
}