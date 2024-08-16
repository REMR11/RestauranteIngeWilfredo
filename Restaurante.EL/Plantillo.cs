using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.EL;

public class Plantillo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    [Column(name:"Platillo_Id", TypeName="bigint")]
    private long PlatilloId { get; set; }

    [Column(name:"Nombre")]
    private String Nombre {get; set;}

    [Column(name:"Nombre")]
    private String Descripcion { get; set; }

    [Column(name:"Nombre")]
    private float Precio { get; set; }
    
    [Column(name:"Nombre")]
    private Boolean habilitado { get; set; }

    private ICollection<Ingredientes> ingedientes{ get; set; }

}
