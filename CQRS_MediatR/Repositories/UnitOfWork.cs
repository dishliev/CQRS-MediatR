using CQRS_MediatR.Data;

namespace CQRS_MediatR.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task CompleteAsync(CancellationToken token)
        {
            await _context.SaveChangesAsync(token);
        }
    }
}
