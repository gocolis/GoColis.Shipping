using System.ComponentModel.DataAnnotations;

namespace GoColis.Shipping.Infrastructure.Common;

public abstract class Entity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}