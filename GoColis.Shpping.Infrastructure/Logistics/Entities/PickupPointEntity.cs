namespace GoColis.Shpping.Infrastructure.Logistics.Entities;

public class PickupPointEntity: Entity
{
    [Required]
    [StringLength(200)]
    public string Adresse { get; set; }

    [Required]
    [StringLength(50)]
    public string Ville { get; set; }

    [Required]
    [StringLength(10)]
    public string CodePostal { get; set; }

    [Required]
    [StringLength(50)]
    public string Pays { get; set; }

    [Required]
    [Column(TypeName = "decimal(10, 8)")]
    public decimal Latitude { get; set; }

    [Required]
    [Column(TypeName = "decimal(11, 8)")]
    public decimal Longitude { get; set; }
    
}
