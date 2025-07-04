using SnackMindAPI.Models;

using SnackMindModel.Order.Order;

using SnackMindService.Service.ServiceBase.Order.Order;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Order.Order
{
    [RoutePrefix("api/orderitems")]
    public class OrderItemController : ApiController
    {
        private readonly IOrderItemService _orderItemService;
        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var items = await _orderItemService.GetAllAsync();
            if (items == null || items.Count == 0)
                return Ok(new ApiResponse<object>(false, "No order items found", items));
            return Ok(new ApiResponse<object>(true, "Order items listed successfully", items));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var item = await _orderItemService.GetByRefAsync(@ref);
            if (item == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order item not found"));
            return Ok(new ApiResponse<mdlOrderItem>(true, "Order item found", item));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlOrderItem item)
        {
            if (item == null)
                return BadRequest(new ApiResponse<object>(false, "Order item object is null").Message);
            var result = await _orderItemService.AddAsync(item);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order item added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlOrderItem item)
        {
            if (item == null || @ref != item.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid order item data").Message);
            var existingItem = await _orderItemService.GetByRefAsync(@ref);
            if (existingItem == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order item not found"));
            var result = await _orderItemService.UpdateAsync(item);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order item updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingItem = await _orderItemService.GetByRefAsync(@ref);
            if (existingItem == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order item not found"));
            var result = await _orderItemService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order item deleted successfully"));
            return InternalServerError();
        }
    }
}