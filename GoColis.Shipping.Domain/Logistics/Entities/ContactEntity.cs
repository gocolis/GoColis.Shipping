using GoColis.Shipping.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoColis.Shipping.Domain.Logistics.Entities;

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