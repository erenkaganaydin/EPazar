using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using EPazar.Data.Repositories;
using System;

namespace EPazar.Data.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        #region Field

        private readonly EFContext _dbContext;

        #endregion Field

        #region Properties

        protected bool Issucces { get; set; }

        #endregion Properties

        #region Construction

        public EFUnitOfWork(EFContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion Construction

        #region IUnitOfWork

        public IRepository<T> GetRepository<T>() where T : class => new EFRepository<T>(_dbContext);

        public async Task<bool> SaveChangesAsync<T>(T entity, bool setIdentity) where T : class
        {
            var transaction = _dbContext.Database.BeginTransaction();

            try
            {
                if (setIdentity)
                    await IdentitySetInsertOnAsync(entity).ConfigureAwait(true);

                await _dbContext.SaveChangesAsync()
                                .ConfigureAwait(true);

                transaction.Commit();

                Issucces = true;
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                Issucces = false;
            }
            finally
            {
                if (setIdentity)
                    await IdentitySetInsertOffAsync(entity).ConfigureAwait(true);
            }

            return Issucces;
        }

        #endregion IUnitOfWork

        #region IdentitySetInsert

        private async Task IdentitySetInsertOnAsync<T>(T entity) where T : class
        {
            await _dbContext.Database
                            .ExecuteSqlRawAsync($"SET IDENTITY_INSERT [dbo].[{typeof(T).Name}] ON")
                            .ConfigureAwait(true);
        }

        private async Task IdentitySetInsertOffAsync<T>(T entity) where T : class
        {
            await _dbContext.Database
                            .ExecuteSqlRawAsync($"SET IDENTITY_INSERT [dbo].[{typeof(T).Name}] OFF")
                            .ConfigureAwait(true);
        }

        #endregion IdentitySetInsert
    }
}