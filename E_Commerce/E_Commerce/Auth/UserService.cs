using E_Commerce.Auth.Model.DTO;
using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class UserService : IUser
    {
        private UserManager<ApplicationUser> _userManager;
        // remove the JwtToken Service and use the signInManager
        private SignInManager<ApplicationUser> _signInManager;

        // replace JWT with signInmanager
        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> SignInMngr)
        {
            _userManager = userManager;
            _signInManager = SignInMngr;
        }
        public async Task<UserDTO> Register(RegisterDTO registerDto, ModelStateDictionary modelstate)
        {
            var user = new ApplicationUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
            };
            user.CartID = user.Id;

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
            {
                // here goes the roles specifications ... 
                IList<string> Roles = new List<string>();
                Roles.Add("user");
                await _userManager.AddToRolesAsync(user, Roles);
                return new UserDTO
                {
                    Username = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user)
                };
            }
            // // Else, that means there is an error, let us collect all the errors using the modelState
            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? "Password Issue" :
                    error.Code.Contains("Email") ? "Email Issue" :
                    error.Code.Contains("UserName") ? nameof(registerDto.UserName) :
                    "";

                modelstate.AddModelError(errorKey, error.Description);
            }
            return null;
        }


        // Updated 
        public async Task<UserDTO> Authenticate(string username, string password)
        {
            // replace the usage of the userManager and use the signinmanager
            var result = await _signInManager.PasswordSignInAsync(username, password, true, false);

            // get the user from the user manager after successfully operating login
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(username);
                return new UserDTO
                {
                    Username = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user)
                };
            }

            //if (await _userManager.CheckPasswordAsync(user, password))
            //{

            //}

            return null;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}