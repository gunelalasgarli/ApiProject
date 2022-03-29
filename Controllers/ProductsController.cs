using FirstApi.Data;
using FirstApi.Data.Entities;
using FirstApi.DTOs.ProductDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }
        //[Route("")]
        [HttpGet("")]
        public IActionResult GetAll(int page = 1)
        {
            ProductListDto productListDto = new ProductListDto
            {
                Products = _context.Products.Where(x => !x.IsDeleted).Include(x => x.Category).Skip((page - 1) * 10).Take(10).Select(x => new ProductListItemDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    SalePrice = x.SalePrice,
                    CategoryName = x.Category.Name,
                }).ToList(),
                TotalCount = _context.Products.Where(x => !x.IsDeleted).Count()

            };
            return Ok(productListDto);
        }

        //[Route("{id}")]
        //[HttpGet("detail")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _context.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            if (product == null) return NotFound();

            ProductDetailDto productDto = new ProductDetailDto
            {
                Id = product.Id,
                Name = product.Name,
                SalePrice = product.SalePrice,
                CostPrice = product.CostPrice,
                Category = new CategoryInProductDetailDto
                {
                    Id = product.CategoryId,
                    Name = product.Category.Name
                }

            };

            return Ok(productDto);
        }

        [HttpPost("")]
        public IActionResult Create(ProductPostDto productDto)
        {
            if (!_context.Categories.Any(x => x.Id == productDto.CategoryId)) return NotFound();

            Product product = new Product
            {
                Name = productDto.Name,
                CostPrice = productDto.CostPrice,
                SalePrice = productDto.SalePrice,
                CategoryId=productDto.CategoryId,
                IsDeleted = false
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return StatusCode(201, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductPostDto productDto)
        {
            Product product = _context.Products.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (product == null) return NotFound();

            if (!_context.Categories.Any(x => x.Id == productDto.CategoryId)) return NotFound();

            product.Name = productDto.Name;
            product.SalePrice = productDto.SalePrice;
            product.CostPrice = productDto.CostPrice;
            product.ModifiedAt = DateTime.UtcNow.AddHours(4);
            product.CategoryId = productDto.CategoryId;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            Product product = _context.Products.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (product == null) return NotFound();

            product.IsDeleted = true;
            product.ModifiedAt = DateTime.UtcNow.AddHours(4);

            _context.SaveChanges();

            return NoContent();

        }

    }
}
