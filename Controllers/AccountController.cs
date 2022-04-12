using FirstApi.Data.Entities;
using FirstApi.DTOs.AccountDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _usermanager = userManager;
            _rolemanager = roleManager;
        }
        #region UserandRoleCreatetest
        //[HttpGet("rolecreate")]
        //public async Task<IActionResult> RoleCreate()
        //{

        //     await _rolemanager.CreateAsync(new IdentityRole("admin"));
        //     await _rolemanager.CreateAsync(new IdentityRole("superadmin"));
        //     await _rolemanager.CreateAsync(new IdentityRole("member"));

        //    return Ok();
        //}
        //[HttpGet("test")]

        //public async Task<IActionResult> test() 
        //{
        //    AppUser user = new AppUser
        //    {
        //        Fullname = "Super Admin",
        //        UserName = "Admin",

        //    };

        //    var result = await _usermanager.CreateAsync(user,"Admin123");

        //    if (!result.Succeeded) return BadRequest();

        //    await _usermanager.AddToRoleAsync(user, "admin");

        //    return Ok();
        //}

        #endregion

        public async Task<IActionResult> Login(AdminLoginDto loginDto)
        {
            AppUser admin = await _usermanager.FindByNameAsync(loginDto.Username);
            if (admin == null) return NotFound();

            if (!await _usermanager.CheckPasswordAsync(admin, loginDto.Password)) return Unauthorized();

            string token = "";

            return Ok(token);
        }


    }
}
