using Ardalis.Specification.EntityFrameworkCore;
using Core.Interfaces;
using Infrastucture.Data;

namespace Infrastructure.Data
{
    public class EfRepository<T> : RepositoryBase<T>, IRepository<T> where T : class
    {
        public EfRepository(LotteryContext dbContext) : base(dbContext)
        {
        }
    }

}
