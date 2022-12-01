using CQRS_MediatR.Models;
using CQRS_MediatR.Repositories;
using MediatR;

namespace CQRS_MediatR.Domain.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                Name = request.Name,
                Address = request.Address
            };

            await _customerRepository.AddAsync(customer);
            await _unitOfWork.CompleteAsync();

            return customer;
        }
    }
}
