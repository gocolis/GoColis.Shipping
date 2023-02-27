﻿using GoColis.Shipping.Domain.Logistics.Agregat;

namespace GoColis.Shipping.Domain.Common;

public interface IRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity);
    Task RemoveAsync(string id);
    Task<List<PickupPoint>> GetAllAsync();
}