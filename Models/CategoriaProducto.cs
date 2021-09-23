using System;
using System.ComponentModel.DataAnnotations;
namespace proyectoFormativo.Models
{
    public class CategoriaProducto
    {
        [ForeignKey("IdProducto")]
        public Categoria Producto  { get; set; }

        [Required(ErrorMessage = "El campo Stock es requerido")]
        public int Stock { get; set; }
    }
}