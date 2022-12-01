namespace CQRS_MediatR.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
        Task CompleteAsync(CancellationToken token);
    }
}
