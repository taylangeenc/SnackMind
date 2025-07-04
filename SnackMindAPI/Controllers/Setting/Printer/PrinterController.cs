using SnackMindAPI.Models;

using SnackMindModel.Setting.Printer;

using SnackMindService.Service.ServiceBase.Setting.Printer;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Setting.Printer
{
    [RoutePrefix("api/printers")]
    public class PrinterController : ApiController
    {
        private readonly IPrinterService _printerService;
        public PrinterController(IPrinterService printerService)
        {
            _printerService = printerService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var printers = await _printerService.GetAllAsync();
            if (printers == null || printers.Count == 0)
                return Ok(new ApiResponse<object>(false, "No printers found", printers));
            return Ok(new ApiResponse<object>(true, "Printers listed successfully", printers));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var printer = await _printerService.GetByRefAsync(@ref);
            if (printer == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Printer not found"));
            return Ok(new ApiResponse<mdlPrinter>(true, "Printer found", printer));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlPrinter printer)
        {
            if (printer == null)
                return BadRequest(new ApiResponse<object>(false, "Printer object is null").Message);
            var result = await _printerService.AddAsync(printer);
            if (result)
                return Ok(new ApiResponse<object>(true, "Printer added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlPrinter printer)
        {
            if (printer == null || @ref != printer.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid printer data").Message);
            var existingPrinter = await _printerService.GetByRefAsync(@ref);
            if (existingPrinter == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Printer not found"));
            var result = await _printerService.UpdateAsync(printer);
            if (result)
                return Ok(new ApiResponse<object>(true, "Printer updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingPrinter = await _printerService.GetByRefAsync(@ref);
            if (existingPrinter == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Printer not found"));
            var result = await _printerService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Printer deleted successfully"));
            return InternalServerError();
        }
    }
}