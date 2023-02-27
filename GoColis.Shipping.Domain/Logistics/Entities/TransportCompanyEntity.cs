using GoColis.Shipping.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace GoColis.Shipping.Domain.Logistics.Entities;

internal class TransportCompanyEntity : Entity
{
    [Key] public int Id { get; set; }

    [Required] [StringLength(50)] public string Name { get; set; }

    [Required] [StringLength(10)] public string Code { get; set; }
}