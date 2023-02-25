using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoColis.Shipping.Infrastructure.Common;

namespace GoColis.Shipping.Infrastructure.Logistics.Entities;

public class ContactEntity : Entity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string? Role { get; set; }

    [Required]
    [ForeignKey("PickupPointEntity")]
    public Guid PickupPointID { get; set; }
}