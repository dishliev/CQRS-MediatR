using CQRS_MediatR.Domain.Communication;
using CQRS_MediatR.Models;
using MediatR;

namespace CQRS_MediatR.Domain.Commands
{
    public class DeleteCustomerCommand : IRequest<Response<Customer>>
    {
        public int Id { get; private set; }

        public DeleteCustomerCommand(int id)
        {
            this.Id = id;
        }
    }
}