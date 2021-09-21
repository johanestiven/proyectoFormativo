using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoFormativo.Models
{
    public class Softecnologia
    {
        {
            [Key]
            public int Documemento { get; set; }
            [Display(Name = "Usuario")]
            public int UsuarioDocumento { get; set; }

            [ForeignKey("UsuarioDocumento")]
            public Usuario Usuario { get; set; }

            [Display(Name = "Rol")]
            public int RolId { get; set; }
            [ForeignKey("RolId")]
            public Rol Rol { get; set; }

            [Display(Name = "Pedido")]
            public int PedidoId { get; set; }
            [ForeignKey("PedidoId")]
            public Pedido Pedido { get; set; }    
            
                
        }
    }
}