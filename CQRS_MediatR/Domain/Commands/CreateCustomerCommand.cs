using CQRS_MediatR.Models;
using MediatR;

namespace CQRS_MediatR.Domain.Commands
{
    public class CreateCustomerCommand : IRequest<Customer>
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

        public CreateCustomerCommand(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
