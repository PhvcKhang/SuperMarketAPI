using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SuperMarketAPI.Application.DTOs;
using SuperMarketAPI.Domain.Models;
using SuperMarketAPI.Domain.Services;
using SuperMarketAPI.ViewModels;

namespace SuperMarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;

        }
        [HttpGet("All Categories")]
        //Asynchronous request?
        public ActionResult<IEnumerable<CategoryViewModel>> ListAllCategories()
        {
            try
            {
                var categories = _categoryService.ListAllCategories();
                var view = _mapper.Map<IEnumerable<CategoryViewModel>>(categories);
                return Ok(view);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }          
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryAsync ([FromBody] CreateCategoryDTO DTO)
        {
            try
            {
                await _categoryService.CreateCategoryAsync(DTO);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategoryAsync(int id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategoryAsync(int id, [FromBody] CreateCategoryDTO DTO)
        {
            try
            {
                await _categoryService.UpdateCategoryAsync(id,DTO);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
            return Ok();
        }
    }
    }

    