using GoColis.Shipping.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoColis.Shipping.Domain.Logistics.Entities;

[Table("PickupPoints")]
public class PickupPointEntity : Entity
{
    [Required]
    [ForeignKey("TransportCompanyEntity")]
    [StringLength(20)]
    public string IdSte { get; set; }

    [Required] [StringLength(200)] public string Adresse { get; set; }

    [Required]
    [Column(TypeName = "decimal(10, 8)")]
    public decimal Latitude { get; set; }

    [Required]
    [Column(TypeName = "decimal(11, 8)")]
    public decimal Longitude { get; set; }

    public ICollection<ContactEntity> Contacts { get; set; }
}