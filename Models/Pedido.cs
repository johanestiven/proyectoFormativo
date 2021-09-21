namespace proyectoFormativo.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
       
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string NombreCliente { get; set; }
       
        [MaxLength(120)]
        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string ApellidosCliente { get; set; }

        [ForeignKey("Id_Cliente")]
        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public Cliente Cliente { get; set; }

        [ForeignKey("Id_Produco")]
        [Required(ErrorMessage = "El campo producto es requerido")]
        public Producto Producto { get; set; }
        
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo Nombre producto es requerido")]
        public string NombreProducto { get; set; }

        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El campo Cantidad es requerido")]

        [Required(ErrorMessage = "El campo Fecha de pedido es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Pedido")]
        public DateTime FechaPedido { get; set; }

        public int Total { get; set; }
        [Required(ErrorMessage = "El campo Total es requerido")]
        
    }
}