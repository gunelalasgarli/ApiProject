using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DTOs.ProductDtos
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public CategoryInProductDetailDto Category { get; set; }
    }

    public class CategoryInProductDetailDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
