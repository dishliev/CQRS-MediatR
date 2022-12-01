using CQRS_MediatR.Models;
using MediatR;

namespace CQRS_MediatR.Domain.Queries.Customers
{
    public class GetCustomerQuery : IRequest<Customer>
    {
        public int Id { get; private set; }

        public GetCustomerQuery(int id)
        {
            this.Id = id;
        }
    }
}