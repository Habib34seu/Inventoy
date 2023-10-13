using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Domain.Entities.InventoryEntity.BasicEntity;
using INV.Infrastructure.Context;

namespace INV.Infrastructure.Repository.InvRepository.BasicInvRepository
{
    public class UOMRepository : GenericRepository<UOMEntity>, IUOMRepository
    {
        private readonly AppDbContext _dbContext;

        public UOMRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
