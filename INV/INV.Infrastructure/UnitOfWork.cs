using INV.Application.UoW;
using INV.Infrastructure.Context;
using INV.Infrastructure.Repository.InvRepository.BasicInvRepository;

namespace INV.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UOMRepository UOMRepository { get; set; }
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            this.UOMRepository = new UOMRepository(_dbContext);
        }
        public async Task commit()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
