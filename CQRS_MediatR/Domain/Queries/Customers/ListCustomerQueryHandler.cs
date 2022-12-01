using CQRS_MediatR.Models;
using CQRS_MediatR.Repositories;
using MediatR;

namespace CQRS_MediatR.Domain.Queries.Customers
{

    public class ListCustomerQueryHandler : IRequestHandler<ListCustomerQuery, IEnumerable<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;

        public ListCustomerQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> Handle(ListCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.ListAsync();
        }
    }
}
