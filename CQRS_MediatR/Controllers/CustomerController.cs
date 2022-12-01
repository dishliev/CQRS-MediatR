using CQRS_MediatR.Domain.Commands;
using CQRS_MediatR.Domain.Communication;
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

        [HttpPost]
        [ProducesResponseType(typeof(Customer), 201)]
        [ProducesResponseType(typeof(ErrorResource), 400)]
        public async Task<IActionResult> PostAsync([FromBody] CustomerResource resource)
        {
            var customer = await _mediator.Send(new CreateCustomerCommand(resource.Name, resource.Address));
            return Created($"/api/customers/{customer.Id}", customer);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Response<Customer>), 200)]
        [ProducesResponseType(typeof(ErrorResource), 400)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var response = await _mediator.Send(new DeleteCustomerCommand(id));
            return ProduceCustomerResponse(response);
        }

        private IActionResult ProduceCustomerResponse(Response<Customer> response)
        {
            if (!response.Success)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Data);
        }
    }
}
