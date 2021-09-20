using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PowerMode.Areas.Identity.Data;
using PowerMode.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerMode.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class UsersController : Controller
    {
        private readonly PowerModeContext _context;
        private readonly UserManager<PowerUser> _userManager;
        private readonly SignInManager<PowerUser> _signInManager;

        public UsersController(PowerModeContext context, UserManager<PowerUser> userManager, SignInManager<PowerUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var UserList = (from u in _context.Users
                            select u).ToList();
                           
            return View(UserList);
        }

        public async Task<IActionResult> Delete(string[] ids)
        {
            var users = (from u in _context.Users
                         select u).ToList();
            foreach (var user in users)
            {
                if (ids.Contains(user.Id.ToString()))
                {
                    _context.Users.Remove(user);
                }
            }
            await _context.SaveChangesAsync();
            return Redirect("/Users/Index");
        }

        public async Task<IActionResult> Block(string[] ids)
        {
            var users = (from u in _context.Users
                         select u).ToList();
            foreach (var user in users)
            {
                if (ids.Contains(user.Id.ToString()))
                {
                    user.isBlocked = true;
                    await _userManager.UpdateAsync(user);
                }
            }
            return Redirect("/Users/Index");
        }

        public async Task<IActionResult> Unblock(string[] ids)
        {
            var users = (from u in _context.Users
                         select u).ToList();
            foreach (var user in users)
            {
                if (ids.Contains(user.Id.ToString()))
                {
                    user.isBlocked = false;
                    await _userManager.UpdateAsync(user);
                }
            }
            return Redirect("/Users/Index");
        }

    }
}
