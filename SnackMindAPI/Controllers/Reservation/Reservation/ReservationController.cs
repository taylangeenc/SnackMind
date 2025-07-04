using SnackMindAPI.Models;

using SnackMindModel.Reservation.Reservation;

using SnackMindService.Service.ServiceBase.Reservation.Reservation;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Reservation.Reservation
{
    [RoutePrefix("api/reservations")]
    public class ReservationController : ApiController
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var reservations = await _reservationService.GetAllAsync();
            if (reservations == null || reservations.Count == 0)
                return Ok(new ApiResponse<object>(false, "No reservations found", reservations));
            return Ok(new ApiResponse<object>(true, "Reservations listed successfully", reservations));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var reservation = await _reservationService.GetByRefAsync(@ref);
            if (reservation == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Reservation not found"));
            return Ok(new ApiResponse<mdlReservation>(true, "Reservation found", reservation));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlReservation reservation)
        {
            if (reservation == null)
                return BadRequest(new ApiResponse<object>(false, "Reservation object is null").Message);
            var result = await _reservationService.AddAsync(reservation);
            if (result)
                return Ok(new ApiResponse<object>(true, "Reservation added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlReservation reservation)
        {
            if (reservation == null || @ref != reservation.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid reservation data").Message);
            var existingReservation = await _reservationService.GetByRefAsync(@ref);
            if (existingReservation == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Reservation not found"));
            var result = await _reservationService.UpdateAsync(reservation);
            if (result)
                return Ok(new ApiResponse<object>(true, "Reservation updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingReservation = await _reservationService.GetByRefAsync(@ref);
            if (existingReservation == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Reservation not found"));
            var result = await _reservationService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Reservation deleted successfully"));
            return InternalServerError();
        }
    }
}