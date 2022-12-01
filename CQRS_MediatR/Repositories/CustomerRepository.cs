using CQRS_MediatR.Data;
using CQRS_MediatR.Models;

namespace CQRS_MediatR.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
