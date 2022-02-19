using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using EPazar.Data.UnitOfWork;

namespace EPazar.Data.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        #region Properties

        private readonly IUnitOfWork _uow;
        private readonly DbContext _dbContext;

        #endregion Properties

        #region Construction

        public EFRepository(EFContext dbContext)
        {
            _dbContext = dbContext;
            _uow = new EFUnitOfWork(dbContext);
        }

        #endregion Construction

        #region GetAll

        public IQueryable<T> GetAll() => _dbContext.Set<T>();

        #endregion GetAll

        #region GetAll

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate) => _dbContext.Set<T>().Where(predicate);

        #endregion GetAll

        #region Get

        public T Get(Expression<Func<T, bool>> predicate) => _dbContext.Set<T>().Where(predicate).SingleOrDefault();

        #endregion Get

        #region Insert

        public async Task<bool> InsertAsync(T entity, bool setIdentity)
        {
            _dbContext.Set<T>().Add(entity);

            return await _uow.SaveChangesAsync(entity, setIdentity)
                             .ConfigureAwait(true);
        }

        #endregion Insert

        #region Update

        public async Task<bool> UpdateAsync(T entity)
        {
            GetId(entity, entity.GetType().GetProperties());

            return await _uow.SaveChangesAsync(entity, false)
                             .ConfigureAwait(true);
        }

        private void GetId(T entity, PropertyInfo[] props)
        {
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].Name == "Id")
                {
                    _dbContext.Entry(_dbContext.Set<T>().Find(props[i].GetValue(entity)))
                              .CurrentValues
                              .SetValues(entity);
                    break;
                }
            }
        }

        #endregion Update

        #region GetById

        public T GetById(object id) => throw new NotImplementedException();

        #endregion GetById

        #region Method AddRange

        public async Task<bool> AddRangeAsync(List<T> entity)
        {
            await _dbContext.Set<T>()
                            .AddRangeAsync(entity)
                            .ConfigureAwait(true);

            return await _uow.SaveChangesAsync(entity, false)
                             .ConfigureAwait(true);
        }

        #endregion Method AddRange

        #region Method RemoveRange

        public async Task<bool> DeleteSqlRawAsync(T entity)
        {
            var type = typeof(T);
            var property = type.GetProperty("Id");
            var Id = property.GetValue(entity);
            var query = "DELETE FROM " + type.Name + " where ID=" + Id + "";
            var result = await _dbContext.Database
                                         .ExecuteSqlRawAsync(query)
                                         .ConfigureAwait(true);

            return result > 0;
        }

        #endregion Method RemoveRange

        #region Method Deleted

        public async Task<bool> DeleteAsync(T entity)
        {
            if (GetTypeProperty(entity))
                return await UpdateAsync(entity).ConfigureAwait(true);

            return false;
        }

        #endregion Method Deleted

        #region GetTypeProperty

        private static bool GetTypeProperty(T entity)
        {
            if (entity.GetType().GetProperty("Deleted") == null)
                return false;

            entity.GetType()
                  .GetProperty("Deleted")
                  .SetValue(entity, true);

            return true;
        }

        #endregion GetTypeProperty
    }
}