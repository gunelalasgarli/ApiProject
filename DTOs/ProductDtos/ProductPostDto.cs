using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DTOs.ProductDtos
{
    public class ProductPostDto
    {
        public int CategoryId { get; set; }
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
    }

    public class ProductPostDtoValidator : AbstractValidator<ProductPostDto> 
    {
        public ProductPostDtoValidator()
        {
            RuleFor(x => x.Name).MaximumLength(250).NotNull().NotEmpty().MinimumLength(2);
            RuleFor(x => x.CostPrice).GreaterThanOrEqualTo(0);
            RuleFor(x => x.SalePrice).GreaterThanOrEqualTo(0);
            RuleFor(x => x.CategoryId).GreaterThan(0);

            RuleFor(x => x).Custom((x, context) =>
              {
                  if (x.CostPrice > x.SalePrice)
                  {
                      context.AddFailure(nameof(x.SalePrice), "Sale Price must be greater than Cost Price");
                  }
              });
        }
    
    }
}
