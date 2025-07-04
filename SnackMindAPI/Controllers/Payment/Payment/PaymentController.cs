using SnackMindAPI.Models;
using SnackMindModel.Payment.Payment;
using SnackMindService.Service.ServiceBase.Payment.Payment;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Payment.Payment
{
    [RoutePrefix("api/payments")]
    public class PaymentController : ApiController
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var payments = await _paymentService.GetAllAsync();
            if (payments == null || payments.Count == 0)
                return Ok(new ApiResponse<object>(false, "No payments found", payments));
            return Ok(new ApiResponse<object>(true, "Payments listed successfully", payments));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var payment = await _paymentService.GetByRefAsync(@ref);
            if (payment == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Payment not found"));
            return Ok(new ApiResponse<mdlPayment>(true, "Payment found", payment));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlPayment payment)
        {
            if (payment == null)
                return BadRequest(new ApiResponse<object>(false, "Payment object is null").Message);
            var result = await _paymentService.AddAsync(payment);
            if (result)
                return Ok(new ApiResponse<object>(true, "Payment added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlPayment payment)
        {
            if (payment == null || @ref != payment.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid payment data").Message);
            var existingPayment = await _paymentService.GetByRefAsync(@ref);
            if (existingPayment == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Payment not found"));
            var result = await _paymentService.UpdateAsync(payment);
            if (result)
                return Ok(new ApiResponse<object>(true, "Payment updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingPayment = await _paymentService.GetByRefAsync(@ref);
            if (existingPayment == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Payment not found"));
            var result = await _paymentService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Payment deleted successfully"));
            return InternalServerError();
        }
    }
}