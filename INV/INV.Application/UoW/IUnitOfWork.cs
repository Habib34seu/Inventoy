using INV.Application.Contracts.Repository.InventoryRepository.BasicRepository;

namespace INV.Application.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IUOMRepository UOMRepository { get; }
        Task Save();
    }
}
