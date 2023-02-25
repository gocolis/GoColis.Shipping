using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Infrastructure.Common;
using GoColis.Shipping.Infrastructure.Logistics.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoColis.Shipping.Infrastructure.Logistics.Repositories.Implement;

public class PickupPointRepository : Repository, IPickupPointRepository<PickupPoint>
{
    public PickupPointRepository(DatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(PickupPoint entity)
    {
        //TODO: Add Mapper
        var creatDate = DateTime.UtcNow;
        var contacts = entity.Contacts.Select(x => new ContactEntity
        {
            Id = new Guid(),
            Email=x.email,
            FirstName=x.firstName,
            LastName =x.lastName,
            Phone=x.phoneNumber,
            CreatedAt = creatDate,
            PickupPointID= entity.Id
        }).ToList();

        var pickupPoint = new PickupPointEntity
        {
            Id = entity.Id,
            Adresse = entity.Address,
            IdSte = entity.IdSte,
            Latitude = entity.Latitude,
            Longitude = entity.Longitude,
            CreatedAt = creatDate,
            Contacts = contacts
        };

        await _dbContext.PickupPoints.AddAsync(pickupPoint);
        _dbContext.SaveChanges();
    }

    public async Task<PickupPoint> GetAsync(Guid id)
    {
        var all = await _dbContext.PickupPoints.ToListAsync();

        var entity =await _dbContext.PickupPoints.Include(x=>x.Contacts).FirstOrDefaultAsync(x => x.Id == id);

        return new PickupPoint
        {
            Id = entity.Id,
            IdSte = entity.IdSte,
            Latitude = entity.Latitude,
            Longitude = entity.Longitude,
            Contacts = entity.Contacts.Select(x => new Domain.Common.ValueObjects.Contact(x.FirstName,x.LastName,x.Email,x.Phone)).ToList()
        };
    }
}