using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.Data.Entities;
using FormBuilder.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FormBuilder.Data.Services
{
    /// <summary>
    /// Base service to be implemented by all services
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        /// <summary>
        /// Our applications Db context
        /// </summary>
        private readonly AppDbContext _appDbContext;

        /// <summary>
        /// Default constructor, getting the Db context through DI
        /// </summary>
        /// <param name="appDbContext"></param>
        public BaseService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _appDbContext.Set<TEntity>().AsQueryable();
        }

        public async Task<TEntity> GetById(string id)
        {
            return await _appDbContext.Set<TEntity>()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Create(TEntity entity)
        {
            await _appDbContext.Set<TEntity>()
                .AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _appDbContext.Set<TEntity>()
                .Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            _appDbContext.Set<TEntity>()
                .Remove(await _appDbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id));
            await _appDbContext.SaveChangesAsync();
        }
    }
}