using webapiserver.Data.Context;
using webapiserver.Domain.Entities;
using webapiserver.Domain.Interfaces;

namespace webapiserver.Data.Repositories
{
    public class PointItemsRepository : RepositoryBase<PointItem>, IPointItemsRepository
    {
        public PointItemsRepository(AppDbContext context) : base(context)
        {
            
        }

        public AppDbContext DbContext
        {
            get { return DbContext as AppDbContext; }
        }
    }
}