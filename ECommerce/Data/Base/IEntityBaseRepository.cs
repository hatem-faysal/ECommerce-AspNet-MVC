﻿namespace ECommerce.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class,IBaseEntity
    {
        Task<IEnumerable<T>> GetAllAsycn();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

    }
}
