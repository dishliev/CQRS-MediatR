using CQRS_MediatR.Domain.Communication;
using CQRS_MediatR.Models;
using CQRS_MediatR.Repositories;
using MediatR;

namespace CQRS_MediatR.Domain.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, Response<Customer>>
    {
        private readonly ICustomerRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCustomerCommandHandler(ICustomerRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<Customer>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _repository.FindByIdAsync(request.Id);

            if (customer == null)
            {
                return new Response<Customer>("Customer not found");
            }

            _repository.Delete(customer);
            await _unitOfWork.CompleteAsync();

            return new Response<Customer>(customer);
        }
    }
}
