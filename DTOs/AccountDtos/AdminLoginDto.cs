using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DTOs.AccountDtos
{
    public class AdminLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AdminLoginDtovalidator : AbstractValidator<AdminLoginDto> 
    {
        public AdminLoginDtovalidator()
        {
            RuleFor(c => c.Username).MinimumLength(2).MaximumLength(20).NotEmpty().NotNull();
            RuleFor(c => c.Password).MinimumLength(6).MaximumLength(20).NotEmpty().NotNull(); 
        }
    }
}
