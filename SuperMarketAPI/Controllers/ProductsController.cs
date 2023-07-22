using Microsoft.AspNetCore.Mvc;
using SuperMarketAPI.Application.DTOs;
using SuperMarketAPI.Domain.Services;
using SuperMarketAPI.Domain.Models;
using AutoMapper;
using SuperMarketAPI.Application.Services;
using SuperMarketAPI.ViewModels;

namespace SuperMarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync([FromBody] CreateProductDTO DTO)
        {
            try
            {
                await _productService.CreateProductAsync(DTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
            return Ok();
        }

        [HttpGet("Id/Error")]
        public ActionResult<ProductViewModel> GetProduct([FromQuery] GetProductDTO DTO)
        {
            try
            {
                _mapper.Map<ProductViewModel>(_productService.GetProduct(DTO));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(_mapper.Map<ProductViewModel>(_productService.GetProduct(DTO)));
        }
    }
}
