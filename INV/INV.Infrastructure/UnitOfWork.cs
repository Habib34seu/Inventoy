using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;
using INV.Application.UoW;
using INV.Infrastructure.Context;
using INV.Infrastructure.Repository.InvRepository.BasicInvRepository;

namespace INV.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        private IUOMRepository _uomRepository;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUOMRepository UOMRepository => _uomRepository ??= new UOMRepository(_dbContext);

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
        public  void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
