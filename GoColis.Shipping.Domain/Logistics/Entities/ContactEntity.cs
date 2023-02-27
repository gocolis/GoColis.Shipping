using GoColis.Shipping.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoColis.Shipping.Domain.Logistics.Entities;

[Table("Contacts")]
public class ContactEntity : Entity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string? Role { get; set; }

    [Required]
    [ForeignKey("PickupPoint_VS_Contact")]
    [Column("PickupPointID")]
    public Guid PickupPointID { get; set; }

    public PickupPointEntity PickupPoint { get; set; }
}