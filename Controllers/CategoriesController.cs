using FirstApi.Data;
using FirstApi.Data.Entities;
using FirstApi.DTOs.CategoryDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult GetAll(int page=1)
        {

            CategoryListDto categoryDto = new CategoryListDto
            {
                Categories = _context.Categories.Where(x => x.IsDeleted == false).Skip((page - 1) * 10).Take(10).Select(x => new CategoryListItemDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList(),
                TotalCount = _context.Categories.Where(x => !x.IsDeleted).Count()
            };

            return Ok(categoryDto);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var category = _context.Categories.FirstOrDefault(x=>x.Id==id&&x.IsDeleted==false);
            if (category == null) return NotFound();

            CategoryDetailDto categoryDto = new CategoryDetailDto
            {
                Id=category.Id,
                Name=category.Name
            };

            return Ok(categoryDto); 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            Category category = _context.Categories.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);

            if (category == null) return NotFound();

            category.IsDeleted = true;
            category.ModifiedAt = DateTime.UtcNow.AddHours(4);

            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost("")]
        public IActionResult Create(CategoryPostDto categoryDto) 
        {
            Category category = new Category
            {
                Name = categoryDto.Name,
                IsDeleted = false
            };

            _context.Categories.Add(category);
            _context.SaveChanges();

            return StatusCode(201, category);

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,CategoryPostDto categoryDto) 
        {
            Category category = _context.Categories.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);

            if (category == null) return NotFound();

            category.Name = categoryDto.Name;
            category.ModifiedAt = DateTime.UtcNow.AddHours(4);

            _context.SaveChanges();

            return NoContent();
        }
    }
}
