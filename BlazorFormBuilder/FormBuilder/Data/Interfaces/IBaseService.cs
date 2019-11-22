using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FormBuilder.Data.Interfaces
{
    /// <summary>
    /// Generic service for all CRUD operations
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(string id);

        Task Create(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(string id);
    }
}