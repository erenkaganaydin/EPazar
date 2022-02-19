using EPazar.Data;
using EPazar.Data.Repositories;

namespace EPazar.BaseBusiness.Base
{
    public class BaseBusiness<T> : EFContext where T : class, new()
    {
        protected IRepository<T> Query;

        protected BaseBusiness()
        {
            Query = new EFRepository<T>(this);
        }
    }
}