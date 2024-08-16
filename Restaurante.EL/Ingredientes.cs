using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.EL;

public class Ingredientes
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    private long IngredienteId { get; set; }

    [Column(name:"Nombre")]
    private String Nombre { get; set; }

    [Column(name:"Descripcion")]
    private String Descripcion { get; set; }

    [Range(1,1000)]
    [Column(name:"Cantidad")]
    private double Cantidad { get; set; }

    private Plantillo Platillo{ get; set;}
}
