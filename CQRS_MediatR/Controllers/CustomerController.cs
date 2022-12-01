using CQRS_MediatR.Domain.Queries.Customers;
using CQRS_MediatR.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_MediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> ListAsync()
        {
            return await _mediator.Send(new ListCustomerQuery());
        }
    }
}
