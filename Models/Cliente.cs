namespace proyectoFormativo.Models
{
    public class Cliente
    {
        //hdgydvu
        //jahahahaha
        [Key]
        public int Id { get; set; }

        [MaxLength(25)]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }
       
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string Apellidos { get; set; }
       
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo Dirección es requerido")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo Celular es requerido")]       
        public int Celular { get; set; }

        [Required(ErrorMessage = "El campo E-mail es requerido")]
        [Display(Name = "E-mail")]        
        public string Email { get; set; }

        [ForeignKey("IdPedido")]
        public Pedido Pedido  { get; set; }
    }
}