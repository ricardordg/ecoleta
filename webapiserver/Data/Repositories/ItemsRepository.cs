using webapiserver.Data.Context;
using webapiserver.Domain.Entities;
using webapiserver.Domain.Interfaces;

namespace webapiserver.Data.Repositories
{
    public class ItemsRepository : RepositoryBase<Item>, IItemsRepository
    {
        public ItemsRepository(AppDbContext context) : base(context)
        {
            
        }

        public AppDbContext DbContext
        {
            get { return DbContext as AppDbContext; }
        }
    }
}