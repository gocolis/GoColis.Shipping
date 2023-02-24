namespace GoColis.Shpping.Infrastructure.Logistics.Entities;

public class PickupPointEntity: Entity
{

    [Required]
    [ForeignKey("TransportCompanyEntity")]
    [StringLength(20)]
    public string IdSte { get; set; }

    [Required]
    [StringLength(200)]
    public string Adresse { get; set; }
  
    [Required]
    [Column(TypeName = "decimal(10, 8)")]
    public decimal Latitude { get; set; }

    [Required]
    [Column(TypeName = "decimal(11, 8)")]
    public decimal Longitude { get; set; }

    public ICollection<Contact> Contacts { get; set; }
    
}
