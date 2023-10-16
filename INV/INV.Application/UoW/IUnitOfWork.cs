namespace INV.Application.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task commit();
    }
}
