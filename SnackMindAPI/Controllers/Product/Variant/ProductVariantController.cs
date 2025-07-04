using SnackMindAPI.Models;

using SnackMindModel.Product.Variant;

using SnackMindService.Service.ServiceBase.Place.Zone;
using SnackMindService.Service.ServiceBase.Product.Variant;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Variant
{
    public class ProductVariantController : ApiController
    {
        private readonly IProductVariantService _productVariantService;
        public ProductVariantController(IProductVariantService productVariantService)
        {
            _productVariantService = productVariantService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var variants = await _productVariantService.GetAllAsync();
            if (variants == null || !variants.Any())
                return Ok(new ApiResponse<object>(false, "No product variants found", variants));
            return Ok(new ApiResponse<object>(true, "Product variants listed successfully", variants));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var variant = await _productVariantService.GetByRefAsync(@ref);
            if (variant == null)
                return Content(HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product variant not found", variant));
            return Ok(new ApiResponse<mdlProductVariant>(true, "Product variant found", variant));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlProductVariant variant)
        {
            if (variant == null)
                return BadRequest("Invalid product variant data");
            var result = await _productVariantService.AddAsync(variant);
            if (result)
                return Ok(new ApiResponse<object>(false, "Product variant added succesfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlProductVariant variant)
        {
            if (variant == null || @ref != variant.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid variant data").Message);
            var existingVariant = await _productVariantService.GetByRefAsync(@ref);
            if (existingVariant == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Variant not found"));
            var result = await _productVariantService.UpdateAsync(variant);
            if (result)
                return Ok(new ApiResponse<object>(true, "Variant updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingVariant = await _productVariantService.GetByRefAsync(@ref);
            if (existingVariant == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Variant not found"));
            var result = await _productVariantService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Variant deleted successfully"));
            return InternalServerError();
        }
    }
}