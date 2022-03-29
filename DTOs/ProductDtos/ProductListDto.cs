using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DTOs.ProductDtos
{
    public class ProductListDto
    {
        public List<ProductListItemDto> Products { get; set; }
        //public int Page { get; set; }
        public int TotalCount { get; set; }
        //public bool HasNext { get; set; }
        //public bool HasPrev { get; set; }
    }

    public class ProductListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public string CategoryName { get; set; }
    }
}
