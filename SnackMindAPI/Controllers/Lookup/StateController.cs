using global::SnackMindAPI.Models;

using SnackMindModel.Lookup;

using SnackMindService.Service.ServiceBase.Lookup;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Lookup
{
    [RoutePrefix("api/orderitemstates")]
    public class OrderItemStateController : ApiController
    {
        private readonly IOrderItemStateService _orderItemStateService;
        public OrderItemStateController(IOrderItemStateService orderItemStateService)
        {
            _orderItemStateService = orderItemStateService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var states = await _orderItemStateService.GetAllAsync();
            if (states == null || states.Count == 0)
                return Ok(new ApiResponse<object>(false, "No order item states found", states));
            return Ok(new ApiResponse<object>(true, "Order item states listed successfully", states));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var state = await _orderItemStateService.GetByRefAsync(@ref);
            if (state == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order item state not found"));
            return Ok(new ApiResponse<mdlOrderItemState>(true, "Order item state found", state));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlOrderItemState state)
        {
            if (state == null)
                return BadRequest(new ApiResponse<object>(false, "Order item state object is null").Message);
            var result = await _orderItemStateService.AddAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order item state added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlOrderItemState state)
        {
            if (state == null || @ref != state.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid order item state data").Message);
            var existingState = await _orderItemStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order item state not found"));
            var result = await _orderItemStateService.UpdateAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order item state updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingState = await _orderItemStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Order item state not found"));
            var result = await _orderItemStateService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Order item state deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/tablestates")]
    public class TableStateController : ApiController
    {
        private readonly ITableStateService _tableStateService;
        public TableStateController(ITableStateService tableStateService)
        {
            _tableStateService = tableStateService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var states = await _tableStateService.GetAllAsync();
            if (states == null || states.Count == 0)
                return Ok(new ApiResponse<object>(false, "No table states found", states));
            return Ok(new ApiResponse<object>(true, "Table states listed successfully", states));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var state = await _tableStateService.GetByRefAsync(@ref);
            if (state == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Table state not found"));
            return Ok(new ApiResponse<mdlTableState>(true, "Table state found", state));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlTableState state)
        {
            if (state == null)
                return BadRequest(new ApiResponse<object>(false, "Table state object is null").Message);
            var result = await _tableStateService.AddAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Table state added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlTableState state)
        {
            if (state == null || @ref != state.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid table state data").Message);
            var existingState = await _tableStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Table state not found"));
            var result = await _tableStateService.UpdateAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Table state updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingState = await _tableStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Table state not found"));
            var result = await _tableStateService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Table state deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/paymenttype")]
    public class PaymentTypeController : ApiController
    {
        private readonly IPaymentTypeService _paymentTypeService;
        public PaymentTypeController(IPaymentTypeService paymentTypeService)
        {
            _paymentTypeService = paymentTypeService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var types = await _paymentTypeService.GetAllAsync();
            if (types == null || types.Count == 0)
                return Ok(new ApiResponse<object>(false, "No payment types found", types));
            return Ok(new ApiResponse<object>(true, "Payment types listed successfully", types));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var type = await _paymentTypeService.GetByRefAsync(@ref);
            if (type == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Payment type not found"));
            return Ok(new ApiResponse<mdlPaymentType>(true, "Payment type found", type));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlPaymentType type)
        {
            if (type == null)
                return BadRequest(new ApiResponse<object>(false, "Payment type object is null").Message);
            var result = await _paymentTypeService.AddAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Payment type added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlPaymentType type)
        {
            if (type == null || @ref != type.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid payment type data").Message);
            var existingType = await _paymentTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Payment type not found"));
            var result = await _paymentTypeService.UpdateAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Payment type updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingType = await _paymentTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Payment type not found"));
            var result = await _paymentTypeService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Payment type deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/reservationstate")]
    public class ReservationStateController : ApiController
    {
        private readonly IReservationStateService _reservationStateService;
        public ReservationStateController(IReservationStateService reservationStateService)
        {
            _reservationStateService = reservationStateService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var states = await _reservationStateService.GetAllAsync();
            if (states == null || states.Count == 0)
                return Ok(new ApiResponse<object>(false, "No reservation states found", states));
            return Ok(new ApiResponse<object>(true, "Reservation states listed successfully", states));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var state = await _reservationStateService.GetByRefAsync(@ref);
            if (state == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Reservation state not found"));
            return Ok(new ApiResponse<mdlReservationState>(true, "Reservation state found", state));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlReservationState state)
        {
            if (state == null)
                return BadRequest(new ApiResponse<object>(false, "Reservation state object is null").Message);
            var result = await _reservationStateService.AddAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Reservation state added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlReservationState state)
        {
            if (state == null || @ref != state.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid reservation state data").Message);
            var existingState = await _reservationStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Reservation state not found"));
            var result = await _reservationStateService.UpdateAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Reservation state updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingState = await _reservationStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Reservation state not found"));
            var result = await _reservationStateService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Reservation state deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/stockmovementtype")]
    public class StockMovementTypeController : ApiController
    {
        private readonly IStockMovementTypeService _stockMovementTypeService;
        public StockMovementTypeController(IStockMovementTypeService stockMovementTypeService)
        {
            _stockMovementTypeService = stockMovementTypeService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var types = await _stockMovementTypeService.GetAllAsync();
            if (types == null || types.Count == 0)
                return Ok(new ApiResponse<object>(false, "No stock movement types found", types));
            return Ok(new ApiResponse<object>(true, "Stock movement types listed successfully", types));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var type = await _stockMovementTypeService.GetByRefAsync(@ref);
            if (type == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Stock movement type not found"));
            return Ok(new ApiResponse<mdlStockMovementType>(true, "Stock movement type found", type));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlStockMovementType type)
        {
            if (type == null)
                return BadRequest(new ApiResponse<object>(false, "Stock movement type object is null").Message);
            var result = await _stockMovementTypeService.AddAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Stock movement type added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlStockMovementType type)
        {
            if (type == null || @ref != type.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid stock movement type data").Message);
            var existingType = await _stockMovementTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Stock movement type not found"));
            var result = await _stockMovementTypeService.UpdateAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Stock movement type updated successfully"));
            return InternalServerError();
        }
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingType = await _stockMovementTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Stock movement type not found"));
            var result = await _stockMovementTypeService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Stock movement type deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/purchaseorderstate")]
    public class PurchaseOrderStateController : ApiController
    {
        private readonly IPurchaseOrderStateService _purchaseOrderStateService;
        public PurchaseOrderStateController(IPurchaseOrderStateService purchaseOrderStateService)
        {
            _purchaseOrderStateService = purchaseOrderStateService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var states = await _purchaseOrderStateService.GetAllAsync();
            if (states == null || states.Count == 0)
                return Ok(new ApiResponse<object>(false, "No purchase order states found", states));
            return Ok(new ApiResponse<object>(true, "Purchase order states listed successfully", states));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var state = await _purchaseOrderStateService.GetByRefAsync(@ref);
            if (state == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Purchase order state not found"));
            return Ok(new ApiResponse<mdlPurchaseOrderState>(true, "Purchase order state found", state));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlPurchaseOrderState state)
        {
            if (state == null)
                return BadRequest(new ApiResponse<object>(false, "Purchase order state object is null").Message);
            var result = await _purchaseOrderStateService.AddAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Purchase order state added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlPurchaseOrderState state)
        {
            if (state == null || @ref != state.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid purchase order state data").Message);
            var existingState = await _purchaseOrderStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Purchase order state not found"));
            var result = await _purchaseOrderStateService.UpdateAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Purchase order state updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingState = await _purchaseOrderStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Purchase order state not found"));
            var result = await _purchaseOrderStateService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Purchase order state deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/printdestination")]
    public class PrintDestinationController : ApiController
    {
        private readonly IPrintDestinationService _printDestinationService;
        public PrintDestinationController(IPrintDestinationService printDestinationService)
        {
            _printDestinationService = printDestinationService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var destinations = await _printDestinationService.GetAllAsync();
            if (destinations == null || destinations.Count == 0)
                return Ok(new ApiResponse<object>(false, "No print destinations found", destinations));
            return Ok(new ApiResponse<object>(true, "Print destinations listed successfully", destinations));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var destination = await _printDestinationService.GetByRefAsync(@ref);
            if (destination == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Print destination not found"));
            return Ok(new ApiResponse<mdlPrintDestination>(true, "Print destination found", destination));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlPrintDestination destination)
        {
            if (destination == null)
                return BadRequest(new ApiResponse<object>(false, "Print destination object is null").Message);
            var result = await _printDestinationService.AddAsync(destination);
            if (result)
                return Ok(new ApiResponse<object>(true, "Print destination added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlPrintDestination destination)
        {
            if (destination == null || @ref != destination.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid print destination data").Message);
            var existingDestination = await _printDestinationService.GetByRefAsync(@ref);
            if (existingDestination == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Print destination not found"));
            var result = await _printDestinationService.UpdateAsync(destination);
            if (result)
                return Ok(new ApiResponse<object>(true, "Print destination updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingDestination = await _printDestinationService.GetByRefAsync(@ref);
            if (existingDestination == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Print destination not found"));
            var result = await _printDestinationService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Print destination deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/printstate")]
    public class PrintStateController : ApiController
    {
        private readonly IPrintStateService _printStateService;
        public PrintStateController(IPrintStateService printStateService)
        {
            _printStateService = printStateService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var states = await _printStateService.GetAllAsync();
            if (states == null || states.Count == 0)
                return Ok(new ApiResponse<object>(false, "No print states found", states));
            return Ok(new ApiResponse<object>(true, "Print states listed successfully", states));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var state = await _printStateService.GetByRefAsync(@ref);
            if (state == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Print state not found"));
            return Ok(new ApiResponse<mdlPrintState>(true, "Print state found", state));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlPrintState state)
        {
            if (state == null)
                return BadRequest(new ApiResponse<object>(false, "Print state object is null").Message);
            var result = await _printStateService.AddAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Print state added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlPrintState state)
        {
            if (state == null || @ref != state.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid print state data").Message);
            var existingState = await _printStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Print state not found"));
            var result = await _printStateService.UpdateAsync(state);
            if (result)
                return Ok(new ApiResponse<object>(true, "Print state updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingState = await _printStateService.GetByRefAsync(@ref);
            if (existingState == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Print state not found"));
            var result = await _printStateService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Print state deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/printerconnectiontype")]
    public class PrinterConnectionTypeController : ApiController
    {
        private readonly IPrinterConnectionTypeService _printerConnectionTypeService;
        public PrinterConnectionTypeController(IPrinterConnectionTypeService printerConnectionTypeService)
        {
            _printerConnectionTypeService = printerConnectionTypeService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var types = await _printerConnectionTypeService.GetAllAsync();
            if (types == null || types.Count == 0)
                return Ok(new ApiResponse<object>(false, "No printer connection types found", types));
            return Ok(new ApiResponse<object>(true, "Printer connection types listed successfully", types));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var type = await _printerConnectionTypeService.GetByRefAsync(@ref);
            if (type == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Printer connection type not found"));
            return Ok(new ApiResponse<mdlPrinterConnectionType>(true, "Printer connection type found", type));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlPrinterConnectionType type)
        {
            if (type == null)
                return BadRequest(new ApiResponse<object>(false, "Printer connection type object is null").Message);
            var result = await _printerConnectionTypeService.AddAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Printer connection type added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlPrinterConnectionType type)
        {
            if (type == null || @ref != type.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid printer connection type data").Message);
            var existingType = await _printerConnectionTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Printer connection type not found"));
            var result = await _printerConnectionTypeService.UpdateAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Printer connection type updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingType = await _printerConnectionTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Printer connection type not found"));
            var result = await _printerConnectionTypeService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Printer connection type deleted successfully"));
            return InternalServerError();
        }
    }

    [RoutePrefix("api/logtype")]
    public class LogTypeController : ApiController
    {
        private readonly ILogTypeService _logTypeService;
        public LogTypeController(ILogTypeService logTypeService)
        {
            _logTypeService = logTypeService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var types = await _logTypeService.GetAllAsync();
            if (types == null || types.Count == 0)
                return Ok(new ApiResponse<object>(false, "No log types found", types));
            return Ok(new ApiResponse<object>(true, "Log types listed successfully", types));
        }
        [HttpGet]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var type = await _logTypeService.GetByRefAsync(@ref);
            if (type == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Log type not found"));
            return Ok(new ApiResponse<mdlLogType>(true, "Log type found", type));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlLogType type)
        {
            if (type == null)
                return BadRequest(new ApiResponse<object>(false, "Log type object is null").Message);
            var result = await _logTypeService.AddAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Log type added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlLogType type)
        {
            if (type == null || @ref != type.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid log type data").Message);
            var existingType = await _logTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Log type not found"));
            var result = await _logTypeService.UpdateAsync(type);
            if (result)
                return Ok(new ApiResponse<object>(true, "Log type updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingType = await _logTypeService.GetByRefAsync(@ref);
            if (existingType == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Log type not found"));
            var result = await _logTypeService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Log type deleted successfully"));
            return InternalServerError();
        }
    }
}