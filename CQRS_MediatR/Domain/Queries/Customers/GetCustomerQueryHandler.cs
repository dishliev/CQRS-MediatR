using CQRS_MediatR.Models;
using CQRS_MediatR.Repositories;
using MediatR;

namespace CQRS_MediatR.Domain.Queries.Customers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            if (request.Id <= 0)
            {
                throw new ArgumentException(nameof(request.Id));
            }

            return await _customerRepository.FindByIdAsync(request.Id);
        }
    }
}
