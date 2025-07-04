using SnackMindAPI.Models;

using SnackMindModel.Order.Order;

using SnackMindService.Service.ServiceBase.Order.Order;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Order.Order
{
    [RoutePrefix("api/orders")]
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var orders = await _orderService.GetAllAsync();
            if (orders == null || orders.Count == 0)
                return Ok(new ApiResponse<object>(false, "No orders found", orders));
            return Ok(new ApiResponse<object>(true, "Orders listed successfully", orders));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var order = await _orderService.GetByRefAsync(@ref);
            if (order == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order not found"));
            return Ok(new ApiResponse<mdlOrder>(true, "Order found", order));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlOrder order)
        {
            if (order == null)
                return BadRequest(new ApiResponse<object>(false, "Order object is null").Message);
            var result = await _orderService.AddAsync(order);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlOrder order)
        {
            if (order == null || @ref != order.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid order data").Message);
            var existingOrder = await _orderService.GetByRefAsync(@ref);
            if (existingOrder == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order not found"));
            var result = await _orderService.UpdateAsync(order);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingOrder = await _orderService.GetByRefAsync(@ref);
            if (existingOrder == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order not found"));
            var result = await _orderService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order deleted successfully"));
            return InternalServerError();
        }
    }
}