using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DTOs.CategoryDtos
{
    public class CategoryPostDto
    {
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
    }

    public class CategoryPostValidator : AbstractValidator<CategoryPostDto>
    {
        public CategoryPostValidator()
        {
            RuleFor(x => x.Name).MaximumLength(250).NotNull().NotEmpty().MinimumLength(2);           
        }

    }
}
