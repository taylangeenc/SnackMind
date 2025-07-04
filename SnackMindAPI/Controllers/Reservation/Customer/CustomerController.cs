using SnackMindAPI.Models;

using SnackMindModel.Reservation.Customer;

using SnackMindService.Service.ServiceBase.Reservation.Customer;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Reservation.Customer
{
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            if (customers == null || customers.Count == 0)
                return Ok(new ApiResponse<object>(false, "No customers found", customers));
            return Ok(new ApiResponse<object>(true, "Customers listed successfully", customers));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var customers = await _customerService.GetAllAsync(x => x.IsActive);
            if (customers == null || customers.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active customers found", customers));
            return Ok(new ApiResponse<object>(true, "Active customers listed successfully", customers));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var customers = await _customerService.GetAllAsync(x => !x.IsActive);
            if (customers == null || customers.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive customers found", customers));
            return Ok(new ApiResponse<object>(true, "Passive customers listed successfully", customers));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var customer = await _customerService.GetByRefAsync(@ref);
            if (customer == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Customer not found"));
            return Ok(new ApiResponse<mdlCustomer>(true, "Customer found", customer));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlCustomer customer)
        {
            if (customer == null)
                return BadRequest(new ApiResponse<object>(false, "Customer object is null").Message);
            var result = await _customerService.AddAsync(customer);
            if (result)
                return Ok(new ApiResponse<object>(true, "Customer added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlCustomer customer)
        {
            if (customer == null || @ref != customer.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid customer data").Message);
            var existingCustomer = await _customerService.GetByRefAsync(@ref);
            if (existingCustomer == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Customer not found"));
            var result = await _customerService.UpdateAsync(customer);
            if (result)
                return Ok(new ApiResponse<object>(true, "Customer updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingCustomer = await _customerService.GetByRefAsync(@ref);
            if (existingCustomer == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Customer not found"));
            var result = await _customerService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Customer deleted successfully"));
            return InternalServerError();
        }
    }
}