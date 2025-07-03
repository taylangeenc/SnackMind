using SnackMindModel.Order.Order;

using SnackMindService.Service.ServiceBase.Order.Order;

using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Order.Order
{
    [RoutePrefix("api/orders")]
    public class OrderController : ApiController
    {
        // GET: Order
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        [Route("all")]
        public async Task<IHttpActionResult> GetAllOrders()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IHttpActionResult> CreateOrder([FromBody] mdlOrder order)
        {
            if (order == null)
                return BadRequest("Order is null");
            var result = await _orderService.AddAsync(order);
            if (result)
                return Ok("Order created.");
            else
                return InternalServerError();
        }
    }
}