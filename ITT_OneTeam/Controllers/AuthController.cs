using ITT_OneTeam.Identity;
using ITT_OneTeam.Models.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.Security.Claims;
using System.Security.Principal;

namespace ITT_OneTeam.Controllers
{
    [Route("auth")]    
    public class AuthController : Controller
    {
        private UserManager<AppIdentityUser> UserManager { get; set; }
        private RoleManager<IdentityRole> RoleManager { get; set; }

        private AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        private SignInManager<AppIdentityUser> SignInManager { get; set; }

        public AuthController(UserManager<AppIdentityUser> userManager, RoleManager<IdentityRole> roleManager, AuthenticationStateProvider authenticationStateProvider, SignInManager<AppIdentityUser> signInManager) 
        {
            this.UserManager = userManager; 
            this.RoleManager = roleManager;
            this.AuthenticationStateProvider = authenticationStateProvider;
            this.SignInManager = signInManager;
        }

        [HttpGet("login"), AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            return View(new Login());
        }

        [HttpPost("login"), AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginUser(Login LoginInfo)
        {
            if (ModelState.IsValid) { 

                var appUser = await UserManager.Users.FirstOrDefaultAsync(f => f.UserName == LoginInfo.Username);

                if (appUser == null)
                {
                    ModelState.AddModelError(nameof(LoginInfo.Password), "Username not found");
                }
                else
                {
                    var signInResult = await SignInManager.PasswordSignInAsync(appUser, LoginInfo.Password, true, false);

                    if(signInResult.Succeeded == false)
                    {
                        ModelState.AddModelError(nameof(LoginInfo.Password), "Invalid password");
                    }
                    else
                    {
                        return Redirect("/");
                    }

                }
            }

            return View("Login", new Login());

        }

        [HttpGet("logout")]
        public async Task<IActionResult> logout()
        {
            if (SignInManager.IsSignedIn(User))
            {
                await SignInManager.SignOutAsync();
            }

            return Redirect("/");
        }

       

    }


}
