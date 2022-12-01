using CQRS_MediatR.Models;
using MediatR;

namespace CQRS_MediatR.Domain.Queries.Customers
{
    public class ListCustomerQuery : IRequest<IEnumerable<Customer>>
    {
    }
}
