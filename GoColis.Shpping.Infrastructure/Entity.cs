namespace GoColis.Shpping.Infrastructure;
public abstract class Entity
{
    public Guid Id { get; set; }
    public DataTime CreatedAt { get; set; }
    public DataTime UpdatededAt { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}
